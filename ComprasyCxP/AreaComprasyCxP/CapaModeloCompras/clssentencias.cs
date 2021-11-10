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

        public string calculoDebe(string fechaI, string fechaF)
        {
            //select sum(saldo) from polizaDetalle where concepto = 'Venta' and idTipoOperacion = '1' 
            //and fechaPoliza between cast('2021-10-1' as date) and cast('2021-10-02' as date);

            string total = "";
            string Query = "select sum(total) from facturaencabezado where " + " fecha between cast('" + fechaI + "' as date) and cast('" + fechaF + "' as date) ;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                total = busqueda["sum(total)"].ToString();

            }

            return total;
        }

        public string calculoHaber(string fechaI, string fechaF)
        {
            //select sum(saldo) from polizaDetalle where concepto = 'Venta' and idTipoOperacion = '1' 
            //and fechaPoliza between cast('2021-10-1' as date) and cast('2021-10-02' as date);

            string total = "";
            string Query = "select sum(total) from facturaencabezado where " + " fecha between cast('" + fechaI + "' as date) and cast('" + fechaF + "' as date) ;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                total = busqueda["sum(total)"].ToString();

            }

            return total;
        }

        public string incrementarId()
        {
            string id = "";
            // string Query = "select * from polizaEncabezado order by length (idPolizaEncabezado) DESC limit 1;";
            string Query = " SELECT(idPolizaEncabezado * 1) as `idPolizaEncabezado` from polizaEncabezado order by(idPolizaEncabezado) DESC limit 1;";
            //  string Query = "select * from polizaDetalle ORDER BY length(idPolizaEncabezado ) ASC;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["idPolizaEncabezado"].ToString();

            }
            else
            {
                Console.WriteLine("Error acá");
            }
            return id;
        }

        public void insertarEncabezado(string Id, string fecha, string tipoPoliza)
        {
            string cadena = "INSERT INTO" +
            " polizaEncabezado VALUES (" + "'" + Id + "', '" + fecha + "' ,'" + tipoPoliza + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        public void insertarDetalle(string Id, string fecha, string idCuenta, string saldo, string idtipoOp, string concepto)
        {


            string cadena = "INSERT INTO" +
            " polizaDetalle VALUES (" + "'" + Id + "', '" + fecha + "' ,'" + idCuenta + "','" + saldo + "','" + idtipoOp + "','" + concepto + "' );";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


    }
}
