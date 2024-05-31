using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabelPrinting
{
    public partial class RptViwer : Form
    {
        public CrystalDecisions.CrystalReports.Engine.ReportDocument rptRD1 { get; set; }
        public String rptTitle { get; set; }
        public bool isDirectPrint { get; set; }

        public RptViwer()
        {
            InitializeComponent();
        }

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
