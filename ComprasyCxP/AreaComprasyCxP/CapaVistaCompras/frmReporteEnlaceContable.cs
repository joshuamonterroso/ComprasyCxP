using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaCompras
{
    public partial class frmReporteEnlaceContable : Form
    {
        public frmReporteEnlaceContable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReporteEnlaceContabilidad form = new frmReporteEnlaceContabilidad();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReporteEnlaceContabilidadE form = new frmReporteEnlaceContabilidadE();
            form.Show();
        }
    }
}
