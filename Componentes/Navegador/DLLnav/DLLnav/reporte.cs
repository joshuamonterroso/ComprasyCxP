using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL.nav
{
    public partial class reporte : Form
    {
        public string ruta = "";

        public reporte()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {

            CrystalDecisions.CrystalReports.Engine.ReportDocument reporte = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            reporte.Load(@"" + ruta);
            crystalReportViewer1.ReportSource = reporte;

        }

        private void reporte_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void reporte_FormClosing(object sender, FormClosingEventArgs e)
        {


            this.Hide();
            this.Parent = null;
            e.Cancel = true;

            CrystalDecisions.CrystalReports.Engine.ReportDocument reporte = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            reporte.Load(@"" + ruta);
            crystalReportViewer1.ReportSource = reporte;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void reporte_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;

            CrystalDecisions.CrystalReports.Engine.ReportDocument reporte = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            reporte.Load(@"" + ruta);
            crystalReportViewer1.ReportSource = reporte;

        }
    }
}