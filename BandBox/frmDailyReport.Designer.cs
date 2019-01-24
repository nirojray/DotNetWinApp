namespace BandBox
{
    partial class frmDailyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailyReport));
            this.crvDailyReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gbBill = new System.Windows.Forms.GroupBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.btnBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvDailyReport
            // 
            this.crvDailyReport.ActiveViewIndex = -1;
            this.crvDailyReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDailyReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDailyReport.Location = new System.Drawing.Point(9, 70);
            this.crvDailyReport.Name = "crvDailyReport";
            this.crvDailyReport.Size = new System.Drawing.Size(1010, 659);
            this.crvDailyReport.TabIndex = 3;
            // 
            // gbBill
            // 
            this.gbBill.Controls.Add(this.dtpInvoiceDate);
            this.gbBill.Controls.Add(this.btnBill);
            this.gbBill.Controls.Add(this.label1);
            this.gbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBill.ForeColor = System.Drawing.Color.DarkRed;
            this.gbBill.Location = new System.Drawing.Point(9, 12);
            this.gbBill.Name = "gbBill";
            this.gbBill.Size = new System.Drawing.Size(1010, 52);
            this.gbBill.TabIndex = 2;
            this.gbBill.TabStop = false;
            this.gbBill.Text = "BILL";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd-MM-yyyy";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(115, 19);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(149, 20);
            this.dtpInvoiceDate.TabIndex = 14;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(270, 19);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(55, 23);
            this.btnBill.TabIndex = 13;
            this.btnBill.Text = "SHOW";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "BILL DATE : ";
            // 
            // frmDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 741);
            this.Controls.Add(this.crvDailyReport);
            this.Controls.Add(this.gbBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDailyReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDailyReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbBill.ResumeLayout(false);
            this.gbBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDailyReport;
        private System.Windows.Forms.GroupBox gbBill;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
    }
}