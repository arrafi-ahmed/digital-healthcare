namespace DigitalHealthCarePro.Hospital
{
    partial class FormMngTest
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
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.tabMngTest = new MetroFramework.Controls.MetroTabControl();
            this.tabAllTest = new System.Windows.Forms.TabPage();
            this.dgvAllTest = new MetroFramework.Controls.MetroGrid();
            this.TestIdD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOwnTest = new System.Windows.Forms.TabPage();
            this.dgvOwnTest = new MetroFramework.Controls.MetroGrid();
            this.TestIdO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestNameO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNewTest = new MetroFramework.Controls.MetroTextBox();
            this.btnAddNew = new MetroFramework.Controls.MetroButton();
            this.tTipSlot = new MetroFramework.Components.MetroToolTip();
            this.txtSlotN = new MetroFramework.Controls.MetroTextBox();
            this.txtSlotA = new MetroFramework.Controls.MetroTextBox();
            this.txtSlotM = new MetroFramework.Controls.MetroTextBox();
            this.slotNight = new MetroFramework.Controls.MetroTextBox();
            this.slotAfternoon = new MetroFramework.Controls.MetroTextBox();
            this.slotMorning = new MetroFramework.Controls.MetroTextBox();
            this.pnlAddTest = new MetroFramework.Controls.MetroPanel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.txtChargeUpdate = new MetroFramework.Controls.MetroTextBox();
            this.txtOwnTestIdO = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlUpdtOwnTest = new MetroFramework.Controls.MetroPanel();
            this.btnAddOwn = new MetroFramework.Controls.MetroButton();
            this.txtOwnTestId = new MetroFramework.Controls.MetroTextBox();
            this.txtCharge = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pnlAddOwnTest = new MetroFramework.Controls.MetroPanel();
            this.tabMngTest.SuspendLayout();
            this.tabAllTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTest)).BeginInit();
            this.tabOwnTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnTest)).BeginInit();
            this.pnlAddTest.SuspendLayout();
            this.pnlUpdtOwnTest.SuspendLayout();
            this.pnlAddOwnTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(534, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 19);
            this.lblId.TabIndex = 55;
            this.lblId.Text = "metroLabel1";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Location = new System.Drawing.Point(471, 56);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(57, 19);
            this.metroLabel10.TabIndex = 54;
            this.metroLabel10.Text = "User ID:";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(623, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 53;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(703, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 52;
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
            this.labelTitle.TabIndex = 51;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(27, 144);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by Test Name";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(263, 23);
            this.txtSearch.TabIndex = 59;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Test Name";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 23);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tabMngTest
            // 
            this.tabMngTest.Controls.Add(this.tabAllTest);
            this.tabMngTest.Controls.Add(this.tabOwnTest);
            this.tabMngTest.Location = new System.Drawing.Point(23, 173);
            this.tabMngTest.Name = "tabMngTest";
            this.tabMngTest.SelectedIndex = 0;
            this.tabMngTest.Size = new System.Drawing.Size(754, 411);
            this.tabMngTest.TabIndex = 64;
            this.tabMngTest.UseSelectable = true;
            this.tabMngTest.SelectedIndexChanged += new System.EventHandler(this.TabMngTest_SelectedIndexChanged);
            // 
            // tabAllTest
            // 
            this.tabAllTest.BackColor = System.Drawing.SystemColors.Window;
            this.tabAllTest.Controls.Add(this.dgvAllTest);
            this.tabAllTest.Location = new System.Drawing.Point(4, 38);
            this.tabAllTest.Name = "tabAllTest";
            this.tabAllTest.Size = new System.Drawing.Size(746, 369);
            this.tabAllTest.TabIndex = 0;
            this.tabAllTest.Text = "All Tests";
            // 
            // dgvAllTest
            // 
            this.dgvAllTest.AllowUserToAddRows = false;
            this.dgvAllTest.AllowUserToDeleteRows = false;
            this.dgvAllTest.AllowUserToResizeRows = false;
            this.dgvAllTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAllTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAllTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestIdD,
            this.TestName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllTest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllTest.EnableHeadersVisualStyles = false;
            this.dgvAllTest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAllTest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAllTest.Location = new System.Drawing.Point(0, 3);
            this.dgvAllTest.Name = "dgvAllTest";
            this.dgvAllTest.ReadOnly = true;
            this.dgvAllTest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTest.Size = new System.Drawing.Size(743, 370);
            this.dgvAllTest.TabIndex = 66;
            this.dgvAllTest.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvAllTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAllTest_CellDoubleClick);
            // 
            // TestIdD
            // 
            this.TestIdD.DataPropertyName = "TestId";
            this.TestIdD.HeaderText = "Test ID";
            this.TestIdD.Name = "TestIdD";
            this.TestIdD.ReadOnly = true;
            // 
            // TestName
            // 
            this.TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // tabOwnTest
            // 
            this.tabOwnTest.BackColor = System.Drawing.SystemColors.Window;
            this.tabOwnTest.Controls.Add(this.dgvOwnTest);
            this.tabOwnTest.Location = new System.Drawing.Point(4, 38);
            this.tabOwnTest.Name = "tabOwnTest";
            this.tabOwnTest.Size = new System.Drawing.Size(746, 369);
            this.tabOwnTest.TabIndex = 1;
            this.tabOwnTest.Text = "Own Tests";
            // 
            // dgvOwnTest
            // 
            this.dgvOwnTest.AllowUserToAddRows = false;
            this.dgvOwnTest.AllowUserToDeleteRows = false;
            this.dgvOwnTest.AllowUserToResizeRows = false;
            this.dgvOwnTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOwnTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOwnTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOwnTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOwnTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOwnTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestIdO,
            this.TestNameO,
            this.TestCharge,
            this.slotM,
            this.slotA,
            this.slotN,
            this.HpId});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOwnTest.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOwnTest.EnableHeadersVisualStyles = false;
            this.dgvOwnTest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOwnTest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOwnTest.Location = new System.Drawing.Point(0, 3);
            this.dgvOwnTest.Name = "dgvOwnTest";
            this.dgvOwnTest.ReadOnly = true;
            this.dgvOwnTest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOwnTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOwnTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOwnTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOwnTest.Size = new System.Drawing.Size(743, 370);
            this.dgvOwnTest.TabIndex = 67;
            this.dgvOwnTest.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvOwnTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOwnTest_CellDoubleClick);
            // 
            // TestIdO
            // 
            this.TestIdO.DataPropertyName = "TestId";
            this.TestIdO.HeaderText = "Test ID";
            this.TestIdO.Name = "TestIdO";
            this.TestIdO.ReadOnly = true;
            // 
            // TestNameO
            // 
            this.TestNameO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestNameO.DataPropertyName = "TestName";
            this.TestNameO.HeaderText = "Test Name";
            this.TestNameO.Name = "TestNameO";
            this.TestNameO.ReadOnly = true;
            // 
            // TestCharge
            // 
            this.TestCharge.DataPropertyName = "TestCharge";
            this.TestCharge.HeaderText = "Test Charge";
            this.TestCharge.Name = "TestCharge";
            this.TestCharge.ReadOnly = true;
            // 
            // slotM
            // 
            this.slotM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.slotM.DataPropertyName = "Morning";
            this.slotM.HeaderText = "Morning";
            this.slotM.Name = "slotM";
            this.slotM.ReadOnly = true;
            this.slotM.Width = 75;
            // 
            // slotA
            // 
            this.slotA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.slotA.DataPropertyName = "Afternoon";
            this.slotA.HeaderText = "Afternoon";
            this.slotA.Name = "slotA";
            this.slotA.ReadOnly = true;
            this.slotA.Width = 83;
            // 
            // slotN
            // 
            this.slotN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.slotN.DataPropertyName = "Night";
            this.slotN.HeaderText = "Night";
            this.slotN.Name = "slotN";
            this.slotN.ReadOnly = true;
            this.slotN.Width = 59;
            // 
            // HpId
            // 
            this.HpId.DataPropertyName = "HpId";
            this.HpId.HeaderText = "HpId";
            this.HpId.Name = "HpId";
            this.HpId.ReadOnly = true;
            this.HpId.Visible = false;
            // 
            // txtNewTest
            // 
            // 
            // 
            // 
            this.txtNewTest.CustomButton.Image = null;
            this.txtNewTest.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtNewTest.CustomButton.Name = "";
            this.txtNewTest.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewTest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewTest.CustomButton.TabIndex = 1;
            this.txtNewTest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewTest.CustomButton.UseSelectable = true;
            this.txtNewTest.CustomButton.Visible = false;
            this.txtNewTest.Lines = new string[0];
            this.txtNewTest.Location = new System.Drawing.Point(12, 0);
            this.txtNewTest.MaxLength = 32767;
            this.txtNewTest.Name = "txtNewTest";
            this.txtNewTest.PasswordChar = '\0';
            this.txtNewTest.PromptText = "Input New Test Name";
            this.txtNewTest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewTest.SelectedText = "";
            this.txtNewTest.SelectionLength = 0;
            this.txtNewTest.SelectionStart = 0;
            this.txtNewTest.ShortcutsEnabled = true;
            this.txtNewTest.Size = new System.Drawing.Size(263, 23);
            this.txtNewTest.TabIndex = 68;
            this.txtNewTest.UseSelectable = true;
            this.txtNewTest.WaterMark = "Input New Test Name";
            this.txtNewTest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewTest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(281, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(98, 23);
            this.btnAddNew.TabIndex = 67;
            this.btnAddNew.Text = "Add New Test";
            this.btnAddNew.UseSelectable = true;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // tTipSlot
            // 
            this.tTipSlot.Style = MetroFramework.MetroColorStyle.Blue;
            this.tTipSlot.StyleManager = null;
            this.tTipSlot.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtSlotN
            // 
            // 
            // 
            // 
            this.txtSlotN.CustomButton.Image = null;
            this.txtSlotN.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txtSlotN.CustomButton.Name = "";
            this.txtSlotN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSlotN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSlotN.CustomButton.TabIndex = 1;
            this.txtSlotN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSlotN.CustomButton.UseSelectable = true;
            this.txtSlotN.CustomButton.Visible = false;
            this.txtSlotN.Lines = new string[0];
            this.txtSlotN.Location = new System.Drawing.Point(279, 1);
            this.txtSlotN.MaxLength = 32767;
            this.txtSlotN.Name = "txtSlotN";
            this.txtSlotN.PasswordChar = '\0';
            this.txtSlotN.PromptText = "Night";
            this.txtSlotN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlotN.SelectedText = "";
            this.txtSlotN.SelectionLength = 0;
            this.txtSlotN.SelectionStart = 0;
            this.txtSlotN.ShortcutsEnabled = true;
            this.txtSlotN.Size = new System.Drawing.Size(60, 23);
            this.txtSlotN.TabIndex = 72;
            this.tTipSlot.SetToolTip(this.txtSlotN, "Set available slots on each shift");
            this.txtSlotN.UseSelectable = true;
            this.txtSlotN.WaterMark = "Night";
            this.txtSlotN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSlotN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSlotA
            // 
            // 
            // 
            // 
            this.txtSlotA.CustomButton.Image = null;
            this.txtSlotA.CustomButton.Location = new System.Drawing.Point(45, 1);
            this.txtSlotA.CustomButton.Name = "";
            this.txtSlotA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSlotA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSlotA.CustomButton.TabIndex = 1;
            this.txtSlotA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSlotA.CustomButton.UseSelectable = true;
            this.txtSlotA.CustomButton.Visible = false;
            this.txtSlotA.Lines = new string[0];
            this.txtSlotA.Location = new System.Drawing.Point(208, 1);
            this.txtSlotA.MaxLength = 32767;
            this.txtSlotA.Name = "txtSlotA";
            this.txtSlotA.PasswordChar = '\0';
            this.txtSlotA.PromptText = "Afternoon";
            this.txtSlotA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlotA.SelectedText = "";
            this.txtSlotA.SelectionLength = 0;
            this.txtSlotA.SelectionStart = 0;
            this.txtSlotA.ShortcutsEnabled = true;
            this.txtSlotA.Size = new System.Drawing.Size(67, 23);
            this.txtSlotA.TabIndex = 72;
            this.tTipSlot.SetToolTip(this.txtSlotA, "Set available slots on each shift");
            this.txtSlotA.UseSelectable = true;
            this.txtSlotA.WaterMark = "Afternoon";
            this.txtSlotA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSlotA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSlotM
            // 
            // 
            // 
            // 
            this.txtSlotM.CustomButton.Image = null;
            this.txtSlotM.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.txtSlotM.CustomButton.Name = "";
            this.txtSlotM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSlotM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSlotM.CustomButton.TabIndex = 1;
            this.txtSlotM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSlotM.CustomButton.UseSelectable = true;
            this.txtSlotM.CustomButton.Visible = false;
            this.txtSlotM.Lines = new string[0];
            this.txtSlotM.Location = new System.Drawing.Point(131, 1);
            this.txtSlotM.MaxLength = 32767;
            this.txtSlotM.Name = "txtSlotM";
            this.txtSlotM.PasswordChar = '\0';
            this.txtSlotM.PromptText = "Morning";
            this.txtSlotM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlotM.SelectedText = "";
            this.txtSlotM.SelectionLength = 0;
            this.txtSlotM.SelectionStart = 0;
            this.txtSlotM.ShortcutsEnabled = true;
            this.txtSlotM.Size = new System.Drawing.Size(72, 23);
            this.txtSlotM.TabIndex = 72;
            this.tTipSlot.SetToolTip(this.txtSlotM, "Set available slots on each shift");
            this.txtSlotM.UseSelectable = true;
            this.txtSlotM.WaterMark = "Morning";
            this.txtSlotM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSlotM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // slotNight
            // 
            // 
            // 
            // 
            this.slotNight.CustomButton.Image = null;
            this.slotNight.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.slotNight.CustomButton.Name = "";
            this.slotNight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.slotNight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.slotNight.CustomButton.TabIndex = 1;
            this.slotNight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.slotNight.CustomButton.UseSelectable = true;
            this.slotNight.CustomButton.Visible = false;
            this.slotNight.Lines = new string[0];
            this.slotNight.Location = new System.Drawing.Point(279, 1);
            this.slotNight.MaxLength = 32767;
            this.slotNight.Name = "slotNight";
            this.slotNight.PasswordChar = '\0';
            this.slotNight.PromptText = "Night";
            this.slotNight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.slotNight.SelectedText = "";
            this.slotNight.SelectionLength = 0;
            this.slotNight.SelectionStart = 0;
            this.slotNight.ShortcutsEnabled = true;
            this.slotNight.Size = new System.Drawing.Size(60, 23);
            this.slotNight.TabIndex = 72;
            this.tTipSlot.SetToolTip(this.slotNight, "Please input available number of Night slot");
            this.slotNight.UseSelectable = true;
            this.slotNight.WaterMark = "Night";
            this.slotNight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.slotNight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // slotAfternoon
            // 
            // 
            // 
            // 
            this.slotAfternoon.CustomButton.Image = null;
            this.slotAfternoon.CustomButton.Location = new System.Drawing.Point(45, 1);
            this.slotAfternoon.CustomButton.Name = "";
            this.slotAfternoon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.slotAfternoon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.slotAfternoon.CustomButton.TabIndex = 1;
            this.slotAfternoon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.slotAfternoon.CustomButton.UseSelectable = true;
            this.slotAfternoon.CustomButton.Visible = false;
            this.slotAfternoon.Lines = new string[0];
            this.slotAfternoon.Location = new System.Drawing.Point(208, 1);
            this.slotAfternoon.MaxLength = 32767;
            this.slotAfternoon.Name = "slotAfternoon";
            this.slotAfternoon.PasswordChar = '\0';
            this.slotAfternoon.PromptText = "Afternoon";
            this.slotAfternoon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.slotAfternoon.SelectedText = "";
            this.slotAfternoon.SelectionLength = 0;
            this.slotAfternoon.SelectionStart = 0;
            this.slotAfternoon.ShortcutsEnabled = true;
            this.slotAfternoon.Size = new System.Drawing.Size(67, 23);
            this.slotAfternoon.TabIndex = 72;
            this.tTipSlot.SetToolTip(this.slotAfternoon, "Please input available number of Afternoon slot");
            this.slotAfternoon.UseSelectable = true;
            this.slotAfternoon.WaterMark = "Afternoon";
            this.slotAfternoon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.slotAfternoon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // slotMorning
            // 
            // 
            // 
            // 
            this.slotMorning.CustomButton.Image = null;
            this.slotMorning.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.slotMorning.CustomButton.Name = "";
            this.slotMorning.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.slotMorning.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.slotMorning.CustomButton.TabIndex = 1;
            this.slotMorning.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.slotMorning.CustomButton.UseSelectable = true;
            this.slotMorning.CustomButton.Visible = false;
            this.slotMorning.Lines = new string[0];
            this.slotMorning.Location = new System.Drawing.Point(131, 1);
            this.slotMorning.MaxLength = 32767;
            this.slotMorning.Name = "slotMorning";
            this.slotMorning.PasswordChar = '\0';
            this.slotMorning.PromptText = "Morning";
            this.slotMorning.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.slotMorning.SelectedText = "";
            this.slotMorning.SelectionLength = 0;
            this.slotMorning.SelectionStart = 0;
            this.slotMorning.ShortcutsEnabled = true;
            this.slotMorning.Size = new System.Drawing.Size(72, 23);
            this.slotMorning.TabIndex = 72;
            this.tTipSlot.SetToolTip(this.slotMorning, "Please input available number of Morning slot");
            this.slotMorning.UseSelectable = true;
            this.slotMorning.WaterMark = "Morning";
            this.slotMorning.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.slotMorning.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnlAddTest
            // 
            this.pnlAddTest.Controls.Add(this.btnAddNew);
            this.pnlAddTest.Controls.Add(this.txtNewTest);
            this.pnlAddTest.HorizontalScrollbarBarColor = true;
            this.pnlAddTest.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAddTest.HorizontalScrollbarSize = 10;
            this.pnlAddTest.Location = new System.Drawing.Point(15, 116);
            this.pnlAddTest.Name = "pnlAddTest";
            this.pnlAddTest.Size = new System.Drawing.Size(379, 23);
            this.pnlAddTest.TabIndex = 71;
            this.pnlAddTest.VerticalScrollbarBarColor = true;
            this.pnlAddTest.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAddTest.VerticalScrollbarSize = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(242, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtChargeUpdate
            // 
            // 
            // 
            // 
            this.txtChargeUpdate.CustomButton.Image = null;
            this.txtChargeUpdate.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtChargeUpdate.CustomButton.Name = "";
            this.txtChargeUpdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChargeUpdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChargeUpdate.CustomButton.TabIndex = 1;
            this.txtChargeUpdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChargeUpdate.CustomButton.UseSelectable = true;
            this.txtChargeUpdate.CustomButton.Visible = false;
            this.txtChargeUpdate.Lines = new string[0];
            this.txtChargeUpdate.Location = new System.Drawing.Point(131, 28);
            this.txtChargeUpdate.MaxLength = 32767;
            this.txtChargeUpdate.Name = "txtChargeUpdate";
            this.txtChargeUpdate.PasswordChar = '\0';
            this.txtChargeUpdate.PromptText = "Input Charge";
            this.txtChargeUpdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChargeUpdate.SelectedText = "";
            this.txtChargeUpdate.SelectionLength = 0;
            this.txtChargeUpdate.SelectionStart = 0;
            this.txtChargeUpdate.ShortcutsEnabled = true;
            this.txtChargeUpdate.Size = new System.Drawing.Size(104, 23);
            this.txtChargeUpdate.TabIndex = 72;
            this.txtChargeUpdate.UseSelectable = true;
            this.txtChargeUpdate.WaterMark = "Input Charge";
            this.txtChargeUpdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChargeUpdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOwnTestIdO
            // 
            // 
            // 
            // 
            this.txtOwnTestIdO.CustomButton.Image = null;
            this.txtOwnTestIdO.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtOwnTestIdO.CustomButton.Name = "";
            this.txtOwnTestIdO.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOwnTestIdO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOwnTestIdO.CustomButton.TabIndex = 1;
            this.txtOwnTestIdO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOwnTestIdO.CustomButton.UseSelectable = true;
            this.txtOwnTestIdO.CustomButton.Visible = false;
            this.txtOwnTestIdO.Enabled = false;
            this.txtOwnTestIdO.Lines = new string[0];
            this.txtOwnTestIdO.Location = new System.Drawing.Point(17, 28);
            this.txtOwnTestIdO.MaxLength = 32767;
            this.txtOwnTestIdO.Name = "txtOwnTestIdO";
            this.txtOwnTestIdO.PasswordChar = '\0';
            this.txtOwnTestIdO.PromptText = "Own Test ID";
            this.txtOwnTestIdO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOwnTestIdO.SelectedText = "";
            this.txtOwnTestIdO.SelectionLength = 0;
            this.txtOwnTestIdO.SelectionStart = 0;
            this.txtOwnTestIdO.ShortcutsEnabled = true;
            this.txtOwnTestIdO.Size = new System.Drawing.Size(108, 23);
            this.txtOwnTestIdO.TabIndex = 69;
            this.txtOwnTestIdO.UseSelectable = true;
            this.txtOwnTestIdO.WaterMark = "Own Test ID";
            this.txtOwnTestIdO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOwnTestIdO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 73;
            this.metroLabel1.Text = "Update Test Details:";
            // 
            // pnlUpdtOwnTest
            // 
            this.pnlUpdtOwnTest.Controls.Add(this.metroLabel1);
            this.pnlUpdtOwnTest.Controls.Add(this.txtOwnTestIdO);
            this.pnlUpdtOwnTest.Controls.Add(this.txtSlotM);
            this.pnlUpdtOwnTest.Controls.Add(this.txtSlotA);
            this.pnlUpdtOwnTest.Controls.Add(this.txtSlotN);
            this.pnlUpdtOwnTest.Controls.Add(this.txtChargeUpdate);
            this.pnlUpdtOwnTest.Controls.Add(this.btnUpdate);
            this.pnlUpdtOwnTest.HorizontalScrollbarBarColor = true;
            this.pnlUpdtOwnTest.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlUpdtOwnTest.HorizontalScrollbarSize = 10;
            this.pnlUpdtOwnTest.Location = new System.Drawing.Point(435, 116);
            this.pnlUpdtOwnTest.Name = "pnlUpdtOwnTest";
            this.pnlUpdtOwnTest.Size = new System.Drawing.Size(340, 52);
            this.pnlUpdtOwnTest.TabIndex = 70;
            this.pnlUpdtOwnTest.VerticalScrollbarBarColor = true;
            this.pnlUpdtOwnTest.VerticalScrollbarHighlightOnWheel = false;
            this.pnlUpdtOwnTest.VerticalScrollbarSize = 10;
            // 
            // btnAddOwn
            // 
            this.btnAddOwn.Location = new System.Drawing.Point(242, 28);
            this.btnAddOwn.Name = "btnAddOwn";
            this.btnAddOwn.Size = new System.Drawing.Size(97, 23);
            this.btnAddOwn.TabIndex = 68;
            this.btnAddOwn.Text = "Add Own Test";
            this.btnAddOwn.UseSelectable = true;
            this.btnAddOwn.Click += new System.EventHandler(this.BtnAddOwn_Click);
            // 
            // txtOwnTestId
            // 
            // 
            // 
            // 
            this.txtOwnTestId.CustomButton.Image = null;
            this.txtOwnTestId.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtOwnTestId.CustomButton.Name = "";
            this.txtOwnTestId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOwnTestId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOwnTestId.CustomButton.TabIndex = 1;
            this.txtOwnTestId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOwnTestId.CustomButton.UseSelectable = true;
            this.txtOwnTestId.CustomButton.Visible = false;
            this.txtOwnTestId.Enabled = false;
            this.txtOwnTestId.Lines = new string[0];
            this.txtOwnTestId.Location = new System.Drawing.Point(17, 28);
            this.txtOwnTestId.MaxLength = 32767;
            this.txtOwnTestId.Name = "txtOwnTestId";
            this.txtOwnTestId.PasswordChar = '\0';
            this.txtOwnTestId.PromptText = "Own Test ID";
            this.txtOwnTestId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOwnTestId.SelectedText = "";
            this.txtOwnTestId.SelectionLength = 0;
            this.txtOwnTestId.SelectionStart = 0;
            this.txtOwnTestId.ShortcutsEnabled = true;
            this.txtOwnTestId.Size = new System.Drawing.Size(108, 23);
            this.txtOwnTestId.TabIndex = 69;
            this.txtOwnTestId.UseSelectable = true;
            this.txtOwnTestId.WaterMark = "Own Test ID";
            this.txtOwnTestId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOwnTestId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCharge
            // 
            // 
            // 
            // 
            this.txtCharge.CustomButton.Image = null;
            this.txtCharge.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtCharge.CustomButton.Name = "";
            this.txtCharge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCharge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCharge.CustomButton.TabIndex = 1;
            this.txtCharge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCharge.CustomButton.UseSelectable = true;
            this.txtCharge.CustomButton.Visible = false;
            this.txtCharge.Lines = new string[0];
            this.txtCharge.Location = new System.Drawing.Point(131, 28);
            this.txtCharge.MaxLength = 32767;
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.PasswordChar = '\0';
            this.txtCharge.PromptText = "Input Charge";
            this.txtCharge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCharge.SelectedText = "";
            this.txtCharge.SelectionLength = 0;
            this.txtCharge.SelectionStart = 0;
            this.txtCharge.ShortcutsEnabled = true;
            this.txtCharge.Size = new System.Drawing.Size(104, 23);
            this.txtCharge.TabIndex = 70;
            this.txtCharge.UseSelectable = true;
            this.txtCharge.WaterMark = "Input Charge";
            this.txtCharge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCharge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 2);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 73;
            this.metroLabel2.Text = "Insert Test Details:";
            // 
            // pnlAddOwnTest
            // 
            this.pnlAddOwnTest.Controls.Add(this.metroLabel2);
            this.pnlAddOwnTest.Controls.Add(this.txtCharge);
            this.pnlAddOwnTest.Controls.Add(this.slotMorning);
            this.pnlAddOwnTest.Controls.Add(this.txtOwnTestId);
            this.pnlAddOwnTest.Controls.Add(this.slotAfternoon);
            this.pnlAddOwnTest.Controls.Add(this.btnAddOwn);
            this.pnlAddOwnTest.Controls.Add(this.slotNight);
            this.pnlAddOwnTest.HorizontalScrollbarBarColor = true;
            this.pnlAddOwnTest.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAddOwnTest.HorizontalScrollbarSize = 10;
            this.pnlAddOwnTest.Location = new System.Drawing.Point(435, 116);
            this.pnlAddOwnTest.Name = "pnlAddOwnTest";
            this.pnlAddOwnTest.Size = new System.Drawing.Size(340, 52);
            this.pnlAddOwnTest.TabIndex = 76;
            this.pnlAddOwnTest.VerticalScrollbarBarColor = true;
            this.pnlAddOwnTest.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAddOwnTest.VerticalScrollbarSize = 10;
            // 
            // FormMngTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.pnlAddOwnTest);
            this.Controls.Add(this.pnlAddTest);
            this.Controls.Add(this.pnlUpdtOwnTest);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tabMngTest);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.Name = "FormMngTest";
            this.Resizable = false;
            this.Text = "Manage Tests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMngTest_FormClosed);
            this.tabMngTest.ResumeLayout(false);
            this.tabAllTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTest)).EndInit();
            this.tabOwnTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnTest)).EndInit();
            this.pnlAddTest.ResumeLayout(false);
            this.pnlUpdtOwnTest.ResumeLayout(false);
            this.pnlUpdtOwnTest.PerformLayout();
            this.pnlAddOwnTest.ResumeLayout(false);
            this.pnlAddOwnTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTabControl tabMngTest;
        private System.Windows.Forms.TabPage tabAllTest;
        private MetroFramework.Controls.MetroGrid dgvAllTest;
        private System.Windows.Forms.TabPage tabOwnTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestIdD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private MetroFramework.Controls.MetroGrid dgvOwnTest;
        private MetroFramework.Controls.MetroTextBox txtNewTest;
        private MetroFramework.Controls.MetroButton btnAddNew;
        private MetroFramework.Components.MetroToolTip tTipSlot;
        private MetroFramework.Controls.MetroPanel pnlAddTest;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtChargeUpdate;
        private MetroFramework.Controls.MetroTextBox txtSlotN;
        private MetroFramework.Controls.MetroTextBox txtSlotA;
        private MetroFramework.Controls.MetroTextBox txtSlotM;
        private MetroFramework.Controls.MetroTextBox txtOwnTestIdO;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel pnlUpdtOwnTest;
        private MetroFramework.Controls.MetroTextBox slotNight;
        private MetroFramework.Controls.MetroButton btnAddOwn;
        private MetroFramework.Controls.MetroTextBox slotAfternoon;
        private MetroFramework.Controls.MetroTextBox txtOwnTestId;
        private MetroFramework.Controls.MetroTextBox slotMorning;
        private MetroFramework.Controls.MetroTextBox txtCharge;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel pnlAddOwnTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestIdO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestNameO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotM;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotA;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HpId;
    }
}