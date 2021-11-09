using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaReporte
{
    //Luis Reyes 0901-15-3121
    public partial class frmReporteEmp : Form
    {
        public frmReporteEmp()
        {
            InitializeComponent();
        }
        //Luis Reyes 0901-15-3121
        public frmReporteEmp(String texto)
        {
            InitializeComponent();
            textBox1.Text = texto;
            mostrar();
        }
        //Luis Reyes 0901-15-3121
        public void mostrar()
        {
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(textBox1.Text);
            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }
    }
}
