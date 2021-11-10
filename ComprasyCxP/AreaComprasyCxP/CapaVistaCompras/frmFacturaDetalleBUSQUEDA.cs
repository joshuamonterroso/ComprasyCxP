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
    public partial class frmFacturaDetalleBUSQUEDA : Form
    {

        clscontrolador log = new clscontrolador();


        public frmFacturaDetalleBUSQUEDA()
        {
            InitializeComponent();
        }

        private void BtnBuscarFacturaDetalle_Click(object sender, EventArgs e)
        {
            actualizardatagrid(txtProveedorGESTIONCOMPRAS.Text);
        }

        public void actualizardatagrid(string condicion)
        {
            DataTable dt = log.llenarDvgFdetalle(condicion);
            dvgFacturasDetalle.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagrid1();
        }

        public void actualizardatagrid1()
        {
            DataTable dt = log.actualizar2();
            dvgFacturasDetalle.DataSource = dt;
        }

        private void frmFacturaDetalleBUSQUEDA_Load(object sender, EventArgs e)
        {
            llenarcombo();
        }

        public void llenarcombo()
        {
            cboProductoFacturaDetalle.Items.Clear();
            OdbcDataReader datareader = log.llenarProducto();
            while (datareader.Read())
            {
                cbopr.Items.Add(datareader[0].ToString());
                cboProductoFacturaDetalle.Items.Add(datareader[1].ToString());
            }
        }

        private void cboProductoFacturaDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbopr.SelectedIndex = cboProductoFacturaDetalle.SelectedIndex;
            txtProveedorGESTIONCOMPRAS.Text = cbopr.SelectedItem.ToString();
        }
    }
}
