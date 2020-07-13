namespace DigitalHealthCarePro.Hospital
{
    partial class FormRcntPat
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
            this.btnAccessPres = new MetroFramework.Controls.MetroButton();
            this.btnAccessRep = new MetroFramework.Controls.MetroButton();
            this.PatAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatBlood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSndRep = new MetroFramework.Controls.MetroButton();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdmnId = new MetroFramework.Controls.MetroLabel();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.dgvRcntPat = new MetroFramework.Controls.MetroGrid();
            this.txtPatId = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRcntPat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccessPres
            // 
            this.btnAccessPres.Location = new System.Drawing.Point(1023, 107);
            this.btnAccessPres.Name = "btnAccessPres";
            this.btnAccessPres.Size = new System.Drawing.Size(151, 23);
            this.btnAccessPres.TabIndex = 172;
            this.btnAccessPres.Text = "Access Prescriptions";
            this.btnAccessPres.UseSelectable = true;
            this.btnAccessPres.Click += new System.EventHandler(this.BtnAccessPres_Click);
            // 
            // btnAccessRep
            // 
            this.btnAccessRep.Location = new System.Drawing.Point(709, 107);
            this.btnAccessRep.Name = "btnAccessRep";
            this.btnAccessRep.Size = new System.Drawing.Size(151, 23);
            this.btnAccessRep.TabIndex = 170;
            this.btnAccessRep.Text = "Access Reports";
            this.btnAccessRep.UseSelectable = true;
            this.btnAccessRep.Click += new System.EventHandler(this.BtnAccessRep_Click);
            // 
            // PatAddress
            // 
            this.PatAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatAddress.DataPropertyName = "Address";
            this.PatAddress.HeaderText = "Address";
            this.PatAddress.MinimumWidth = 30;
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.ReadOnly = true;
            // 
            // PatPhone
            // 
            this.PatPhone.DataPropertyName = "Phone";
            this.PatPhone.HeaderText = "Phone";
            this.PatPhone.MinimumWidth = 100;
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.ReadOnly = true;
            this.PatPhone.Width = 120;
            // 
            // PatEmail
            // 
            this.PatEmail.DataPropertyName = "Email";
            this.PatEmail.HeaderText = "Email";
            this.PatEmail.MinimumWidth = 100;
            this.PatEmail.Name = "PatEmail";
            this.PatEmail.ReadOnly = true;
            this.PatEmail.Width = 120;
            // 
            // PatBlood
            // 
            this.PatBlood.DataPropertyName = "BloodGroup";
            this.PatBlood.HeaderText = "Blood Group";
            this.PatBlood.MinimumWidth = 50;
            this.PatBlood.Name = "PatBlood";
            this.PatBlood.ReadOnly = true;
            this.PatBlood.Width = 80;
            // 
            // PatAge
            // 
            this.PatAge.DataPropertyName = "Age";
            this.PatAge.HeaderText = "Age";
            this.PatAge.MinimumWidth = 30;
            this.PatAge.Name = "PatAge";
            this.PatAge.ReadOnly = true;
            this.PatAge.Width = 50;
            // 
            // PatName
            // 
            this.PatName.DataPropertyName = "Name";
            this.PatName.HeaderText = "Name";
            this.PatName.MinimumWidth = 100;
            this.PatName.Name = "PatName";
            this.PatName.ReadOnly = true;
            this.PatName.Width = 150;
            // 
            // btnSndRep
            // 
            this.btnSndRep.Location = new System.Drawing.Point(866, 107);
            this.btnSndRep.Name = "btnSndRep";
            this.btnSndRep.Size = new System.Drawing.Size(151, 23);
            this.btnSndRep.TabIndex = 171;
            this.btnSndRep.Text = "Send Report";
            this.btnSndRep.UseSelectable = true;
            this.btnSndRep.Click += new System.EventHandler(this.BtnSndRep_Click);
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "Id";
            this.PatientId.HeaderText = "Patient ID";
            this.PatientId.MinimumWidth = 80;
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Location = new System.Drawing.Point(862, 60);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.TabIndex = 168;
            this.metroLabel10.Text = "User ID:";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(23, 107);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by Name";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(209, 23);
            this.txtSearch.TabIndex = 166;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Name";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(238, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 165;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1099, 60);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 163;
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
            this.labelTitle.TabIndex = 162;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabelAdmnId
            // 
            this.metroLabelAdmnId.AutoSize = true;
            this.metroLabelAdmnId.Location = new System.Drawing.Point(23, 79);
            this.metroLabelAdmnId.Name = "metroLabelAdmnId";
            this.metroLabelAdmnId.Size = new System.Drawing.Size(0, 0);
            this.metroLabelAdmnId.TabIndex = 161;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1019, 60);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 164;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(930, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 19);
            this.lblId.TabIndex = 169;
            this.lblId.Text = "metroLabel1";
            // 
            // dgvRcntPat
            // 
            this.dgvRcntPat.AllowUserToAddRows = false;
            this.dgvRcntPat.AllowUserToDeleteRows = false;
            this.dgvRcntPat.AllowUserToResizeRows = false;
            this.dgvRcntPat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRcntPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRcntPat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRcntPat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRcntPat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRcntPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRcntPat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientId,
            this.PatName,
            this.PatAge,
            this.PatBlood,
            this.PatEmail,
            this.PatPhone,
            this.PatAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRcntPat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRcntPat.EnableHeadersVisualStyles = false;
            this.dgvRcntPat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRcntPat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRcntPat.Location = new System.Drawing.Point(23, 136);
            this.dgvRcntPat.Name = "dgvRcntPat";
            this.dgvRcntPat.ReadOnly = true;
            this.dgvRcntPat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRcntPat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRcntPat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRcntPat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRcntPat.Size = new System.Drawing.Size(1151, 511);
            this.dgvRcntPat.TabIndex = 167;
            this.dgvRcntPat.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvRcntPat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRcntPat_CellDoubleClick);
            // 
            // txtPatId
            // 
            // 
            // 
            // 
            this.txtPatId.CustomButton.Image = null;
            this.txtPatId.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtPatId.CustomButton.Name = "";
            this.txtPatId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatId.CustomButton.TabIndex = 1;
            this.txtPatId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatId.CustomButton.UseSelectable = true;
            this.txtPatId.CustomButton.Visible = false;
            this.txtPatId.Lines = new string[0];
            this.txtPatId.Location = new System.Drawing.Point(546, 107);
            this.txtPatId.MaxLength = 32767;
            this.txtPatId.Name = "txtPatId";
            this.txtPatId.PasswordChar = '\0';
            this.txtPatId.PromptText = "Patient ID";
            this.txtPatId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatId.SelectedText = "";
            this.txtPatId.SelectionLength = 0;
            this.txtPatId.SelectionStart = 0;
            this.txtPatId.ShortcutsEnabled = true;
            this.txtPatId.Size = new System.Drawing.Size(157, 23);
            this.txtPatId.TabIndex = 173;
            this.txtPatId.UseSelectable = true;
            this.txtPatId.WaterMark = "Patient ID";
            this.txtPatId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormRcntPat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 670);
            this.Controls.Add(this.txtPatId);
            this.Controls.Add(this.btnAccessPres);
            this.Controls.Add(this.btnAccessRep);
            this.Controls.Add(this.btnSndRep);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabelAdmnId);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvRcntPat);
            this.MaximizeBox = false;
            this.Name = "FormRcntPat";
            this.Resizable = false;
            this.Text = "Recent Patients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRcntPat_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRcntPat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAccessPres;
        private MetroFramework.Controls.MetroButton btnAccessRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatBlood;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatName;
        private MetroFramework.Controls.MetroButton btnSndRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabelAdmnId;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroGrid dgvRcntPat;
        private MetroFramework.Controls.MetroTextBox txtPatId;
    }
}