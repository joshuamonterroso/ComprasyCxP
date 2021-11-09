using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;
using System.Collections;
namespace CapaControlador
{
    public class ClaseControlador
    {
        string errores = "";
        TextBox[] texts;
        Control control;

        ClaseModelo modelo = new ClaseModelo();

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public TextBox[] ordenandoTextos(Control parent)
        {
            texts = modelo.funTexts(parent);
            control = parent;
            TextBox[] alias = new TextBox[texts.Length];

            int j = 0;
            for (int i = (texts.Length - 1); i >= 0; i--)
            {
                alias[j] = texts[i];
                j++;
            }

            return alias;
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funAsignarAliasControl(TextBox[] alias, string tabla, string BD)
        {
            errores = modelo.funAsignarAlias(alias, tabla, BD);
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funAsignarSalidadControl(Form menu)
        {
            if (String.IsNullOrEmpty(errores))
            {
                modelo.funSalida(menu);
                modelo.funDeshabilitarTexts(control);
            }
            else
            {
                MessageBox.Show(errores);
                menu.Close();
            }
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public int funUltimoEnteroControl(string tabla)
        {
            int longitud = texts.Length;
            int entero = modelo.funUltimoEntero(tabla, texts[longitud - 1].Tag.ToString());

            return entero;
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            modelo.funLlenarCombo(cbx,tabla,value, display, estatus);
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funSeleccionarDTControl(DataGridView data)
        {
            modelo.funSeleccionarDT(data);
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void funSetearRBControl(RadioButton activo, RadioButton inactivo, TextBox estatus)
        {
            modelo.funSetearRB(activo, inactivo, estatus);
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void funCambioEstatusRBControl(TextBox estado, RadioButton AI, string cadenaEstado)
        {
            modelo.funCambioEstatusRB(estado, AI, cadenaEstado);
        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void funComboTextboxControl(ComboBox combo, TextBox combotexto)
        {
            modelo.funComboTextbox(combo, combotexto);

        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void funTextboxComboControl(ComboBox combo, TextBox combotexto)
        {
            modelo.funTextboxCombo(combo, combotexto);
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void funDPTextBoxControl(DateTimePicker date, TextBox textoDate)
        {
            modelo.funDPTextBox(date,textoDate);

        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funTextBoxDPTControl(DateTimePicker date, TextBox textoDate)
        {
            modelo.funTextBoxDPT(date, textoDate);
        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public string funReportesControl(string idAplicacion, string campoRuta, string campoB, string tablaR)
        {
            string ruta = modelo.funReportes(idAplicacion, campoRuta, campoB, tablaR);
            return ruta;
        }

        //Wilber Segura 0901-18-13952
        public ArrayList consIndividual(string id, string tablas, int cuenta, string referencia)//Metodo necesario para la actualizacion
        {
            var arList = modelo.consIndividual(id, tablas, cuenta, referencia);
            return arList;
        }
        

        public DataTable llenarTbl(string tablaDB)//Jaime López 0901-18-735
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return modelo.llenarTbl(tablaDB);
        }
        public bool modificar(TextBox[] campos, string tablas)//Modificar de Wilber Enrique Segura Ramirez 0901-18-13952
        {
          return modelo.modificar(campos, tablas); 
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public bool insertar(TextBox[] campos, string tablas)
        {
            return modelo.insertar(campos, tablas);
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void funEliminarControl(TextBox[] arreglo, string tabla, string campoEstado)
        {
            modelo.eliminar(arreglo, tabla, campoEstado);
        }

        /*Geovani Fernando Mendoza - 9959-18-15407*/
        public void funAyudaControl(string idAplicacion, string nombreCampo, string tablaA)
        {
            modelo.funAyuda(idAplicacion, nombreCampo, tablaA, control);

            //MessageBox.Show(tablaA);

        }

        /*Liam Patrick Bernard García - 0901-18-10092*/
        public string funObtienePermisos(string idUsuario, string idAplicacion)
        {
            CapaModeloSeguridadHSC.llamarPermisos modeloSeguridad = new CapaModeloSeguridadHSC.llamarPermisos();
            return modeloSeguridad.llenarpermisos(idUsuario, idAplicacion);
        }

    }

}
