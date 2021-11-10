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
    public partial class frmReporteFactura : Form
    {
        public frmReporteFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReporteFE form = new frmReporteFE();
            form.MdiParent = this;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReporteFD form = new frmReporteFD();
            form.MdiParent = this;
            form.Show();
        }
    }
}
