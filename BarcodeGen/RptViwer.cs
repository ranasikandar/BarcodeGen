using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace BarcodeGen
{
    public partial class RptViwer : MetroForm
    {
        public RptViwer()
        {
            InitializeComponent();
        }


        public CrystalDecisions.CrystalReports.Engine.ReportDocument rptRD1 { get; set; }
        public String rptTitle { get; set; }
        public bool isDirectPrint { get; set; }


        private void RptViwer_Load(object sender, EventArgs e)
        {
            if (isDirectPrint)
            {
                rptRD1.PrintToPrinter(1, false, 0, 0);
                this.Close();
            }
            else
            {
                this.Text = rptTitle;
                this.crystalReportViewer1.ReportSource = rptRD1;

                this.Refresh();
            }
            //this.reportViewer1.RefreshReport();
        }

        private void RptViwer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.rptRD1 != null)
            {
                this.rptRD1.Close();
                this.rptRD1.Dispose();
            }

            this.crystalReportViewer1.Dispose();
            this.crystalReportViewer1 = null;

            System.GC.Collect();
        }
    }
}
