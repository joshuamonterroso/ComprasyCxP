using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitacoraUsuario;
using CapaControlador;
using CapaVista;

namespace DLL.nav
{
    public partial class navegador : UserControl
    {
        //Variables Globales
        TextBox[] campos;
        string tablas;
        string DB;
        int estado = 0;
        public string campoEstado = "";
        public string tablaAyuda = "";
        public string campoAyuda = "";
        public reporte formReporte = new reporte();
        public string idAplicacion = "";

        DataGridView dataE;
        ClaseControlador control = new ClaseControlador();
        Control controles;
        //Gabriel Coyoy
        //Estas variables permiten actualizar los datos de las combobox
        ArrayList referencia0 = new ArrayList(); 
        ArrayList referencia1 = new ArrayList();
        ArrayList referencia2 = new ArrayList();
        ArrayList referencia3 = new ArrayList();
        ArrayList referencia4 = new ArrayList();

        //Liam Patrick Bernard García 0901-18-10092
        public Boolean permisoIngreso = true;  //Valor que debe llegar de seguridad
        public Boolean permisoModificar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoEliminar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoConsultar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoReporteador = true;  //Valor que debe llegar de seguridad

        public string permisos;
        public string usuario = "";
        public string aplicacion = "";
        public string idusuario;
        public string idmodulo;
        //Fin varaibles globales


        public navegador()
        {
            InitializeComponent();
        }

        public void funActualizarPermisos() //Liam Patrick Bernard García 0901-18-10092, Jaime López 0901-18-735
        {
            CapaControladorSeguridadHSC.Controlador controladorSeguridad = new CapaControladorSeguridadHSC.Controlador();
            idusuario = controladorSeguridad.consultausuario(usuario);
            idAplicacion = controladorSeguridad.consultaaplicacion(aplicacion);

            //MessageBox.Show("La aplicacion es: " + idAplicacion + aplicacion);
            //MessageBox.Show("El Usuario es: " + idusuario + usuario);
            //permisos = "11011"; //Escritura, Lectura, Imprimir, Eliminar, Modificar

            permisos = control.funObtienePermisos(idusuario, idAplicacion);
            //MessageBox.Show("El Usuario y Aplicacion es: " + idusuario + idAplicacion + " " + permisos);

            if(permisos.Length < 5)
            {
                MessageBox.Show("El Usuario no tiene permisos para esta aplicacion.");
                generic.Close();
                return;
            }

            if (permisos[0] == '1')
            {
                permisoIngreso = true;
            }
            else
            {
                permisoIngreso = false;
            }

            if (permisos[1] == '1')
            {

            }
            else
            {
                MessageBox.Show("Usted No Tiene Permisos de Lectura");
                generic.Close();
            }

            if (permisos[2] == '1')
            {
                permisoReporteador = true;
            }
            else
            {
                permisoReporteador = false;
            }

            if (permisos[3] == '1')
            {
                permisoEliminar = true;
            }
            else
            {
                permisoEliminar = false;
            }

            if (permisos[4] == '1')
            {
                permisoModificar = true;
            }
            else
            {
                permisoModificar = false;
            }

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            //Habilitación de Permisos, Liam Patrick Bernard García, 0901-18-10092

            if (permisoIngreso == false)
            {
                btnIngresar.Enabled = false;
            }
            else
            {
                btnIngresar.Enabled = true;
            }

            if (permisoModificar == false)
            {
                btnModificar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
            }

            if (permisoEliminar == false)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }

            if (permisoConsultar == false)
            {
                btnConsultar.Enabled = false;
            }
            else
            {
                btnConsultar.Enabled = true;
            }

            if (permisoReporteador == false)
            {
                btnReporte.Enabled = false;
            }
            else
            {
                btnReporte.Enabled = true;
            }
        }

