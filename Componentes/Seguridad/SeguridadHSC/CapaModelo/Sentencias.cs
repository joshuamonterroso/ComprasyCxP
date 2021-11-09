using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModeloSeguridadHSC
{
    public class Sentencias
    {
        private Conexion cn = new Conexion();
        private OdbcCommand Comm;

        //frmLogin Kevin Flores 9959-18-17632
        public int funIniciarSesion(string Usuario, string Contraseña, int validar)
        {
            try
            {
                string con = "";

                string Query = "select * from Usuario where nombre='" + Usuario + "';";

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                if (busqueda.Read())
                {
                    con = busqueda["contraseña"].ToString();
                }

                validar = Contraseña.CompareTo(con);
            }
            catch
            {
            }

            return validar;
        }
        //Kevin Flores 9959-18-17632
        public int funInicio(string Usuario, string Contrasena)
        {
            try
            {
                string Us = "";
                string Con = "";
                Comm = new OdbcCommand("SELECT nombre, contraseña FROM usuario WHERE nombre ='" + Usuario + "' AND contraseña ='" + Contrasena + "' AND estado = 1 ;", cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                reader.Read();
                Us = reader.GetString(0);
                Con = reader.GetString(1);
                reader.Close();
                if (String.IsNullOrEmpty(Us) || String.IsNullOrEmpty(Con))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consular usuario:  " + ex);
                return 0;
            }
        }

        //frmMantenimientoAplicacion Sebastián Moreira 9959-18-7960 
        public void funInsertar(string Id, string Modulo, string Nombre, int estado, string rutaChm, string rutaHtml)
        {
            //INSERT INTO `componenteseguridad`.`aplicacion` (`pkId`, `fkIdModulo`, `nombre`, `estado`, `rutaChm`, `rutaHtml`) VALUES('1001', '2', 'Conta', '1', '0', '0');
            string cadena = "INSERT INTO aplicacion VALUES ('" + Id + "', '" + Modulo + "' , '" + Nombre + "' , '" + estado + "', '" + rutaChm + "', '" + rutaHtml + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Sebastián Moreira 9959-18-7960
        public void funModificar(string Id, string Modulo, string Nombre, int estado, string rutaChm, string rutaHtml)
        {
            string cadena = "UPDATE aplicacion set pkId ='" + Id + "', fkIdModulo= '" + Modulo
              + "',nombre ='" + Nombre + "',estado = " + estado + ", rutaChm = '" + rutaChm + "', rutaHtml = '" + rutaHtml + "'  where pkId= '" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Sebastián Moreira 9959-18-7960
        public void funEliminar(string Id)
        {
            string cadena = "delete from aplicacion where pkId ='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Sebastián Moreira 9959-18-7960
        public (string, int) funBuscar(string id, string nombre, int estado, string ruta)
        {
            string Query = "select * from Aplicacion where pkId='" + id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                nombre = busqueda["nombre"].ToString();
                estado = int.Parse(busqueda["estado"].ToString());
            }

            return (nombre, estado);
        }
        //Sebastián Moreira 9959-18-7960
        public OdbcDataAdapter llenarTblAplicacion(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Sebastián Moreira 9959-18-7960
        public string consultaModulo(string nombre)
        {

            string id = "";
            string Query = "select * from Modulo where nombre='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["pkid"].ToString();

            }


            return id;
        }


        //frmPerfiles Heydi Quemé 9959-18-5335

        public OdbcDataAdapter PerfilllenarTbl(string tabla2)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkid, nombre FROM " + tabla2 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Heydi Quemé 9959-18-5335
        public OdbcDataAdapter PerfilllenarTblPersonal(string tabla2, string condicion)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT perfil.pkid, perfil.nombre FROM " + tabla2 + "  LEFT JOIN usuarioperfil ON perfil.pkid = usuarioperfil.fkidperfil LEFT JOIN usuario ON usuarioperfil.fkidusuario = usuario.pkid WHERE usuario.pkid = " + condicion + " ORDER BY perfil.pkid;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Heydi Quemé 9959-18-5335
        public OdbcDataAdapter PerfilllenarNombre(string tabla, string condicion)// metodo  que obtinene el contenido
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT nombre FROM " + tabla + " WHERE pkid = " + condicion + "  ;";
            OdbcDataAdapter dataName = new OdbcDataAdapter(sql, cn.conexion());
            return dataName;
        }
        //Heydi Quemé 9959-18-5335
        public void Perfilagregar(string tabla3, string valor1, string valor2)
        {
            string sql = "INSERT INTO " + tabla3 + " (fkidUsuario, fkidPerfil) Values( '" + valor1 + "', '" + valor2 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //Heydi Quemé 9959-18-5335
        public void Perfileliminar(string tabla3, string valor1, string valor2)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidUsuario = '" + valor1 + "' AND  fkidperfil='" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Heydi Quemé 9959-18-5335
        public void Perfileliminartodo(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidUsuario = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Heydi Quemé 9959-18-5335
        public void Perfilagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            string sql = "INSERT INTO usuarioperfil (fkidUsuario, fkidPerfil) SELECT NULL, pkid FROM perfil;";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

            string sql2 = "UPDATE usuarioperfil SET " + tabla3 + " = '" + valor1 + "' WHERE fkidUsuario = '';";
            OdbcCommand consulta2 = new OdbcCommand(sql2, cn.conexion());
            consulta2.ExecuteNonQuery();
        }

        //frmAplicaciones Danny Saldaña 0901-18-18686
        public OdbcDataAdapter aplicacionllenarTbl(string tabla2)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkId, nombre FROM " + tabla2 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Danny Saldaña 0901-18-18686
        public OdbcDataAdapter aplicacionllenarTblPerfil(string tabla4)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkid, nombre FROM " + tabla4 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Danny Saldaña 0901-18-18686
        public OdbcDataAdapter aplicacionllenarTblPersonal(string tabla3, string condicion)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT aplicacion.pkid, aplicacion.nombre FROM " + tabla3 + "  LEFT JOIN usuarioaplicacion ON aplicacion.pkid = usuarioaplicacion.fkidAplicacion LEFT JOIN usuario ON usuarioaplicacion.fkIdUsuario = usuario.pkid WHERE usuario.pkid = " + condicion + " ORDER BY aplicacion.pkid;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;


        }
        //Danny Saldaña 0901-18-18686
        public OdbcDataAdapter aplicacionllenarNombre(string tabla, string condicion)// metodo  que obtinene el contenido
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT nombre FROM " + tabla + " WHERE pkid = " + condicion + "  ;";
            OdbcDataAdapter dataName = new OdbcDataAdapter(sql, cn.conexion());
            return dataName;
        }
        //Danny Saldaña 0901-18-18686
        public void aplicacionagregar(string tabla3, string valor1, string valor2)
        {
            string sql = "INSERT INTO " + tabla3 + "  Values('" + valor1 + "','" + valor2 + "',null,null,null,null,null);";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Danny Saldaña 0901-18-18686
        public void aplicacioneliminar(string tabla3, string valor1, string valor2)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidUsuario = '" + valor1 + "' AND  fkidAplicacion='" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Danny Saldaña 0901-18-18686
        public void aplicacioneliminartodo(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidUsuario = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Danny Saldaña 0901-18-18686
        public void aplicacionagregartodo(string tabla3, string valor1, string valor2, string tabla2)
        {
            string sql = "INSERT INTO UsuarioAplicacion (fkidUsuario, fkidaplicacion) SELECT *, pkid FROM aplicacion;";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        
            string sql2 = "UPDATE UsuarioAplicacion SET " + tabla3 + " = '" + valor1 + "' WHERE fkidUsuario = '';";
            OdbcCommand consulta2 = new OdbcCommand(sql2, cn.conexion());
            consulta2.ExecuteNonQuery();
        }
        //frmAplicaciones Danny Saldaña 0901-18-18686

        public OdbcDataAdapter aplicacionllenarTblPersonal(string tabla2)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT aplicacion.pkid, aplicacion.nombre, perfil.pkid, perfil.nombre FROM aplicacionperfil  LEFT JOIN aplicacion ON aplicacion.pkid = aplicacionperfil.fkidAplicacion LEFT JOIN perfil ON aplicacionperfil.fkidPerfil = perfil.pkid ORDER BY aplicacion.pkid;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Danny Saldaña 0901-18-18686

        public void aplicacioneliminartodo(string tabla3)
        {
            string sql = "DELETE FROM aplicacionperfil;";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }



        //frmRecuperarContraseña Heydi Quemé 9959-18-5335
        public OdbcDataReader funcModificarContraseña(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
                return null;
            }
        }
        //Heydi Quemé 9959-18-5335
        public void funRecuperar(string Usuario, string Contraseña)
        {
            try
            {
                string cadena = "UPDATE" +
                " Usuario SET contraseña=" + Contraseña + "WHERE nombre=" + Usuario + "';";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
            }
        }
        //Heydi Quemé 9959-18-5335
        public OdbcDataReader llenarcbxUsuario(string sql)
        {
            try
            {
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

        //mantenimiento Perfil Luis de la Cruz 0901-18-17144

        public void funInsertar(string Id, string Nombre, int estado)
        {
            string cadena = "INSERT INTO Perfil VALUES ('" + Id + "', '" + Nombre + "' , '" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Luis de la Cruz 0901-18-17144
        public void funModificar(string Id, string Nombre, int estado)
        {
            string cadena = "UPDATE perfil set pkId ='" + Id
              + "',nombre ='" + Nombre + "',estado = " + estado + "  where pkId= '" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Luis de la Cruz 0901-18-17144
        public void funEliminarPerfil(string Id)
        {
            string cadena = "delete from perfil where pkId ='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Luis de la Cruz 0901-18-17144
        public (string, int) funBuscar(string id, string nombre, int estado)
        {
            string Query = "select * from Perfil where pkId='" + id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                nombre = busqueda["nombre"].ToString();
                estado = int.Parse(busqueda["estado"].ToString());
            }

            return (nombre, estado);
        }
        //Luis de la Cruz 0901-18-17144
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkid, nombre, estado FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Aplicacion a perfiles Roberto Lopez 0901-18-4982
        public OdbcDataAdapter llenarTblappaperf(string tabla2)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkid, nombre FROM " + tabla2 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Roberto Lopez 0901-18-4982
        public OdbcDataAdapter llenarTblPersonalappaperf(string tabla2, string condicion)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT aplicacion.pkid, aplicacion.nombre FROM " + tabla2 + "  LEFT JOIN aplicacionperfil ON aplicacion.pkid = aplicacionperfil.fkidAplicacion LEFT JOIN perfil ON aplicacionperfil.fkidPerfil = perfil.pkid WHERE perfil.pkid = " + condicion + " ORDER BY aplicacion.pkid;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Roberto Lopez 0901-18-4982
        public OdbcDataAdapter llenarNombreappaperf(string tabla, string condicion)// metodo  que obtinene el contenido
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT nombre FROM " + tabla + " WHERE pkid = " + condicion + "  ;";
            OdbcDataAdapter dataName = new OdbcDataAdapter(sql, cn.conexion());
            return dataName;
        }
        //Roberto Lopez 0901-18-4982
        public void agregarappaperf(string tabla3, string valor1, string valor2)
        {
            string sql = "INSERT INTO " + tabla3 + " (fkIdPerfil, fkIdAplicacion) Values( '" + valor1 + "', '" + valor2 + "');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Roberto Lopez 0901-18-4982
        public void eliminarappaperf(string tabla3, string valor1, string valor2)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidPerfil = '" + valor1 + "' AND  fkidAplicacion='" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Roberto Lopez 0901-18-4982
        public void perfileliminartodoappaperf(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidPerfil = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Roberto Lopez 0901-18-4982
        public void perfilagregartodoappaperf(string tabla3, string valor1, string valor2, string tabla2)
        {
            string sql = "INSERT INTO usuarioperfil (fkidAplicacion, fkidPerfil) SELECT NULL, pkid FROM perfil;";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

            string sql2 = "UPDATE aplicacionperfil SET " + tabla3 + " = '" + valor1 + "' WHERE fkidUsuario = '';";
            OdbcCommand consulta2 = new OdbcCommand(sql2, cn.conexion());
            consulta2.ExecuteNonQuery();
        }

        //Cambiar contraseña Roberto Lopez 0901-18-4982

        public OdbcDataReader funcModificar(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
                return null;
            }
        }
        //Roberto Lopez 0901-18-4982
        public void registrarUsuario(string pkId, string fkIdEmpleado, string nombre, string contraseña, string estado)
        {
            string sql = "INSERT INTO usuario (pkId, fkIdEmpleado, nombre, contraseña, estado, intento) Values( '" + pkId + "', '" + fkIdEmpleado + "', '" + nombre + "', '" + contraseña + "', '" + estado + "', '0');";
            try
            {
                OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
                consulta.ExecuteNonQuery();
            }

            catch (Exception e)

            {
                Console.WriteLine("Ya existe un usuario con ese id de empleado");
            }
        }

        //frmPermisos Heydi Quemé 9959-18-5335
        public OdbcDataReader llenarcbxPerfil(string sql)
        {
            try
            {
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
        //Heydi Quemé 9959-18-5335
        public OdbcDataReader llenarcbxUsuarios(string sql)
        {
            try
            {
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
        //Heydi Quemé 9959-18-5335
        public OdbcDataReader llenarcbxAplicacion(string sql)
        {
            try
            {
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
        //Heydi Quemé 9959-18-5335
        public string consultaperfil(string nombre)
        {

            string id = "";
            string Query = "select * from Perfil where nombre='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["pkid"].ToString();

            }


            return id;
        }
        //Heydi Quemé 9959-18-5335
        public string consultausuario(string nombre)
        {

            string id = "";
            string Query = "select * from Usuario where nombre='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["pkid"].ToString();

            }


            return id;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaaplicacion(string nombre)
        {

            string id = "";
            string Query = "select * from Aplicacion where nombre='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["pkid"].ToString();

            }


            return id;
        }
        //Heydi Quemé 9959-18-5335
        public void InsertarPUsuApl(string usuario, string aplicacion, int escribir, int leer, int modificar, int eliminar, int imprimir)
        {

            try
            {
                string cadena = "UPDATE usuarioaplicacion SET permisoEscritura=" + escribir + ",permisoLectura=" + leer + ",permisoModificar=" + modificar + ",permisoEliminar=" + eliminar + ",permisoImprimir=" + imprimir + " WHERE fkIdUsuario=" + usuario + " AND fkIdAplicacion=" + aplicacion + ";";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Asignación Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Asignación:" + ex);
            }


        }
        //Heydi Quemé 9959-18-5335
        public void InsertarPPerApl(string perfil, string aplicacion, int escribir, int leer, int modificar, int eliminar, int imprimir)
        {

            try
            {
                string cadena = "UPDATE aplicacionperfil SET permisoEscritura=" + escribir + ",permisoLectura=" + leer + ",permisoModificar=" + modificar + ",permisoEliminar=" + eliminar + ",permisoImprimir=" + imprimir + " WHERE fkIdPerfil=" + perfil + " AND fkIdAplicacion=" + aplicacion + ";";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Asignación Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Asignación:" + ex);
            }

        }
        //Heydi Quemé 9959-18-5335
        public OdbcDataAdapter llenarpermisosUA(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Heydi Quemé 9959-18-5335
        public OdbcDataAdapter llenarpermisosPA(string tabla2)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla2 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaperfiln(string id)
        {

            string nombre = "";
            string Query = "select * from Perfil where pkid='" + id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                nombre = busqueda["nombre"].ToString();

            }


            return nombre;
        }
        //Heydi Quemé 9959-18-5335
        public string consultausuarion(string id)
        {

            string nombre = "";
            string Query = "select * from Usuario where pkid='" + id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                nombre = busqueda["nombre"].ToString();

            }


            return nombre;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaaplicacionn(string id)
        {

            string nombre = "";
            string Query = "select * from Aplicacion where pkid='" + id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                nombre = busqueda["nombre"].ToString();

            }


            return nombre;
        }
        //mantenimiento Módulo Kevin Flores 9959-18-17632

        public void metodoInsertar(string Id, string Nombre, string Descripcion,int estado)
        {
            //INSERT INTO `componenteseguridad`.`modulo` (`pkId`, `nombre`, `descripcion`, `estado`) VALUES('3', 'Reportes', '0', '1');

            string cadena = "INSERT INTO modulo VALUES ('" + Id + "', '" + Nombre + "' , '" + Descripcion + "' , '" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Kevin Flores 9959-18-17632
        public void metodoModificar(string Id, string Nombre, string Descripcion, int estado)
        {
            string cadena = "UPDATE modulo set pkId ='" + Id
              + "',nombre ='" + Nombre + "',descripcion ='" + Descripcion + "',estado = " + estado + "  where pkId= '" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Kevin Flores 9959-18-17632
        public void metodoEliminar(string Id)
        {
            string cadena = "delete from modulo where pkId ='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        //Kevin Flores 9959-18-17632
        public (string, string, int) metodoBuscar(string id, string nombre, string descripcion, int estado)
        {
            string Query = "select * from Modulo where pkId='" + id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                nombre = busqueda["nombre"].ToString();
                descripcion = busqueda["descripcion"].ToString();
                estado = int.Parse(busqueda["estado"].ToString());
            }

            return (nombre, descripcion, estado);
        }
        //Kevin Flores 9959-18-17632
        public OdbcDataAdapter metodollenarTbl(string tabla)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pkid, nombre, descripcion, estado FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
    }
}
