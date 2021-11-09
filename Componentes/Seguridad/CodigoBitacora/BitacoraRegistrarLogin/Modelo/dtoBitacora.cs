using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    /// MELANIE REVOLORIO
    /// <summary>
    /// Modelo Bitácora
    /// </summary>
    public class dtoBitacora //data transfer object
    {
        public int pkId { get; set; }
        public int fkIdUsuario { get; set; }
        public string host { get; set; }
        public string ip { get; set; }
        public int fkIdModulo { get; set; }
        public int fkIdAplicacion { get; set; }
        public string accion { get; set; }
        public DateTime conexionFecha { get; set; }
        public TimeSpan conexionHora { get; set; }


        public dtoBitacora()
        {
            DateTime fecha = DateTime.Now;
            string fechaconHora = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaSolita = fecha.ToString("yyyy-MM-dd");
            DateTime fechaNueva = DateTime.Parse(fechaconHora);
            conexionFecha = DateTime.Parse(fechaSolita);
            conexionHora = new TimeSpan(fechaNueva.Hour, fechaNueva.Minute, fechaNueva.Second);
        }
    }
}