namespace DigitalHealthCarePro.Hospital
{
    partial class FormAccessPres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPatDetails = new MetroFramework.Controls.MetroButton();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgvAccessPres = new MetroFramework.Controls.MetroGrid();
            this.presId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtDate = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdmnId = new MetroFramework.Controls.MetroLabel();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessPres)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatDetails
            // 
            this.btnPatDetails.Location = new System.Drawing.Point(332, 448);
            this.btnPatDetails.Name = "btnPatDetails";
            this.btnPatDetails.Size = new System.Drawing.Size(130, 23);
            this.btnPatDetails.TabIndex = 178;
            this.btnPatDetails.Text = "Patient Details";
            this.btnPatDetails.UseSelectable = true;
            this.btnPatDetails.Click += new System.EventHandler(this.BtnPatDetails_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtDetails.Location = new System.Drawing.Point(77, 147);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(1099, 283);
            this.txtDetails.TabIndex = 175;
            this.txtDetails.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 38);
            this.metroLabel2.TabIndex = 174;
            this.metroLabel2.Text = "Presn. \r\nDetails";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(982, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 176;
            this.metroLabel3.Text = "Date";
            // 
            // dgvAccessPres
            // 
            this.dgvAccessPres.AllowUserToAddRows = false;
            this.dgvAccessPres.AllowUserToDeleteRows = false;
            this.dgvAccessPres.AllowUserToResizeRows = false;
            this.dgvAccessPres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAccessPres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccessPres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAccessPres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccessPres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccessPres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccessPres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.presId,
            this.PatientId,
            this.presTime,
            this.presDetails});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccessPres.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccessPres.EnableHeadersVisualStyles = false;
            this.dgvAccessPres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAccessPres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAccessPres.Location = new System.Drawing.Point(26, 477);
            this.dgvAccessPres.Name = "dgvAccessPres";
            this.dgvAccessPres.ReadOnly = true;
            this.dgvAccessPres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccessPres.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccessPres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccessPres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccessPres.Size = new System.Drawing.Size(1150, 170);
            this.dgvAccessPres.TabIndex = 171;
            this.dgvAccessPres.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvAccessPres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccessPres_CellDoubleClick);
            // 
            // presId
            // 
            this.presId.DataPropertyName = "PresId";
            this.presId.HeaderText = "Presn. ID";
            this.presId.MinimumWidth = 80;
            this.presId.Name = "presId";
            this.presId.ReadOnly = true;
            this.presId.Width = 80;
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "PatId";
            this.PatientId.HeaderText = "Patient ID";
            this.PatientId.MinimumWidth = 80;
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            // 
            // presTime
            // 
            this.presTime.DataPropertyName = "Time";
            this.presTime.HeaderText = "Presn. Date";
            this.presTime.MinimumWidth = 100;
            this.presTime.Name = "presTime";
            this.presTime.ReadOnly = true;
            this.presTime.Width = 150;
            // 
            // presDetails
            // 
            this.presDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.presDetails.DataPropertyName = "Details";
            this.presDetails.HeaderText = "Presn. Details";
            this.presDetails.MinimumWidth = 300;
            this.presDetails.Name = "presDetails";
            this.presDetails.ReadOnly = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Location = new System.Drawing.Point(866, 56);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.TabIndex = 172;
            this.metroLabel10.Text = "User ID:";
            // 
            // txtDate
            // 
            // 
            // 
            // 
            this.txtDate.CustomButton.Image = null;
            this.txtDate.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtDate.CustomButton.Name = "";
            this.txtDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDate.CustomButton.TabIndex = 1;
            this.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDate.CustomButton.UseSelectable = true;
            this.txtDate.CustomButton.Visible = false;
            this.txtDate.Lines = new string[0];
            this.txtDate.Location = new System.Drawing.Point(1024, 118);
            this.txtDate.MaxLength = 32767;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.ReadOnly = true;
            this.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.ShortcutsEnabled = true;
            this.txtDate.Size = new System.Drawing.Size(153, 23);
            this.txtDate.TabIndex = 169;
            this.txtDate.UseSelectable = true;
            this.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtSearch.Location = new System.Drawing.Point(26, 448);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by Patient ID";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(209, 23);
            this.txtSearch.TabIndex = 167;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Patient ID";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 38);
            this.metroLabel1.TabIndex = 168;
            this.metroLabel1.Text = "Presn. \r\nID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(241, 448);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 166;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1103, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 164;
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
            this.labelTitle.TabIndex = 163;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabelAdmnId
            // 
            this.metroLabelAdmnId.AutoSize = true;
            this.metroLabelAdmnId.Location = new System.Drawing.Point(23, 79);
            this.metroLabelAdmnId.Name = "metroLabelAdmnId";
            this.metroLabelAdmnId.Size = new System.Drawing.Size(0, 0);
            this.metroLabelAdmnId.TabIndex = 162;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1023, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 165;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(934, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 19);
            this.lblId.TabIndex = 173;
            this.lblId.Text = "metroLabel1";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(77, 118);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(124, 23);
            this.txtId.TabIndex = 170;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormAccessPres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 670);
            this.Controls.Add(this.btnPatDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dgvAccessPres);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabelAdmnId);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.MaximizeBox = false;
            this.Name = "FormAccessPres";
            this.Resizable = false;
            this.Text = "Access Prescriptions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAccessPres_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessPres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnPatDetails;
        private System.Windows.Forms.RichTextBox txtDetails;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid dgvAccessPres;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtDate;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabelAdmnId;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroTextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn presId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn presTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn presDetails;
    }
}