namespace DigitalHealthCarePro.Admin
{
    partial class FormAdmin
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
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tileHospital = new MetroFramework.Controls.MetroTile();
            this.tilePatient = new MetroFramework.Controls.MetroTile();
            this.tileDoctor = new MetroFramework.Controls.MetroTile();
            this.tileChkTransaction = new MetroFramework.Controls.MetroTile();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.tileChkStat = new MetroFramework.Controls.MetroTile();
            this.lblGreeting = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(23, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 19);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(600, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "metroLabel1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(538, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "User ID:";
            // 
            // tileHospital
            // 
            this.tileHospital.ActiveControl = null;
            this.tileHospital.Location = new System.Drawing.Point(299, 207);
            this.tileHospital.Name = "tileHospital";
            this.tileHospital.Size = new System.Drawing.Size(150, 120);
            this.tileHospital.TabIndex = 8;
            this.tileHospital.Text = "Manage\r\nHospitals";
            this.tileHospital.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileHospital.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileHospital.UseSelectable = true;
            this.tileHospital.Click += new System.EventHandler(this.TileHospital_Click);
            // 
            // tilePatient
            // 
            this.tilePatient.ActiveControl = null;
            this.tilePatient.Location = new System.Drawing.Point(455, 207);
            this.tilePatient.Name = "tilePatient";
            this.tilePatient.Size = new System.Drawing.Size(150, 120);
            this.tilePatient.TabIndex = 8;
            this.tilePatient.Text = "Manage \r\nPatients";
            this.tilePatient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePatient.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePatient.UseSelectable = true;
            this.tilePatient.Click += new System.EventHandler(this.TilePatient_Click);
            // 
            // tileDoctor
            // 
            this.tileDoctor.ActiveControl = null;
            this.tileDoctor.Location = new System.Drawing.Point(143, 207);
            this.tileDoctor.Name = "tileDoctor";
            this.tileDoctor.Size = new System.Drawing.Size(150, 120);
            this.tileDoctor.TabIndex = 8;
            this.tileDoctor.Text = "Manage\r\nDoctors";
            this.tileDoctor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileDoctor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDoctor.UseSelectable = true;
            this.tileDoctor.Click += new System.EventHandler(this.TileDoctor_Click);
            // 
            // tileChkTransaction
            // 
            this.tileChkTransaction.ActiveControl = null;
            this.tileChkTransaction.Location = new System.Drawing.Point(538, 151);
            this.tileChkTransaction.Name = "tileChkTransaction";
            this.tileChkTransaction.Size = new System.Drawing.Size(223, 50);
            this.tileChkTransaction.TabIndex = 8;
            this.tileChkTransaction.Text = "Check Transactions";
            this.tileChkTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileChkTransaction.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileChkTransaction.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileChkTransaction.UseSelectable = true;
            this.tileChkTransaction.Click += new System.EventHandler(this.TileCheckTransaction_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(688, 63);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // tileChkStat
            // 
            this.tileChkStat.ActiveControl = null;
            this.tileChkStat.Location = new System.Drawing.Point(611, 207);
            this.tileChkStat.Name = "tileChkStat";
            this.tileChkStat.Size = new System.Drawing.Size(150, 120);
            this.tileChkStat.TabIndex = 10;
            this.tileChkStat.Text = "Check \r\nStatistics";
            this.tileChkStat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileChkStat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileChkStat.UseSelectable = true;
            this.tileChkStat.Click += new System.EventHandler(this.TileChkStat_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGreeting.Location = new System.Drawing.Point(23, 120);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(164, 25);
            this.lblGreeting.TabIndex = 11;
            this.lblGreeting.Text = " Welcome Greetings";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 350);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.tileChkStat);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tilePatient);
            this.Controls.Add(this.tileDoctor);
            this.Controls.Add(this.tileChkTransaction);
            this.Controls.Add(this.tileHospital);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Admin Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile tileHospital;
        private MetroFramework.Controls.MetroTile tilePatient;
        private MetroFramework.Controls.MetroTile tileDoctor;
        private MetroFramework.Controls.MetroTile tileChkTransaction;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroTile tileChkStat;
        private MetroFramework.Controls.MetroLabel lblGreeting;
    }
}