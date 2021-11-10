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
    }
}
