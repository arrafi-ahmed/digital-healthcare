namespace DigitalHealthCarePro.Doctor
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
            this.lblIdPat = new MetroFramework.Controls.MetroLabel();
            this.tTipShowSlots = new MetroFramework.Components.MetroToolTip();
            this.btnAvailableSlots = new MetroFramework.Controls.MetroButton();
            this.tTipConfirm = new MetroFramework.Components.MetroToolTip();
            this.dtpBookDoc = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdmnId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblAge = new MetroFramework.Controls.MetroLabel();
            this.lblBloodG = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblIdDoc = new MetroFramework.Controls.MetroLabel();
            this.btnSet = new MetroFramework.Controls.MetroButton();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.pnlSlotDetails = new MetroFramework.Controls.MetroPanel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tTipWholeDay = new MetroFramework.Components.MetroToolTip();
            this.btnBlockDay = new MetroFramework.Controls.MetroButton();
            this.pnlSlotDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdPat
            // 
            this.lblIdPat.AutoSize = true;
            this.lblIdPat.Location = new System.Drawing.Point(69, -2);
            this.lblIdPat.Name = "lblIdPat";
            this.lblIdPat.Size = new System.Drawing.Size(13, 19);
            this.lblIdPat.TabIndex = 119;
            this.lblIdPat.Text = " ";
            // 
            // tTipShowSlots
            // 
            this.tTipShowSlots.AutomaticDelay = 300;
            this.tTipShowSlots.AutoPopDelay = 5000;
            this.tTipShowSlots.InitialDelay = 200;
            this.tTipShowSlots.ReshowDelay = 40;
            this.tTipShowSlots.Style = MetroFramework.MetroColorStyle.Blue;
            this.tTipShowSlots.StyleManager = null;
            this.tTipShowSlots.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // btnAvailableSlots
            // 
            this.btnAvailableSlots.AutoSize = true;
            this.btnAvailableSlots.Location = new System.Drawing.Point(388, 145);
            this.btnAvailableSlots.Name = "btnAvailableSlots";
            this.btnAvailableSlots.Size = new System.Drawing.Size(86, 49);
            this.btnAvailableSlots.TabIndex = 102;
            this.btnAvailableSlots.Text = "Show Valid \r\nBookings";
            this.tTipShowSlots.SetToolTip(this.btnAvailableSlots, "Available slots are unchecked,\r\nUnavailable slots are checked.");
            this.btnAvailableSlots.UseSelectable = true;
            this.btnAvailableSlots.Click += new System.EventHandler(this.BtnAvailableSlots_Click);
            // 
            // tTipConfirm
            // 
            this.tTipConfirm.AutomaticDelay = 300;
            this.tTipConfirm.AutoPopDelay = 5000;
            this.tTipConfirm.InitialDelay = 200;
            this.tTipConfirm.ReshowDelay = 60;
            this.tTipConfirm.Style = MetroFramework.MetroColorStyle.Blue;
            this.tTipConfirm.StyleManager = null;
            this.tTipConfirm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dtpBookDoc
            // 
            this.dtpBookDoc.CustomFormat = "dddd , dd , MMMM , yyyy,    ( HH:mm tt )";
            this.dtpBookDoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookDoc.Location = new System.Drawing.Point(101, 145);
            this.dtpBookDoc.Name = "dtpBookDoc";
            this.dtpBookDoc.Size = new System.Drawing.Size(281, 20);
            this.dtpBookDoc.TabIndex = 117;
            this.tTipConfirm.SetToolTip(this.dtpBookDoc, "You can book next 30 days range from today");
            this.dtpBookDoc.ValueChanged += new System.EventHandler(this.DtpBookDoc_ValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 143);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 118;
            this.metroLabel3.Text = "Select Slot:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 270);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 116;
            this.metroLabel4.Text = "Booked Slots:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 115;
            this.metroLabel1.Text = "Digital HealthCare";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabelAdmnId
            // 
            this.metroLabelAdmnId.AutoSize = true;
            this.metroLabelAdmnId.Location = new System.Drawing.Point(23, 79);
            this.metroLabelAdmnId.Name = "metroLabelAdmnId";
            this.metroLabelAdmnId.Size = new System.Drawing.Size(0, 0);
            this.metroLabelAdmnId.TabIndex = 114;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(351, -2);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 19);
            this.metroLabel6.TabIndex = 109;
            this.metroLabel6.Text = "Blood Group:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(206, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 107;
            this.metroLabel5.Text = "Age:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 108;
            this.metroLabel2.Text = "Name:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(24, 19);
            this.metroLabel7.TabIndex = 106;
            this.metroLabel7.Text = "ID:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(764, 60);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(54, 19);
            this.metroLabel8.TabIndex = 105;
            this.metroLabel8.Text = "User ID:";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(248, 1);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(13, 19);
            this.lblAge.TabIndex = 110;
            this.lblAge.Text = " ";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBloodG
            // 
            this.lblBloodG.AutoSize = true;
            this.lblBloodG.Location = new System.Drawing.Point(445, -2);
            this.lblBloodG.Name = "lblBloodG";
            this.lblBloodG.Size = new System.Drawing.Size(13, 19);
            this.lblBloodG.TabIndex = 111;
            this.lblBloodG.Text = " ";
            this.lblBloodG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 19);
            this.lblName.TabIndex = 112;
            this.lblName.Text = " ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdDoc
            // 
            this.lblIdDoc.AutoSize = true;
            this.lblIdDoc.Location = new System.Drawing.Point(836, 60);
            this.lblIdDoc.Name = "lblIdDoc";
            this.lblIdDoc.Size = new System.Drawing.Size(81, 19);
            this.lblIdDoc.TabIndex = 113;
            this.lblIdDoc.Text = "metroLabel1";
            this.lblIdDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSet
            // 
            this.btnSet.AutoSize = true;
            this.btnSet.Location = new System.Drawing.Point(101, 171);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(140, 23);
            this.btnSet.TabIndex = 103;
            this.btnSet.Text = "Block Slot";
            this.btnSet.UseSelectable = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Location = new System.Drawing.Point(928, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 104;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Location = new System.Drawing.Point(1008, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 101;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pnlSlotDetails
            // 
            this.pnlSlotDetails.Controls.Add(this.lblIdPat);
            this.pnlSlotDetails.Controls.Add(this.metroLabel2);
            this.pnlSlotDetails.Controls.Add(this.lblName);
            this.pnlSlotDetails.Controls.Add(this.lblBloodG);
            this.pnlSlotDetails.Controls.Add(this.lblPhone);
            this.pnlSlotDetails.Controls.Add(this.lblAge);
            this.pnlSlotDetails.Controls.Add(this.metroLabel7);
            this.pnlSlotDetails.Controls.Add(this.metroLabel6);
            this.pnlSlotDetails.Controls.Add(this.lblAddress);
            this.pnlSlotDetails.Controls.Add(this.metroLabel10);
            this.pnlSlotDetails.Controls.Add(this.metroLabel11);
            this.pnlSlotDetails.Controls.Add(this.metroLabel5);
            this.pnlSlotDetails.HorizontalScrollbarBarColor = true;
            this.pnlSlotDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSlotDetails.HorizontalScrollbarSize = 10;
            this.pnlSlotDetails.Location = new System.Drawing.Point(601, 145);
            this.pnlSlotDetails.Name = "pnlSlotDetails";
            this.pnlSlotDetails.Size = new System.Drawing.Size(481, 90);
            this.pnlSlotDetails.TabIndex = 120;
            this.pnlSlotDetails.VerticalScrollbarBarColor = true;
            this.pnlSlotDetails.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSlotDetails.VerticalScrollbarSize = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(351, 33);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(13, 19);
            this.lblPhone.TabIndex = 110;
            this.lblPhone.Text = " ";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(69, 71);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(13, 19);
            this.lblAddress.TabIndex = 107;
            this.lblAddress.Text = " ";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 71);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 19);
            this.metroLabel10.TabIndex = 107;
            this.metroLabel10.Text = "Address:";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(296, 33);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(49, 19);
            this.metroLabel11.TabIndex = 107;
            this.metroLabel11.Text = "Phone:";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(601, 112);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(93, 19);
            this.metroLabel9.TabIndex = 118;
            this.metroLabel9.Text = "Patient Details:";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tTipWholeDay
            // 
            this.tTipWholeDay.Style = MetroFramework.MetroColorStyle.Blue;
            this.tTipWholeDay.StyleManager = null;
            this.tTipWholeDay.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnBlockDay
            // 
            this.btnBlockDay.Location = new System.Drawing.Point(248, 171);
            this.btnBlockDay.Name = "btnBlockDay";
            this.btnBlockDay.Size = new System.Drawing.Size(134, 23);
            this.btnBlockDay.TabIndex = 121;
            this.btnBlockDay.Text = "Block Day";
            this.btnBlockDay.UseSelectable = true;
            this.btnBlockDay.Click += new System.EventHandler(this.BtnBlockDay_Click);
            // 
            // FormChkBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 670);
            this.Controls.Add(this.btnBlockDay);
            this.Controls.Add(this.pnlSlotDetails);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtpBookDoc);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelAdmnId);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lblIdDoc);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnAvailableSlots);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.MaximizeBox = false;
            this.Name = "FormChkBook";
            this.Resizable = false;
            this.Text = "Check Bookings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChkBook_FormClosed);
            this.Load += new System.EventHandler(this.FormChkBook_Load);
            this.pnlSlotDetails.ResumeLayout(false);
            this.pnlSlotDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblIdPat;
        private MetroFramework.Components.MetroToolTip tTipShowSlots;
        private MetroFramework.Controls.MetroButton btnAvailableSlots;
        private MetroFramework.Components.MetroToolTip tTipConfirm;
        private System.Windows.Forms.DateTimePicker dtpBookDoc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelAdmnId;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblAge;
        private MetroFramework.Controls.MetroLabel lblBloodG;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblIdDoc;
        private MetroFramework.Controls.MetroButton btnSet;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroPanel pnlSlotDetails;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Components.MetroToolTip tTipWholeDay;
        private MetroFramework.Controls.MetroButton btnBlockDay;
    }
}