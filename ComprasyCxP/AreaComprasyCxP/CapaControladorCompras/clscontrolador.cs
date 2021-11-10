using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModeloCompras;

namespace CapaControladorCompras
{
    public class clscontrolador
    {
        //Instanciamos la clase sentencias

        clssentencias sn = new clssentencias();
                public OdbcDataReader insertar_bodegas(string[] dato)
                {
                    return sn.insertar_bodegas(dato);
                }
                public OdbcDataReader insertar_linea(string[] dato)
                {
                    return sn.insertar_linea(dato);
                }
                public OdbcDataReader insertar_marca(string[] dato)
                {
                    return sn.insertar_marca(dato);
                }

        //fernando biggs
        public OdbcDataReader insertar_OrdenC(string[] dato)
        {
            return sn.insertar_OrdenCompra(dato);
        }

        public OdbcDataReader llenarcboProv()
        {
            return sn.llenarcboprovCompras();
        }

        public OdbcDataReader insertar_FacturaEn(string[] dato)
        {
            return sn.insertar_FacturaEncabezado(dato);
        }

        public OdbcDataReader llenarcboOrdenC()
        {
            return sn.llenarcboIDorden();
        }

        public OdbcDataReader insertar_FacturaD(string[] dato)
        {
            return sn.insertar_FacturaDetalle(dato);
        }

        public OdbcDataReader llenarFacturasE()
        {
            return sn.llenarFacE();
        }

        public OdbcDataReader llenarProducto()
        {
            return sn.llenarPr();
        }

        public DataTable llenarDvgOrdenCompra(string condicion)
        {
            OdbcDataAdapter dt = sn.llenardvgor(condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarDvgFE(string condicion)
        {
            OdbcDataAdapter dt = sn.llenardvgFE(condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable actualizar()
        {
            OdbcDataAdapter dt = sn.llenardvgORNOR();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable actualizarFE()
        {
            OdbcDataAdapter dt = sn.llenardvgFEnc();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public OdbcDataReader llenarProv()
        {
            return sn.llenarPrOr();
        }

        public DataTable actualizar2()
        {
            OdbcDataAdapter dt = sn.llenardvgFD();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarDvgFdetalle(string condicion)
        {
            OdbcDataAdapter dt = sn.llenardvgFde(condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}
