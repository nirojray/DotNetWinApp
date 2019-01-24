namespace BandBox
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.gbBill = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNameM = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crvBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbBillNo = new System.Windows.Forms.ComboBox();
            this.gbBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBill
            // 
            this.gbBill.Controls.Add(this.cbBillNo);
            this.gbBill.Controls.Add(this.btnBack);
            this.gbBill.Controls.Add(this.btnCancel);
            this.gbBill.Controls.Add(this.lblNameM);
            this.gbBill.Controls.Add(this.btnBill);
            this.gbBill.Controls.Add(this.txtBillNo);
            this.gbBill.Controls.Add(this.label1);
            this.gbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBill.ForeColor = System.Drawing.Color.DarkRed;
            this.gbBill.Location = new System.Drawing.Point(12, 12);
            this.gbBill.Name = "gbBill";
            this.gbBill.Size = new System.Drawing.Size(1010, 52);
            this.gbBill.TabIndex = 0;
            this.gbBill.TabStop = false;
            this.gbBill.Text = "BILL";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(502, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "CANCEL BILL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNameM
            // 
            this.lblNameM.AutoSize = true;
            this.lblNameM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameM.Location = new System.Drawing.Point(255, 22);
            this.lblNameM.Name = "lblNameM";
            this.lblNameM.Size = new System.Drawing.Size(16, 20);
            this.lblNameM.TabIndex = 14;
            this.lblNameM.Text = "*";
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(281, 19);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(55, 23);
            this.btnBill.TabIndex = 13;
            this.btnBill.Text = "SHOW";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(104, 21);
            this.txtBillNo.MaxLength = 50;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(145, 20);
            this.txtBillNo.TabIndex = 12;
            this.txtBillNo.TextChanged += new System.EventHandler(this.txtBillNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "BILL NO : ";
            // 
            // crvBill
            // 
            this.crvBill.ActiveViewIndex = -1;
            this.crvBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBill.Location = new System.Drawing.Point(12, 70);
            this.crvBill.Name = "crvBill";
            this.crvBill.Size = new System.Drawing.Size(1010, 659);
            this.crvBill.TabIndex = 1;
            // 
            // cbBillNo
            // 
            this.cbBillNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBillNo.FormattingEnabled = true;
            this.cbBillNo.Location = new System.Drawing.Point(105, 19);
            this.cbBillNo.Name = "cbBillNo";
            this.cbBillNo.Size = new System.Drawing.Size(144, 21);
            this.cbBillNo.TabIndex = 17;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 741);
            this.Controls.Add(this.crvBill);
            this.Controls.Add(this.gbBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBill";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.gbBill.ResumeLayout(false);
            this.gbBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBill;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBill;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBill;
        private System.Windows.Forms.Label lblNameM;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbBillNo;
    }
}