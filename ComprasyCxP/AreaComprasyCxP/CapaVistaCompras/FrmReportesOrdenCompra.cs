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
    public partial class FrmReportesOrdenCompra : Form
    {
        public FrmReportesOrdenCompra()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporteOrdenCompra ordenC = new frmReporteOrdenCompra();
            ordenC.MdiParent = this;
            ordenC.Show();
        }
    }
}
