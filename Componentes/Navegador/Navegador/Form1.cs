using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        /*Brayan Mauricio Cifuentes López - 9959-18-11113 - Creacion de Formulario*/
        public Form1()
        {
            InitializeComponent();

            //TextBox[] alias = { txtID, txtCodigoMarca, txtNombre, txtFecha, txtDescripcion, txtStock, txtPrecio, txtEstatus};
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "producto", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);
            navegador1.funLlenarComboControl(cbxCodMarca, "marcaP", "idMarca", "nombre","estatus");
            
            //inicio de elementos para dar de baja
            navegador1.campoEstado = "estado";
            //fin de elementos para dar de baja

            /* Inicio ID Aplicacion usada para reportes y ayudas */
            navegador1.idAplicacion = "1";
            /* Inicio ID Aplicacion usada para reportes y ayudas */

            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda


            // Inicio datos para ejecurar reportes
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes

            navegador1.pideGrid(this.dvgConsulta);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);
            //String cadena = txtprueba.Text;
            //navegador1.pruebaMensaje(cadena);

            // Actualizacion de Permisos, Liam Patrick Bernard García - 0901-18-10092
            navegador1.usuario = "admin";
            navegador1.aplicacion = "Mantenimiento Módulo";
            navegador1.funActualizarPermisos();
            navegador1.idmodulo = "1";
            //cbxCodMarca

        }

       /* public void ayudaR()
        {
            Help.ShowHelp(this, "Ayudas/AyudasSistemaReparto.chm", "ManualSistemaReparto.html");

        }
       */
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String dt = "";
            dt = dtProducto.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            txtFecha.Text = dt;
           // MessageBox.Show(txtFecha.Text);
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            //String cbx = cbxCodMarca.Text();
            //cbxCodMarca
            
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, radioButton1, "A");
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstatus, radioButton2, "I");
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {

        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        private void cbxCodMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

            navegador1.funComboTextboxVista(cbxCodMarca, txtCodigoMarca);
            
        }

        /*Geovani Fernando Mendoza - 9959-18-15407*/
        private void navegador1_Load_2(object sender, EventArgs e)
        {

        }

        private void dvgConsulta_CurrentCellChanged(object sender, EventArgs e)
        {
            //navegador1.cargaData();
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        private void dvgConsulta_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dvgConsulta);
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(radioButton1, radioButton2, txtEstatus);
        }
        
        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        private void txtCodigoMarca_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cbxCodMarca, txtCodigoMarca);
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        private void dtProducto_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dtProducto,txtFecha);
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dtProducto, txtFecha);
            navegador1.funDPTextBoxVista(dtProducto, txtFecha);
        }
    }
}
