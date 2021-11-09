using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaModeloReporte;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CapaControladorReporte
{
    public class Controlador
    {
        //Carol Monterroso 0901-17-5961
        //funcion para actualizar el datagrid
        Sentencias con = new Sentencias();
        public void Actualizar(string nombre, string ruta, string IdAplicacion, string estado, string id)
        {
            string exc = @"\\";
            string orgn = @"\";
            ruta = ruta.Replace(orgn, exc);
            con.Guardar(nombre, ruta, IdAplicacion, estado, id);
        }
        //Angel Chacón 9959-18-5201 
        //funcion para guardar nuevo reporte
        public void GuardarD(string id, string nombre, string ruta, string IdAplicacion, string estado)
        {
            string exc = @"\\";
            string orgn = @"\";
            ruta = ruta.Replace(orgn, exc);

            con.Guardar2(id, nombre, ruta, IdAplicacion, estado);
        }
        //Angel Chacón 9959-18-5201 
        //Funcion para obtener el IdAplic
        public OdbcDataReader IdAplici(string nombreA)
        {
            return con.IdAplic(nombreA);
        }
        //Angel Chacón 9959-18-5201 
        //Funcion para obtener el nombre de la aplicacion en combobox
        public OdbcDataReader llenarcbxAplic()
        {
            return con.llenarcbxAplicacion();
        }
        Sentencias cons = new Sentencias();
        //Francisco 0901-17-16694 
        public DataTable llenarTbl(string tabla)//Llena el datagrid con los datos obtenidos en la funcion de consultas 
        {
            OdbcDataAdapter dt = cons.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        // Luis Reyes 0901-15-3121
        // llenado del datagrid
        public DataTable llenarTb2(string datob) //Aquie creamos la funcion DataTable llenarTb2 que resive el dato que esta en el variable datob
        {
            OdbcDataAdapter db = cons.llenarTb2(datob); //creamos un objeto
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }
        //Carol Monterroso 0901-17-5961
        public void data(string tabla)
        {
            string datos = tabla;
            cons.dataGrid(datos);
        }
    }
}
