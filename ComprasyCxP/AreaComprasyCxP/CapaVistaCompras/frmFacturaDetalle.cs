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
    public partial class frmFacturaDetalle : Form
    {

        clscontrolador log = new clscontrolador();

        public frmFacturaDetalle()
        {
            InitializeComponent();
        }

        private void frmFacturaDetalle_Load(object sender, EventArgs e)
        {
            llenarcomboFacturaEncabezado();
            llenarcomboProducto();
        }

        public void llenarcomboFacturaEncabezado()
        {
            cboFacturaEncabezado.Items.Clear();
            OdbcDataReader datareader = log.llenarFacturasE();
            while (datareader.Read())
            {
                cboFacturaEncabezado.Items.Add(datareader[0].ToString());
            }
        }

        public void llenarcomboProducto()
        {
            cboProducto.Items.Clear();
            OdbcDataReader datareader = log.llenarProducto();
            while (datareader.Read())
            {
                cbopr.Items.Add(datareader[0].ToString());
                cboProducto.Items.Add(datareader[1].ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] valores = { txtFacturaDe.Text, txtIDFacturaEn.Text, txtProdcuto.Text, txtMonto.Text, txtConcepto.Text };
            if (log.insertar_FacturaD(valores) == null)
            {
                MessageBox.Show("Error al ingresar");
            }
            else
            {
                MessageBox.Show("Datos Agregados a la base de datos", "Insercion de datos");
                txtFacturaDe.Text = "";
                txtIDFacturaEn.Text = "";
                txtProdcuto.Text = "";
                txtMonto.Text = "";
                txtConcepto.Text = "";
                cboFacturaEncabezado.Text = "";
                cboProducto.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFacturaDe.Text = "";
            txtIDFacturaEn.Text = "";
            txtProdcuto.Text = "";
            txtMonto.Text = "";
            txtConcepto.Text = "";
            cboFacturaEncabezado.Text = "";
            cboProducto.Text = "";
        }

        private void cboFacturaEncabezado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDFacturaEn.Text = cboFacturaEncabezado.SelectedItem.ToString();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbopr.SelectedIndex = cboProducto.SelectedIndex;
            txtProdcuto.Text = cbopr.SelectedItem.ToString();
        }
    }
}
