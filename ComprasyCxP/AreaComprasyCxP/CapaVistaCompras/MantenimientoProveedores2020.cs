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
    public partial class MantenimientoProveedores2020 : Form
    {
        public MantenimientoProveedores2020()
        {

            InitializeComponent();
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "proveedor", "hotelsancarlos");
            navegador1.funAsignarSalidadVista(this);
            navegador1.campoEstado = "stsproveedor";
            navegador1.idAplicacion = "2020";
            navegador1.tablaAyuda = "aplicacion";
            navegador1.campoAyuda = "pkId";
            navegador1.pideGrid(dvcProveedores);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);
            navegador1.funLlenarComboControl(cboEmpresa, "empresa", "idEmpresa", "nombre", "estatus");
        }

        public void funActualizarUsuario(string user)
        {            
            navegador1.usuario = user;
            navegador1.aplicacion = "MantenimientoProveedores2020";
            navegador1.funActualizarPermisos();
            navegador1.idmodulo = "2";
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActivo.Checked == true)
            {
                txtstatus.Text = "A";
            }
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInactivo.Checked == true)
            {
                txtstatus.Text = "I";
            }

        }

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cboEmpresa, txtempresa);
        }

        private void dvcProveedores_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dvcProveedores);
        }

        private void txtstatus_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtstatus);
        }

        private void txtempresa_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cboEmpresa, txtempresa);
        }

        private void MantenimientoProveedores2020_Load(object sender, EventArgs e)
        {

        }
    }
}
