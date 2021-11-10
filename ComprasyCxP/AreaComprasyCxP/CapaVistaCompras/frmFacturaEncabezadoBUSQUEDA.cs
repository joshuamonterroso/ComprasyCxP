using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorCompras;

namespace CapaVistaCompras
{
    public partial class frmFacturaEncabezadoBUSQUEDA : Form
    {

        clscontrolador log = new clscontrolador();

        public frmFacturaEncabezadoBUSQUEDA()
        {
            InitializeComponent();
        }

        private void frmFacturaEncabezadoBUSQUEDA_Load(object sender, EventArgs e)
        {
            llenarcombo();
        }

        public void llenarcombo()
        {
            cboProveedorFacturaEncabezado.Items.Clear();
            OdbcDataReader datareader = log.llenarProv();
            while (datareader.Read())
            {
                cbmprov.Items.Add(datareader[0].ToString());
                cboProveedorFacturaEncabezado.Items.Add(datareader[1].ToString());
            }
        }

        private void BtnBuscarFacturaEncabezado_Click(object sender, EventArgs e)
        {
            actualizardatagrid(txtProveedorGESTIONCOMPRAS.Text);
        }

        public void actualizardatagrid(string condicion)
        {
            DataTable dt = log.llenarDvgFE(condicion);
            dgvFacturasEncabezado.DataSource = dt;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizardatagrid1();
        }

        public void actualizardatagrid1()
        {
            DataTable dt = log.actualizarFE();
            dgvFacturasEncabezado.DataSource = dt;
        }

        private void cboProveedorFacturaEncabezado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmprov.SelectedIndex = cboProveedorFacturaEncabezado.SelectedIndex;
            txtProveedorGESTIONCOMPRAS.Text = cbmprov.SelectedItem.ToString();
        }
    }
}
