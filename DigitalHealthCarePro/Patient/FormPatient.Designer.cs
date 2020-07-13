namespace DigitalHealthCarePro.Patient
{
    partial class FormPatient
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
            this.tileMakePayment = new MetroFramework.Controls.MetroTile();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdmnId = new MetroFramework.Controls.MetroLabel();
            this.tileOwnPres = new MetroFramework.Controls.MetroTile();
            this.ownReport = new MetroFramework.Controls.MetroTile();
            this.tileFindDoc = new MetroFramework.Controls.MetroTile();
            this.tileFindHp = new MetroFramework.Controls.MetroTile();
            this.lblGreeting = new MetroFramework.Controls.MetroLabel();
            this.btnEditHp = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(696, 63);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // tileMakePayment
            // 
            this.tileMakePayment.ActiveControl = null;
            this.tileMakePayment.Location = new System.Drawing.Point(541, 151);
            this.tileMakePayment.Name = "tileMakePayment";
            this.tileMakePayment.Size = new System.Drawing.Size(229, 50);
            this.tileMakePayment.TabIndex = 16;
            this.tileMakePayment.Text = "Recent Payments";
            this.tileMakePayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileMakePayment.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileMakePayment.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileMakePayment.UseSelectable = true;
            this.tileMakePayment.Click += new System.EventHandler(this.TileMakePayment_Click);
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
            this.metroLabel3.Location = new System.Drawing.Point(422, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "User ID:";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(489, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 19);
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
            // tileOwnPres
            // 
            this.tileOwnPres.ActiveControl = null;
            this.tileOwnPres.Location = new System.Drawing.Point(464, 207);
            this.tileOwnPres.Name = "tileOwnPres";
            this.tileOwnPres.Size = new System.Drawing.Size(150, 120);
            this.tileOwnPres.TabIndex = 19;
            this.tileOwnPres.Text = "Own \r\nPrescriptions";
            this.tileOwnPres.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileOwnPres.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileOwnPres.UseSelectable = true;
            this.tileOwnPres.Click += new System.EventHandler(this.TileOwnPres_Click);
            // 
            // ownReport
            // 
            this.ownReport.ActiveControl = null;
            this.ownReport.Location = new System.Drawing.Point(620, 207);
            this.ownReport.Name = "ownReport";
            this.ownReport.Size = new System.Drawing.Size(150, 120);
            this.ownReport.TabIndex = 20;
            this.ownReport.Text = "Own \r\nReports";
            this.ownReport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ownReport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ownReport.UseSelectable = true;
            this.ownReport.Click += new System.EventHandler(this.OwnReport_Click);
            // 
            // tileFindDoc
            // 
            this.tileFindDoc.ActiveControl = null;
            this.tileFindDoc.Location = new System.Drawing.Point(152, 207);
            this.tileFindDoc.Name = "tileFindDoc";
            this.tileFindDoc.Size = new System.Drawing.Size(150, 120);
            this.tileFindDoc.TabIndex = 21;
            this.tileFindDoc.Text = "Find \r\nDoctors";
            this.tileFindDoc.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileFindDoc.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileFindDoc.UseSelectable = true;
            this.tileFindDoc.Click += new System.EventHandler(this.TileFindDoc_Click);
            // 
            // tileFindHp
            // 
            this.tileFindHp.ActiveControl = null;
            this.tileFindHp.Location = new System.Drawing.Point(308, 207);
            this.tileFindHp.Name = "tileFindHp";
            this.tileFindHp.Size = new System.Drawing.Size(150, 120);
            this.tileFindHp.TabIndex = 22;
            this.tileFindHp.Text = "Find \rHospitals";
            this.tileFindHp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileFindHp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileFindHp.UseSelectable = true;
            this.tileFindHp.Click += new System.EventHandler(this.TileFindHp_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGreeting.Location = new System.Drawing.Point(23, 120);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(164, 25);
            this.lblGreeting.TabIndex = 35;
            this.lblGreeting.Text = " Welcome Greetings";
            // 
            // btnEditHp
            // 
            this.btnEditHp.Location = new System.Drawing.Point(577, 63);
            this.btnEditHp.Name = "btnEditHp";
            this.btnEditHp.Size = new System.Drawing.Size(113, 23);
            this.btnEditHp.TabIndex = 37;
            this.btnEditHp.Text = "Edit Account";
            this.btnEditHp.UseSelectable = true;
            this.btnEditHp.Click += new System.EventHandler(this.BtnEditHp_Click);
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 350);
            this.Controls.Add(this.btnEditHp);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.tileFindHp);
            this.Controls.Add(this.tileFindDoc);
            this.Controls.Add(this.ownReport);
            this.Controls.Add(this.tileOwnPres);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tileMakePayment);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.metroLabelAdmnId);
            this.MaximizeBox = false;
            this.Name = "FormPatient";
            this.Resizable = false;
            this.Text = "Patient Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPatient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroTile tileMakePayment;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel metroLabelAdmnId;
        private MetroFramework.Controls.MetroTile tileOwnPres;
        private MetroFramework.Controls.MetroTile ownReport;
        private MetroFramework.Controls.MetroTile tileFindDoc;
        private MetroFramework.Controls.MetroTile tileFindHp;
        private MetroFramework.Controls.MetroLabel lblGreeting;
        private MetroFramework.Controls.MetroButton btnEditHp;
    }
}