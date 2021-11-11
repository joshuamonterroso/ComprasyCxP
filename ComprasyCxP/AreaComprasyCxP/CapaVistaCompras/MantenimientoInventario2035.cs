using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaCompras
{
    public partial class MantenimientoInventario2035 : Form
    {
        //Adolfo Monterroso 0901-18-50, hizo todo en este form
        public MantenimientoInventario2035()
        {
            InitializeComponent();
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "inventario", "hotelsancarlos");
            navegador1.funAsignarSalidadVista(this);
            navegador1.campoEstado = "estatus";
            navegador1.idAplicacion = "2035";
            navegador1.tablaAyuda = "aplicacion";
            navegador1.campoAyuda = "pkId";
            navegador1.pideGrid(dataGridView1);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);
            navegador1.funLlenarComboControl(cboSucursal, "sucursal", "idSucursal", "nombre", "estatus");
            navegador1.funLlenarComboControl(cboTipo, "tipoinventario", "Pkid", "nombre", "estatus");
            navegador1.funLlenarComboControl(cboBodega, "bodega", "pkid", "nombre", "estado");
        }

        public void funActualizarUsuario(string user)
        {
            navegador1.usuario = user;
            navegador1.aplicacion = "MantenimientoInventario2035";
            navegador1.funActualizarPermisos();
            navegador1.idmodulo = "2";
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
        }

        private void MantenimientoInventario2035_Load(object sender, EventArgs e)
        {

        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActivo.Checked == true)
            {
                txtEstado.Text = "A";
            }
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInactivo.Checked == true)
            {
                txtEstado.Text = "I";
            }
        }

        private void txtSucursal_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cboSucursal, txtSucursal);
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cboTipo, txtTipo);
        }

        private void ttxBodega_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cboBodega, ttxBodega);
        }

        private void cboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cboSucursal, txtSucursal);
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cboTipo, txtTipo);
        }

        private void cboBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cboBodega, ttxBodega);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dataGridView1);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtEstado);
        }
    }
}
