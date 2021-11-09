using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    /*Brayan Mauricio Cifuentes López - 9959-18-11113 - Creacion de MDI*/
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Form1 Prod = new Form1();
            Prod.MdiParent = this;
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }
    }
}
