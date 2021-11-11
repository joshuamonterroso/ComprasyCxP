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
    public partial class MantenimientoProducto2025 : Form
    {
        public MantenimientoProducto2025()
        {
            InitializeComponent();
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "producto", "hotelsancarlos");
            navegador1.funAsignarSalidadVista(this);
            navegador1.campoEstado = "Estatus";
            navegador1.idAplicacion = "2025";
            navegador1.tablaAyuda = "aplicacion";
            navegador1.campoAyuda = "pkId";
            navegador1.pideGrid(dataGridView1);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);
            navegador1.funLlenarComboControl(cboInventario, "inventario", "Pkid", "fkidsucursal", "estatus");
            navegador1.funLlenarComboControl(cboLinea, "linea", "idLinea", "nombre", "estatus");
        }

        public void funActualizarUsuario(string user)
        {
            navegador1.usuario = user;
            navegador1.aplicacion = "MantenimientoProducto2025";
            navegador1.funActualizarPermisos();
            navegador1.idmodulo = "2";
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
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

        
        private void MantenimientoProducto2025_Load(object sender, EventArgs e)
        {

        }

        private void txtLinea_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cboLinea, txtLinea);
        }

        private void cboInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cboInventario, txtTipo);
        }

        private void cboLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cboLinea, txtLinea);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dataGridView1);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtEstado);
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cboInventario, txtTipo);
        }
    }
}
