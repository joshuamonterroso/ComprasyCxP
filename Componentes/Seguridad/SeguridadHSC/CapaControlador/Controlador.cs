using CapaModeloSeguridadHSC;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorSeguridadHSC
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();
        private llamarPermisos ll = new llamarPermisos();
        //Permisos de Botones Luis de la Cruz 0901-18-17144

       

        //frmLogin Kevin Flores 9959-18-17632
        public int InicarSesion(string Usuario, string Contraseña, int validar)
        {
            validar = sn.funIniciarSesion(Usuario, Contraseña, validar);

            return validar;
        }

        public int funIniciarSesion(string Usuario, string Contrasena)
        {
            int estado = sn.funInicio(Usuario, Contrasena);
            return estado;
        }
        //Controlador de bloquear usuario. //Kevin Flores 9959-18-17632
        public void funcBloquearUsuario(string Usuario)
        {
            string Consulta = "UPDATE usuario set estado= 0 where nombre= '" + Usuario + "';";
            sn.funcModificar(Consulta);
        }


        //frmMantenimientoAplicacion//Sebastián Moreira 9959-18-7960
        public void insertarAplicacion(string Id, string modulo, string nombre, int Estado, string RutaChm, string rutahtml)
        {
            sn.funInsertar(Id, modulo, nombre, Estado, RutaChm, rutahtml);
        }
        //Sebastián Moreira 9959-18-7960
        public void modificarAplicacion(string Id, string modulo, string nombre, int Estado, string RutaChm, string rutahtml)
        {
            sn.funModificar(Id, modulo, nombre, Estado, RutaChm, rutahtml);
        }
        //Sebastián Moreira 9959-18-7960
        public (string, int, string) buscarAplicacion(string id, string nombre, int estado, string ruta)
        {
            sn.funBuscar(id, nombre, estado, ruta);
            return (nombre, estado, ruta);
        }
        //Sebastián Moreira 9959-18-7960
        public void eliminarAplicacion(string id)
        {
            sn.funEliminar(id);
        }
        //Sebastián Moreira 9959-18-7960
        public DataTable llenarTblAplicacion(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblAplicacion(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Sebastián Moreira 9959-18-7960
        public OdbcDataReader llenarcbxModulo()
        {
            string sql = "SELECT nombre FROM modulo;";
            return sn.llenarcbxUsuario(sql);
        }
        //Sebastián Moreira 9959-18-7960
        public string consultaModulo(string nombre)
        {
            string id = sn.consultaModulo(nombre);
            return id;
        }


        //frmPerfiles//Danny Saldaña 0901-18-18686
        public DataTable PerfilllenarTbl(string tabla2)
        {
            OdbcDataAdapter dt = sn.PerfilllenarTbl(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public DataTable PerfilllenarTblPersonal(string tabla2, string condicion)
        {
            OdbcDataAdapter dt = sn.PerfilllenarTblPersonal(tabla2, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public DataTable PerfilllenarNombre(string tabla, string condicion)
        {
            OdbcDataAdapter dt = sn.PerfilllenarNombre(tabla, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public void Perfilagregar(string tabla3, string valor1, string valor2)
        {
            sn.Perfilagregar(tabla3, valor1, valor2);
        }
        //Danny Saldaña 0901-18-18686
        public void Perfileliminar(string tabla3, string valor1, string valor2)
        {
            sn.Perfileliminar(tabla3, valor1, valor2);
        }
        //Danny Saldaña 0901-18-18686
        public void perfilPerfileliminartodo(string tabla3, string valor1)
        {
            sn.Perfileliminartodo(tabla3, valor1);
        }
        //Danny Saldaña 0901-18-18686
        public void perfilPerfilagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            sn.Perfilagregartodo(tabla3, valor1, valor2, tabla2);
        }

        //frmApliaciones
        //frmApliaciones//Danny Saldaña 0901-18-18686
        public DataTable aplicacionllenarTbl(string tabla2)
        {
            OdbcDataAdapter dt = sn.aplicacionllenarTbl(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public DataTable aplicacionllenarTblPerfil(string tabla4)
        {
            OdbcDataAdapter dt = sn.aplicacionllenarTbl(tabla4);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public DataTable aplicacionllenarTblPersonal(string tabla2)
        {
            OdbcDataAdapter dt = sn.aplicacionllenarTblPersonal(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        //Danny Saldaña 0901-18-18686
        public void aplicacionagregar(string tabla3, string valor1, string valor2)
        {
            sn.aplicacionagregar(tabla3, valor1, valor2);
        }
        //Danny Saldaña 0901-18-18686
        public void aplicacioneliminar(string tabla3, string valor1, string valor2)
        {
            sn.aplicacioneliminar(tabla3, valor1, valor2);
        }
        //Danny Saldaña 0901-18-18686
        public void aplicacioneliminartodo(string tabla3)
        {
            sn.aplicacioneliminartodo(tabla3);
        }
        //Danny Saldaña 0901-18-18686
        public void aplicacionagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            sn.aplicacionagregartodo(tabla3, valor1, valor2, tabla2);
        }
        //Danny Saldaña 0901-18-18686
        public DataTable aplicacionllenarTblPersonal(string tabla3, string condicion)
        {
            OdbcDataAdapter dt = sn.aplicacionllenarTblPersonal(tabla3, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Danny Saldaña 0901-18-18686
        public DataTable aplicacionllenarNombre(string tabla, string condicion)
        {
            OdbcDataAdapter dt = sn.aplicacionllenarNombre(tabla, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Danny Saldaña 0901-18-18686

        public void aplicacioneliminartodo(string tabla3, string valor1)
        {
            sn.aplicacioneliminartodo(tabla3, valor1);
        }

        //frmRecuperarContraseña//Heydi Quemé 9959-18-5335
        //frmRContraseña
        public void recuperarContraseña(string Usuario, string Contraseña)
        {
            try
            {
                sn.funRecuperar(Usuario, Contraseña);
            }
            catch
            {
            }
        }
        //Heydi Quemé 9959-18-5335
        public OdbcDataReader llenarcbo()
        {
            string sql = "SELECT nombre FROM usuario;";
            return sn.llenarcbxUsuario(sql);
        }

        //Mantenimiento Perfil//Luis de la Cruz 0901-18-17144

        public void insertarPerfil(string Id, string Nombre, int Estado)
        {
            sn.funInsertar(Id, Nombre, Estado);
        }
        //Luis de la Cruz 0901-18-17144
        public void modificarPerfil(string Id, string Nombre, int Estado)
        {
            sn.funModificar(Id, Nombre, Estado);
        }
        //Ivania Gatica 0901-18-19528
        public (string, int) buscarPerfil(string id, string nombre, int estado, string ruta)
        {
            sn.funBuscar(id, nombre, estado);
            return (nombre, estado);
        }
        //Ivania Gatica 0901-18-19528
        public void eliminarPerfil(string id)
        {
            sn.funEliminarPerfil(id);
        }
        //Ivania Gatica 0901-18-19528
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Aplicacion a perfiles//Roberto Lopez 0901-18-4982
        public DataTable llenarTblappaperf(string tabla2)
        {
            OdbcDataAdapter dt = sn.llenarTblappaperf(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Roberto Lopez 0901-18-4982
        public DataTable llenarTblPersonalappaperf(string tabla2, string condicion)
        {
            OdbcDataAdapter dt = sn.llenarTblPersonalappaperf(tabla2, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Roberto Lopez 0901-18-4982
        public DataTable llenarNombreappaperf(string tabla, string condicion)
        {
            OdbcDataAdapter dt = sn.llenarNombreappaperf(tabla, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Roberto Lopez 0901-18-4982
        public void agregarappaperf(string tabla3, string valor1, string valor2)
        {
            sn.agregarappaperf(tabla3, valor1, valor2);
        }
        //Roberto Lopez 0901-18-4982
        public void eliminarappaperf(string tabla3, string valor1, string valor2)
        {
            sn.eliminarappaperf(tabla3, valor1, valor2);
        }
        //Roberto Lopez 0901-18-4982
        public void perfileliminartodoappaperf(string tabla3, string valor1)
        {
            sn.perfileliminartodoappaperf(tabla3, valor1);
        }
        //Roberto Lopez 0901-18-4982
        public void perfilagregartodoappaperf(string tabla3, string valor1, string valor2, string tabla2)
        {
            sn.perfilagregartodoappaperf(tabla3, valor1, valor2, tabla2);
        }

        //Cambiar contraseña//Roberto Lopez 0901-18-4982

        public OdbcDataReader funcModificar_Contraseña(string Usuario, string Contraseña)
        {
            string Consulta = "UPDATE usuario SET contraseña = '" + Contraseña + "' where nombre = '" + Usuario + "';";
            return sn.funcModificar(Consulta);
        }
        //Roberto Lopez 0901-18-4982
        public void registrarUsuario(string pkId, string fkIdEmpleado, string nombre, string contraseña, string estado)
        {
            sn.registrarUsuario(pkId, fkIdEmpleado, nombre, contraseña, estado);
        }

        //frmPermisos Heydi Quemé 9959-18-5335
        public OdbcDataReader llenarcbxPerfil()
        {
            string sql = "SELECT nombre FROM perfil;";
            return sn.llenarcbxUsuario(sql);
        }
        //Heydi Quemé 9959-18-5335
        public OdbcDataReader llenarcbxUsuarios()
        {
            string sql = "SELECT nombre FROM usuario;";
            return sn.llenarcbxUsuario(sql);
        }
        //Heydi Quemé 9959-18-5335
        public OdbcDataReader llenarcbxAplicacion()
        {
            string sql = "SELECT nombre FROM aplicacion;";
            return sn.llenarcbxUsuario(sql);
        }
        //Heydi Quemé 9959-18-5335
        public string consultausuario(string nombre)
        {
            string id = sn.consultausuario(nombre);
            return id;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaperfil(string nombre)
        {
            string id = sn.consultaperfil(nombre);
            return id;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaaplicacion(string nombre)
        {
            string id = sn.consultaaplicacion(nombre);
            return id;
        }
        //Heydi Quemé 9959-18-5335
        public void InsertarPPerApl(string perfil, string aplicacion, int escribir, int leer, int modificar, int eliminar, int imprimir)
        {
            sn.InsertarPPerApl(perfil, aplicacion, escribir, leer, modificar, eliminar, imprimir);
        }
        //Heydi Quemé 9959-18-5335
        public void InsertarUsuApl(string usuario, string aplicacion, int escribir, int leer, int modificar, int eliminar, int imprimir)
        {
            sn.InsertarPUsuApl(usuario, aplicacion, escribir, leer, modificar, eliminar, imprimir);
        }
        //Heydi Quemé 9959-18-5335
        public DataTable llenarpermisosUA(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarpermisosUA(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Heydi Quemé 9959-18-5335
        public DataTable llenarpermisosPA(string tabla2)
        {
            OdbcDataAdapter dt = sn.llenarpermisosPA(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Heydi Quemé 9959-18-5335
        public string consultausuarion(string id)
        {
            string nombre = sn.consultausuarion(id);
            return nombre;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaperfiln(string id)
        {
            string nombre = sn.consultaperfiln(id);
            return nombre;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaaplicacionn(string id)
        {
            string nombre = sn.consultaaplicacionn(id);
            return nombre;
        }

        //Mantenimiento Modulo Kevin Flores 9959-18-17632

        public void metodoInsertar(string Id, string Nombre, string Descripcion, int Estado)
        {
            sn.metodoInsertar(Id, Nombre, Descripcion, Estado);
        }
        //Kevin Flores 9959-18-17632
        public void modificarModificar(string Id, string Nombre, string Descripcion, int Estado)
        {
            sn.metodoModificar(Id, Nombre, Descripcion, Estado);
        }
        //Kevin Flores 9959-18-17632
        public (string, string, int) metodoBuscar(string id, string nombre, string descripcion, int estado, string ruta)
        {
            sn.metodoBuscar(id, nombre, descripcion, estado);
            return (nombre, descripcion, estado);
        }
        //Kevin Flores 9959-18-17632
        public void metodoEliminar(string id)
        {
            sn.metodoEliminar(id);
        }
        //Kevin Flores 9959-18-17632
        public DataTable metodollenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.metodollenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}