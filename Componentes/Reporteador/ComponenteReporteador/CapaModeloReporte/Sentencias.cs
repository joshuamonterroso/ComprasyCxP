using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloReporte
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        //Carol Monterroso 0901-17-5961
        public void Guardar(string nombre, string ruta, string IdAplicacion, string estado, string id)
        {
            string cadena = "UPDATE reporte SET" +
                "nombre = '" + nombre + "'," +
                "ruta = '" + ruta + "'," +
                "idAplicacion = '" + IdAplicacion + "'," +
                "estado = '" + estado + "' " +
                "WHERE (idReporte = '" + id + "');";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Guardado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en CapaModeloReporte --> Sentencias: " + e);
            }
        }
        //Luis Reyes 0901-15-3121
        public void Guardar2(string id, string nombre, string ruta, string IdAplicacion, string estado)
        {
            string cadena = "INSERT INTO reporte VALUES('" + id + "','" + nombre + "','" + ruta + "','" + IdAplicacion + "','" + estado + "');";

            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Guardado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en CapaModelo --> Consulta: " + e);
            }
        }
        //Angel Chacón 9959-18-5201

        public OdbcDataReader IdMod(string cadena)
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader leer = consulta.ExecuteReader();
                return leer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en CapaModelo --> Consultas: " + e);
                return null;
            }
        }
        //Angel Chacón 9959-18-5201

        public OdbcDataReader llenarcbxmodulo(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Angel Chacón 9959-18-5201

        public OdbcDataReader IdAplic(string nombreA)//conexion para obtener el IdAplicacion para el Combobox
        {
            string cadena = "Select pkId from aplicacion where nombre = '" + nombreA + "';";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader leer = consulta.ExecuteReader();
                return leer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Capa Modelo --> Consultas: " + e);
                return null;
            }
        }
        //Angel Chacón 9959-18-5201
        //Funcion para obtener el IdModulo        
        public OdbcDataReader llenarcbxAplicacion()//conexion para obtener el nombre de la aplicacion en combobox
        {
            string sql = "SELECT nombre FROM hotelsancarlos.aplicacion;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Angel Chacón 9959-18-5201
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla en la BD
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        // Luis Reyes 0901-15-3121
        public OdbcDataAdapter llenarTb2(string datob)// metodo que obtinene de la tabla de la busqueda 
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM reporte where nombre = '" + datob + "' ;"; // aqui ponemos la consulta de la busqueda que vallamos hacer en la BD
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable; // Aquie retorna el dataTable
        }
        // Luis Reyes 0901-15-3121
        public void dataGrid(string datos)
        {
            string cadena = @"SELECT * FROM hotelsancarlos.reporte;";

            OdbcDataAdapter consulta = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();
            consulta.Fill(dt);
            datos = Convert.ToString(dt);
        }
    }
}
