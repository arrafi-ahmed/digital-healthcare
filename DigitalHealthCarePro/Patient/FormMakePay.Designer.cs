namespace DigitalHealthCarePro.Patient
{
    partial class FormMakePay
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
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdmnId = new MetroFramework.Controls.MetroLabel();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.pnlTopBar = new MetroFramework.Controls.MetroPanel();
            this.pnlPay = new MetroFramework.Controls.MetroPanel();
            this.cmbRole = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnPay = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtACNo = new MetroFramework.Controls.MetroTextBox();
            this.lblAmount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.cmbMethod = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtBookId = new MetroFramework.Controls.MetroTextBox();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtFee = new MetroFramework.Controls.MetroTextBox();
            this.pnlRcntPay = new MetroFramework.Controls.MetroPanel();
            this.pnlSearch = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.lblRcntPay = new MetroFramework.Controls.MetroLabel();
            this.tabPay = new MetroFramework.Controls.MetroTabControl();
            this.tabPayDoc = new System.Windows.Forms.TabPage();
            this.dgvPayDoc = new MetroFramework.Controls.MetroGrid();
            this.PaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPayHp = new System.Windows.Forms.TabPage();
            this.dgvPayHp = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopBar.SuspendLayout();
            this.pnlPay.SuspendLayout();
            this.pnlRcntPay.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tabPay.SuspendLayout();
            this.tabPayDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDoc)).BeginInit();
            this.tabPayHp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayHp)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel10
            // 
            this.metroLabel10.Location = new System.Drawing.Point(6, 1);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(55, 19);
            this.metroLabel10.TabIndex = 177;
            this.metroLabel10.Text = "User ID:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(234, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 175;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(23, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 19);
            this.labelTitle.TabIndex = 174;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabelAdmnId
            // 
            this.metroLabelAdmnId.AutoSize = true;
            this.metroLabelAdmnId.Location = new System.Drawing.Point(23, 79);
            this.metroLabelAdmnId.Name = "metroLabelAdmnId";
            this.metroLabelAdmnId.Size = new System.Drawing.Size(0, 0);
            this.metroLabelAdmnId.TabIndex = 173;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(155, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 176;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(67, 2);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 19);
            this.lblId.TabIndex = 178;
            this.lblId.Text = "metroLabel1";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblId);
            this.pnlTopBar.Controls.Add(this.btnHome);
            this.pnlTopBar.Controls.Add(this.btnLogout);
            this.pnlTopBar.Controls.Add(this.metroLabel10);
            this.pnlTopBar.HorizontalScrollbarBarColor = true;
            this.pnlTopBar.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTopBar.HorizontalScrollbarSize = 10;
            this.pnlTopBar.Location = new System.Drawing.Point(717, 55);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(309, 24);
            this.pnlTopBar.TabIndex = 191;
            this.pnlTopBar.VerticalScrollbarBarColor = true;
            this.pnlTopBar.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTopBar.VerticalScrollbarSize = 10;
            // 
            // pnlPay
            // 
            this.pnlPay.Controls.Add(this.cmbRole);
            this.pnlPay.Controls.Add(this.metroLabel4);
            this.pnlPay.Controls.Add(this.btnPay);
            this.pnlPay.Controls.Add(this.metroLabel7);
            this.pnlPay.Controls.Add(this.txtACNo);
            this.pnlPay.Controls.Add(this.lblAmount);
            this.pnlPay.Controls.Add(this.metroLabel3);
            this.pnlPay.Controls.Add(this.txtId);
            this.pnlPay.Controls.Add(this.cmbMethod);
            this.pnlPay.Controls.Add(this.metroLabel6);
            this.pnlPay.Controls.Add(this.metroLabel2);
            this.pnlPay.Controls.Add(this.metroLabel5);
            this.pnlPay.Controls.Add(this.txtBookId);
            this.pnlPay.Controls.Add(this.txtAmount);
            this.pnlPay.Controls.Add(this.txtFee);
            this.pnlPay.HorizontalScrollbarBarColor = true;
            this.pnlPay.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPay.HorizontalScrollbarSize = 10;
            this.pnlPay.Location = new System.Drawing.Point(23, 107);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(265, 324);
            this.pnlPay.TabIndex = 192;
            this.pnlPay.VerticalScrollbarBarColor = true;
            this.pnlPay.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPay.VerticalScrollbarSize = 10;
            // 
            // cmbRole
            // 
            this.cmbRole.Enabled = false;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.ItemHeight = 23;
            this.cmbRole.Items.AddRange(new object[] {
            "Doctor",
            "Hospital"});
            this.cmbRole.Location = new System.Drawing.Point(126, 80);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(139, 29);
            this.cmbRole.TabIndex = 188;
            this.cmbRole.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(47, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 189;
            this.metroLabel4.Text = "Payee Role";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(191, 301);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(74, 23);
            this.btnPay.TabIndex = 179;
            this.btnPay.Text = "Pay";
            this.btnPay.UseSelectable = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(61, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 182;
            this.metroLabel7.Text = "Payee ID";
            // 
            // txtACNo
            // 
            // 
            // 
            // 
            this.txtACNo.CustomButton.Image = null;
            this.txtACNo.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtACNo.CustomButton.Name = "";
            this.txtACNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtACNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtACNo.CustomButton.TabIndex = 1;
            this.txtACNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtACNo.CustomButton.UseSelectable = true;
            this.txtACNo.CustomButton.Visible = false;
            this.txtACNo.Lines = new string[0];
            this.txtACNo.Location = new System.Drawing.Point(126, 263);
            this.txtACNo.MaxLength = 32767;
            this.txtACNo.Name = "txtACNo";
            this.txtACNo.PasswordChar = '\0';
            this.txtACNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtACNo.SelectedText = "";
            this.txtACNo.SelectionLength = 0;
            this.txtACNo.SelectionStart = 0;
            this.txtACNo.ShortcutsEnabled = true;
            this.txtACNo.Size = new System.Drawing.Size(139, 23);
            this.txtACNo.TabIndex = 187;
            this.txtACNo.UseSelectable = true;
            this.txtACNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtACNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(22, 172);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(98, 19);
            this.lblAmount.TabIndex = 182;
            this.lblAmount.Text = "Paying Amount";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(66, 263);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 186;
            this.metroLabel3.Text = "A/C No";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(126, 0);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(139, 23);
            this.txtId.TabIndex = 183;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.ItemHeight = 23;
            this.cmbMethod.Items.AddRange(new object[] {
            "bKash",
            "Rocket",
            "UPay"});
            this.cmbMethod.Location = new System.Drawing.Point(126, 215);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(139, 29);
            this.cmbMethod.TabIndex = 185;
            this.cmbMethod.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(90, 130);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(30, 19);
            this.metroLabel6.TabIndex = 182;
            this.metroLabel6.Text = "Fee";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(65, 215);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 184;
            this.metroLabel2.Text = "Method";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(47, 38);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 19);
            this.metroLabel5.TabIndex = 182;
            this.metroLabel5.Text = "Booking ID";
            // 
            // txtBookId
            // 
            // 
            // 
            // 
            this.txtBookId.CustomButton.Image = null;
            this.txtBookId.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtBookId.CustomButton.Name = "";
            this.txtBookId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBookId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookId.CustomButton.TabIndex = 1;
            this.txtBookId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookId.CustomButton.UseSelectable = true;
            this.txtBookId.CustomButton.Visible = false;
            this.txtBookId.Enabled = false;
            this.txtBookId.Lines = new string[0];
            this.txtBookId.Location = new System.Drawing.Point(126, 38);
            this.txtBookId.MaxLength = 32767;
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.PasswordChar = '\0';
            this.txtBookId.ReadOnly = true;
            this.txtBookId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookId.SelectedText = "";
            this.txtBookId.SelectionLength = 0;
            this.txtBookId.SelectionStart = 0;
            this.txtBookId.ShortcutsEnabled = true;
            this.txtBookId.Size = new System.Drawing.Size(139, 23);
            this.txtBookId.TabIndex = 183;
            this.txtBookId.UseSelectable = true;
            this.txtBookId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(126, 172);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(139, 23);
            this.txtAmount.TabIndex = 183;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFee
            // 
            // 
            // 
            // 
            this.txtFee.CustomButton.Image = null;
            this.txtFee.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtFee.CustomButton.Name = "";
            this.txtFee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFee.CustomButton.TabIndex = 1;
            this.txtFee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFee.CustomButton.UseSelectable = true;
            this.txtFee.CustomButton.Visible = false;
            this.txtFee.Enabled = false;
            this.txtFee.Lines = new string[0];
            this.txtFee.Location = new System.Drawing.Point(126, 130);
            this.txtFee.MaxLength = 32767;
            this.txtFee.Name = "txtFee";
            this.txtFee.PasswordChar = '\0';
            this.txtFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFee.SelectedText = "";
            this.txtFee.SelectionLength = 0;
            this.txtFee.SelectionStart = 0;
            this.txtFee.ShortcutsEnabled = true;
            this.txtFee.Size = new System.Drawing.Size(139, 23);
            this.txtFee.TabIndex = 183;
            this.txtFee.UseSelectable = true;
            this.txtFee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnlRcntPay
            // 
            this.pnlRcntPay.Controls.Add(this.pnlSearch);
            this.pnlRcntPay.Controls.Add(this.lblRcntPay);
            this.pnlRcntPay.Controls.Add(this.tabPay);
            this.pnlRcntPay.HorizontalScrollbarBarColor = true;
            this.pnlRcntPay.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRcntPay.HorizontalScrollbarSize = 10;
            this.pnlRcntPay.Location = new System.Drawing.Point(307, 107);
            this.pnlRcntPay.Name = "pnlRcntPay";
            this.pnlRcntPay.Size = new System.Drawing.Size(719, 328);
            this.pnlRcntPay.TabIndex = 193;
            this.pnlRcntPay.VerticalScrollbarBarColor = true;
            this.pnlRcntPay.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRcntPay.VerticalScrollbarSize = 10;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.HorizontalScrollbarBarColor = true;
            this.pnlSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSearch.HorizontalScrollbarSize = 10;
            this.pnlSearch.Location = new System.Drawing.Point(468, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(251, 23);
            this.pnlSearch.TabIndex = 195;
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
            this.txtSearch.PromptText = "Search by Payment ID";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(161, 23);
            this.txtSearch.TabIndex = 184;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Payment ID";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(174, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 183;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblRcntPay
            // 
            this.lblRcntPay.AutoSize = true;
            this.lblRcntPay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRcntPay.Location = new System.Drawing.Point(4, -3);
            this.lblRcntPay.Name = "lblRcntPay";
            this.lblRcntPay.Size = new System.Drawing.Size(144, 25);
            this.lblRcntPay.TabIndex = 186;
            this.lblRcntPay.Text = "Recent Payments:";
            // 
            // tabPay
            // 
            this.tabPay.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPay.Controls.Add(this.tabPayDoc);
            this.tabPay.Controls.Add(this.tabPayHp);
            this.tabPay.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabPay.Location = new System.Drawing.Point(4, 26);
            this.tabPay.Multiline = true;
            this.tabPay.Name = "tabPay";
            this.tabPay.SelectedIndex = 1;
            this.tabPay.Size = new System.Drawing.Size(712, 299);
            this.tabPay.TabIndex = 185;
            this.tabPay.UseSelectable = true;
            // 
            // tabPayDoc
            // 
            this.tabPayDoc.CausesValidation = false;
            this.tabPayDoc.Controls.Add(this.dgvPayDoc);
            this.tabPayDoc.Location = new System.Drawing.Point(4, 41);
            this.tabPayDoc.Name = "tabPayDoc";
            this.tabPayDoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPayDoc.Size = new System.Drawing.Size(704, 254);
            this.tabPayDoc.TabIndex = 0;
            this.tabPayDoc.Text = "Pay Doctor";
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
            this.PaymentId,
            this.docId,
            this.BookDocId,
            this.PaidAmount,
            this.Method,
            this.paymentStatus,
            this.ACNo,
            this.PID});
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
            this.dgvPayDoc.Location = new System.Drawing.Point(2, -1);
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
            this.dgvPayDoc.Size = new System.Drawing.Size(700, 257);
            this.dgvPayDoc.TabIndex = 171;
            this.dgvPayDoc.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // PaymentId
            // 
            this.PaymentId.DataPropertyName = "PayId";
            this.PaymentId.HeaderText = "Payment ID";
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.ReadOnly = true;
            // 
            // docId
            // 
            this.docId.DataPropertyName = "DocId";
            this.docId.HeaderText = "Doctor ID";
            this.docId.Name = "docId";
            this.docId.ReadOnly = true;
            // 
            // BookDocId
            // 
            this.BookDocId.DataPropertyName = "BID";
            this.BookDocId.HeaderText = "Booking ID";
            this.BookDocId.Name = "BookDocId";
            this.BookDocId.ReadOnly = true;
            // 
            // PaidAmount
            // 
            this.PaidAmount.DataPropertyName = "Amount";
            this.PaidAmount.HeaderText = "Paid Amount";
            this.PaidAmount.Name = "PaidAmount";
            this.PaidAmount.ReadOnly = true;
            this.PaidAmount.Width = 50;
            // 
            // Method
            // 
            this.Method.DataPropertyName = "Method";
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            // 
            // paymentStatus
            // 
            this.paymentStatus.DataPropertyName = "Paid";
            this.paymentStatus.HeaderText = "Payment Status";
            this.paymentStatus.Name = "paymentStatus";
            this.paymentStatus.ReadOnly = true;
            // 
            // ACNo
            // 
            this.ACNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ACNo.DataPropertyName = "ACNo";
            this.ACNo.HeaderText = "A/C No";
            this.ACNo.Name = "ACNo";
            this.ACNo.ReadOnly = true;
            // 
            // PID
            // 
            this.PID.DataPropertyName = "PatId";
            this.PID.HeaderText = "PatId";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Visible = false;
            // 
            // tabPayHp
            // 
            this.tabPayHp.CausesValidation = false;
            this.tabPayHp.Controls.Add(this.dgvPayHp);
            this.tabPayHp.Location = new System.Drawing.Point(4, 41);
            this.tabPayHp.Name = "tabPayHp";
            this.tabPayHp.Size = new System.Drawing.Size(704, 254);
            this.tabPayHp.TabIndex = 1;
            this.tabPayHp.Text = "Pay Hospital";
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
            this.dataGridViewTextBoxColumn1,
            this.HpId,
            this.BIH,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10});
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
            this.dgvPayHp.Location = new System.Drawing.Point(2, -1);
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
            this.dgvPayHp.Size = new System.Drawing.Size(700, 257);
            this.dgvPayHp.TabIndex = 172;
            this.dgvPayHp.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PayId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Payment ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // HpId
            // 
            this.HpId.DataPropertyName = "HpId";
            this.HpId.HeaderText = "Hospital ID";
            this.HpId.Name = "HpId";
            this.HpId.ReadOnly = true;
            // 
            // BIH
            // 
            this.BIH.DataPropertyName = "BIH";
            this.BIH.HeaderText = "Booking ID";
            this.BIH.Name = "BIH";
            this.BIH.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Paid Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Method";
            this.dataGridViewTextBoxColumn5.HeaderText = "Method";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Paid";
            this.dataGridViewTextBoxColumn6.HeaderText = "Payment Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ACNo";
            this.dataGridViewTextBoxColumn7.HeaderText = "A/C No";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PatId";
            this.dataGridViewTextBoxColumn10.HeaderText = "PatId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // FormMakePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 458);
            this.Controls.Add(this.pnlRcntPay);
            this.Controls.Add(this.pnlPay);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabelAdmnId);
            this.MaximizeBox = false;
            this.Name = "FormMakePay";
            this.Resizable = false;
            this.Text = "Make Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMakePay_FormClosed);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            this.pnlRcntPay.ResumeLayout(false);
            this.pnlRcntPay.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.tabPay.ResumeLayout(false);
            this.tabPayDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDoc)).EndInit();
            this.tabPayHp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayHp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabelAdmnId;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroPanel pnlTopBar;
        private MetroFramework.Controls.MetroPanel pnlPay;
        private MetroFramework.Controls.MetroComboBox cmbRole;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnPay;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtACNo;
        private MetroFramework.Controls.MetroLabel lblAmount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroComboBox cmbMethod;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtBookId;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroTextBox txtFee;
        private MetroFramework.Controls.MetroPanel pnlRcntPay;
        private MetroFramework.Controls.MetroTabControl tabPay;
        private System.Windows.Forms.TabPage tabPayDoc;
        private MetroFramework.Controls.MetroGrid dgvPayDoc;
        private System.Windows.Forms.TabPage tabPayHp;
        private MetroFramework.Controls.MetroGrid dgvPayHp;
        private MetroFramework.Controls.MetroPanel pnlSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroLabel lblRcntPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn docId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}