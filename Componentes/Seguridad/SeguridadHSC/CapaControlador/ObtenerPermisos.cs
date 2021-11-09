using CapaModeloSeguridadHSC;

namespace CapaControladorSeguridadHSC
{ //Jorge González 0901-18-3920
    public class ObtenerPermisos
    { static string Usuario;
        OtorgarPermisos permisos = new OtorgarPermisos();
        public string funcPermisosPorAplicacion(string strUsuario)
        {
            return permisos.funcPermisosPorAplicacion(strUsuario);
        }
        public string usuarioglobal
        {
            get { return Usuario; }
            set { Usuario = value; }
        }



    }



   
   
}
