namespace DigitalHealthCarePro.Admin
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
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.cmbTimeRange = new MetroFramework.Controls.MetroComboBox();
            this.txtTotalDoc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbUser = new MetroFramework.Controls.MetroComboBox();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalPat = new MetroFramework.Controls.MetroTextBox();
            this.txtTotalTrans = new MetroFramework.Controls.MetroTextBox();
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
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalTest = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalBook = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtTotalHp = new MetroFramework.Controls.MetroTextBox();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.pnlHp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(513, 57);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTitle.Location = new System.Drawing.Point(22, 61);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 19);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Digital HealthCare";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(266, 57);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 17);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "User ID:";
            // 
            // lblId
            // 
            this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblId.Location = new System.Drawing.Point(332, 57);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(94, 17);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "metroLabel1";
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
            this.cmbTimeRange.Location = new System.Drawing.Point(373, 102);
            this.cmbTimeRange.Name = "cmbTimeRange";
            this.cmbTimeRange.PromptText = "Time Range";
            this.cmbTimeRange.Size = new System.Drawing.Size(116, 29);
            this.cmbTimeRange.TabIndex = 16;
            this.cmbTimeRange.UseSelectable = true;
            this.cmbTimeRange.SelectedValueChanged += new System.EventHandler(this.CmbTimeRange_SelectedValueChanged);
            // 
            // txtTotalDoc
            // 
            // 
            // 
            // 
            this.txtTotalDoc.CustomButton.Image = null;
            this.txtTotalDoc.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtTotalDoc.CustomButton.Name = "";
            this.txtTotalDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalDoc.CustomButton.TabIndex = 1;
            this.txtTotalDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalDoc.CustomButton.UseSelectable = true;
            this.txtTotalDoc.CustomButton.Visible = false;
            this.txtTotalDoc.Lines = new string[0];
            this.txtTotalDoc.Location = new System.Drawing.Point(146, 180);
            this.txtTotalDoc.MaxLength = 32767;
            this.txtTotalDoc.Name = "txtTotalDoc";
            this.txtTotalDoc.PasswordChar = '\0';
            this.txtTotalDoc.ReadOnly = true;
            this.txtTotalDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalDoc.SelectedText = "";
            this.txtTotalDoc.SelectionLength = 0;
            this.txtTotalDoc.SelectionStart = 0;
            this.txtTotalDoc.ShortcutsEnabled = true;
            this.txtTotalDoc.Size = new System.Drawing.Size(104, 23);
            this.txtTotalDoc.TabIndex = 15;
            this.txtTotalDoc.UseSelectable = true;
            this.txtTotalDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(50, 180);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Total Doctors";
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.ItemHeight = 23;
            this.cmbUser.Items.AddRange(new object[] {
            "Doctor",
            "Hospital"});
            this.cmbUser.Location = new System.Drawing.Point(269, 102);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.PromptText = "Select User";
            this.cmbUser.Size = new System.Drawing.Size(98, 29);
            this.cmbUser.TabIndex = 16;
            this.cmbUser.UseSelectable = true;
            this.cmbUser.SelectedValueChanged += new System.EventHandler(this.CmbUser_SelectedValueChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(526, 129);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 19);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "Hospital";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(48, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Total Hopitals";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(49, 209);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(91, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Total Patients";
            // 
            // txtTotalPat
            // 
            // 
            // 
            // 
            this.txtTotalPat.CustomButton.Image = null;
            this.txtTotalPat.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtTotalPat.CustomButton.Name = "";
            this.txtTotalPat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPat.CustomButton.TabIndex = 1;
            this.txtTotalPat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPat.CustomButton.UseSelectable = true;
            this.txtTotalPat.CustomButton.Visible = false;
            this.txtTotalPat.Lines = new string[0];
            this.txtTotalPat.Location = new System.Drawing.Point(146, 209);
            this.txtTotalPat.MaxLength = 32767;
            this.txtTotalPat.Name = "txtTotalPat";
            this.txtTotalPat.PasswordChar = '\0';
            this.txtTotalPat.ReadOnly = true;
            this.txtTotalPat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPat.SelectedText = "";
            this.txtTotalPat.SelectionLength = 0;
            this.txtTotalPat.SelectionStart = 0;
            this.txtTotalPat.ShortcutsEnabled = true;
            this.txtTotalPat.Size = new System.Drawing.Size(104, 23);
            this.txtTotalPat.TabIndex = 15;
            this.txtTotalPat.UseSelectable = true;
            this.txtTotalPat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTotalTrans
            // 
            // 
            // 
            // 
            this.txtTotalTrans.CustomButton.Image = null;
            this.txtTotalTrans.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtTotalTrans.CustomButton.Name = "";
            this.txtTotalTrans.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalTrans.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalTrans.CustomButton.TabIndex = 1;
            this.txtTotalTrans.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalTrans.CustomButton.UseSelectable = true;
            this.txtTotalTrans.CustomButton.Visible = false;
            this.txtTotalTrans.Lines = new string[0];
            this.txtTotalTrans.Location = new System.Drawing.Point(146, 238);
            this.txtTotalTrans.MaxLength = 32767;
            this.txtTotalTrans.Name = "txtTotalTrans";
            this.txtTotalTrans.PasswordChar = '\0';
            this.txtTotalTrans.ReadOnly = true;
            this.txtTotalTrans.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalTrans.SelectedText = "";
            this.txtTotalTrans.SelectionLength = 0;
            this.txtTotalTrans.SelectionStart = 0;
            this.txtTotalTrans.ShortcutsEnabled = true;
            this.txtTotalTrans.Size = new System.Drawing.Size(104, 23);
            this.txtTotalTrans.TabIndex = 15;
            this.txtTotalTrans.UseSelectable = true;
            this.txtTotalTrans.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalTrans.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.pnlHp.Location = new System.Drawing.Point(269, 141);
            this.pnlHp.Name = "pnlHp";
            this.pnlHp.Size = new System.Drawing.Size(318, 211);
            this.pnlHp.TabIndex = 17;
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
            this.txtPayRcv.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtPayRcv.CustomButton.Name = "";
            this.txtPayRcv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPayRcv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayRcv.CustomButton.TabIndex = 1;
            this.txtPayRcv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayRcv.CustomButton.UseSelectable = true;
            this.txtPayRcv.CustomButton.Visible = false;
            this.txtPayRcv.Lines = new string[0];
            this.txtPayRcv.Location = new System.Drawing.Point(146, 67);
            this.txtPayRcv.MaxLength = 32767;
            this.txtPayRcv.Name = "txtPayRcv";
            this.txtPayRcv.PasswordChar = '\0';
            this.txtPayRcv.ReadOnly = true;
            this.txtPayRcv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayRcv.SelectedText = "";
            this.txtPayRcv.SelectionLength = 0;
            this.txtPayRcv.SelectionStart = 0;
            this.txtPayRcv.ShortcutsEnabled = true;
            this.txtPayRcv.Size = new System.Drawing.Size(168, 23);
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
            this.txtDocSent.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtDocSent.CustomButton.Name = "";
            this.txtDocSent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocSent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocSent.CustomButton.TabIndex = 1;
            this.txtDocSent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocSent.CustomButton.UseSelectable = true;
            this.txtDocSent.CustomButton.Visible = false;
            this.txtDocSent.Lines = new string[0];
            this.txtDocSent.Location = new System.Drawing.Point(146, 96);
            this.txtDocSent.MaxLength = 32767;
            this.txtDocSent.Name = "txtDocSent";
            this.txtDocSent.PasswordChar = '\0';
            this.txtDocSent.ReadOnly = true;
            this.txtDocSent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocSent.SelectedText = "";
            this.txtDocSent.SelectionLength = 0;
            this.txtDocSent.SelectionStart = 0;
            this.txtDocSent.ShortcutsEnabled = true;
            this.txtDocSent.Size = new System.Drawing.Size(168, 23);
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
            this.txtSlotBlock.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtSlotBlock.CustomButton.Name = "";
            this.txtSlotBlock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSlotBlock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSlotBlock.CustomButton.TabIndex = 1;
            this.txtSlotBlock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSlotBlock.CustomButton.UseSelectable = true;
            this.txtSlotBlock.CustomButton.Visible = false;
            this.txtSlotBlock.Lines = new string[0];
            this.txtSlotBlock.Location = new System.Drawing.Point(146, 183);
            this.txtSlotBlock.MaxLength = 32767;
            this.txtSlotBlock.Name = "txtSlotBlock";
            this.txtSlotBlock.PasswordChar = '\0';
            this.txtSlotBlock.ReadOnly = true;
            this.txtSlotBlock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlotBlock.SelectedText = "";
            this.txtSlotBlock.SelectionLength = 0;
            this.txtSlotBlock.SelectionStart = 0;
            this.txtSlotBlock.ShortcutsEnabled = true;
            this.txtSlotBlock.Size = new System.Drawing.Size(168, 23);
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
            this.txtBookRcv.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtBookRcv.CustomButton.Name = "";
            this.txtBookRcv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBookRcv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookRcv.CustomButton.TabIndex = 1;
            this.txtBookRcv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookRcv.CustomButton.UseSelectable = true;
            this.txtBookRcv.CustomButton.Visible = false;
            this.txtBookRcv.Lines = new string[0];
            this.txtBookRcv.Location = new System.Drawing.Point(146, 125);
            this.txtBookRcv.MaxLength = 32767;
            this.txtBookRcv.Name = "txtBookRcv";
            this.txtBookRcv.PasswordChar = '\0';
            this.txtBookRcv.ReadOnly = true;
            this.txtBookRcv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookRcv.SelectedText = "";
            this.txtBookRcv.SelectionLength = 0;
            this.txtBookRcv.SelectionStart = 0;
            this.txtBookRcv.ShortcutsEnabled = true;
            this.txtBookRcv.Size = new System.Drawing.Size(168, 23);
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
            this.txtDayBlock.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtDayBlock.CustomButton.Name = "";
            this.txtDayBlock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDayBlock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDayBlock.CustomButton.TabIndex = 1;
            this.txtDayBlock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDayBlock.CustomButton.UseSelectable = true;
            this.txtDayBlock.CustomButton.Visible = false;
            this.txtDayBlock.Lines = new string[0];
            this.txtDayBlock.Location = new System.Drawing.Point(146, 154);
            this.txtDayBlock.MaxLength = 32767;
            this.txtDayBlock.Name = "txtDayBlock";
            this.txtDayBlock.PasswordChar = '\0';
            this.txtDayBlock.ReadOnly = true;
            this.txtDayBlock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDayBlock.SelectedText = "";
            this.txtDayBlock.SelectionLength = 0;
            this.txtDayBlock.SelectionStart = 0;
            this.txtDayBlock.ShortcutsEnabled = true;
            this.txtDayBlock.Size = new System.Drawing.Size(168, 23);
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
            this.txtPendInc.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtPendInc.CustomButton.Name = "";
            this.txtPendInc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPendInc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPendInc.CustomButton.TabIndex = 1;
            this.txtPendInc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPendInc.CustomButton.UseSelectable = true;
            this.txtPendInc.CustomButton.Visible = false;
            this.txtPendInc.Lines = new string[0];
            this.txtPendInc.Location = new System.Drawing.Point(146, 38);
            this.txtPendInc.MaxLength = 32767;
            this.txtPendInc.Name = "txtPendInc";
            this.txtPendInc.PasswordChar = '\0';
            this.txtPendInc.ReadOnly = true;
            this.txtPendInc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPendInc.SelectedText = "";
            this.txtPendInc.SelectionLength = 0;
            this.txtPendInc.SelectionStart = 0;
            this.txtPendInc.ShortcutsEnabled = true;
            this.txtPendInc.Size = new System.Drawing.Size(168, 23);
            this.txtPendInc.TabIndex = 15;
            this.txtPendInc.UseSelectable = true;
            this.txtPendInc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPendInc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDoc.Location = new System.Drawing.Point(30, 96);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(110, 19);
            this.lblDoc.TabIndex = 14;
            this.lblDoc.Text = "Documents Sent";
            this.lblDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(18, 10);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(122, 19);
            this.metroLabel13.TabIndex = 14;
            this.metroLabel13.Text = "Confirmed Income";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(47, 183);
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
            this.txtConfInc.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtConfInc.CustomButton.Name = "";
            this.txtConfInc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfInc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfInc.CustomButton.TabIndex = 1;
            this.txtConfInc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfInc.CustomButton.UseSelectable = true;
            this.txtConfInc.CustomButton.Visible = false;
            this.txtConfInc.Lines = new string[0];
            this.txtConfInc.Location = new System.Drawing.Point(146, 10);
            this.txtConfInc.MaxLength = 32767;
            this.txtConfInc.Name = "txtConfInc";
            this.txtConfInc.PasswordChar = '\0';
            this.txtConfInc.ReadOnly = true;
            this.txtConfInc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfInc.SelectedText = "";
            this.txtConfInc.SelectionLength = 0;
            this.txtConfInc.SelectionStart = 0;
            this.txtConfInc.ShortcutsEnabled = true;
            this.txtConfInc.Size = new System.Drawing.Size(168, 23);
            this.txtConfInc.TabIndex = 15;
            this.txtConfInc.UseSelectable = true;
            this.txtConfInc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfInc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(7, 67);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(133, 19);
            this.metroLabel15.TabIndex = 14;
            this.metroLabel15.Text = "Payments Receieved";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(46, 154);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(94, 19);
            this.metroLabel16.TabIndex = 14;
            this.metroLabel16.Text = "Days Blocked ";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(11, 125);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(129, 19);
            this.metroLabel17.TabIndex = 14;
            this.metroLabel17.Text = "Bookings Receieved";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(33, 38);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(107, 19);
            this.metroLabel18.TabIndex = 14;
            this.metroLabel18.Text = "Pending Income";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(68, 296);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(72, 19);
            this.metroLabel19.TabIndex = 14;
            this.metroLabel19.Text = "Total Tests";
            // 
            // txtTotalTest
            // 
            // 
            // 
            // 
            this.txtTotalTest.CustomButton.Image = null;
            this.txtTotalTest.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtTotalTest.CustomButton.Name = "";
            this.txtTotalTest.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalTest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalTest.CustomButton.TabIndex = 1;
            this.txtTotalTest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalTest.CustomButton.UseSelectable = true;
            this.txtTotalTest.CustomButton.Visible = false;
            this.txtTotalTest.Lines = new string[0];
            this.txtTotalTest.Location = new System.Drawing.Point(146, 296);
            this.txtTotalTest.MaxLength = 32767;
            this.txtTotalTest.Name = "txtTotalTest";
            this.txtTotalTest.PasswordChar = '\0';
            this.txtTotalTest.ReadOnly = true;
            this.txtTotalTest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalTest.SelectedText = "";
            this.txtTotalTest.SelectionLength = 0;
            this.txtTotalTest.SelectionStart = 0;
            this.txtTotalTest.ShortcutsEnabled = true;
            this.txtTotalTest.Size = new System.Drawing.Size(104, 23);
            this.txtTotalTest.TabIndex = 15;
            this.txtTotalTest.UseSelectable = true;
            this.txtTotalTest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalTest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.Location = new System.Drawing.Point(23, 238);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(117, 19);
            this.metroLabel20.TabIndex = 14;
            this.metroLabel20.Text = "Total Transactions";
            // 
            // txtTotalBook
            // 
            // 
            // 
            // 
            this.txtTotalBook.CustomButton.Image = null;
            this.txtTotalBook.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtTotalBook.CustomButton.Name = "";
            this.txtTotalBook.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalBook.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalBook.CustomButton.TabIndex = 1;
            this.txtTotalBook.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalBook.CustomButton.UseSelectable = true;
            this.txtTotalBook.CustomButton.Visible = false;
            this.txtTotalBook.Lines = new string[0];
            this.txtTotalBook.Location = new System.Drawing.Point(146, 267);
            this.txtTotalBook.MaxLength = 32767;
            this.txtTotalBook.Name = "txtTotalBook";
            this.txtTotalBook.PasswordChar = '\0';
            this.txtTotalBook.ReadOnly = true;
            this.txtTotalBook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalBook.SelectedText = "";
            this.txtTotalBook.SelectionLength = 0;
            this.txtTotalBook.SelectionStart = 0;
            this.txtTotalBook.ShortcutsEnabled = true;
            this.txtTotalBook.Size = new System.Drawing.Size(104, 23);
            this.txtTotalBook.TabIndex = 15;
            this.txtTotalBook.UseSelectable = true;
            this.txtTotalBook.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalBook.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.Location = new System.Drawing.Point(42, 267);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(98, 19);
            this.metroLabel21.TabIndex = 14;
            this.metroLabel21.Text = "Total Bookings";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(495, 102);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by ID";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(92, 23);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by ID";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // txtTotalHp
            // 
            // 
            // 
            // 
            this.txtTotalHp.CustomButton.Image = null;
            this.txtTotalHp.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtTotalHp.CustomButton.Name = "";
            this.txtTotalHp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalHp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalHp.CustomButton.TabIndex = 1;
            this.txtTotalHp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalHp.CustomButton.UseSelectable = true;
            this.txtTotalHp.CustomButton.Visible = false;
            this.txtTotalHp.Lines = new string[0];
            this.txtTotalHp.Location = new System.Drawing.Point(146, 151);
            this.txtTotalHp.MaxLength = 32767;
            this.txtTotalHp.Name = "txtTotalHp";
            this.txtTotalHp.PasswordChar = '\0';
            this.txtTotalHp.ReadOnly = true;
            this.txtTotalHp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalHp.SelectedText = "";
            this.txtTotalHp.SelectionLength = 0;
            this.txtTotalHp.SelectionStart = 0;
            this.txtTotalHp.ShortcutsEnabled = true;
            this.txtTotalHp.Size = new System.Drawing.Size(104, 23);
            this.txtTotalHp.TabIndex = 15;
            this.txtTotalHp.UseSelectable = true;
            this.txtTotalHp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalHp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(432, 57);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "Home";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // FormChkStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 372);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlHp);
            this.Controls.Add(this.txtTotalTest);
            this.Controls.Add(this.txtTotalTrans);
            this.Controls.Add(this.txtTotalBook);
            this.Controls.Add(this.txtTotalPat);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTotalHp);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.txtTotalDoc);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.cmbTimeRange);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FormChkStat";
            this.Padding = new System.Windows.Forms.Padding(20, 61, 20, 17);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check Statistics";
            this.TransparencyKey = System.Drawing.Color.LightSkyBlue;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChkStat_FormClosed);
            this.pnlHp.ResumeLayout(false);
            this.pnlHp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroComboBox cmbTimeRange;
        private MetroFramework.Controls.MetroTextBox txtTotalDoc;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmbUser;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtTotalPat;
        private MetroFramework.Controls.MetroTextBox txtTotalTrans;
        private MetroFramework.Controls.MetroPanel pnlHp;
        private MetroFramework.Controls.MetroTextBox txtPayRcv;
        private MetroFramework.Controls.MetroTextBox txtDocSent;
        private MetroFramework.Controls.MetroTextBox txtTotalTest;
        private MetroFramework.Controls.MetroTextBox txtSlotBlock;
        private MetroFramework.Controls.MetroTextBox txtBookRcv;
        private MetroFramework.Controls.MetroTextBox txtDayBlock;
        private MetroFramework.Controls.MetroTextBox txtPendInc;
        private MetroFramework.Controls.MetroLabel lblDoc;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtConfInc;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txtTotalBook;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtTotalHp;
        private MetroFramework.Controls.MetroButton btnHome;
    }
}