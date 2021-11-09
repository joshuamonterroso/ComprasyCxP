using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Collections;
using System.Data;

namespace CapaModelo
{
    public class ClaseModelo
    {
        /*Grupo #3*/
        Conexion conexion = new Conexion();
        string tablaBD = "";
        TextBox[] arreglo;
        string rutaAyudaCHM = "";
        string rutaAyudaHTML = "";


        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public TextBox[] funTexts(Control parent)
        {
            int contador = 0;

            foreach (Control ctr in parent.Controls)
            {
                if (ctr is TextBox)
                {
                    contador++;
                }
            }

            TextBox[] alias = new TextBox[contador];

            contador = 0;
            foreach (Control ctr in parent.Controls)
            {

                if (ctr is TextBox)
                {
                    alias[contador] = (TextBox)ctr;
                    contador++;
                }

            }

            return alias;
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funDeshabilitarTexts(Control parent)
        {
            foreach (Control ctr in parent.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Enabled = false;
                }

                if (ctr is ComboBox)
                {
                    ctr.Enabled = false;
                }

                if (ctr is DateTimePicker)
                {
                    ctr.Enabled = false;
                }

                if (ctr is RadioButton)
                {
                    ctr.Enabled = false;
                }
            }
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public int funUltimoEntero(string tabla, string campoB)
        {
            string ultimoEntero = "";
            int enteroSumado = 0;
            OdbcDataReader leer = null;

            string sql = "select" + " " + "(" + campoB + "*1" + ")" + " " + "as" + " " + campoB + " " + "FROM" + " " + tabla + " " + "ORDER BY" + " " + campoB + " " + "DESC Limit 1";
            OdbcConnection conect = conexion.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    ultimoEntero = leer.GetString(0);
                    //enteroSumado += ultimoEntero; 
                    enteroSumado = int.Parse(ultimoEntero) + 1;
                }

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
            }
            finally
            {
                conexion.desconexion(conect);
            }

            if (enteroSumado == 0)
            {
                enteroSumado = 1;
            }


