using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaRRHH
{
    public partial class informeEnlaces : Form
    {
        public informeEnlaces()
        {
            InitializeComponent();
        }

        public string ruta = "";

        

        private void reporte_Load(object sender, EventArgs e)
        {

            CrystalDecisions.CrystalReports.Engine.ReportDocument EnlacesContabilidad = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            EnlacesContabilidad.Load(@"" + ruta);
            crystalReportViewer1.ReportSource = EnlacesContabilidad;

        }

        private void reporte_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void reporte_FormClosing(object sender, FormClosingEventArgs e)
        {


            this.Hide();
            this.Parent = null;
            e.Cancel = true;

            CrystalDecisions.CrystalReports.Engine.ReportDocument EnlacesContabilidad = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            EnlacesContabilidad.Load(@"" + ruta);
            crystalReportViewer1.ReportSource = EnlacesContabilidad;

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

            CrystalDecisions.CrystalReports.Engine.ReportDocument EnlacesContabilidad = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            EnlacesContabilidad.Load(@"" + ruta);
            crystalReportViewer1.ReportSource = EnlacesContabilidad;

        }
    }
}
