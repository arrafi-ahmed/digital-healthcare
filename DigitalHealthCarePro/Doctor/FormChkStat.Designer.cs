namespace DigitalHealthCarePro.Doctor
{
    partial class FormChkStat
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
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.pnlHp = new MetroFramework.Controls.MetroPanel();
            this.txtPayRcv = new MetroFramework.Controls.MetroTextBox();
            this.txtDocSent = new MetroFramework.Controls.MetroTextBox();
            this.txtSlotBlock = new MetroFramework.Controls.MetroTextBox();
            this.txtBookRcv = new MetroFramework.Controls.MetroTextBox();
            this.txtDayBlock = new MetroFramework.Controls.MetroTextBox();
            this.txtPendInc = new MetroFramework.Controls.MetroTextBox();
            this.lblDoc = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtConfInc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.cmbTimeRange = new MetroFramework.Controls.MetroComboBox();
            this.pnlHp.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel10
            // 
            this.metroLabel10.Location = new System.Drawing.Point(250, 60);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.TabIndex = 160;
            this.metroLabel10.Text = "User ID:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(487, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 158;
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
            this.labelTitle.TabIndex = 157;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(407, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 159;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(318, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 19);
            this.lblId.TabIndex = 161;
            this.lblId.Text = "metroLabel1";
            // 
            // pnlHp
            // 
            this.pnlHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHp.Controls.Add(this.txtPayRcv);
            this.pnlHp.Controls.Add(this.txtDocSent);
            this.pnlHp.Controls.Add(this.txtSlotBlock);
            this.pnlHp.Controls.Add(this.txtBookRcv);
            this.pnlHp.Controls.Add(this.txtDayBlock);
            this.pnlHp.Controls.Add(this.txtPendInc);
            this.pnlHp.Controls.Add(this.lblDoc);
            this.pnlHp.Controls.Add(this.metroLabel13);
            this.pnlHp.Controls.Add(this.metroLabel14);
            this.pnlHp.Controls.Add(this.txtConfInc);
            this.pnlHp.Controls.Add(this.metroLabel15);
            this.pnlHp.Controls.Add(this.metroLabel16);
            this.pnlHp.Controls.Add(this.metroLabel17);
            this.pnlHp.Controls.Add(this.metroLabel18);
            this.pnlHp.HorizontalScrollbarBarColor = true;
            this.pnlHp.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHp.HorizontalScrollbarSize = 10;
            this.pnlHp.Location = new System.Drawing.Point(23, 145);
            this.pnlHp.Name = "pnlHp";
            this.pnlHp.Size = new System.Drawing.Size(538, 124);
            this.pnlHp.TabIndex = 164;
            this.pnlHp.VerticalScrollbarBarColor = true;
            this.pnlHp.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHp.VerticalScrollbarSize = 10;
            // 
            // txtPayRcv
            // 
            // 
            // 
            // 
            this.txtPayRcv.CustomButton.Image = null;
            this.txtPayRcv.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtPayRcv.CustomButton.Name = "";
            this.txtPayRcv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPayRcv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayRcv.CustomButton.TabIndex = 1;
            this.txtPayRcv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayRcv.CustomButton.UseSelectable = true;
            this.txtPayRcv.CustomButton.Visible = false;
            this.txtPayRcv.Lines = new string[0];
            this.txtPayRcv.Location = new System.Drawing.Point(142, 63);
            this.txtPayRcv.MaxLength = 32767;
            this.txtPayRcv.Name = "txtPayRcv";
            this.txtPayRcv.PasswordChar = '\0';
            this.txtPayRcv.ReadOnly = true;
            this.txtPayRcv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayRcv.SelectedText = "";
            this.txtPayRcv.SelectionLength = 0;
            this.txtPayRcv.SelectionStart = 0;
            this.txtPayRcv.ShortcutsEnabled = true;
            this.txtPayRcv.Size = new System.Drawing.Size(119, 23);
            this.txtPayRcv.TabIndex = 15;
            this.txtPayRcv.UseSelectable = true;
            this.txtPayRcv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPayRcv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDocSent
            // 
            // 
            // 
            // 
            this.txtDocSent.CustomButton.Image = null;
            this.txtDocSent.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtDocSent.CustomButton.Name = "";
            this.txtDocSent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocSent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocSent.CustomButton.TabIndex = 1;
            this.txtDocSent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocSent.CustomButton.UseSelectable = true;
            this.txtDocSent.CustomButton.Visible = false;
            this.txtDocSent.Lines = new string[0];
            this.txtDocSent.Location = new System.Drawing.Point(142, 92);
            this.txtDocSent.MaxLength = 32767;
            this.txtDocSent.Name = "txtDocSent";
            this.txtDocSent.PasswordChar = '\0';
            this.txtDocSent.ReadOnly = true;
            this.txtDocSent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocSent.SelectedText = "";
            this.txtDocSent.SelectionLength = 0;
            this.txtDocSent.SelectionStart = 0;
            this.txtDocSent.ShortcutsEnabled = true;
            this.txtDocSent.Size = new System.Drawing.Size(119, 23);
            this.txtDocSent.TabIndex = 15;
            this.txtDocSent.UseSelectable = true;
            this.txtDocSent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocSent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSlotBlock
            // 
            // 
            // 
            // 
            this.txtSlotBlock.CustomButton.Image = null;
            this.txtSlotBlock.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtSlotBlock.CustomButton.Name = "";
            this.txtSlotBlock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSlotBlock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSlotBlock.CustomButton.TabIndex = 1;
            this.txtSlotBlock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSlotBlock.CustomButton.UseSelectable = true;
            this.txtSlotBlock.CustomButton.Visible = false;
            this.txtSlotBlock.Lines = new string[0];
            this.txtSlotBlock.Location = new System.Drawing.Point(414, 64);
            this.txtSlotBlock.MaxLength = 32767;
            this.txtSlotBlock.Name = "txtSlotBlock";
            this.txtSlotBlock.PasswordChar = '\0';
            this.txtSlotBlock.ReadOnly = true;
            this.txtSlotBlock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlotBlock.SelectedText = "";
            this.txtSlotBlock.SelectionLength = 0;
            this.txtSlotBlock.SelectionStart = 0;
            this.txtSlotBlock.ShortcutsEnabled = true;
            this.txtSlotBlock.Size = new System.Drawing.Size(119, 23);
            this.txtSlotBlock.TabIndex = 15;
            this.txtSlotBlock.UseSelectable = true;
            this.txtSlotBlock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSlotBlock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBookRcv
            // 
            // 
            // 
            // 
            this.txtBookRcv.CustomButton.Image = null;
            this.txtBookRcv.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtBookRcv.CustomButton.Name = "";
            this.txtBookRcv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBookRcv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookRcv.CustomButton.TabIndex = 1;
            this.txtBookRcv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookRcv.CustomButton.UseSelectable = true;
            this.txtBookRcv.CustomButton.Visible = false;
            this.txtBookRcv.Lines = new string[0];
            this.txtBookRcv.Location = new System.Drawing.Point(414, 6);
            this.txtBookRcv.MaxLength = 32767;
            this.txtBookRcv.Name = "txtBookRcv";
            this.txtBookRcv.PasswordChar = '\0';
            this.txtBookRcv.ReadOnly = true;
            this.txtBookRcv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookRcv.SelectedText = "";
            this.txtBookRcv.SelectionLength = 0;
            this.txtBookRcv.SelectionStart = 0;
            this.txtBookRcv.ShortcutsEnabled = true;
            this.txtBookRcv.Size = new System.Drawing.Size(119, 23);
            this.txtBookRcv.TabIndex = 15;
            this.txtBookRcv.UseSelectable = true;
            this.txtBookRcv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookRcv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDayBlock
            // 
            // 
            // 
            // 
            this.txtDayBlock.CustomButton.Image = null;
            this.txtDayBlock.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtDayBlock.CustomButton.Name = "";
            this.txtDayBlock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDayBlock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDayBlock.CustomButton.TabIndex = 1;
            this.txtDayBlock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDayBlock.CustomButton.UseSelectable = true;
            this.txtDayBlock.CustomButton.Visible = false;
            this.txtDayBlock.Lines = new string[0];
            this.txtDayBlock.Location = new System.Drawing.Point(414, 35);
            this.txtDayBlock.MaxLength = 32767;
            this.txtDayBlock.Name = "txtDayBlock";
            this.txtDayBlock.PasswordChar = '\0';
            this.txtDayBlock.ReadOnly = true;
            this.txtDayBlock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDayBlock.SelectedText = "";
            this.txtDayBlock.SelectionLength = 0;
            this.txtDayBlock.SelectionStart = 0;
            this.txtDayBlock.ShortcutsEnabled = true;
            this.txtDayBlock.Size = new System.Drawing.Size(119, 23);
            this.txtDayBlock.TabIndex = 15;
            this.txtDayBlock.UseSelectable = true;
            this.txtDayBlock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDayBlock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPendInc
            // 
            // 
            // 
            // 
            this.txtPendInc.CustomButton.Image = null;
            this.txtPendInc.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtPendInc.CustomButton.Name = "";
            this.txtPendInc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPendInc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPendInc.CustomButton.TabIndex = 1;
            this.txtPendInc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPendInc.CustomButton.UseSelectable = true;
            this.txtPendInc.CustomButton.Visible = false;
            this.txtPendInc.Lines = new string[0];
            this.txtPendInc.Location = new System.Drawing.Point(142, 34);
            this.txtPendInc.MaxLength = 32767;
            this.txtPendInc.Name = "txtPendInc";
            this.txtPendInc.PasswordChar = '\0';
            this.txtPendInc.ReadOnly = true;
            this.txtPendInc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPendInc.SelectedText = "";
            this.txtPendInc.SelectionLength = 0;
            this.txtPendInc.SelectionStart = 0;
            this.txtPendInc.ShortcutsEnabled = true;
            this.txtPendInc.Size = new System.Drawing.Size(119, 23);
            this.txtPendInc.TabIndex = 15;
            this.txtPendInc.UseSelectable = true;
            this.txtPendInc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPendInc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDoc.Location = new System.Drawing.Point(18, 92);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(118, 19);
            this.lblDoc.TabIndex = 14;
            this.lblDoc.Text = "Prescriptions Sent";
            this.lblDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(14, 6);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(122, 19);
            this.metroLabel13.TabIndex = 14;
            this.metroLabel13.Text = "Confirmed Income";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(315, 64);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(93, 19);
            this.metroLabel14.TabIndex = 14;
            this.metroLabel14.Text = "Slots Blocked ";
            // 
            // txtConfInc
            // 
            // 
            // 
            // 
            this.txtConfInc.CustomButton.Image = null;
            this.txtConfInc.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtConfInc.CustomButton.Name = "";
            this.txtConfInc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfInc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfInc.CustomButton.TabIndex = 1;
            this.txtConfInc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfInc.CustomButton.UseSelectable = true;
            this.txtConfInc.CustomButton.Visible = false;
            this.txtConfInc.Lines = new string[0];
            this.txtConfInc.Location = new System.Drawing.Point(142, 6);
            this.txtConfInc.MaxLength = 32767;
            this.txtConfInc.Name = "txtConfInc";
            this.txtConfInc.PasswordChar = '\0';
            this.txtConfInc.ReadOnly = true;
            this.txtConfInc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfInc.SelectedText = "";
            this.txtConfInc.SelectionLength = 0;
            this.txtConfInc.SelectionStart = 0;
            this.txtConfInc.ShortcutsEnabled = true;
            this.txtConfInc.Size = new System.Drawing.Size(119, 23);
            this.txtConfInc.TabIndex = 15;
            this.txtConfInc.UseSelectable = true;
            this.txtConfInc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfInc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(3, 63);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(133, 19);
            this.metroLabel15.TabIndex = 14;
            this.metroLabel15.Text = "Payments Receieved";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(314, 35);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(94, 19);
            this.metroLabel16.TabIndex = 14;
            this.metroLabel16.Text = "Days Blocked ";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(279, 6);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(129, 19);
            this.metroLabel17.TabIndex = 14;
            this.metroLabel17.Text = "Bookings Receieved";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(29, 34);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(107, 19);
            this.metroLabel18.TabIndex = 14;
            this.metroLabel18.Text = "Pending Income";
            // 
            // cmbTimeRange
            // 
            this.cmbTimeRange.FormattingEnabled = true;
            this.cmbTimeRange.ItemHeight = 23;
            this.cmbTimeRange.Items.AddRange(new object[] {
            "Today",
            "Last 30 Days",
            "Last 1 Year",
            "Lifetime"});
            this.cmbTimeRange.Location = new System.Drawing.Point(445, 110);
            this.cmbTimeRange.Name = "cmbTimeRange";
            this.cmbTimeRange.PromptText = "Time Range";
            this.cmbTimeRange.Size = new System.Drawing.Size(116, 29);
            this.cmbTimeRange.TabIndex = 163;
            this.cmbTimeRange.UseSelectable = true;
            this.cmbTimeRange.SelectedValueChanged += new System.EventHandler(this.CmbTimeRange_SelectedValueChanged);
            // 
            // FormChkStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 290);
            this.Controls.Add(this.pnlHp);
            this.Controls.Add(this.cmbTimeRange);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblId);
            this.MaximizeBox = false;
            this.Name = "FormChkStat";
            this.Resizable = false;
            this.Text = "Statitistics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChkStat_FormClosed);
            this.pnlHp.ResumeLayout(false);
            this.pnlHp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroPanel pnlHp;
        private MetroFramework.Controls.MetroTextBox txtPayRcv;
        private MetroFramework.Controls.MetroTextBox txtDocSent;
        private MetroFramework.Controls.MetroTextBox txtSlotBlock;
        private MetroFramework.Controls.MetroTextBox txtBookRcv;
        private MetroFramework.Controls.MetroTextBox txtDayBlock;
        private MetroFramework.Controls.MetroTextBox txtPendInc;
        private MetroFramework.Controls.MetroLabel lblDoc;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtConfInc;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroComboBox cmbTimeRange;
    }
}