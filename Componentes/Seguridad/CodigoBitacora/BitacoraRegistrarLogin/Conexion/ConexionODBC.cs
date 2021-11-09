using System.Data.Odbc;

namespace Conexion
{
    /// JORGE GONZÁLEZ Y MELANIE REVOLORIO
    /// <summary>
    /// Conexion ODBC
    /// </summary>
    public class ConexionODBC
    {
        private string dsn = "Dsn=conexionHSC";

        /// <summary>
        /// Inicia la conexión hacia ODBC con el DSN especificado.
        /// </summary>
        /// <returns></returns>
        public OdbcConnection abrirConexion()
        {
            OdbcConnection conexion = new OdbcConnection(dsn);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (OdbcException e)
            {
                return null;
            }
        }

        /// <summary>
        /// Cierra la conexión hacia ODBC con el DSN especificado.
        /// </summary>
        /// <param name="conexion"></param>
        public void cerrarConexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException e)
            {
            }
        }
    }
}