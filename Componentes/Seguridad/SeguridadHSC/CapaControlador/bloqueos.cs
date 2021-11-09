using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using CapaModeloSeguridadHSC;

//0901-18-17144 Luis De la Cruz
namespace CapaControladorSeguridadHSC
{
    public class bloqueos
    {
        llamarPermisos llp = new llamarPermisos();

        public string bloqueo(string id, string app)
        {
            string cadena = llp.llenarpermisos(id, app);

            return cadena;

        }




    }
}