        /*private void pnlBgIngresar_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Hola");
        }*/

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public TextBox[] funAsignandoTexts(Control parent)
        {
            controles = parent;
            return control.ordenandoTextos(parent);
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funAsignarAliasVista(TextBox[] alias, string tabla, string BD)
        {
            control.funAsignarAliasControl(alias, tabla, BD);
            campos = alias;
            tablas = tabla;
            DB = BD;
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funAsignarSalidadVista(Form menu)
        {
            control.funAsignarSalidadControl(menu);
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            referencia1.Add(tabla);
            referencia2.Add(value);
            referencia3.Add(display);
            referencia4.Add(estatus);
            referencia0.Add(cbx);
            control.funLlenarComboControl( cbx,tabla,  value,  display,  estatus);

        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funSeleccionarDTVista(DataGridView data)
        {
            dataE = data;
            control.funSeleccionarDTControl(data);
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void funSetearRBVista(RadioButton activo, RadioButton inactivo, TextBox estatus)
        {
            control.funSetearRBControl(activo, inactivo, estatus);
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void funCambioEstatusRBVista(TextBox estado, RadioButton AI, string cadenaEstado)
        {
            control.funCambioEstatusRBControl(estado, AI, cadenaEstado);
        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void funComboTextboxVista(ComboBox combo, TextBox combotexto)
        {
            control.funComboTextboxControl(combo, combotexto);
        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void funTextboxComboVista(ComboBox combo, TextBox combotexto)
        {
            control.funTextboxComboControl(combo, combotexto);
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void funDPTextBoxVista(DateTimePicker date, TextBox textoDate)
        {
            control.funDPTextBoxControl(date, textoDate);
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funTextBoxDPTVista(DateTimePicker date, TextBox textoDate)
        {
            control.funTextBoxDPTControl(date,textoDate);
        }


        private void actualizarCombo()
        {
            for (int i=0; i < referencia0.Count; i++)
            {
                //Gabriel Coyoy
                //ComboBox temporal = (ComboBox)referencia0[i];
                //MessageBox.Show(temporal.Text + (string)referencia1[i] + (string)referencia2[i] + (string)referencia3[i] + (string)referencia4[i]);
                control.funLlenarComboControl((ComboBox)referencia0[i], (string)referencia1[i], (string)referencia2[i], (string)referencia3[i], (string)referencia4[i]);
            } 
            
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void mensaje()
        {
            MessageBox.Show("Prueba de Funcion #2");
        }

        public void mensaje2()
        {
            MessageBox.Show("Prueba de Funcion #3");
        }

        /*private void pnlBgM_MouseClick(object sender, MouseEventArgs e)
        {
            mensaje();
        }

        private void pnlBgG_MouseClick(object sender, MouseEventArgs e)
        {
            mensaje2();
        }
        */

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void pruebaMensaje(string cadena)
        {
            MessageBox.Show("La cadena es: " + cadena);
        }
        
        private void desactivarBotones(int tipo) //Jaime López 0901-18-735
        {

            //desactivarBotones cambiara los .Enabled de los botones
            //indicados
            /*
             * 0 Desactiva los botones de cancelar y guardar. Activa ingreso, modificación, eliminación, consulta, reporte y actu
             * 1 Desactiva los botones de insertar, modificar, eliminar, consulta, reporte y actu. Activa guardar y cancelar
             * 
             * Cada uno activará lo que el otro desactive
             * 0 Activa insertar, modificar y eliminar
             * 1 Actica Cancelar y Guardar
             */
            if (tipo == 0)
            {
                //activa
                //Función de Validar Permisos, Liam Patrick Bernard Garcia, 0901-18-10092
                if (permisoIngreso == false)
                {
                    btnIngresar.Enabled = false;
                }
                else
                {
                    btnIngresar.Enabled = true;
                }

                if (permisoModificar == false)
                {
                    btnModificar.Enabled = false;
                }
                else
                {
                    btnModificar.Enabled = true;
                }

                if (permisoEliminar == false)
                {
                    btnEliminar.Enabled = false;
                }
                else
                {
                    btnEliminar.Enabled = true;
                }

                if (permisoConsultar == false)
                {
                    btnConsultar.Enabled = false;
                }
                else
                {
                    btnConsultar.Enabled = true;
                }

                if (permisoReporteador == false)
                {
                    btnReporte.Enabled = false;
                }
                else
                {
                    btnReporte.Enabled = true;
                }

                btnActualizar.Enabled = true;
                //desactiva
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
            {
                //desactiva
                btnIngresar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnConsultar.Enabled = false;
                btnReporte.Enabled = false;
                btnActualizar.Enabled = false;
                //activa
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)//Jaime López 0901-18-735
        {
            estado = 0;
            desactivarBotones(0);
            manipularTextboxs(0);

            /* Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora cancelar = new Bitacora();
            //guardar.guardarEnBitacora(idAplicacion, "1", "0012", "guardar");
            cancelar.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "cancelar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Metodos de ingresar y eliminar adaptados por Melissa Aldana, al boton guardar
            switch (estado)
            {
                case 1://Ingresar
                    bool resultadoI;
                    resultadoI = control.insertar(campos, tablas);
                    if (resultadoI == true)
                    {
                        MessageBox.Show("El ingreso se a realizado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("El ingreso no se realizó con éxito!");
                    }

                    break;

                case 2://Modificar de Wilber Enrique Segura Ramirez 0901-18-13952
                    bool resultado;//Varaible para saber si se ejecutó con éxito la sentencia SQL
                    resultado = control.modificar(campos, tablas);
                    if(resultado == true)
                    {
                        MessageBox.Show("Modificación realizada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Modificación no se realizó con éxito!");
                    }
                    break;


                case 3://Eliminar
                    /*Brayan Mauricio Cifuentes López - 9959-18-11113*/

                    //string resultadoE;
                    control.funEliminarControl(campos, tablas, campoEstado);
                    //resultadoE = control.ToString();
                    //bool value = Convert.ToBoolean(resultadoE);

                    //if (value == true)
                    //{
                      //  MessageBox.Show("Eliminación realizada con éxito!");
                    //}
                    //else
                    //{
                     //   MessageBox.Show("Eliminación no se realizó con éxito!");
                    //}

                    break;

                case 0://Error alguno de los otros casos no hizo su trabajo
                    MessageBox.Show("Error, no ha seleccionado ninguna función para guardar sus acciones");
                    break;
            }
            estado = 0;
            desactivarBotones(0);
            manipularTextboxs(0);
            llenaTabla();//recarga los datos de la tabla

            /* Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora guardar = new Bitacora();
            //guardar.guardarEnBitacora(idAplicacion, "1", "0012", "guardar");
            guardar.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "guardar");

        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int entero = control.funUltimoEnteroControl(tablas);
            int cantidadCampos = campos.Length;
            campos[0].Text = entero.ToString();
           

            foreach (Control ctr in controles.Controls)
            {
                if (ctr is TextBox)
                {
                    if(ctr.Tag.ToString() == campos[0].Tag.ToString())
                    {
                        ctr.Enabled = false;
                    }
                    else
                    {
                        ctr.Enabled = true;
                      
                    }
                    
                }

                if (ctr is ComboBox)
                {
                    ctr.Enabled = true;
                }

                if (ctr is DateTimePicker)
                {
                    ctr.Enabled = true;
                }

                if (ctr is RadioButton)
                {
                    ctr.Enabled = true;
                }
            }

            estado = 1;
            desactivarBotones(1);
            manipularTextboxs(1);
            /*Daniel Enrique Navas Hernandez 0901-18-15032*/ 
            Bitacora insertar = new Bitacora();
            insertar.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "insertar");
        }

        //Lo hizo Wilber Enrique Segura Ramirez 0901-18-13952
        private void btnModificar_Click(object sender, EventArgs e)//Boton de modificar campos dinámico
        {
            if (dvgConsulta != null)
            {
                if (dvgConsulta.RowCount - 1 > 0)
                {
                    manipularTextboxs(3);
                   /* int cuenta = campos.Length;
                    string referencia = campos[0].Tag.ToString();//Nos sirve para obtener el campo para hacer la consulta
                    string id = dvgConsulta.CurrentRow.Cells[0].Value.ToString();
                    var arList = control.consIndividual(id, tablas, cuenta, referencia);
                    for(int i=0; i<cuenta; i++)
                    {
                        campos[i].Text = (string)arList[i];
                    }*/
                    estado = 2;
                    desactivarBotones(1);
                }
                else
                {
                    MessageBox.Show("No tiene Registros");
                    return;
                }
                   
            }
            else
            {
                MessageBox.Show("No existe ninguna datagridview");
                return;
            }
            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora modificar = new Bitacora();
            modificar.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "modificar");
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            control.funEliminarControl(campos, tablas, campoEstado);
            //control.funSeleccionarDTControl(dataE);
            estado = 3;
            desactivarBotones(0);
            manipularTextboxs(0);
            llenaTabla();

            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora eliminar = new Bitacora();
            eliminar.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "eliminar");


        }


        //boton de verificacion para navegacion sin registros
        public Boolean veriNavegar(){//Kevin Rolando González Ramírez 0901-18-1387
            
            if (dvgConsulta.RowCount-1 > 0)
               
                return true;
            else 
                return false;
            }


        DataGridView dvgConsulta;
        //funcion para pedir datagridView

        
        public void pideGrid(DataGridView tabla)//Kevin Rolando González Ramírez 0901-18-1387
        {
            dvgConsulta = tabla;
        }

       
        public void llenaTabla() //Jaime López 0901-18-735
        {
            DataTable dt = control.llenarTbl(tablas);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;
        }


        private void btnSiguiente_Click(object sender, EventArgs e)//Kevin Rolando González Ramírez 0901-18-1387
        {

            //verificacion de la existencia de registros
            if (veriNavegar() == false) { 
            MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                return;
              }

            //obtengo el indicie actual
            int actual = dvgConsulta.CurrentCell.RowIndex;


            int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 
            int numFilas = dvgConsulta.RowCount;
            //MessageBox.Show("cantidad de filas: "+numFilas);


            if (actual == numFilas - 2)
            {
                dvgConsulta.CurrentCell = dvgConsulta.Rows[0].Cells[0];
            }
            else
            {

                var arList = new ArrayList();//todos los campos a obtener de la tabla


                dvgConsulta.CurrentCell = dvgConsulta.Rows[actual + 1].Cells[0];
                //for para guardar todos los datos de la columnas
                for (int i = 0; i < numColumnas; i++)
                {
                    string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                    arList.Add(col);//vamos guardando todos los campos

                }
            }
            cargaData();
            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora botonSiguiente = new Bitacora();
            botonSiguiente.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "Boton Siguiente");
        }

        private void btnAnterior_Click(object sender, EventArgs e)//Kevin Rolando González Ramírez 0901-18-1387
        {
            //verificacion de la existencia de registros
            if (veriNavegar() == false)
            {
                MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                return;
            }

            //obtengo el indicie actual
            int actual = dvgConsulta.CurrentCell.RowIndex;


            //hacer un condicional para ver si no es el primer campo

            if (actual == 0)
            {
                // MessageBox.Show("Lo siento no puede retroceder mas esta en el primer campo");
                dvgConsulta.CurrentCell = dvgConsulta.Rows[dvgConsulta.RowCount - 2].Cells[0];
            }
            else
            {


                dvgConsulta.CurrentCell = dvgConsulta.Rows[actual - 1].Cells[0];
                var arList = new ArrayList();//todos los campos a obtener de la tabla

                int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 

                //for para guardar todos los datos de la columnas
                for (int i = 0; i < numColumnas; i++)
                {
                    string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                    arList.Add(col);//vamos guardando todos los campos

                }



                //string para ver los datos
                /*for (int i = 0; i < arList.Count; i++)
                {
                    MessageBox.Show("arlist[" + i + "] =" + arList[i]);
                }

                */
            }
            cargaData();
            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora botonAnterior = new Bitacora();
            botonAnterior.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "Boton Anterior");
        }

        private void btnInicio_Click(object sender, EventArgs e)//Kevin Rolando González Ramírez 0901-18-1387
        {

            //verificacion de la existencia de registros
            if (veriNavegar() == false)
            {
                MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                return;
            }

            dvgConsulta.CurrentCell = dvgConsulta.Rows[0].Cells[0];

            var arList = new ArrayList();//todos los campos a obtener de la tabla

            int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 

            //for para guardar todos los datos de la columnas
            for (int i = 0; i < numColumnas; i++)
            {
                string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                arList.Add(col);//vamos guardando todos los campos

            }
            cargaData();

            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora inicio = new Bitacora();
            inicio.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "inicio");
        }

        private void btnFinal_Click(object sender, EventArgs e)//Kevin Rolando González Ramírez 0901-18-1387
        {
            //verificacion de la existencia de registros
            if (veriNavegar() == false)
            {
                MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                return;
            }

            dvgConsulta.CurrentCell = dvgConsulta.Rows[dvgConsulta.RowCount - 2].Cells[0];

            var arList = new ArrayList();//todos los campos a obtener de la tabla

            int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 

            //for para guardar todos los datos de la columnas
            for (int i = 0; i < numColumnas; i++)
            {
                string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                arList.Add(col);//vamos guardando todos los campos

            }
            cargaData();

            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora final = new Bitacora();
            final.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "Final");
        }

        private void navegador_Load(object sender, EventArgs e)
        {

        }
         
        /* Daniel Enrique Navas Hernandez 0901-18-15032 */ 
        private void btnActualizar_Click(object sender, EventArgs e)//Daniel Navas
        {
            llenaTabla();
            //falta actu de combos
            for (int i = 0; i < campos.Length; i++)
            {

                campos[i].Text = "";

            }

            actualizarCombo();

            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora actualizar = new Bitacora();
            actualizar.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "actualizar");
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        private void btnSalir_Click(object sender, EventArgs e)
        {
            generic.Close();

            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora salir = new Bitacora();
            salir.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "Salir");
        }
        Form generic;

        public void pedirRef(Form generico)//Jaime López 0901-18-735
        {
            generic = generico;
        }




        /*Geovani Fernando Mendoza - 9959-18-15407*/
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            control.funAyudaControl(idAplicacion, campoAyuda, tablaAyuda);
            //   Help.ShowHelp(parent, rutaAyudaCHM, rutaAyudaHTML);

            //Help.ShowHelp(this, "Ayudas/AyudasSistemaReparto.chm", "ManualSistemaReparto.html");

            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora ayuda = new Bitacora();
            ayuda.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "Ayuda");
        }

        private void manipularTextboxs(int modo)//Josue Zapata 9959-18-4829 y Jaime López 0901-18-735
        {
            /*
             * 0 desactiva todos los controles de entrada del usuario y limpia los campos
             * 1 activa todos los controles menos el id
             */
            //llamar este metodo desde donde se utilice (al iniciar, guardar, cancelar, ingresar, etc)
            //basicamente: ingresar, modificar y eliminar activan el modo 1
            //y el guardar y cancelar usan el modo 0 (desactivan todo porque ya habran completado una operacion)

            int cantidadCampos = campos.Length;
            if (modo == 0)
            {
                foreach (Control ctr in controles.Controls)
                {
                    if (ctr is TextBox)
                    {
                        ctr.Enabled = false;
                        ctr.Text = "";
                    }

                    if (ctr is ComboBox)
                    {
                        ctr.Enabled = false;
                        ctr.Text = "";
                    }

                    if (ctr is DateTimePicker)
                    {
                        ctr.Enabled = false;
                        //((DateTimePicker)ctr).Value = DateTime.Now;
                    }

                    if (ctr is RadioButton)
                    {
                        ctr.Enabled = false;
                    }

                    if (ctr is DataGridView)
                    {
                        ctr.Enabled = true;
                    }
                }
            }

            if (modo == 1 || modo == 3)
            {
                foreach (Control ctr in controles.Controls)
                {
                    if (ctr is TextBox)
                    {
                        if (ctr.Tag.ToString() == campos[0].Tag.ToString())
                        {
                            ctr.Enabled = false;
                        }
                        else
                        {
                            ctr.Enabled = true;
                            if(modo == 1)
                            {
                                ctr.Text = "";
                            }
                            
                        }
                    }

                    if (ctr is ComboBox)
                    {
                        ctr.Enabled = true;
                    }

                    if (ctr is DateTimePicker)
                    {
                        ctr.Enabled = true;
                        if(modo == 1)
                        {
                            ((DateTimePicker)ctr).Value = DateTime.Now;
                        }
                        
                    }

                    if (ctr is RadioButton)
                    {
                        ctr.Enabled = true;
                        if(modo == 1)
                        {
                            ((RadioButton)ctr).Checked = false;
                        }
                        
                    }

                    if (ctr is DataGridView)
                    {
                        ctr.Enabled = false;
                    }
                }
            }

        }
        public void cargaData()//Kevin Rolando González Ramírez 0901-18-1387
        {
            int cantidadCampos = dvgConsulta.Columns.Count;
            /* //Liam Patrick
            if (cantidadCampos == 0)
            {
                return;
            }
            */
            for (int i = 0; i < cantidadCampos; i++)
            {
                campos[i].Text = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
            }
            //dvgConsulta.CurrentRow();
            //dvgConsulta.CurrentCellChanged
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funReportesVista(string campoRuta, string campoB, string tablaR)
        {
            formReporte.ruta = control.funReportesControl(idAplicacion, campoRuta, campoB, tablaR);
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funMostrarFormR()
        {
            formReporte.Show();
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(formReporte.ruta))
            {
                MessageBox.Show("Error con la ruta del reporte, verifique que la Aplicacion existe y que la ruta sea la correcta!");
            }
            else
            {
                funMostrarFormR();
            }
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(formReporte.ruta))
            {
                MessageBox.Show("Error con la ruta del reporte, verifique que la Aplicacion existe y que la ruta sea la correcta!");
            }
            else
            {
                funMostrarFormR();
            }
            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora reporteador = new Bitacora();
            reporteador.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "reporteador");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultasInteligentes CI = new ConsultasInteligentes();
            CI.Show();

            /*Daniel Enrique Navas Hernandez 0901-18-15032*/
            Bitacora consultar = new Bitacora();
            consultar.guardarEnBitacora(idusuario, idmodulo, idAplicacion, "consultar");
        }
    }
}
