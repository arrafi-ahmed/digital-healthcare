namespace DigitalHealthCarePro.Hospital
{
    partial class FormChkBook
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
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.cmbTest = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtpChkBookHp = new System.Windows.Forms.DateTimePicker();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.totalSlotsN = new MetroFramework.Controls.MetroLabel();
            this.totalSlotsA = new MetroFramework.Controls.MetroLabel();
            this.totalSlotsM = new MetroFramework.Controls.MetroLabel();
            this.bookedSlotsN = new MetroFramework.Controls.MetroLabel();
            this.bookedSlotsA = new MetroFramework.Controls.MetroLabel();
            this.bookedSlotsM = new MetroFramework.Controls.MetroLabel();
            this.availableSlotsN = new MetroFramework.Controls.MetroLabel();
            this.availableSlotsA = new MetroFramework.Controls.MetroLabel();
            this.availableSlotsM = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnBlockDay = new MetroFramework.Controls.MetroButton();
            this.btnBlockSlot = new MetroFramework.Controls.MetroButton();
            this.cmbSlot = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.blockDateInfo = new MetroFramework.Controls.MetroLabel();
            this.blockSlotInfo = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(23, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 19);
            this.labelTitle.TabIndex = 61;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(242, 60);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(54, 19);
            this.metroLabel10.TabIndex = 59;
            this.metroLabel10.Text = "User ID:";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(302, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(81, 19);
            this.lblId.TabIndex = 60;
            this.lblId.Text = "metroLabel1";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Location = new System.Drawing.Point(394, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 58;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Location = new System.Drawing.Point(474, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 57;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // cmbTest
            // 
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.ItemHeight = 23;
            this.cmbTest.Location = new System.Drawing.Point(102, 161);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(210, 29);
            this.cmbTest.TabIndex = 73;
            this.cmbTest.UseSelectable = true;
            this.cmbTest.SelectedValueChanged += new System.EventHandler(this.CmbTest_SelectedValueChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 166);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(73, 19);
            this.metroLabel9.TabIndex = 70;
            this.metroLabel9.Text = "Test Name:";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(57, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 72;
            this.metroLabel3.Text = "Date:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpChkBookHp
            // 
            this.dtpChkBookHp.CustomFormat = "dddd , dd , MMMM , yyyy";
            this.dtpChkBookHp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChkBookHp.Location = new System.Drawing.Point(102, 135);
            this.dtpChkBookHp.Name = "dtpChkBookHp";
            this.dtpChkBookHp.Size = new System.Drawing.Size(210, 20);
            this.dtpChkBookHp.TabIndex = 69;
            this.dtpChkBookHp.ValueChanged += new System.EventHandler(this.DtpChkBookHp_ValueChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.totalSlotsN);
            this.metroPanel1.Controls.Add(this.totalSlotsA);
            this.metroPanel1.Controls.Add(this.totalSlotsM);
            this.metroPanel1.Controls.Add(this.bookedSlotsN);
            this.metroPanel1.Controls.Add(this.bookedSlotsA);
            this.metroPanel1.Controls.Add(this.bookedSlotsM);
            this.metroPanel1.Controls.Add(this.availableSlotsN);
            this.metroPanel1.Controls.Add(this.availableSlotsA);
            this.metroPanel1.Controls.Add(this.availableSlotsM);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 293);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(525, 149);
            this.metroPanel1.TabIndex = 78;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // totalSlotsN
            // 
            this.totalSlotsN.AutoSize = true;
            this.totalSlotsN.Location = new System.Drawing.Point(440, 114);
            this.totalSlotsN.Name = "totalSlotsN";
            this.totalSlotsN.Size = new System.Drawing.Size(13, 19);
            this.totalSlotsN.TabIndex = 84;
            this.totalSlotsN.Text = " ";
            // 
            // totalSlotsA
            // 
            this.totalSlotsA.AutoSize = true;
            this.totalSlotsA.Location = new System.Drawing.Point(300, 114);
            this.totalSlotsA.Name = "totalSlotsA";
            this.totalSlotsA.Size = new System.Drawing.Size(13, 19);
            this.totalSlotsA.TabIndex = 85;
            this.totalSlotsA.Text = " ";
            // 
            // totalSlotsM
            // 
            this.totalSlotsM.AutoSize = true;
            this.totalSlotsM.Location = new System.Drawing.Point(155, 114);
            this.totalSlotsM.Name = "totalSlotsM";
            this.totalSlotsM.Size = new System.Drawing.Size(13, 19);
            this.totalSlotsM.TabIndex = 86;
            this.totalSlotsM.Text = " ";
            // 
            // bookedSlotsN
            // 
            this.bookedSlotsN.AutoSize = true;
            this.bookedSlotsN.Location = new System.Drawing.Point(440, 52);
            this.bookedSlotsN.Name = "bookedSlotsN";
            this.bookedSlotsN.Size = new System.Drawing.Size(13, 19);
            this.bookedSlotsN.TabIndex = 87;
            this.bookedSlotsN.Text = " ";
            // 
            // bookedSlotsA
            // 
            this.bookedSlotsA.AutoSize = true;
            this.bookedSlotsA.Location = new System.Drawing.Point(300, 52);
            this.bookedSlotsA.Name = "bookedSlotsA";
            this.bookedSlotsA.Size = new System.Drawing.Size(13, 19);
            this.bookedSlotsA.TabIndex = 88;
            this.bookedSlotsA.Text = " ";
            // 
            // bookedSlotsM
            // 
            this.bookedSlotsM.AutoSize = true;
            this.bookedSlotsM.Location = new System.Drawing.Point(155, 52);
            this.bookedSlotsM.Name = "bookedSlotsM";
            this.bookedSlotsM.Size = new System.Drawing.Size(13, 19);
            this.bookedSlotsM.TabIndex = 89;
            this.bookedSlotsM.Text = " ";
            // 
            // availableSlotsN
            // 
            this.availableSlotsN.AutoSize = true;
            this.availableSlotsN.Location = new System.Drawing.Point(440, 83);
            this.availableSlotsN.Name = "availableSlotsN";
            this.availableSlotsN.Size = new System.Drawing.Size(13, 19);
            this.availableSlotsN.TabIndex = 90;
            this.availableSlotsN.Text = " ";
            // 
            // availableSlotsA
            // 
            this.availableSlotsA.AutoSize = true;
            this.availableSlotsA.Location = new System.Drawing.Point(300, 83);
            this.availableSlotsA.Name = "availableSlotsA";
            this.availableSlotsA.Size = new System.Drawing.Size(13, 19);
            this.availableSlotsA.TabIndex = 91;
            this.availableSlotsA.Text = " ";
            // 
            // availableSlotsM
            // 
            this.availableSlotsM.AutoSize = true;
            this.availableSlotsM.Location = new System.Drawing.Point(155, 83);
            this.availableSlotsM.Name = "availableSlotsM";
            this.availableSlotsM.Size = new System.Drawing.Size(13, 19);
            this.availableSlotsM.TabIndex = 92;
            this.availableSlotsM.Text = " ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(427, 14);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 78;
            this.metroLabel8.Text = "Night";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(273, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 79;
            this.metroLabel2.Text = "Afternoon";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(132, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 80;
            this.metroLabel1.Text = "Morning";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(26, 114);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(70, 19);
            this.metroLabel13.TabIndex = 81;
            this.metroLabel13.Text = "Total Slots:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(1, 83);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(96, 19);
            this.metroLabel12.TabIndex = 82;
            this.metroLabel12.Text = "Available Slots:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 52);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 83;
            this.metroLabel4.Text = "Booked Slots:";
            // 
            // btnBlockDay
            // 
            this.btnBlockDay.Location = new System.Drawing.Point(210, 234);
            this.btnBlockDay.Name = "btnBlockDay";
            this.btnBlockDay.Size = new System.Drawing.Size(102, 23);
            this.btnBlockDay.TabIndex = 79;
            this.btnBlockDay.Text = "Block Day";
            this.btnBlockDay.UseSelectable = true;
            this.btnBlockDay.Click += new System.EventHandler(this.BtnBlockDay_Click);
            // 
            // btnBlockSlot
            // 
            this.btnBlockSlot.Location = new System.Drawing.Point(102, 234);
            this.btnBlockSlot.Name = "btnBlockSlot";
            this.btnBlockSlot.Size = new System.Drawing.Size(102, 23);
            this.btnBlockSlot.TabIndex = 80;
            this.btnBlockSlot.Text = "Block Slot";
            this.btnBlockSlot.UseSelectable = true;
            this.btnBlockSlot.Click += new System.EventHandler(this.BtnBlockSlot_Click);
            // 
            // cmbSlot
            // 
            this.cmbSlot.FormattingEnabled = true;
            this.cmbSlot.ItemHeight = 23;
            this.cmbSlot.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Night"});
            this.cmbSlot.Location = new System.Drawing.Point(102, 196);
            this.cmbSlot.Name = "cmbSlot";
            this.cmbSlot.Size = new System.Drawing.Size(210, 29);
            this.cmbSlot.TabIndex = 82;
            this.cmbSlot.UseSelectable = true;
            this.cmbSlot.SelectedValueChanged += new System.EventHandler(this.CmbSlot_SelectedValueChanged);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(62, 200);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(34, 19);
            this.metroLabel16.TabIndex = 81;
            this.metroLabel16.Text = "Slot:";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // blockDateInfo
            // 
            this.blockDateInfo.AutoSize = true;
            this.blockDateInfo.Location = new System.Drawing.Point(323, 136);
            this.blockDateInfo.Name = "blockDateInfo";
            this.blockDateInfo.Size = new System.Drawing.Size(123, 19);
            this.blockDateInfo.TabIndex = 70;
            this.blockDateInfo.Text = "This date is blocked";
            this.blockDateInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // blockSlotInfo
            // 
            this.blockSlotInfo.AutoSize = true;
            this.blockSlotInfo.Location = new System.Drawing.Point(323, 200);
            this.blockSlotInfo.Name = "blockSlotInfo";
            this.blockSlotInfo.Size = new System.Drawing.Size(117, 19);
            this.blockSlotInfo.TabIndex = 70;
            this.blockSlotInfo.Text = "This slot is blocked";
            this.blockSlotInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormChkBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 465);
            this.Controls.Add(this.cmbSlot);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.btnBlockSlot);
            this.Controls.Add(this.btnBlockDay);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.cmbTest);
            this.Controls.Add(this.blockSlotInfo);
            this.Controls.Add(this.blockDateInfo);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtpChkBookHp);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.MaximizeBox = false;
            this.Name = "FormChkBook";
            this.Resizable = false;
            this.Text = "Check Bookings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChkBook_FormClosed);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroComboBox cmbTest;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dtpChkBookHp;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel totalSlotsN;
        private MetroFramework.Controls.MetroLabel totalSlotsA;
        private MetroFramework.Controls.MetroLabel totalSlotsM;
        private MetroFramework.Controls.MetroLabel bookedSlotsN;
        private MetroFramework.Controls.MetroLabel bookedSlotsA;
        private MetroFramework.Controls.MetroLabel bookedSlotsM;
        private MetroFramework.Controls.MetroLabel availableSlotsN;
        private MetroFramework.Controls.MetroLabel availableSlotsA;
        private MetroFramework.Controls.MetroLabel availableSlotsM;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnBlockDay;
        private MetroFramework.Controls.MetroButton btnBlockSlot;
        private MetroFramework.Controls.MetroComboBox cmbSlot;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel blockDateInfo;
        private MetroFramework.Controls.MetroLabel blockSlotInfo;
    }
}