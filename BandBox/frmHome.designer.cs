namespace BandBox
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.M_MASTER = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_USER = new System.Windows.Forms.ToolStripMenuItem();
            this.M_INVOICE = new System.Windows.Forms.ToolStripMenuItem();
            this.M_BILL = new System.Windows.Forms.ToolStripMenuItem();
            this.M_DAILYREPORT = new System.Windows.Forms.ToolStripMenuItem();
            this.LblVersion = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_MASTER,
            this.M_INVOICE,
            this.M_BILL,
            this.M_DAILYREPORT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1360, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // M_MASTER
            // 
            this.M_MASTER.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SM_USER});
            this.M_MASTER.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.M_MASTER.Name = "M_MASTER";
            this.M_MASTER.Size = new System.Drawing.Size(66, 20);
            this.M_MASTER.Text = "MASTER";
            // 
            // SM_USER
            // 
            this.SM_USER.Name = "SM_USER";
            this.SM_USER.Size = new System.Drawing.Size(104, 22);
            this.SM_USER.Text = "USER";
            this.SM_USER.Click += new System.EventHandler(this.SM_USER_Click);
            // 
            // M_INVOICE
            // 
            this.M_INVOICE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.M_INVOICE.Name = "M_INVOICE";
            this.M_INVOICE.Size = new System.Drawing.Size(66, 20);
            this.M_INVOICE.Text = "INVOICE";
            this.M_INVOICE.Click += new System.EventHandler(this.M_INVOICE_Click);
            // 
            // M_BILL
            // 
            this.M_BILL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.M_BILL.Name = "M_BILL";
            this.M_BILL.Size = new System.Drawing.Size(43, 20);
            this.M_BILL.Text = "BILL";
            this.M_BILL.Click += new System.EventHandler(this.M_BILL_Click);
            // 
            // M_DAILYREPORT
            // 
            this.M_DAILYREPORT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.M_DAILYREPORT.Name = "M_DAILYREPORT";
            this.M_DAILYREPORT.Size = new System.Drawing.Size(98, 20);
            this.M_DAILYREPORT.Text = "DAILYREPORT";
            this.M_DAILYREPORT.Click += new System.EventHandler(this.M_DAILYREPORT_Click);
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.ForeColor = System.Drawing.Color.Red;
            this.LblVersion.Location = new System.Drawing.Point(1240, 8);
            this.LblVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(66, 13);
            this.LblVersion.TabIndex = 5;
            this.LblVersion.Text = "LblVersion";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BandBox.Properties.Resources.HOME1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 479);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAND BOX";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem M_INVOICE;
        private System.Windows.Forms.ToolStripMenuItem M_MASTER;
        private System.Windows.Forms.ToolStripMenuItem SM_USER;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.ToolStripMenuItem M_BILL;
        private System.Windows.Forms.ToolStripMenuItem M_DAILYREPORT;
    }
}