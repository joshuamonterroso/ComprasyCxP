using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo
{
    public class clsSentencias
    {
        //Obtener datos de una tabla capa Modelo
        //Adolfo Monterroso 0901-18-50
        clsconexion con = new clsconexion();

        //Adolfo Monterroso 0901-18-50
        public OdbcDataAdapter llenartb1(string tabla) //Metodo que obtiene el contenido de una tabla
        {
            string sql = tabla;
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        //Adolfo Monterroso 0901-18-50
        //Llenar combobox con tablas de bd
        public OdbcDataReader llenarcbotabla(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        //Adolfo Monterroso 0901-18-50
        //Ejecuta querys de insert, update y delete
        public void insertarconsulta(string cadena)
        {
        try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, con.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo" + Error);
            }
        }
        //Adolfo Monterroso 0901-18-50
        //Valida si la consulta es valida
        public OdbcDataReader validarconsulta(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        //Adolfo Monterroso 0901-18-50
        public OdbcDataAdapter llenartb2(string sql) //Metodo que obtiene el contenido de una tabla
        {
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        //Adolfo Monterroso 0901-18-50
        //Obtenemos el registro de consultas almacenadas
        public OdbcDataReader llenarcbonombreconsulta(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
