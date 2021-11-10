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
    public partial class frmAyudasOrdenesCompra : Form
    {
        public frmAyudasOrdenesCompra()
        {
            InitializeComponent();
        }

        private void btnAyudas_Click(object sender, EventArgs e)
        {
            //ayudasOrdenesCompra/ayudasOrdenCompra
            Help.ShowHelp(this, "ayudasOrdenesCompra/ayudasOrdenCompra.chm", "Manual-de-Usuario-Ordenes-de-Compra.html");
        }
    }
}
