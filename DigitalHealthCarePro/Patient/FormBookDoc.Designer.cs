namespace DigitalHealthCarePro.Patient
{
    partial class FormBookDoc
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
            this.lblIdPat = new MetroFramework.Controls.MetroLabel();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdmnId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAvailableSlots = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.dtpBookDoc = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tTipShowSlots = new MetroFramework.Components.MetroToolTip();
            this.lblDept = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblVisitHr = new MetroFramework.Controls.MetroLabel();
            this.lblIdDoc = new MetroFramework.Controls.MetroLabel();
            this.tTipConfirm = new MetroFramework.Components.MetroToolTip();
            this.lblFee = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(859, 60);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(54, 19);
            this.metroLabel10.TabIndex = 53;
            this.metroLabel10.Text = "User ID:";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdPat
            // 
            this.lblIdPat.AutoSize = true;
            this.lblIdPat.Location = new System.Drawing.Point(931, 60);
            this.lblIdPat.Name = "lblIdPat";
            this.lblIdPat.Size = new System.Drawing.Size(81, 19);
            this.lblIdPat.TabIndex = 54;
            this.lblIdPat.Text = "metroLabel1";
            this.lblIdPat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Location = new System.Drawing.Point(1023, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 23);
            this.btnHome.TabIndex = 52;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Location = new System.Drawing.Point(1103, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 51;
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
            this.labelTitle.TabIndex = 56;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabelAdmnId
            // 
            this.metroLabelAdmnId.AutoSize = true;
            this.metroLabelAdmnId.Location = new System.Drawing.Point(23, 79);
            this.metroLabelAdmnId.Name = "metroLabelAdmnId";
            this.metroLabelAdmnId.Size = new System.Drawing.Size(0, 0);
            this.metroLabelAdmnId.TabIndex = 55;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(648, 143);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 53;
            this.metroLabel1.Text = "Doctor ID:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAvailableSlots
            // 
            this.btnAvailableSlots.AutoSize = true;
            this.btnAvailableSlots.Location = new System.Drawing.Point(128, 174);
            this.btnAvailableSlots.Name = "btnAvailableSlots";
            this.btnAvailableSlots.Size = new System.Drawing.Size(163, 23);
            this.btnAvailableSlots.TabIndex = 52;
            this.btnAvailableSlots.Text = "Show Booked Slots";
            this.tTipShowSlots.SetToolTip(this.btnAvailableSlots, "Available slots are unchecked \r\n& unavailable slots are checked.");
            this.btnAvailableSlots.UseSelectable = true;
            this.btnAvailableSlots.Click += new System.EventHandler(this.BtnAvailableSlots_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Location = new System.Drawing.Point(422, 145);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(74, 23);
            this.btnConfirm.TabIndex = 52;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // dtpBookDoc
            // 
            this.dtpBookDoc.CustomFormat = "dddd , dd , MMMM , yyyy,    ( HH:mm tt )";
            this.dtpBookDoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookDoc.Location = new System.Drawing.Point(128, 145);
            this.dtpBookDoc.Name = "dtpBookDoc";
            this.dtpBookDoc.Size = new System.Drawing.Size(288, 20);
            this.dtpBookDoc.TabIndex = 59;
            this.tTipConfirm.SetToolTip(this.dtpBookDoc, "You can book next 30 days range from today");
            this.dtpBookDoc.ValueChanged += new System.EventHandler(this.DtpBookDoc_ValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 143);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 61;
            this.metroLabel3.Text = "Booking Time:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 270);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 58;
            this.metroLabel4.Text = "Booked Slots:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(859, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 53;
            this.metroLabel2.Text = "Doctor Name:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(648, 176);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 19);
            this.metroLabel5.TabIndex = 53;
            this.metroLabel5.Text = "Dept:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(860, 176);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 19);
            this.metroLabel6.TabIndex = 53;
            this.metroLabel6.Text = "Visiting Hours:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(722, 176);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(81, 19);
            this.lblDept.TabIndex = 54;
            this.lblDept.Text = "metroLabel1";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(957, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 19);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "metroLabel1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVisitHr
            // 
            this.lblVisitHr.AutoSize = true;
            this.lblVisitHr.Location = new System.Drawing.Point(957, 177);
            this.lblVisitHr.Name = "lblVisitHr";
            this.lblVisitHr.Size = new System.Drawing.Size(81, 19);
            this.lblVisitHr.TabIndex = 54;
            this.lblVisitHr.Text = "metroLabel1";
            this.lblVisitHr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdDoc
            // 
            this.lblIdDoc.AutoSize = true;
            this.lblIdDoc.Location = new System.Drawing.Point(722, 143);
            this.lblIdDoc.Name = "lblIdDoc";
            this.lblIdDoc.Size = new System.Drawing.Size(83, 19);
            this.lblIdDoc.TabIndex = 62;
            this.lblIdDoc.Text = "metroLabel8";
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
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(722, 210);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(81, 19);
            this.lblFee.TabIndex = 54;
            this.lblFee.Text = "metroLabel1";
            this.lblFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(648, 210);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 19);
            this.metroLabel8.TabIndex = 53;
            this.metroLabel8.Text = "Fee:";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(957, 210);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(81, 19);
            this.lblPhone.TabIndex = 54;
            this.lblPhone.Text = "metroLabel1";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(859, 210);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(49, 19);
            this.metroLabel11.TabIndex = 53;
            this.metroLabel11.Text = "Phone:";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBookDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.lblIdDoc);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtpBookDoc);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabelAdmnId);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblVisitHr);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIdPat);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAvailableSlots);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.MaximizeBox = false;
            this.Name = "FormBookDoc";
            this.Resizable = false;
            this.Text = "Book Doctor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBookDoc_FormClosed);
            this.Load += new System.EventHandler(this.FormBookDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lblIdPat;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabelAdmnId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAvailableSlots;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private System.Windows.Forms.DateTimePicker dtpBookDoc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Components.MetroToolTip tTipShowSlots;
        private MetroFramework.Controls.MetroLabel lblDept;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblVisitHr;
        private MetroFramework.Controls.MetroLabel lblIdDoc;
        private MetroFramework.Components.MetroToolTip tTipConfirm;
        private MetroFramework.Controls.MetroLabel lblFee;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}