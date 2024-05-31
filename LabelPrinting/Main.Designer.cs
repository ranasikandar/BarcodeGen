namespace LabelPrinting
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
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtLabelNum = new System.Windows.Forms.TextBox();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.checkBoxDirectPrint = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxIncreaseSrNum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(37, 50);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(100, 20);
            this.txtPrefix.TabIndex = 1;
            this.txtPrefix.Text = "No. ";
            // 
            // txtLabelNum
            // 
            this.txtLabelNum.Location = new System.Drawing.Point(143, 49);
            this.txtLabelNum.Name = "txtLabelNum";
            this.txtLabelNum.Size = new System.Drawing.Size(63, 20);
            this.txtLabelNum.TabIndex = 3;
            this.txtLabelNum.Text = "434";
            this.txtLabelNum.TextChanged += new System.EventHandler(this.txtLabelNum_TextChanged);
            this.txtLabelNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLabelNum_KeyPress);
            // 
            // txtQt
            // 
            this.txtQt.Location = new System.Drawing.Point(319, 49);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(42, 20);
            this.txtQt.TabIndex = 6;
            this.txtQt.Text = "270";
            this.txtQt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLabelNum_KeyPress);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(475, 48);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // checkBoxDirectPrint
            // 
            this.checkBoxDirectPrint.AutoSize = true;
            this.checkBoxDirectPrint.Location = new System.Drawing.Point(383, 52);
            this.checkBoxDirectPrint.Name = "checkBoxDirectPrint";
            this.checkBoxDirectPrint.Size = new System.Drawing.Size(78, 17);
            this.checkBoxDirectPrint.TabIndex = 7;
            this.checkBoxDirectPrint.Text = "Direct Print";
            this.checkBoxDirectPrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sr Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qt";
            // 
            // checkBoxIncreaseSrNum
            // 
            this.checkBoxIncreaseSrNum.AutoSize = true;
            this.checkBoxIncreaseSrNum.Checked = true;
            this.checkBoxIncreaseSrNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncreaseSrNum.Location = new System.Drawing.Point(212, 52);
            this.checkBoxIncreaseSrNum.Name = "checkBoxIncreaseSrNum";
            this.checkBoxIncreaseSrNum.Size = new System.Drawing.Size(102, 17);
            this.checkBoxIncreaseSrNum.TabIndex = 4;
            this.checkBoxIncreaseSrNum.Text = "Increase SrNum";
            this.checkBoxIncreaseSrNum.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 113);
            this.Controls.Add(this.checkBoxIncreaseSrNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDirectPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtQt);
            this.Controls.Add(this.txtLabelNum);
            this.Controls.Add(this.txtPrefix);
            this.Name = "Main";
            this.Text = "Label Printing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtLabelNum;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox checkBoxDirectPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxIncreaseSrNum;
    }
}

