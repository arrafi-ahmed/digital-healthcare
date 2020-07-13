namespace DigitalHealthCarePro.Admin
{
    partial class FormChkTrans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.tabPay = new MetroFramework.Controls.MetroTabControl();
            this.tabPayDoc = new System.Windows.Forms.TabPage();
            this.dgvPayDoc = new MetroFramework.Controls.MetroGrid();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPayHp = new System.Windows.Forms.TabPage();
            this.dgvPayHp = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.tabPay.SuspendLayout();
            this.tabPayDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDoc)).BeginInit();
            this.tabPayHp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayHp)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(23, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 19);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(636, 56);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "User ID:";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(702, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 19);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "metroLabel1";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(873, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 55;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(793, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 56;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // tabPay
            // 
            this.tabPay.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPay.Controls.Add(this.tabPayDoc);
            this.tabPay.Controls.Add(this.tabPayHp);
            this.tabPay.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabPay.Location = new System.Drawing.Point(23, 99);
            this.tabPay.Multiline = true;
            this.tabPay.Name = "tabPay";
            this.tabPay.SelectedIndex = 0;
            this.tabPay.Size = new System.Drawing.Size(927, 478);
            this.tabPay.TabIndex = 186;
            this.tabPay.UseSelectable = true;
            this.tabPay.SelectedIndexChanged += new System.EventHandler(this.TabPay_SelectedIndexChanged);
            // 
            // tabPayDoc
            // 
            this.tabPayDoc.CausesValidation = false;
            this.tabPayDoc.Controls.Add(this.dgvPayDoc);
            this.tabPayDoc.Location = new System.Drawing.Point(4, 41);
            this.tabPayDoc.Name = "tabPayDoc";
            this.tabPayDoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPayDoc.Size = new System.Drawing.Size(919, 433);
            this.tabPayDoc.TabIndex = 0;
            this.tabPayDoc.Text = "Doctor\'s Transaction";
            // 
            // dgvPayDoc
            // 
            this.dgvPayDoc.AllowUserToAddRows = false;
            this.dgvPayDoc.AllowUserToDeleteRows = false;
            this.dgvPayDoc.AllowUserToResizeRows = false;
            this.dgvPayDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayDoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayDoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.PaymentId,
            this.docId,
            this.BookDocId,
            this.PaidAmount,
            this.Method,
            this.paymentStatus,
            this.ACNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayDoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayDoc.EnableHeadersVisualStyles = false;
            this.dgvPayDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPayDoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayDoc.Location = new System.Drawing.Point(-4, -1);
            this.dgvPayDoc.Name = "dgvPayDoc";
            this.dgvPayDoc.ReadOnly = true;
            this.dgvPayDoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayDoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayDoc.Size = new System.Drawing.Size(927, 438);
            this.dgvPayDoc.TabIndex = 171;
            this.dgvPayDoc.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // PID
            // 
            this.PID.DataPropertyName = "PatId";
            this.PID.HeaderText = "Patient ID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 120;
            // 
            // PaymentId
            // 
            this.PaymentId.DataPropertyName = "PayId";
            this.PaymentId.HeaderText = "Payment ID";
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.ReadOnly = true;
            this.PaymentId.Width = 120;
            // 
            // docId
            // 
            this.docId.DataPropertyName = "DocId";
            this.docId.HeaderText = "Doctor ID";
            this.docId.Name = "docId";
            this.docId.ReadOnly = true;
            this.docId.Width = 120;
            // 
            // BookDocId
            // 
            this.BookDocId.DataPropertyName = "BID";
            this.BookDocId.HeaderText = "Booking ID";
            this.BookDocId.Name = "BookDocId";
            this.BookDocId.ReadOnly = true;
            this.BookDocId.Width = 120;
            // 
            // PaidAmount
            // 
            this.PaidAmount.DataPropertyName = "Amount";
            this.PaidAmount.HeaderText = "Paid Amount";
            this.PaidAmount.Name = "PaidAmount";
            this.PaidAmount.ReadOnly = true;
            this.PaidAmount.Width = 60;
            // 
            // Method
            // 
            this.Method.DataPropertyName = "Method";
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            this.Method.Width = 120;
            // 
            // paymentStatus
            // 
            this.paymentStatus.DataPropertyName = "Paid";
            this.paymentStatus.HeaderText = "Payment Status";
            this.paymentStatus.Name = "paymentStatus";
            this.paymentStatus.ReadOnly = true;
            this.paymentStatus.Width = 60;
            // 
            // ACNo
            // 
            this.ACNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ACNo.DataPropertyName = "ACNo";
            this.ACNo.HeaderText = "A/C No";
            this.ACNo.Name = "ACNo";
            this.ACNo.ReadOnly = true;
            // 
            // tabPayHp
            // 
            this.tabPayHp.CausesValidation = false;
            this.tabPayHp.Controls.Add(this.dgvPayHp);
            this.tabPayHp.Location = new System.Drawing.Point(4, 41);
            this.tabPayHp.Name = "tabPayHp";
            this.tabPayHp.Size = new System.Drawing.Size(919, 433);
            this.tabPayHp.TabIndex = 1;
            this.tabPayHp.Text = "Hospital\'s Transaction";
            // 
            // dgvPayHp
            // 
            this.dgvPayHp.AllowUserToAddRows = false;
            this.dgvPayHp.AllowUserToDeleteRows = false;
            this.dgvPayHp.AllowUserToResizeRows = false;
            this.dgvPayHp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayHp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayHp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayHp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayHp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayHp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayHp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn1,
            this.HpId,
            this.BIH,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayHp.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayHp.EnableHeadersVisualStyles = false;
            this.dgvPayHp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPayHp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayHp.Location = new System.Drawing.Point(-4, -1);
            this.dgvPayHp.Name = "dgvPayHp";
            this.dgvPayHp.ReadOnly = true;
            this.dgvPayHp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayHp.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPayHp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayHp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayHp.Size = new System.Drawing.Size(927, 438);
            this.dgvPayHp.TabIndex = 172;
            this.dgvPayHp.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PatId";
            this.dataGridViewTextBoxColumn10.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PayId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Payment ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // HpId
            // 
            this.HpId.DataPropertyName = "HpId";
            this.HpId.HeaderText = "Hospital ID";
            this.HpId.Name = "HpId";
            this.HpId.ReadOnly = true;
            this.HpId.Width = 120;
            // 
            // BIH
            // 
            this.BIH.DataPropertyName = "BIH";
            this.BIH.HeaderText = "Booking ID";
            this.BIH.Name = "BIH";
            this.BIH.ReadOnly = true;
            this.BIH.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Paid Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Method";
            this.dataGridViewTextBoxColumn5.HeaderText = "Method";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Paid";
            this.dataGridViewTextBoxColumn6.HeaderText = "Payment Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ACNo";
            this.dataGridViewTextBoxColumn7.HeaderText = "A/C No";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.HorizontalScrollbarBarColor = true;
            this.pnlSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSearch.HorizontalScrollbarSize = 10;
            this.pnlSearch.Location = new System.Drawing.Point(697, 99);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(251, 23);
            this.pnlSearch.TabIndex = 196;
            this.pnlSearch.VerticalScrollbarBarColor = true;
            this.pnlSearch.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSearch.VerticalScrollbarSize = 10;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(7, 0);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by Patient ID";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(161, 23);
            this.txtSearch.TabIndex = 184;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Patient ID";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(174, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 185;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FormChkTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 600);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.tabPay);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblId);
            this.MaximizeBox = false;
            this.Name = "FormChkTrans";
            this.Resizable = false;
            this.Text = "Check Transactions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChkTrans_FormClosed);
            this.tabPay.ResumeLayout(false);
            this.tabPayDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDoc)).EndInit();
            this.tabPayHp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayHp)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblId;
       
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroTabControl tabPay;
        private System.Windows.Forms.TabPage tabPayDoc;
        private MetroFramework.Controls.MetroGrid dgvPayDoc;
        private System.Windows.Forms.TabPage tabPayHp;
        private MetroFramework.Controls.MetroGrid dgvPayHp;
        private MetroFramework.Controls.MetroPanel pnlSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn docId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}