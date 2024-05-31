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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txtLabelNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private DataTable makeDataTable(string labelPrefix, Int32 qty, bool increaseSrNum, Int32 srNum = 0)
        {
            try
            {
                DataTable dt = new DataTable();
                Int32 _srNum = srNum;

                DataColumn col = new DataColumn("label");
                col.DataType = System.Type.GetType("System.String");
                dt.Columns.Add(col);

                for (int i = 0; i < Convert.ToInt32(qty); i++)
                {
                    dt.Rows.Add(i);
                    if (srNum>0)
                    {
                        int sr = (!increaseSrNum) ? srNum : _srNum++;
                        dt.Rows[i]["label"] = labelPrefix+sr;
                    }
                    else
                    {
                        dt.Rows[i]["label"] = labelPrefix;
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrefix.Text)&&!string.IsNullOrEmpty(this.txtQt.Text)&&(Convert.ToInt32(txtQt.Text)>0))
            {
                Print(makeDataTable(txtPrefix.Text, Convert.ToInt32(txtQt.Text), checkBoxIncreaseSrNum.Checked, Convert.ToInt32(txtLabelNum.Text)));
            }
            else
            {
                MessageBox.Show("check your input");
            }
        }

        private void Print(DataTable dt)
        {
            try
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument rd = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                string thepath = Application.StartupPath + "\\RptBarcode.rpt";

                //var txtobj = rd.ReportDefinition.ReportObjects["barcode1"];
                //txtobj.Height = 200;
                //txtobj.Width = 400;

                rd.Load(thepath);

                rd.Database.Tables[0].SetDataSource(dt);

                RptViwer rptV = new RptViwer();
                rptV.rptRD1 = rd;
                rptV.rptTitle = "Label Privew";
                rptV.isDirectPrint = checkBoxDirectPrint.Checked;
                rptV.ShowDialog(this);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtLabelNum_TextChanged(object sender, EventArgs e)
        {
            if (txtLabelNum.Text.Length<1)
            {
                txtLabelNum.Text = "0";
            }
        }
    }
}
