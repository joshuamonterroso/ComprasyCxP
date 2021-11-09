using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo
{
   public class clsconexion
    {
        //Adolfo Monterroso 0901-18-50
        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC        
            OdbcConnection conn = new OdbcConnection("Dsn=ConexionHSC");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("NO Conectó");
            }
            return conn;
        }
        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }
    }
}
