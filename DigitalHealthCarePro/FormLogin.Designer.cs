namespace DigitalHealthCarePro
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblRole = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.tileLogin = new MetroFramework.Controls.MetroTile();
            this.cmbRole = new MetroFramework.Controls.MetroComboBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.tileSignUp = new MetroFramework.Controls.MetroTile();
            this.lblAbout = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(216, 126);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(174, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 19);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(202, 187);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 19);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[] {
        "adm-01"};
            this.txtId.Location = new System.Drawing.Point(243, 124);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PromptText = "Input ID";
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(153, 23);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "adm-01";
            this.txtId.UseSelectable = true;
            this.txtId.WaterMark = "Input ID";
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileLogin
            // 
            this.tileLogin.ActiveControl = null;
            this.tileLogin.Location = new System.Drawing.Point(243, 223);
            this.tileLogin.Name = "tileLogin";
            this.tileLogin.Size = new System.Drawing.Size(153, 40);
            this.tileLogin.TabIndex = 2;
            this.tileLogin.Text = "Log In";
            this.tileLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileLogin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLogin.UseSelectable = true;
            this.tileLogin.Click += new System.EventHandler(this.TileLogin_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.ItemHeight = 23;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Hospital",
            "Patient"});
            this.cmbRole.Location = new System.Drawing.Point(243, 182);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.PromptText = "Select Role";
            this.cmbRole.Size = new System.Drawing.Size(153, 29);
            this.cmbRole.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbRole.TabIndex = 3;
            this.cmbRole.UseSelectable = true;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[] {
        "aA11!!"};
            this.txtPassword.Location = new System.Drawing.Point(243, 153);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Input Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(153, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "aA11!!";
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Input Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(23, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 19);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tileSignUp
            // 
            this.tileSignUp.ActiveControl = null;
            this.tileSignUp.Location = new System.Drawing.Point(243, 269);
            this.tileSignUp.Name = "tileSignUp";
            this.tileSignUp.Size = new System.Drawing.Size(153, 40);
            this.tileSignUp.TabIndex = 7;
            this.tileSignUp.Text = "Sign Up";
            this.tileSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSignUp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSignUp.UseSelectable = true;
            this.tileSignUp.Click += new System.EventHandler(this.TileSignUp_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAbout.AutoSize = true;
            this.lblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbout.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAbout.Location = new System.Drawing.Point(23, 298);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(39, 15);
            this.lblAbout.TabIndex = 8;
            this.lblAbout.Text = "About";
            this.lblAbout.Click += new System.EventHandler(this.LblAbout_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 126);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(115, 123);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 333);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.tileSignUp);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.tileLogin);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblID);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Resizable = false;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblRole;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTile tileLogin;
        public MetroFramework.Controls.MetroComboBox cmbRole;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroTile tileSignUp;
        private MetroFramework.Controls.MetroLabel lblAbout;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

