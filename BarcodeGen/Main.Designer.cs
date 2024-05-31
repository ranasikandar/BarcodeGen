namespace BarcodeGen
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.txtBarcode = new MetroFramework.Controls.MetroTextBox();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.tileExample = new MetroFramework.Controls.MetroTile();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.ToggleIsDirectPrint = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tileExample.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleExtender1
            // 
            this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtBarcode
            // 
            // 
            // 
            // 
            this.txtBarcode.CustomButton.Image = null;
            this.txtBarcode.CustomButton.Location = new System.Drawing.Point(130, 2);
            this.txtBarcode.CustomButton.Name = "";
            this.txtBarcode.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarcode.CustomButton.TabIndex = 1;
            this.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarcode.CustomButton.UseSelectable = true;
            this.txtBarcode.CustomButton.Visible = false;
            this.txtBarcode.IconRight = true;
            this.txtBarcode.Lines = new string[0];
            this.txtBarcode.Location = new System.Drawing.Point(106, 95);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBarcode.MaxLength = 10;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.Size = new System.Drawing.Size(152, 24);
            this.txtBarcode.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.txtBarcode, "Enter Barcode here");
            this.txtBarcode.UseSelectable = true;
            this.txtBarcode.UseStyleColors = true;
            this.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Highlight = true;
            this.btnPrint.Location = new System.Drawing.Point(204, 182);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(149, 39);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.metroToolTip1.SetToolTip(this.btnPrint, "Click to Print");
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tileExample
            // 
            this.tileExample.ActiveControl = null;
            this.tileExample.Controls.Add(this.lblPrice);
            this.tileExample.Enabled = false;
            this.tileExample.Location = new System.Drawing.Point(24, 134);
            this.tileExample.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tileExample.Name = "tileExample";
            this.tileExample.Size = new System.Drawing.Size(101, 87);
            this.tileExample.TabIndex = 6;
            this.tileExample.Text = "Example";
            this.tileExample.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileExample.TileImage = global::BarcodeGen.Properties.Resources.Barcode;
            this.tileExample.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileExample.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroToolTip1.SetToolTip(this.tileExample, "Example");
            this.tileExample.UseSelectable = true;
            this.tileExample.UseTileImage = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(27, 9);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 19);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Prince";
            this.metroToolTip1.SetToolTip(this.lblPrice, "Example");
            this.lblPrice.UseStyleColors = true;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(50, 2);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.IconRight = true;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(24, 95);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(72, 24);
            this.txtPrice.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.txtPrice, "Enter Price will be printer on Sticker (optional)");
            this.txtPrice.UseSelectable = true;
            this.txtPrice.UseStyleColors = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(66, 2);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.IconRight = true;
            this.txtQty.Lines = new string[] {
        "60"};
            this.txtQty.Location = new System.Drawing.Point(266, 95);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(88, 24);
            this.txtQty.TabIndex = 5;
            this.txtQty.Text = "60";
            this.metroToolTip1.SetToolTip(this.txtQty, "Enter Number of Stickers to Print");
            this.txtQty.UseSelectable = true;
            this.txtQty.UseStyleColors = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // ToggleIsDirectPrint
            // 
            this.ToggleIsDirectPrint.AutoSize = true;
            this.ToggleIsDirectPrint.Location = new System.Drawing.Point(273, 159);
            this.ToggleIsDirectPrint.Name = "ToggleIsDirectPrint";
            this.ToggleIsDirectPrint.Size = new System.Drawing.Size(80, 17);
            this.ToggleIsDirectPrint.TabIndex = 7;
            this.ToggleIsDirectPrint.Text = "Off";
            this.metroToolTip1.SetToolTip(this.ToggleIsDirectPrint, "Direct Print");
            this.ToggleIsDirectPrint.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(181, 237);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(173, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "by RanaSikandar@mail.com";
            this.metroToolTip1.SetToolTip(this.metroLabel3, "Click for Appreciate Developers Work");
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(106, 74);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(68, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Barcode *";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 74);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Prince";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(266, 74);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Stickers Qty *";
            this.metroLabel2.UseStyleColors = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackImage = global::BarcodeGen.Properties.Resources.Barcode;
            this.BackImagePadding = new System.Windows.Forms.Padding(170, 20, 0, 0);
            this.BackMaxSize = 30;
            this.ClientSize = new System.Drawing.Size(368, 266);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ToggleIsDirectPrint);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.tileExample);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtBarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 266);
            this.MinimumSize = new System.Drawing.Size(368, 266);
            this.Name = "Main";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Barcode Gen";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tileExample.ResumeLayout(false);
            this.tileExample.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroTextBox txtBarcode;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile tileExample;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroToggle ToggleIsDirectPrint;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

