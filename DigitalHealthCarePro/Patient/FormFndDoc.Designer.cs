namespace DigitalHealthCarePro.Patient
{
    partial class FormFndDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFndDoc));
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.dgvDoctor = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitingHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlotDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVisitingHr = new MetroFramework.Controls.MetroTextBox();
            this.txtQualification = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtAge = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdmnId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDept = new MetroFramework.Controls.MetroTextBox();
            this.btnBook = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtFee = new MetroFramework.Controls.MetroTextBox();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.pnlSearch = new MetroFramework.Controls.MetroPanel();
            this.cmbSearchCountry = new MetroFramework.Controls.MetroComboBox();
            this.txtSearchDept = new MetroFramework.Controls.MetroTextBox();
            this.txtSearchCity = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel10
            // 
            this.metroLabel10.Location = new System.Drawing.Point(924, 56);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(66, 19);
            this.metroLabel10.TabIndex = 49;
            this.metroLabel10.Text = "User ID:";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(996, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(86, 19);
            this.lblId.TabIndex = 50;
            this.lblId.Text = "metroLabel1";
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AllowUserToDeleteRows = false;
            this.dgvDoctor.AllowUserToResizeRows = false;
            this.dgvDoctor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDoctor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DocName,
            this.Dept,
            this.Email,
            this.Age,
            this.Qualifications,
            this.Phone,
            this.City,
            this.Fee,
            this.AddressLn,
            this.Country,
            this.WeekStart,
            this.WeekEnd,
            this.StartTime,
            this.CloseTime,
            this.VisitingHour,
            this.SlotDuration,
            this.Password});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoctor.EnableHeadersVisualStyles = false;
            this.dgvDoctor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDoctor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDoctor.Location = new System.Drawing.Point(22, 248);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoctor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctor.Size = new System.Drawing.Size(1220, 302);
            this.dgvDoctor.TabIndex = 47;
            this.dgvDoctor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvDoctor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoctor_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 90;
            // 
            // DocName
            // 
            this.DocName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DocName.DataPropertyName = "Name";
            this.DocName.HeaderText = "Name";
            this.DocName.Name = "DocName";
            this.DocName.ReadOnly = true;
            // 
            // Dept
            // 
            this.Dept.DataPropertyName = "Dept";
            this.Dept.HeaderText = "Dept";
            this.Dept.Name = "Dept";
            this.Dept.ReadOnly = true;
            this.Dept.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            this.Email.Width = 150;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 40;
            // 
            // Qualifications
            // 
            this.Qualifications.DataPropertyName = "Qualifications";
            this.Qualifications.HeaderText = "Qualifications";
            this.Qualifications.Name = "Qualifications";
            this.Qualifications.ReadOnly = true;
            this.Qualifications.Width = 150;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 120;
            // 
            // Fee
            // 
            this.Fee.DataPropertyName = "Fee";
            this.Fee.HeaderText = "Fee";
            this.Fee.Name = "Fee";
            this.Fee.ReadOnly = true;
            this.Fee.Width = 60;
            // 
            // AddressLn
            // 
            this.AddressLn.DataPropertyName = "AddressLn";
            this.AddressLn.HeaderText = "Address Line 1";
            this.AddressLn.Name = "AddressLn";
            this.AddressLn.ReadOnly = true;
            this.AddressLn.Visible = false;
            this.AddressLn.Width = 150;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Visible = false;
            // 
            // WeekStart
            // 
            this.WeekStart.DataPropertyName = "WeekStart";
            this.WeekStart.HeaderText = "WeekStart";
            this.WeekStart.Name = "WeekStart";
            this.WeekStart.ReadOnly = true;
            this.WeekStart.Width = 85;
            // 
            // WeekEnd
            // 
            this.WeekEnd.DataPropertyName = "WeekEnd";
            this.WeekEnd.HeaderText = "Week End";
            this.WeekEnd.Name = "WeekEnd";
            this.WeekEnd.ReadOnly = true;
            this.WeekEnd.Width = 85;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 85;
            // 
            // CloseTime
            // 
            this.CloseTime.DataPropertyName = "CloseTime";
            this.CloseTime.HeaderText = "Close Time";
            this.CloseTime.Name = "CloseTime";
            this.CloseTime.ReadOnly = true;
            this.CloseTime.Width = 85;
            // 
            // VisitingHour
            // 
            this.VisitingHour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitingHour.DataPropertyName = "VisitingHour";
            this.VisitingHour.HeaderText = "Visiting Hours";
            this.VisitingHour.Name = "VisitingHour";
            this.VisitingHour.ReadOnly = true;
            this.VisitingHour.Visible = false;
            // 
            // SlotDuration
            // 
            this.SlotDuration.DataPropertyName = "SlotMin";
            this.SlotDuration.HeaderText = "SlotMin";
            this.SlotDuration.Name = "SlotDuration";
            this.SlotDuration.ReadOnly = true;
            this.SlotDuration.Visible = false;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // txtVisitingHr
            // 
            // 
            // 
            // 
            this.txtVisitingHr.CustomButton.Image = null;
            this.txtVisitingHr.CustomButton.Location = new System.Drawing.Point(312, 1);
            this.txtVisitingHr.CustomButton.Name = "";
            this.txtVisitingHr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVisitingHr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVisitingHr.CustomButton.TabIndex = 1;
            this.txtVisitingHr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVisitingHr.CustomButton.UseSelectable = true;
            this.txtVisitingHr.CustomButton.Visible = false;
            this.txtVisitingHr.Enabled = false;
            this.txtVisitingHr.Lines = new string[0];
            this.txtVisitingHr.Location = new System.Drawing.Point(907, 189);
            this.txtVisitingHr.MaxLength = 32767;
            this.txtVisitingHr.Name = "txtVisitingHr";
            this.txtVisitingHr.PasswordChar = '\0';
            this.txtVisitingHr.ReadOnly = true;
            this.txtVisitingHr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVisitingHr.SelectedText = "";
            this.txtVisitingHr.SelectionLength = 0;
            this.txtVisitingHr.SelectionStart = 0;
            this.txtVisitingHr.ShortcutsEnabled = true;
            this.txtVisitingHr.Size = new System.Drawing.Size(334, 23);
            this.txtVisitingHr.TabIndex = 44;
            this.txtVisitingHr.UseSelectable = true;
            this.txtVisitingHr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVisitingHr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQualification
            // 
            // 
            // 
            // 
            this.txtQualification.CustomButton.Image = null;
            this.txtQualification.CustomButton.Location = new System.Drawing.Point(312, 1);
            this.txtQualification.CustomButton.Name = "";
            this.txtQualification.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQualification.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQualification.CustomButton.TabIndex = 1;
            this.txtQualification.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQualification.CustomButton.UseSelectable = true;
            this.txtQualification.CustomButton.Visible = false;
            this.txtQualification.Enabled = false;
            this.txtQualification.Lines = new string[0];
            this.txtQualification.Location = new System.Drawing.Point(907, 114);
            this.txtQualification.MaxLength = 32767;
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.PasswordChar = '\0';
            this.txtQualification.ReadOnly = true;
            this.txtQualification.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQualification.SelectedText = "";
            this.txtQualification.SelectionLength = 0;
            this.txtQualification.SelectionStart = 0;
            this.txtQualification.ShortcutsEnabled = true;
            this.txtQualification.Size = new System.Drawing.Size(334, 23);
            this.txtQualification.TabIndex = 43;
            this.txtQualification.UseSelectable = true;
            this.txtQualification.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQualification.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Enabled = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(450, 114);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = true;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(298, 23);
            this.txtName.TabIndex = 42;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Enabled = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(450, 172);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ReadOnly = true;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(298, 23);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(296, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Enabled = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(907, 143);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(334, 40);
            this.txtAddress.TabIndex = 40;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(817, 189);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(83, 19);
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "Visiting Hour";
            // 
            // txtAge
            // 
            // 
            // 
            // 
            this.txtAge.CustomButton.Image = null;
            this.txtAge.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.txtAge.CustomButton.Name = "";
            this.txtAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAge.CustomButton.TabIndex = 1;
            this.txtAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAge.CustomButton.UseSelectable = true;
            this.txtAge.CustomButton.Visible = false;
            this.txtAge.Enabled = false;
            this.txtAge.Lines = new string[0];
            this.txtAge.Location = new System.Drawing.Point(66, 172);
            this.txtAge.MaxLength = 32767;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.ReadOnly = true;
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAge.SelectedText = "";
            this.txtAge.SelectionLength = 0;
            this.txtAge.SelectionStart = 0;
            this.txtAge.ShortcutsEnabled = true;
            this.txtAge.Size = new System.Drawing.Size(106, 23);
            this.txtAge.TabIndex = 39;
            this.txtAge.UseSelectable = true;
            this.txtAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Enabled = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(450, 143);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ReadOnly = true;
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(298, 23);
            this.txtPhone.TabIndex = 45;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(66, 114);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(261, 23);
            this.txtId.TabIndex = 37;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Age";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(818, 114);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(82, 19);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Qualification";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(398, 143);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Phone";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(399, 114);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(45, 19);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(403, 172);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Email";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(845, 143);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Address";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "ID";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(23, 219);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by Name";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(185, 23);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Name";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 218);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1088, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1168, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 24;
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
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabelAdmnId
            // 
            this.metroLabelAdmnId.AutoSize = true;
            this.metroLabelAdmnId.Location = new System.Drawing.Point(23, 79);
            this.metroLabelAdmnId.Name = "metroLabelAdmnId";
            this.metroLabelAdmnId.Size = new System.Drawing.Size(0, 0);
            this.metroLabelAdmnId.TabIndex = 22;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 143);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Dept";
            // 
            // txtDept
            // 
            // 
            // 
            // 
            this.txtDept.CustomButton.Image = null;
            this.txtDept.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtDept.CustomButton.Name = "";
            this.txtDept.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDept.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDept.CustomButton.TabIndex = 1;
            this.txtDept.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDept.CustomButton.UseSelectable = true;
            this.txtDept.CustomButton.Visible = false;
            this.txtDept.Enabled = false;
            this.txtDept.Lines = new string[0];
            this.txtDept.Location = new System.Drawing.Point(66, 143);
            this.txtDept.MaxLength = 32767;
            this.txtDept.Name = "txtDept";
            this.txtDept.PasswordChar = '\0';
            this.txtDept.ReadOnly = true;
            this.txtDept.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDept.SelectedText = "";
            this.txtDept.SelectionLength = 0;
            this.txtDept.SelectionStart = 0;
            this.txtDept.ShortcutsEnabled = true;
            this.txtDept.Size = new System.Drawing.Size(261, 23);
            this.txtDept.TabIndex = 42;
            this.txtDept.UseSelectable = true;
            this.txtDept.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDept.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(1143, 218);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(98, 23);
            this.btnBook.TabIndex = 53;
            this.btnBook.Text = "Book Now";
            this.btnBook.UseSelectable = true;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(178, 172);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(30, 19);
            this.metroLabel11.TabIndex = 30;
            this.metroLabel11.Text = "Fee";
            // 
            // txtFee
            // 
            // 
            // 
            // 
            this.txtFee.CustomButton.Image = null;
            this.txtFee.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtFee.CustomButton.Name = "";
            this.txtFee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFee.CustomButton.TabIndex = 1;
            this.txtFee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFee.CustomButton.UseSelectable = true;
            this.txtFee.CustomButton.Visible = false;
            this.txtFee.Enabled = false;
            this.txtFee.Lines = new string[0];
            this.txtFee.Location = new System.Drawing.Point(214, 172);
            this.txtFee.MaxLength = 32767;
            this.txtFee.Name = "txtFee";
            this.txtFee.PasswordChar = '\0';
            this.txtFee.ReadOnly = true;
            this.txtFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFee.SelectedText = "";
            this.txtFee.SelectionLength = 0;
            this.txtFee.SelectionStart = 0;
            this.txtFee.ShortcutsEnabled = true;
            this.txtFee.Size = new System.Drawing.Size(113, 23);
            this.txtFee.TabIndex = 41;
            this.txtFee.UseSelectable = true;
            this.txtFee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.Location = new System.Drawing.Point(214, 219);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(31, 23);
            this.btnFilter.TabIndex = 54;
            this.btnFilter.UseSelectable = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.cmbSearchCountry);
            this.pnlSearch.Controls.Add(this.txtSearchDept);
            this.pnlSearch.Controls.Add(this.txtSearchCity);
            this.pnlSearch.HorizontalScrollbarBarColor = true;
            this.pnlSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSearch.HorizontalScrollbarSize = 10;
            this.pnlSearch.Location = new System.Drawing.Point(251, 211);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(514, 31);
            this.pnlSearch.TabIndex = 55;
            this.pnlSearch.VerticalScrollbarBarColor = true;
            this.pnlSearch.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSearch.VerticalScrollbarSize = 10;
            // 
            // cmbSearchCountry
            // 
            this.cmbSearchCountry.FormattingEnabled = true;
            this.cmbSearchCountry.ItemHeight = 23;
            this.cmbSearchCountry.Location = new System.Drawing.Point(3, 1);
            this.cmbSearchCountry.Name = "cmbSearchCountry";
            this.cmbSearchCountry.PromptText = "Search by Country";
            this.cmbSearchCountry.Size = new System.Drawing.Size(172, 29);
            this.cmbSearchCountry.TabIndex = 28;
            this.cmbSearchCountry.UseSelectable = true;
            // 
            // txtSearchDept
            // 
            // 
            // 
            // 
            this.txtSearchDept.CustomButton.Image = null;
            this.txtSearchDept.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtSearchDept.CustomButton.Name = "";
            this.txtSearchDept.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchDept.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchDept.CustomButton.TabIndex = 1;
            this.txtSearchDept.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchDept.CustomButton.UseSelectable = true;
            this.txtSearchDept.CustomButton.Visible = false;
            this.txtSearchDept.Lines = new string[0];
            this.txtSearchDept.Location = new System.Drawing.Point(354, 7);
            this.txtSearchDept.MaxLength = 32767;
            this.txtSearchDept.Name = "txtSearchDept";
            this.txtSearchDept.PasswordChar = '\0';
            this.txtSearchDept.PromptText = "Search by Dept.";
            this.txtSearchDept.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchDept.SelectedText = "";
            this.txtSearchDept.SelectionLength = 0;
            this.txtSearchDept.SelectionStart = 0;
            this.txtSearchDept.ShortcutsEnabled = true;
            this.txtSearchDept.Size = new System.Drawing.Size(159, 23);
            this.txtSearchDept.TabIndex = 27;
            this.txtSearchDept.UseSelectable = true;
            this.txtSearchDept.WaterMark = "Search by Dept.";
            this.txtSearchDept.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchDept.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSearchCity
            // 
            // 
            // 
            // 
            this.txtSearchCity.CustomButton.Image = null;
            this.txtSearchCity.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtSearchCity.CustomButton.Name = "";
            this.txtSearchCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchCity.CustomButton.TabIndex = 1;
            this.txtSearchCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchCity.CustomButton.UseSelectable = true;
            this.txtSearchCity.CustomButton.Visible = false;
            this.txtSearchCity.Lines = new string[0];
            this.txtSearchCity.Location = new System.Drawing.Point(185, 7);
            this.txtSearchCity.MaxLength = 32767;
            this.txtSearchCity.Name = "txtSearchCity";
            this.txtSearchCity.PasswordChar = '\0';
            this.txtSearchCity.PromptText = "Search by City";
            this.txtSearchCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchCity.SelectedText = "";
            this.txtSearchCity.SelectionLength = 0;
            this.txtSearchCity.SelectionStart = 0;
            this.txtSearchCity.ShortcutsEnabled = true;
            this.txtSearchCity.Size = new System.Drawing.Size(159, 23);
            this.txtSearchCity.TabIndex = 27;
            this.txtSearchCity.UseSelectable = true;
            this.txtSearchCity.WaterMark = "Search by City";
            this.txtSearchCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormFndDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 571);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvDoctor);
            this.Controls.Add(this.txtVisitingHr);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabelAdmnId);
            this.Controls.Add(this.pnlSearch);
            this.MaximizeBox = false;
            this.Name = "FormFndDoc";
            this.Resizable = false;
            this.Text = "Find Doctors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFndDoc_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroGrid dgvDoctor;
        private MetroFramework.Controls.MetroTextBox txtVisitingHr;
        private MetroFramework.Controls.MetroTextBox txtQualification;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtAge;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabelAdmnId;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDept;
        private MetroFramework.Controls.MetroButton btnBook;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtFee;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroPanel pnlSearch;
        private MetroFramework.Controls.MetroComboBox cmbSearchCountry;
        private MetroFramework.Controls.MetroTextBox txtSearchCity;
        private MetroFramework.Controls.MetroTextBox txtSearchDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CloseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitingHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}