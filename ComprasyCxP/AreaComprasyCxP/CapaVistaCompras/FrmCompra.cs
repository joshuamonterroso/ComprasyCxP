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
    public partial class FrmCompra : Form
    {

        clscontrolador log = new clscontrolador();

        public FrmCompra()
        {
            InitializeComponent();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            llenarcombo();
        }
        public void llenarcombo()
        {
            cbmProveedores.Items.Clear();
            OdbcDataReader datareader = log.llenarcboProv();
            while (datareader.Read())
            {
                cbmprov.Items.Add(datareader[0].ToString());
                cbmProveedores.Items.Add(datareader[1].ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] valores = { txtIDordenCompra.Text, txtproveedores.Text, txtMonto.Text, txtFecha.Text, txtDescripcion.Text };
            if (log.insertar_OrdenC(valores) == null)
            {
                MessageBox.Show("Error al ingresar");
            }
            else
            {
                MessageBox.Show("Datos Agregados a la base de datos", "Insercion de datos");
                txtDescripcion.Enabled = false;
                txtMonto.Enabled = false;
                txtFecha.Enabled = false;
                txtDescripcion.Text = "";
                txtMonto.Text = "";
                txtFecha.Text = "";
                txtIDordenCompra.Text = "";
                txtproveedores.Text = "";
                cbmProveedores.Text = "";
                MantenimientoMovimientos2055 formulario = new MantenimientoMovimientos2055();
                formulario.Show();
            }
        }

        private void cbmProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmprov.SelectedIndex = cbmProveedores.SelectedIndex;
            txtproveedores.Text = cbmprov.SelectedItem.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = false;
            txtMonto.Enabled = false;
            txtFecha.Enabled = false;
            txtDescripcion.Text = "";
            txtMonto.Text = "";
            txtFecha.Text = "";
            txtIDordenCompra.Text = "";
            txtproveedores.Text = "";
            cbmProveedores.Text = "";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