            return enteroSumado;
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public string funAsignarAlias(TextBox[] alias, string tabla, string BD)
        {
            /* Inicio para busqueda de tabla en BD */
            string cantidad_tabla = "";
            string errores = "";
            string sql = "SELECT count(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA = '" + BD + "' AND TABLE_NAME = '" + tabla + "'";

            /*MySqlConnection conexionBD = Conexiontwo.conexion();
            conexionBD.Open();*/
            OdbcConnection conect = conexion.conexion();
            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                cantidad_tabla = comando.ExecuteScalar().ToString();

                if (cantidad_tabla == "0")
                {
                    errores += "Error en la tabla" + " " + tabla + " " + "no existe en la Base de datos";
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
                //errores += "error en la BD " + " " + ex;
            }
            finally
            {
                conexion.desconexion(conect);
            }
            /* Final para busqueda de tabla en BD */

            /* Inicio busqueda de cantidades de campos en la una tabla */
            if (String.IsNullOrEmpty(errores))
            {
                int cantidadT = 0;

                foreach (TextBox dato in alias)
                {
                    cantidadT++;
                }

                string cantidadTotalCampos = "";
                string cantidadCampos = "SELECT count(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '" + tabla + "' AND table_schema = '" + BD + "'";
                conect = conexion.conexion();

                try
                {
                    //MySqlCommand buscarCantidad = new MySqlCommand(cantidadCampos, conexionBD);
                    OdbcCommand buscarCantidad = new OdbcCommand(cantidadCampos, conect);
                    cantidadTotalCampos = buscarCantidad.ExecuteScalar().ToString();
                    int cantidadEntero = int.Parse(cantidadTotalCampos);

                    if (cantidadT > cantidadEntero)
                    {
                        errores += "Error los campos del arreglo son mayores al de la tabla " + " " + tabla;
                    }
                    else if (cantidadT < cantidadEntero)
                    {
                        errores += "Error los campos del arreglo son menores al de la tabla " + " " + tabla;
                    }
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show("Error al cargar los datos " + ex.Message);
                }
                finally
                {
                    conexion.desconexion(conect);
                }
            }
            /* Final búsqueda de cantidades de campos en una tabla */


            /* Inicio de busqueda de columnas en la BD */
            if (String.IsNullOrEmpty(errores))
            {
                string[] arreglo;
                int cantidad = 0;

                foreach (TextBox dato in alias)
                {
                    cantidad++;
                }

                arreglo = new string[cantidad];
                string cantidadColumnas = "";
                int i = 0;

                foreach (TextBox dato in alias)
                {
                    arreglo[i] = dato.Tag.ToString();
                    string sqlQ = "SELECT count(*) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = '" + BD + "' AND TABLE_NAME = '" + tabla + "' AND COLUMN_NAME = '" + arreglo[i] + "'";
                    //conexionBD.Open();
                    conect = conexion.conexion();
                    //MessageBox.Show(arreglo[i]);

                    try
                    {
                        //MySqlCommand buscarColumna = new MySqlCommand(sqlQ, conexionBD);
                        OdbcCommand buscarColumna = new OdbcCommand(sqlQ, conect);
                        cantidadColumnas = buscarColumna.ExecuteScalar().ToString();

                        if (cantidadColumnas == "0")
                        {
                            errores += "Error el campo" + " " + arreglo[i] + " " + "dentro de la tabla" + " " + tabla + " " + "no esta definido en la Base de datos";
                            break;
                        }
                    }
                    catch (OdbcException ex)
                    {
                        MessageBox.Show("Error al cargar los datos " + ex.Message);
                    }
                    finally
                    {
                        conexion.desconexion(conect);
                    }

                    i++;
                }

            }

            if (String.IsNullOrEmpty(errores))
            {
                arreglo = alias;
            }
            /* Final de busqueda de columnas en la BD */
            return errores;
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void funSalida(Form menu)
        {
            menu.Show();
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void funLlenarCombo(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            cbx.DataSource = null;
            cbx.Items.Clear();

            String psql = "SELECT * FROM " + " " + tabla + " " + "WHERE " + " " + estatus + "= 'A' or " + estatus + "= '1' ";
            //cbx.Items.Add(psql);

            //MySqlConnection conexionBD = Conexion.conexion();
            OdbcConnection conect = conexion.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                //MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                OdbcDataAdapter data = new OdbcDataAdapter(comando);

                DataTable dt = new DataTable();
                data.Fill(dt);

                cbx.ValueMember = value;
                cbx.DisplayMember = display;
                cbx.DataSource = dt;


                /*OdbcCommand busI = new OdbcCommand(psql, conect);
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    cbx.Items.Add(lector[0] + " " + lector[1] + " " + lector[2] + " ");
                }*/
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                //conexionBD.Close();
                conexion.desconexion(conect);
            }
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funSeleccionarDT(DataGridView data)
        {
            var filaSeleccionada = data.CurrentRow;
            int i = 0;
            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    arreglo[i].Text = celda.Value.ToString();
                    i++;
                }

            }
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void funSetearRB(RadioButton activo, RadioButton inactivo, TextBox estatus)
        {
            if (estatus.Text == "A")
            {
                activo.Checked = true;
            }
            else if (estatus.Text == "I")
            {
                inactivo.Checked = true;
            }

        }


        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void funCambioEstatusRB(TextBox estado, RadioButton AI, string cadenaEstado)
        {
            if (AI.Checked == true)
            {
                estado.Text = cadenaEstado;
            }
        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void funComboTextbox(ComboBox combo, TextBox combotexto)
        {
            if (combo.SelectedValue == null)
            {
                return;
            }
            String cbx = combo.SelectedValue.ToString();
            combotexto.Text = cbx;

        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void funTextboxCombo(ComboBox combo, TextBox combotexto)
        {
            combo.SelectedValue = combotexto.Text.ToString();

        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void funDPTextBox(DateTimePicker date, TextBox textoDate)
        {
            String dt = "";
            dt = date.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            textoDate.Text = dt;

        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funTextBoxDPT(DateTimePicker date, TextBox textoDate)
        {
            if (textoDate.Text != "")
            {
                date.Value = Convert.ToDateTime(textoDate.Text.ToString());
            }

        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public string funReportes(string idAplicacion, string campoRuta, string campoB, string tablaR)
        {
            string ruta = "";
            OdbcDataReader leer = null;

            string sql = "SELECT" + " " + campoRuta + " " + "FROM" + " " + tablaR + " " + "WHERE " + " " + campoB + "=" + idAplicacion;

            OdbcConnection conect = conexion.conexion();

            try
            {

                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    ruta = leer.GetString(0);
                }


            }
            catch (OdbcException ex)
            {

                MessageBox.Show("Error al cargar los datos" + ex.Message);

            }

            finally
            {
                conexion.desconexion(conect);
            }


            return ruta;

        }


        //Jaime López 0901-18-735 y Modificada por Wilmer Torres 9959-18-9131
        public DataTable llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            Conexion cn = new Conexion();

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            //string sql = "select * from " + tabla + ";";
            string sql = "select * from " + tabla + " " + "ORDER BY" + " " + "length(" + arreglo[0].Tag.ToString() + ")ASC";
            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);
            //se trajo el código del procesamiento de la data ODBC a esta parte
            //para aumentar la seguridad, antes estaba en la capa Controlador
            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }
        //Wilber Segura 0901-18-13952
        public ArrayList consIndividual(string id, string tablas, int cuenta, string referencia)
        {
            Conexion cn = new Conexion();
            var arList = new ArrayList();
            OdbcConnection conn = cn.conexion();
            try
            {
                string busqueda = "select * from " + tablas + " where " + referencia + " = " + id + " ;";
                OdbcCommand busI = new OdbcCommand(busqueda, conn);
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    for (int i = 0; i < cuenta; i++)
                    {
                        arList.Add(lector[i].ToString());
                    }
                }
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error en la consulta");
            }
            cn.desconexion(conn);
            return arList;
        }


        public bool modificar(TextBox[] campos, string tablas)//Modificar de Wilber Enrique Segura Ramirez 0901-18-13952
        {
            int resultado = 0;
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string cad = "Entro a la conexion";
            string sentencia = "update " + tablas + " set ";
            for (int i = 1; i < campos.Length; i++)
            {
                if (i < campos.Length - 1)
                {
                    sentencia += campos[i].Tag.ToString() + " = '" + campos[i].Text + "', ";
                }
                else
                {
                    sentencia += campos[i].Tag.ToString() + " = '" + campos[i].Text + "' ";
                }
            }
            sentencia += "where " + campos[0].Tag.ToString() + " = '" + campos[0].Text + "';";
            cad = "Sentencia creada " + sentencia;
            try
            {
                OdbcCommand ingreso = new OdbcCommand(sentencia, conn);
                cad = "Se logró conexion";
                ingreso.ExecuteNonQuery();
                cad = "se ejecutó la sentencia";
                resultado = 1;
            }
            catch (OdbcException Error)
            {
                cad = Error.Message;
                Console.WriteLine("Error al actualizar " + Error);

            }
            cn.desconexion(conn);
            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Melissa Aldana
        public bool insertar(TextBox[] campos, string tablas)
        {
            int resultado = 0;
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string sentencia = "insert into " + tablas + " ( ";
            for (int i = 0; i < campos.Length; i++)
            {
                if (i < campos.Length - 1)
                {
                    sentencia += campos[i].Tag.ToString() + ", ";
                }
                else
                {
                    sentencia += campos[i].Tag.ToString() + " ) values (";
                }
            }

            for (int i = 0; i < campos.Length; i++)
            {
                if (i < campos.Length - 1)
                {
                    sentencia += "'" + campos[i].Text + "'"  + ", ";
                }
                else
                {
                    sentencia += "'" + campos[i].Text + "'" + " );";
                }
            }

            try
            {
                OdbcCommand ingreso = new OdbcCommand(sentencia, conn);
                ingreso.ExecuteNonQuery();
                resultado = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
            cn.desconexion(conn);
            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void eliminar(TextBox[] arreglo, string tabla, string campoEstado)
        {
            Conexion cn = new Conexion();
            OdbcConnection conexion = cn.conexion();

            for (int i = 0; i < arreglo.Length; i++)
            {
                
                if (arreglo[i].Tag.ToString() == campoEstado)
                {
                    
                    //if (arreglo[i].Text =="I")
                    //{
                        //string sql = "UPDATE" + " " + tabla + " " + "SET" + " " + campoEstado + " ="+"'"+arreglo[i].Text+"'"+ " "+"WHERE" + " " + arreglo[0].Tag.ToString() + " = " + arreglo[0].Text;
                        string sql = "UPDATE" + " " + tabla + " " + "SET" + " " + campoEstado + " =" + "'" +'I'+ "'" + " " + "WHERE" + " " + arreglo[0].Tag.ToString() + " = " + arreglo[0].Text;
                        //MessageBox.Show(sql);
                        try
                        {
                            OdbcCommand eliminar = new OdbcCommand(sql, conexion);
                            eliminar.ExecuteNonQuery();

                            MessageBox.Show("Registro dado de baja correctamente");
                        }
                        catch (OdbcException error)
                        {
                            MessageBox.Show("Error al eliminar el registro " + error.Message);
                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Ingrese un estado válido I=Inactivo");
                    //    break;
                    //}
                    
                }
            }

        }

        /*Geovani Fernando Mendoza Funcion Ayuda  - 9959-18-15407*/
        public void funAyuda(string idAplicacion, string nombreCampo, string tablaA, Control parent)
        {
            OdbcDataReader leer = null;

            string sql = "SELECT * FROM " + " " + tablaA + " " + "WHERE " + " " + nombreCampo + "=" + idAplicacion;

            OdbcConnection conect = conexion.conexion();

            try
            {

                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    rutaAyudaCHM = leer.GetString(4);

                    rutaAyudaHTML = leer.GetString(5);
                }


            }
            catch (OdbcException ex)
            {

                MessageBox.Show("Error al cargar los datos" + ex.Message);

            }

            finally
            {
                conexion.desconexion(conect);

            }

            if (String.IsNullOrEmpty(rutaAyudaCHM) || String.IsNullOrEmpty(rutaAyudaHTML))
            {
                MessageBox.Show("La ruta ingresa CHM o Referencia HTML es incorrecta, verifique Aplicacion!");

            }
            else
            {
                Help.ShowHelp(parent, rutaAyudaCHM, rutaAyudaHTML);
            }




        }


    }//fin de clase
}//fin de clase
