namespace DigitalHealthCarePro.Doctor
{
    partial class FormDoctor
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
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.tileCheckBooking = new MetroFramework.Controls.MetroTile();
            this.tileCheckPay = new MetroFramework.Controls.MetroTile();
            this.tileSendPres = new MetroFramework.Controls.MetroTile();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdmnId = new MetroFramework.Controls.MetroLabel();
            this.tileAccessRep = new MetroFramework.Controls.MetroTile();
            this.tileAccessPres = new MetroFramework.Controls.MetroTile();
            this.tileRecentPat = new MetroFramework.Controls.MetroTile();
            this.lblGreeting = new MetroFramework.Controls.MetroLabel();
            this.tileCheckStat = new MetroFramework.Controls.MetroTile();
            this.btnEditDoc = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(997, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // tileCheckBooking
            // 
            this.tileCheckBooking.ActiveControl = null;
            this.tileCheckBooking.Location = new System.Drawing.Point(141, 207);
            this.tileCheckBooking.Name = "tileCheckBooking";
            this.tileCheckBooking.Size = new System.Drawing.Size(150, 120);
            this.tileCheckBooking.TabIndex = 14;
            this.tileCheckBooking.Text = "Check \r\nBookings";
            this.tileCheckBooking.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCheckBooking.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCheckBooking.UseSelectable = true;
            this.tileCheckBooking.Click += new System.EventHandler(this.TileCheckBooking_Click);
            // 
            // tileCheckPay
            // 
            this.tileCheckPay.ActiveControl = null;
            this.tileCheckPay.Location = new System.Drawing.Point(843, 151);
            this.tileCheckPay.Name = "tileCheckPay";
            this.tileCheckPay.Size = new System.Drawing.Size(229, 50);
            this.tileCheckPay.TabIndex = 16;
            this.tileCheckPay.Text = "Check Payment";
            this.tileCheckPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCheckPay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCheckPay.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCheckPay.UseSelectable = true;
            this.tileCheckPay.Click += new System.EventHandler(this.TileCheckPay_Click);
            // 
            // tileSendPres
            // 
            this.tileSendPres.ActiveControl = null;
            this.tileSendPres.Location = new System.Drawing.Point(609, 207);
            this.tileSendPres.Name = "tileSendPres";
            this.tileSendPres.Size = new System.Drawing.Size(150, 120);
            this.tileSendPres.TabIndex = 17;
            this.tileSendPres.Text = "Send \r\nPrescription";
            this.tileSendPres.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSendPres.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSendPres.UseSelectable = true;
            this.tileSendPres.Click += new System.EventHandler(this.TileSendPres_Click);
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
            this.metroLabel3.Location = new System.Drawing.Point(734, 56);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "User ID:";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(797, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 19);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "metroLabel1";
            // 
            // metroLabelAdmnId
            // 
            this.metroLabelAdmnId.AutoSize = true;
            this.metroLabelAdmnId.Location = new System.Drawing.Point(23, 79);
            this.metroLabelAdmnId.Name = "metroLabelAdmnId";
            this.metroLabelAdmnId.Size = new System.Drawing.Size(0, 0);
            this.metroLabelAdmnId.TabIndex = 12;
            // 
            // tileAccessRep
            // 
            this.tileAccessRep.ActiveControl = null;
            this.tileAccessRep.Location = new System.Drawing.Point(453, 207);
            this.tileAccessRep.Name = "tileAccessRep";
            this.tileAccessRep.Size = new System.Drawing.Size(150, 120);
            this.tileAccessRep.TabIndex = 19;
            this.tileAccessRep.Text = "Access \r\nReports";
            this.tileAccessRep.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileAccessRep.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileAccessRep.UseSelectable = true;
            this.tileAccessRep.Click += new System.EventHandler(this.TileAccessRep_Click);
            // 
            // tileAccessPres
            // 
            this.tileAccessPres.ActiveControl = null;
            this.tileAccessPres.Location = new System.Drawing.Point(765, 207);
            this.tileAccessPres.Name = "tileAccessPres";
            this.tileAccessPres.Size = new System.Drawing.Size(150, 120);
            this.tileAccessPres.TabIndex = 20;
            this.tileAccessPres.Text = "Access \r\nPrescriptions";
            this.tileAccessPres.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileAccessPres.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileAccessPres.UseSelectable = true;
            this.tileAccessPres.Click += new System.EventHandler(this.TileAccessPres_Click);
            // 
            // tileRecentPat
            // 
            this.tileRecentPat.ActiveControl = null;
            this.tileRecentPat.AutoSize = true;
            this.tileRecentPat.Location = new System.Drawing.Point(297, 207);
            this.tileRecentPat.Name = "tileRecentPat";
            this.tileRecentPat.Size = new System.Drawing.Size(150, 120);
            this.tileRecentPat.TabIndex = 21;
            this.tileRecentPat.Text = "Recent \r\nPatients";
            this.tileRecentPat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileRecentPat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileRecentPat.UseSelectable = true;
            this.tileRecentPat.Click += new System.EventHandler(this.TileRecentPat_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGreeting.Location = new System.Drawing.Point(23, 120);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(164, 25);
            this.lblGreeting.TabIndex = 22;
            this.lblGreeting.Text = " Welcome Greetings";
            // 
            // tileCheckStat
            // 
            this.tileCheckStat.ActiveControl = null;
            this.tileCheckStat.Location = new System.Drawing.Point(921, 207);
            this.tileCheckStat.Name = "tileCheckStat";
            this.tileCheckStat.Size = new System.Drawing.Size(150, 120);
            this.tileCheckStat.TabIndex = 23;
            this.tileCheckStat.Text = "Check \r\nStatistics";
            this.tileCheckStat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCheckStat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCheckStat.UseSelectable = true;
            this.tileCheckStat.Click += new System.EventHandler(this.TileCheckStat_Click);
            // 
            // btnEditDoc
            // 
            this.btnEditDoc.Location = new System.Drawing.Point(888, 56);
            this.btnEditDoc.Name = "btnEditDoc";
            this.btnEditDoc.Size = new System.Drawing.Size(103, 23);
            this.btnEditDoc.TabIndex = 24;
            this.btnEditDoc.Text = "Edit Account";
            this.btnEditDoc.UseSelectable = true;
            this.btnEditDoc.Click += new System.EventHandler(this.BtnEditDoc_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 350);
            this.Controls.Add(this.btnEditDoc);
            this.Controls.Add(this.tileCheckStat);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.tileRecentPat);
            this.Controls.Add(this.tileAccessPres);
            this.Controls.Add(this.tileAccessRep);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tileCheckBooking);
            this.Controls.Add(this.tileCheckPay);
            this.Controls.Add(this.tileSendPres);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.metroLabelAdmnId);
            this.MaximizeBox = false;
            this.Name = "FormDoctor";
            this.Resizable = false;
            this.Text = "Doctor Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDoctor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroTile tileCheckBooking;
        private MetroFramework.Controls.MetroTile tileCheckPay;
        private MetroFramework.Controls.MetroTile tileSendPres;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel metroLabelAdmnId;
        private MetroFramework.Controls.MetroTile tileAccessRep;
        private MetroFramework.Controls.MetroTile tileAccessPres;
        private MetroFramework.Controls.MetroTile tileRecentPat;
        private MetroFramework.Controls.MetroLabel lblGreeting;
        private MetroFramework.Controls.MetroTile tileCheckStat;
        private MetroFramework.Controls.MetroButton btnEditDoc;
    }
}