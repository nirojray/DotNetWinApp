namespace BandBox
{
    partial class frmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.gbCI = new System.Windows.Forms.GroupBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbUrgent = new System.Windows.Forms.RadioButton();
            this.rbExpress = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameM = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbID = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.txtTQTY = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGTotal = new System.Windows.Forms.TextBox();
            this.lblGTotal = new System.Windows.Forms.Label();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.lblSGST = new System.Windows.Forms.Label();
            this.lblCGST = new System.Windows.Forms.Label();
            this.lblGSTIN = new System.Windows.Forms.Label();
            this.lblHSNCode = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.dgvDETAILS = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.lblQTY = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cBItemDescription = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txtItemDesctiption = new System.Windows.Forms.TextBox();
            this.txtPriceO = new System.Windows.Forms.TextBox();
            this.txtQTYO = new System.Windows.Forms.TextBox();
            this.txtTotalO = new System.Windows.Forms.TextBox();
            this.btnADDO = new System.Windows.Forms.Button();
            this.btnDeleteO = new System.Windows.Forms.Button();
            this.txtPrint = new System.Windows.Forms.Button();
            this.gbCI.SuspendLayout();
            this.gbID.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDETAILS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCI
            // 
            this.gbCI.Controls.Add(this.rbNormal);
            this.gbCI.Controls.Add(this.rbUrgent);
            this.gbCI.Controls.Add(this.rbExpress);
            this.gbCI.Controls.Add(this.txtPhone);
            this.gbCI.Controls.Add(this.label3);
            this.gbCI.Controls.Add(this.label2);
            this.gbCI.Controls.Add(this.lblNameM);
            this.gbCI.Controls.Add(this.txtBillNo);
            this.gbCI.Controls.Add(this.label1);
            this.gbCI.Controls.Add(this.dtpInvoiceDate);
            this.gbCI.Controls.Add(this.lblDate);
            this.gbCI.Controls.Add(this.txtMobile);
            this.gbCI.Controls.Add(this.lblMobile);
            this.gbCI.Controls.Add(this.txtName);
            this.gbCI.Controls.Add(this.lblName);
            this.gbCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCI.ForeColor = System.Drawing.Color.DarkRed;
            this.gbCI.Location = new System.Drawing.Point(12, 38);
            this.gbCI.Name = "gbCI";
            this.gbCI.Size = new System.Drawing.Size(588, 128);
            this.gbCI.TabIndex = 0;
            this.gbCI.TabStop = false;
            this.gbCI.Text = "CUSTOMER INFORMATION";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(185, 98);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(77, 17);
            this.rbNormal.TabIndex = 17;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "NORMAL";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbUrgent
            // 
            this.rbUrgent.AutoSize = true;
            this.rbUrgent.Location = new System.Drawing.Point(102, 98);
            this.rbUrgent.Name = "rbUrgent";
            this.rbUrgent.Size = new System.Drawing.Size(77, 17);
            this.rbUrgent.TabIndex = 16;
            this.rbUrgent.TabStop = true;
            this.rbUrgent.Text = "URGENT";
            this.rbUrgent.UseVisualStyleBackColor = true;
            this.rbUrgent.CheckedChanged += new System.EventHandler(this.rbUrgent_CheckedChanged);
            // 
            // rbExpress
            // 
            this.rbExpress.AutoSize = true;
            this.rbExpress.Location = new System.Drawing.Point(18, 98);
            this.rbExpress.Name = "rbExpress";
            this.rbExpress.Size = new System.Drawing.Size(82, 17);
            this.rbExpress.TabIndex = 15;
            this.rbExpress.TabStop = true;
            this.rbExpress.Text = "EXPRESS";
            this.rbExpress.UseVisualStyleBackColor = true;
            this.rbExpress.CheckedChanged += new System.EventHandler(this.rbExpress_CheckedChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(347, 70);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "PHONE NO : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "*";
            // 
            // lblNameM
            // 
            this.lblNameM.AutoSize = true;
            this.lblNameM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameM.Location = new System.Drawing.Point(1, 48);
            this.lblNameM.Name = "lblNameM";
            this.lblNameM.Size = new System.Drawing.Size(16, 20);
            this.lblNameM.TabIndex = 11;
            this.lblNameM.Text = "*";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Enabled = false;
            this.txtBillNo.Location = new System.Drawing.Point(93, 21);
            this.txtBillNo.MaxLength = 50;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(149, 20);
            this.txtBillNo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "BILL NO : ";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd-MM-yyyy";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(347, 20);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(149, 20);
            this.dtpInvoiceDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(270, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "DATE : ";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(93, 70);
            this.txtMobile.MaxLength = 10;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(149, 20);
            this.txtMobile.TabIndex = 6;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            this.txtMobile.Validating += new System.ComponentModel.CancelEventHandler(this.txtMobile_Validating);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(16, 72);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(65, 13);
            this.lblMobile.TabIndex = 5;
            this.lblMobile.Text = "MOBILE : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 45);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "NAME : ";
            // 
            // gbID
            // 
            this.gbID.Controls.Add(this.txtPrint);
            this.gbID.Controls.Add(this.btnDeleteO);
            this.gbID.Controls.Add(this.btnADDO);
            this.gbID.Controls.Add(this.txtTotalO);
            this.gbID.Controls.Add(this.txtQTYO);
            this.gbID.Controls.Add(this.txtPriceO);
            this.gbID.Controls.Add(this.txtItemDesctiption);
            this.gbID.Controls.Add(this.label5);
            this.gbID.Controls.Add(this.dtpDueDate);
            this.gbID.Controls.Add(this.lbDueDate);
            this.gbID.Controls.Add(this.txtTQTY);
            this.gbID.Controls.Add(this.txtSubTotal);
            this.gbID.Controls.Add(this.label4);
            this.gbID.Controls.Add(this.btnSave);
            this.gbID.Controls.Add(this.txtGTotal);
            this.gbID.Controls.Add(this.lblGTotal);
            this.gbID.Controls.Add(this.txtSGST);
            this.gbID.Controls.Add(this.txtCGST);
            this.gbID.Controls.Add(this.lblSGST);
            this.gbID.Controls.Add(this.lblCGST);
            this.gbID.Controls.Add(this.lblGSTIN);
            this.gbID.Controls.Add(this.lblHSNCode);
            this.gbID.Controls.Add(this.btnDelete);
            this.gbID.Controls.Add(this.btnADD);
            this.gbID.Controls.Add(this.gbDetails);
            this.gbID.Controls.Add(this.txtTotal);
            this.gbID.Controls.Add(this.lblTotal);
            this.gbID.Controls.Add(this.txtQTY);
            this.gbID.Controls.Add(this.lblQTY);
            this.gbID.Controls.Add(this.txtPrice);
            this.gbID.Controls.Add(this.lblPrice);
            this.gbID.Controls.Add(this.cBItemDescription);
            this.gbID.Controls.Add(this.lblItem);
            this.gbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbID.ForeColor = System.Drawing.Color.DarkRed;
            this.gbID.Location = new System.Drawing.Point(12, 166);
            this.gbID.Name = "gbID";
            this.gbID.Size = new System.Drawing.Size(890, 535);
            this.gbID.TabIndex = 1;
            this.gbID.TabStop = false;
            this.gbID.Text = "ITEM DETAILS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "*";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(106, 448);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(147, 20);
            this.dtpDueDate.TabIndex = 34;
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Location = new System.Drawing.Point(26, 451);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(82, 13);
            this.lbDueDate.TabIndex = 33;
            this.lbDueDate.Text = "DUE DATE : ";
            // 
            // txtTQTY
            // 
            this.txtTQTY.Location = new System.Drawing.Point(828, 494);
            this.txtTQTY.Name = "txtTQTY";
            this.txtTQTY.Size = new System.Drawing.Size(56, 20);
            this.txtTQTY.TabIndex = 32;
            this.txtTQTY.Text = "0";
            this.txtTQTY.Visible = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(545, 395);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(107, 20);
            this.txtSubTotal.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "TOTAL";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGTotal
            // 
            this.txtGTotal.Enabled = false;
            this.txtGTotal.Location = new System.Drawing.Point(545, 468);
            this.txtGTotal.Name = "txtGTotal";
            this.txtGTotal.Size = new System.Drawing.Size(107, 20);
            this.txtGTotal.TabIndex = 28;
            // 
            // lblGTotal
            // 
            this.lblGTotal.AutoSize = true;
            this.lblGTotal.Location = new System.Drawing.Point(446, 472);
            this.lblGTotal.Name = "lblGTotal";
            this.lblGTotal.Size = new System.Drawing.Size(95, 13);
            this.lblGTotal.TabIndex = 27;
            this.lblGTotal.Text = "GRAND TOTAL";
            // 
            // txtSGST
            // 
            this.txtSGST.Enabled = false;
            this.txtSGST.Location = new System.Drawing.Point(545, 444);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(107, 20);
            this.txtSGST.TabIndex = 26;
            // 
            // txtCGST
            // 
            this.txtCGST.Enabled = false;
            this.txtCGST.Location = new System.Drawing.Point(545, 420);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(107, 20);
            this.txtCGST.TabIndex = 25;
            // 
            // lblSGST
            // 
            this.lblSGST.AutoSize = true;
            this.lblSGST.Location = new System.Drawing.Point(475, 448);
            this.lblSGST.Name = "lblSGST";
            this.lblSGST.Size = new System.Drawing.Size(64, 13);
            this.lblSGST.TabIndex = 24;
            this.lblSGST.Text = "SGST 9 %";
            // 
            // lblCGST
            // 
            this.lblCGST.AutoSize = true;
            this.lblCGST.Location = new System.Drawing.Point(475, 424);
            this.lblCGST.Name = "lblCGST";
            this.lblCGST.Size = new System.Drawing.Size(64, 13);
            this.lblCGST.TabIndex = 23;
            this.lblCGST.Text = "CGST 9 %";
            // 
            // lblGSTIN
            // 
            this.lblGSTIN.AutoSize = true;
            this.lblGSTIN.Location = new System.Drawing.Point(26, 399);
            this.lblGSTIN.Name = "lblGSTIN";
            this.lblGSTIN.Size = new System.Drawing.Size(57, 13);
            this.lblGSTIN.TabIndex = 22;
            this.lblGSTIN.Text = "GSTIN : ";
            // 
            // lblHSNCode
            // 
            this.lblHSNCode.AutoSize = true;
            this.lblHSNCode.Location = new System.Drawing.Point(26, 423);
            this.lblHSNCode.Name = "lblHSNCode";
            this.lblHSNCode.Size = new System.Drawing.Size(108, 13);
            this.lblHSNCode.TabIndex = 21;
            this.lblHSNCode.Text = "HSN/SAC Code : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(572, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(519, 42);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(52, 23);
            this.btnADD.TabIndex = 12;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dgvDETAILS);
            this.gbDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.gbDetails.Location = new System.Drawing.Point(18, 100);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(645, 293);
            this.gbDetails.TabIndex = 20;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "DETAILS";
            // 
            // dgvDETAILS
            // 
            this.dgvDETAILS.AllowUserToAddRows = false;
            this.dgvDETAILS.AllowUserToDeleteRows = false;
            this.dgvDETAILS.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDETAILS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.itemDescription,
            this.price,
            this.qty,
            this.total});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDETAILS.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDETAILS.EnableHeadersVisualStyles = false;
            this.dgvDETAILS.GridColor = System.Drawing.Color.DarkRed;
            this.dgvDETAILS.Location = new System.Drawing.Point(10, 19);
            this.dgvDETAILS.MultiSelect = false;
            this.dgvDETAILS.Name = "dgvDETAILS";
            this.dgvDETAILS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDETAILS.Size = new System.Drawing.Size(624, 267);
            this.dgvDETAILS.TabIndex = 0;
            this.dgvDETAILS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDETAILS_CellDoubleClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemID.Width = 5;
            // 
            // itemDescription
            // 
            this.itemDescription.HeaderText = "ITEM DESCRIPTION";
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.ReadOnly = true;
            this.itemDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemDescription.Width = 300;
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // qty
            // 
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qty.Width = 75;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(430, 44);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(83, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(428, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "TOTAL";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(341, 44);
            this.txtQTY.MaxLength = 4;
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(83, 20);
            this.txtQTY.TabIndex = 9;
            this.txtQTY.Text = "0";
            this.txtQTY.TextChanged += new System.EventHandler(this.txtQTY_TextChanged);
            // 
            // lblQTY
            // 
            this.lblQTY.AutoSize = true;
            this.lblQTY.Location = new System.Drawing.Point(339, 27);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Size = new System.Drawing.Size(32, 13);
            this.lblQTY.TabIndex = 8;
            this.lblQTY.Text = "QTY";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(239, 44);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(95, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(237, 27);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "PRICE";
            // 
            // cBItemDescription
            // 
            this.cBItemDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBItemDescription.FormattingEnabled = true;
            this.cBItemDescription.Location = new System.Drawing.Point(18, 43);
            this.cBItemDescription.Name = "cBItemDescription";
            this.cBItemDescription.Size = new System.Drawing.Size(214, 21);
            this.cBItemDescription.TabIndex = 1;
            this.cBItemDescription.SelectedIndexChanged += new System.EventHandler(this.cBItemDescription_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(16, 27);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(125, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "ITEM DESCRIPTION";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Image = global::BandBox.Properties.Resources.BandBox;
            this.pbImage.Location = new System.Drawing.Point(606, 20);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(130, 144);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // txtItemDesctiption
            // 
            this.txtItemDesctiption.Location = new System.Drawing.Point(18, 71);
            this.txtItemDesctiption.Name = "txtItemDesctiption";
            this.txtItemDesctiption.Size = new System.Drawing.Size(214, 20);
            this.txtItemDesctiption.TabIndex = 35;
            // 
            // txtPriceO
            // 
            this.txtPriceO.Location = new System.Drawing.Point(239, 71);
            this.txtPriceO.Name = "txtPriceO";
            this.txtPriceO.Size = new System.Drawing.Size(94, 20);
            this.txtPriceO.TabIndex = 36;
            this.txtPriceO.Text = "0";
            this.txtPriceO.TextChanged += new System.EventHandler(this.txtPriceO_TextChanged);
            // 
            // txtQTYO
            // 
            this.txtQTYO.Location = new System.Drawing.Point(341, 71);
            this.txtQTYO.Name = "txtQTYO";
            this.txtQTYO.Size = new System.Drawing.Size(83, 20);
            this.txtQTYO.TabIndex = 37;
            this.txtQTYO.Text = "0";
            this.txtQTYO.TextChanged += new System.EventHandler(this.txtQTYO_TextChanged);
            // 
            // txtTotalO
            // 
            this.txtTotalO.Enabled = false;
            this.txtTotalO.Location = new System.Drawing.Point(431, 71);
            this.txtTotalO.Name = "txtTotalO";
            this.txtTotalO.Size = new System.Drawing.Size(82, 20);
            this.txtTotalO.TabIndex = 38;
            this.txtTotalO.Text = "0";
            // 
            // btnADDO
            // 
            this.btnADDO.Location = new System.Drawing.Point(520, 70);
            this.btnADDO.Name = "btnADDO";
            this.btnADDO.Size = new System.Drawing.Size(51, 23);
            this.btnADDO.TabIndex = 39;
            this.btnADDO.Text = "Add";
            this.btnADDO.UseVisualStyleBackColor = true;
            this.btnADDO.Click += new System.EventHandler(this.btnADDO_Click);
            // 
            // btnDeleteO
            // 
            this.btnDeleteO.Location = new System.Drawing.Point(572, 70);
            this.btnDeleteO.Name = "btnDeleteO";
            this.btnDeleteO.Size = new System.Drawing.Size(52, 23);
            this.btnDeleteO.TabIndex = 40;
            this.btnDeleteO.Text = "Delete";
            this.btnDeleteO.UseVisualStyleBackColor = true;
            this.btnDeleteO.Click += new System.EventHandler(this.btnDeleteO_Click);
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(378, 502);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(75, 23);
            this.txtPrint.TabIndex = 41;
            this.txtPrint.Text = "Print";
            this.txtPrint.UseVisualStyleBackColor = true;
            this.txtPrint.Click += new System.EventHandler(this.txtPrint_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 741);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.gbID);
            this.Controls.Add(this.gbCI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoice";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVOICE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.gbCI.ResumeLayout(false);
            this.gbCI.PerformLayout();
            this.gbID.ResumeLayout(false);
            this.gbID.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDETAILS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCI;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cBItemDescription;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.Label lblQTY;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.DataGridView dgvDETAILS;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtGTotal;
        private System.Windows.Forms.Label lblGTotal;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.Label lblSGST;
        private System.Windows.Forms.Label lblCGST;
        private System.Windows.Forms.Label lblGSTIN;
        private System.Windows.Forms.Label lblHSNCode;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameM;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTQTY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lbDueDate;
        private System.Windows.Forms.RadioButton rbUrgent;
        private System.Windows.Forms.RadioButton rbExpress;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Button btnDeleteO;
        private System.Windows.Forms.Button btnADDO;
        private System.Windows.Forms.TextBox txtTotalO;
        private System.Windows.Forms.TextBox txtQTYO;
        private System.Windows.Forms.TextBox txtPriceO;
        private System.Windows.Forms.TextBox txtItemDesctiption;
        private System.Windows.Forms.Button txtPrint;
    }
}