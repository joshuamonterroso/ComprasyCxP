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
    public partial class frmFacturaEncabezado : Form
    {

        clscontrolador log = new clscontrolador();


        public frmFacturaEncabezado()
        {
            InitializeComponent();
        }

        private void frmFacturaEncabezado_Load(object sender, EventArgs e)
        {
            llenarcombo();
        }
        public void llenarcombo()
        {
            cmbOrdenCompra.Items.Clear();
            OdbcDataReader datareader = log.llenarcboOrdenC();
            while (datareader.Read())
            {
                cmbOrdenCompra.Items.Add(datareader[0].ToString());
                cbmProv.Items.Add(datareader[1].ToString());
                cboprov2.Items.Add(datareader[2].ToString());
                cbmtota.Items.Add(datareader[3].ToString());

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] valores = { txtIDFacturaE.Text, txtprov.Text, txtFecha.Text, txtDescripcion.Text, txtTotal.Text, txtIDOrdenCompra.Text };
            if (log.insertar_FacturaEn(valores) == null)
            {
                MessageBox.Show("Error al ingresar");
            }
            else
            {
                MessageBox.Show("Datos Agregados a la base de datos", "Insercion de datos");
                txtTotal.Text = "";
                txtIDFacturaE.Text = "";
                txtProveedores.Text = "";
                txtFecha.Text = "";
                txtDescripcion.Text = "";
                txtIDOrdenCompra.Text = "";
                cmbOrdenCompra.Text = "";

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            txtIDFacturaE.Text = "";
            txtProveedores.Text = "";
            txtFecha.Text = "";
            txtDescripcion.Text = "";
            txtIDOrdenCompra.Text = "";
            cmbOrdenCompra.Text = "";
        }

        private void cmbOrdenCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDOrdenCompra.Text = cmbOrdenCompra.SelectedItem.ToString();
            cbmProv.SelectedIndex = cmbOrdenCompra.SelectedIndex;
            txtprov.Text = cbmProv.SelectedItem.ToString();
            cboprov2.SelectedIndex = cmbOrdenCompra.SelectedIndex;
            txtProveedores.Text = cboprov2.SelectedItem.ToString();
            cbmtota.SelectedIndex = cmbOrdenCompra.SelectedIndex;
            txtTotal.Text = cbmtota.SelectedItem.ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
             
        }
    }
}
