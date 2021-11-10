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

        // FERNANDO BIGGS INSERTS
        public OdbcDataReader insertar_OrdenCompra(string[] datos)
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO ordencompra Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "');";
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

        public OdbcDataReader insertar_FacturaEncabezado(string[] datos)
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO facturaencabezado Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "');";
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

        public OdbcDataReader insertar_FacturaDetalle(string[] datos)
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO facturadetalle Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "');";
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

        public OdbcDataReader llenarcboprovCompras()
        {
            try
            {
                string sql = "select idProveedor, nombre from proveedor;";
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

        public OdbcDataReader llenarcboIDorden()
        {
            try
            {
                string sql = "SELECT ordencompra.idOrdenCompra, ordencompra.idProveedor,proveedor.nombre, ordencompra.total, ordencompra.fecha, ordencompra.descripcion FROM ordencompra INNER JOIN proveedor ON proveedor.idProveedor = ordencompra.idProveedor";
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

        public OdbcDataReader llenarFacE()
        {
            try
            {
                string sql = "SELECT idFacturaEncabezado from facturaencabezado";
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
        public OdbcDataReader llenarPr()
        {
            try
            {
                string sql = "SELECT pkid,Nombre from producto";
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

        public OdbcDataAdapter llenartb2()
        {
            string sql = "select * from ordencompra;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        public OdbcDataReader llenarPrOr()
        {
            try
            {
                string sql = "select idProveedor, nombre from proveedor;";
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
        public OdbcDataAdapter llenardvgor(string condicion)
        {
            string sql = "SELECT ordencompra.idOrdenCompra, ordencompra.idProveedor, ordencompra.total, ordencompra.fecha, ordencompra.descripcion FROM ordencompra where ordencompra.idProveedor=" + '"' + condicion + '"' + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenardvgFE(string condicion)
        {
            string sql = "SELECT * FROM facturaencabezado where idProveedor =" + '"' + condicion + '"' + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenardvgORNOR()
        {
            string sql = "SELECT * from ordencompra";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenardvgFEnc()
        {
            string sql = "SELECT * from facturaencabezado";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenardvgFD()
        {
            string sql = "SELECT * from facturadetalle";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenardvgFde(string condicion)
        {
            string sql = "SELECT * FROM facturadetalle where idProducto =" + '"' + condicion + '"' + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        //Andrea Guerra 0901-18-858
        public OdbcDataReader consulta(string tabla)
        {
            try
            {
                cn.conexion();
                string consulta = "SELECT * FROM " + tabla + ";";
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

        public OdbcDataReader bodega()
        {
            try
            {
                cn.conexion();
                string consulta = "SELECT pkid, nombre FROM bodega";
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
        // producto

        public OdbcDataReader productos()
        {
            try
            {
                cn.conexion();
                string consulta = "SELECT pkid, Nombre FROM producto";
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

        //producto

        public OdbcDataReader insertar_traslado(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO trasladoproducto Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "' ,'" + datos[6] + "');";
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
