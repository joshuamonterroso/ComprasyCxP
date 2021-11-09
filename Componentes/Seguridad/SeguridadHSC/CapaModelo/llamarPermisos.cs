using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

//0901-18-17144 Luis De la Cruz

namespace CapaModeloSeguridadHSC
{
    public class llamarPermisos
    {
        Conexion cn = new Conexion();


        //Luis de la Cruz 0901-18-17144
        public string llenarpermisos(string id, string app)
        {


            string Query = "SELECT  *    from   usuarioAplicacion   WHERE fkIdUsuario = " + id + " AND fkIdAplicacion= " + app + ";";






            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            string cadena = "";
            if (busqueda.Read())
            {


                string escritura = busqueda["permisoEscritura"].ToString();

               string lectura = busqueda["permisoLectura"].ToString();


               string imprimir = busqueda["permisoImprimir"].ToString();


               string eliminar = busqueda["permisoEliminar"].ToString();


               string modificar = busqueda["permisoModificar"].ToString();

                 cadena = escritura + lectura + imprimir + eliminar + modificar;


            }

            

            return cadena;


        }




    }
}