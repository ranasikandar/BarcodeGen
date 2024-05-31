using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace BarcodeGen
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.tileExample.Text = "";
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            this.tileExample.Text = this.txtBarcode.Text.ToUpper();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.txtBarcode.Text) && !string.IsNullOrEmpty(this.txtQty.Text))
                {
                    double price = 0;
                    if (!string.IsNullOrEmpty(txtPrice.Text))
                    {
                        price = Convert.ToDouble(txtPrice.Text);
                    }

                    Print(makeDataTable(txtBarcode.Text, Convert.ToInt32(txtQty.Text), price));

                    //RptViwer rpt = new RptViwer();
                    //rpt.ShowDialog(this);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Check your input.\n Enter Barcode and Number of Stickers that you want to be printed.", "invalid parameter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                throw ex;
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
                rptV.rptTitle = "Barcode Privew";
                rptV.isDirectPrint = ToggleIsDirectPrint.Checked;
                rptV.ShowDialog(this);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private DataTable makeDataTable(string barcode, Int32 qty, double price = 0)
        {
            try
            {
                DataTable dt = new DataTable();

                DataColumn col = new DataColumn("barcode");
                col.DataType = System.Type.GetType("System.String");
                dt.Columns.Add(col);

                col = new DataColumn("sr");
                col.DataType = System.Type.GetType("System.Int32");
                dt.Columns.Add(col);

                col = new DataColumn("price");
                col.DataType = System.Type.GetType("System.Double");
                dt.Columns.Add(col);

                for (int i = 0; i < Convert.ToInt32(qty); i++)
                {
                    dt.Rows.Add(i);
                    dt.Rows[i]["barcode"] = barcode.ToUpper();
                    dt.Rows[i]["sr"] = i;
                    dt.Rows[i]["price"] = price;
                }

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            this.lblPrice.Text = "Rs." + this.txtPrice.Text + "";
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            try
            {
                //string exMsg = InstallBarcode.RegisterFont().Message;
                System.Diagnostics.Process.Start("mailto:ranasikandar@mail.com?Subject=i%20appreciate%20Barcode_Gen%20Software");
                InstallBarcode.RegisterFont();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
