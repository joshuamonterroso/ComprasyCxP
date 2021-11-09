using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaVistaReporte;
using System.Windows.Forms;

namespace Llamada
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CapaVistaReporte.ReporteadorAdmin());
        }
    }
}
