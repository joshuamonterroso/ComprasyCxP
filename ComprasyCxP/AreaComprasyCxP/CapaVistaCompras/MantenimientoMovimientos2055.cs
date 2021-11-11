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
    public partial class MantenimientoMovimientos2055 : Form
    {
        //Adolfo Monterroso Realizo este form 0901-18-50
        public MantenimientoMovimientos2055()
        {
            InitializeComponent();
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "movimiento", "hotelsancarlos");
            navegador1.funAsignarSalidadVista(this);
            navegador1.campoEstado = "stsMov";
            navegador1.idAplicacion = "2055";
            navegador1.tablaAyuda = "aplicacion";
            navegador1.campoAyuda = "pkId";
            navegador1.pideGrid(dataGridView1);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);
            navegador1.funLlenarComboControl(cboOrden, "ordencompra", "idOrdenCompra", "descripcion", "estado");
        }

        public void funActualizarUsuario(string user)
        {
            navegador1.usuario = user;
            navegador1.aplicacion = "MantenimientoMovimientos2055";
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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dataGridView1);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtEstado);

        }

        private void txtOrden_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cboOrden, txtOrden);
        }

        private void cboOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cboOrden, txtOrden);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
