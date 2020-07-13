namespace DigitalHealthCarePro.Hospital
{
    partial class FormHp
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
            this.tileRecentPatient = new MetroFramework.Controls.MetroTile();
            this.tileCheckPay = new MetroFramework.Controls.MetroTile();
            this.tileSendRep = new MetroFramework.Controls.MetroTile();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdmnId = new MetroFramework.Controls.MetroLabel();
            this.tileMngTest = new MetroFramework.Controls.MetroTile();
            this.tileCheckBooking = new MetroFramework.Controls.MetroTile();
            this.tileAccessReport = new MetroFramework.Controls.MetroTile();
            this.tileAccessPres = new MetroFramework.Controls.MetroTile();
            this.lblGreeting = new MetroFramework.Controls.MetroLabel();
            this.tileChkStat = new MetroFramework.Controls.MetroTile();
            this.btnEditHp = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1147, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // tileRecentPatient
            // 
            this.tileRecentPatient.ActiveControl = null;
            this.tileRecentPatient.Location = new System.Drawing.Point(293, 207);
            this.tileRecentPatient.Name = "tileRecentPatient";
            this.tileRecentPatient.Size = new System.Drawing.Size(150, 120);
            this.tileRecentPatient.TabIndex = 25;
            this.tileRecentPatient.Text = "Recent \r\nPatients";
            this.tileRecentPatient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileRecentPatient.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileRecentPatient.UseSelectable = true;
            this.tileRecentPatient.Click += new System.EventHandler(this.TileRecentPatient_Click);
            // 
            // tileCheckPay
            // 
            this.tileCheckPay.ActiveControl = null;
            this.tileCheckPay.Location = new System.Drawing.Point(995, 151);
            this.tileCheckPay.Name = "tileCheckPay";
            this.tileCheckPay.Size = new System.Drawing.Size(228, 50);
            this.tileCheckPay.TabIndex = 26;
            this.tileCheckPay.Text = "Check Payment";
            this.tileCheckPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCheckPay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCheckPay.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCheckPay.UseSelectable = true;
            this.tileCheckPay.Click += new System.EventHandler(this.TileCheckPay_Click);
            // 
            // tileSendRep
            // 
            this.tileSendRep.ActiveControl = null;
            this.tileSendRep.Location = new System.Drawing.Point(605, 207);
            this.tileSendRep.Name = "tileSendRep";
            this.tileSendRep.Size = new System.Drawing.Size(150, 120);
            this.tileSendRep.TabIndex = 27;
            this.tileSendRep.Text = "Send \r\nReport";
            this.tileSendRep.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSendRep.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSendRep.UseSelectable = true;
            this.tileSendRep.Click += new System.EventHandler(this.TileSendRep_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(23, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 19);
            this.labelTitle.TabIndex = 24;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(874, 56);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "User ID:";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(935, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 19);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "metroLabel1";
            // 
            // metroLabelAdmnId
            // 
            this.metroLabelAdmnId.AutoSize = true;
            this.metroLabelAdmnId.Location = new System.Drawing.Point(23, 79);
            this.metroLabelAdmnId.Name = "metroLabelAdmnId";
            this.metroLabelAdmnId.Size = new System.Drawing.Size(0, 0);
            this.metroLabelAdmnId.TabIndex = 23;
            // 
            // tileMngTest
            // 
            this.tileMngTest.ActiveControl = null;
            this.tileMngTest.Location = new System.Drawing.Point(917, 207);
            this.tileMngTest.Name = "tileMngTest";
            this.tileMngTest.Size = new System.Drawing.Size(150, 120);
            this.tileMngTest.TabIndex = 30;
            this.tileMngTest.Text = "Manage \r\nTests";
            this.tileMngTest.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileMngTest.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileMngTest.UseSelectable = true;
            this.tileMngTest.Click += new System.EventHandler(this.TileMngTest_Click);
            // 
            // tileCheckBooking
            // 
            this.tileCheckBooking.ActiveControl = null;
            this.tileCheckBooking.Location = new System.Drawing.Point(137, 207);
            this.tileCheckBooking.Name = "tileCheckBooking";
            this.tileCheckBooking.Size = new System.Drawing.Size(150, 120);
            this.tileCheckBooking.TabIndex = 31;
            this.tileCheckBooking.Text = "Check \r\nBooking";
            this.tileCheckBooking.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCheckBooking.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCheckBooking.UseSelectable = true;
            this.tileCheckBooking.Click += new System.EventHandler(this.TileCheckBooking_Click);
            // 
            // tileAccessReport
            // 
            this.tileAccessReport.ActiveControl = null;
            this.tileAccessReport.Location = new System.Drawing.Point(761, 207);
            this.tileAccessReport.Name = "tileAccessReport";
            this.tileAccessReport.Size = new System.Drawing.Size(150, 120);
            this.tileAccessReport.TabIndex = 32;
            this.tileAccessReport.Text = "Access\r\nReports";
            this.tileAccessReport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileAccessReport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileAccessReport.UseSelectable = true;
            this.tileAccessReport.Click += new System.EventHandler(this.TileAccessReport_Click);
            // 
            // tileAccessPres
            // 
            this.tileAccessPres.ActiveControl = null;
            this.tileAccessPres.Location = new System.Drawing.Point(449, 207);
            this.tileAccessPres.Name = "tileAccessPres";
            this.tileAccessPres.Size = new System.Drawing.Size(150, 120);
            this.tileAccessPres.TabIndex = 33;
            this.tileAccessPres.Text = "Access\r\nPrescriptions";
            this.tileAccessPres.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileAccessPres.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileAccessPres.UseSelectable = true;
            this.tileAccessPres.Click += new System.EventHandler(this.TileAccessPres_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGreeting.Location = new System.Drawing.Point(23, 120);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(164, 25);
            this.lblGreeting.TabIndex = 34;
            this.lblGreeting.Text = " Welcome Greetings";
            // 
            // tileChkStat
            // 
            this.tileChkStat.ActiveControl = null;
            this.tileChkStat.Location = new System.Drawing.Point(1073, 207);
            this.tileChkStat.Name = "tileChkStat";
            this.tileChkStat.Size = new System.Drawing.Size(150, 120);
            this.tileChkStat.TabIndex = 35;
            this.tileChkStat.Text = "Check \r\nStatistics";
            this.tileChkStat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileChkStat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileChkStat.UseSelectable = true;
            this.tileChkStat.Click += new System.EventHandler(this.TileChkStat_Click);
            // 
            // btnEditHp
            // 
            this.btnEditHp.Location = new System.Drawing.Point(1028, 56);
            this.btnEditHp.Name = "btnEditHp";
            this.btnEditHp.Size = new System.Drawing.Size(113, 23);
            this.btnEditHp.TabIndex = 36;
            this.btnEditHp.Text = "Edit Account";
            this.btnEditHp.UseSelectable = true;
            this.btnEditHp.Click += new System.EventHandler(this.BtnEditHp_Click);
            // 
            // FormHp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 350);
            this.Controls.Add(this.btnEditHp);
            this.Controls.Add(this.tileChkStat);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.tileAccessPres);
            this.Controls.Add(this.tileAccessReport);
            this.Controls.Add(this.tileCheckBooking);
            this.Controls.Add(this.tileMngTest);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tileRecentPatient);
            this.Controls.Add(this.tileCheckPay);
            this.Controls.Add(this.tileSendRep);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.metroLabelAdmnId);
            this.MaximizeBox = false;
            this.Name = "FormHp";
            this.Resizable = false;
            this.Text = "Hospital Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroTile tileRecentPatient;
        private MetroFramework.Controls.MetroTile tileCheckPay;
        private MetroFramework.Controls.MetroTile tileSendRep;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel metroLabelAdmnId;
        private MetroFramework.Controls.MetroTile tileMngTest;
        private MetroFramework.Controls.MetroTile tileCheckBooking;
        private MetroFramework.Controls.MetroTile tileAccessReport;
        private MetroFramework.Controls.MetroTile tileAccessPres;
        private MetroFramework.Controls.MetroLabel lblGreeting;
        private MetroFramework.Controls.MetroTile tileChkStat;
        private MetroFramework.Controls.MetroButton btnEditHp;
    }
}