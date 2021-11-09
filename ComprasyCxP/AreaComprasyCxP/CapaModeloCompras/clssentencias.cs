using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloCompras
{
    public class clssentencias
    {
        clsconexion cn = new clsconexion(); //crear objeto
        OdbcCommand com; //variable para querys

        public OdbcDataReader insertar_bodegas(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO bodegas Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_linea(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO linea Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_marca(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO marca Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

    }
}
