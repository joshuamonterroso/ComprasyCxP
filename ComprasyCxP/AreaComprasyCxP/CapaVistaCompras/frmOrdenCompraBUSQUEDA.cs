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
    public partial class frmOrdenCompraBUSQUEDA : Form
    {

        clscontrolador log = new clscontrolador();


        public frmOrdenCompraBUSQUEDA()
        {
            InitializeComponent();
        }

        private void frmOrdenCompraBUSQUEDA_Load(object sender, EventArgs e)
        {
            llenarcombo();
        }

        public void actualizardatagrid(string condicion)
        {
            DataTable dt = log.llenarDvgOrdenCompra(condicion);
            dgvHistorialCompras.DataSource = dt;
        }

        public void llenarcombo()
        {
            cboProveedorOrdenCompra.Items.Clear();
            OdbcDataReader datareader = log.llenarProv();
            while (datareader.Read())
            {
                cboprov.Items.Add(datareader[0].ToString());
                cboProveedorOrdenCompra.Items.Add(datareader[1].ToString());
            }
        }

        private void cboProveedorOrdenCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboprov.SelectedIndex = cboProveedorOrdenCompra.SelectedIndex;
            txtProveedorGESTIONCOMPRAS.Text = cboprov.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagrid1();
        }

        private void BtnBuscarCompraGESTIONCOMPRA_Click(object sender, EventArgs e)
        {
            actualizardatagrid(txtProveedorGESTIONCOMPRAS.Text);
        }

        public void actualizardatagrid1()
        {
            DataTable dt = log.actualizar();
            dgvHistorialCompras.DataSource = dt;
        }

        private void btnRegresarGESTIONCOMPRAS_Click(object sender, EventArgs e)
        {

        }
    }
}
