using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalHealthCarePro.Admin
{
    public partial class FormChkStat : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private string Sign1 { set; get; }
        private string Sign2 { set; get; }
        private string Unit { set; get; }
        private string Duration { set; get; }
        private DateTime CurrentTime { set; get; }
        private DateTime TimeFormat { set; get; }
        private DataSet Ds { set; get; }
        public FormChkStat(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;

            this.lblUser.Visible = false;
            ShowInfo();
        }

        //Showing General Infos (Left)
        private void ShowInfo()
        {
            string sql = @"select count(Id) Hospital from Hospital;";
            sql += @"select count(Id) Doctor from Doctor;";
            sql += @"select count(Id) Patient from Patient;";
            sql += @"select count(PayId) HpPay from HpPay;";
            sql += @"select count(PayId) DocPay from DocPay;";
            sql += @"select count(BookId) HpBook from HpBook;";
            sql += @"select count(BookId) DocBook from DocBook;";
            sql += @"select count(TestId) HpTest from HpTest;";

            try
            {
                this.Ds = DataAccess.GetDataSet(sql);

                this.txtTotalHp.Text = this.Ds.Tables[0].Rows[0]["Hospital"].ToString();
                this.txtTotalDoc.Text = this.Ds.Tables[1].Rows[0]["Doctor"].ToString();
                this.txtTotalPat.Text = this.Ds.Tables[2].Rows[0]["Patient"].ToString();
                this.txtTotalTrans.Text = (Int16.Parse(this.Ds.Tables[3].Rows[0]["HpPay"].ToString()) + Int16.Parse(this.Ds.Tables[4].Rows[0]["DocPay"].ToString())).ToString();
                this.txtTotalBook.Text = (Int16.Parse(this.Ds.Tables[5].Rows[0]["HpBook"].ToString()) + Int16.Parse(this.Ds.Tables[6].Rows[0]["DocBook"].ToString())).ToString();
                this.txtTotalTest.Text = this.Ds.Tables[7].Rows[0]["HpTest"].ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
           
        }

        //Setting TimeRange
        private void SetTimeRange()
        {
            if (this.cmbTimeRange.SelectedItem != null)
            {
                //currenttime for sqlSpanTIme
                this.CurrentTime = DateTime.Now; 

                //Today
                if (this.cmbTimeRange.SelectedIndex == 0)
                {
                    this.Sign1 = ">=";
                    this.Sign2 = "<=";
                    this.Unit = "day";
                    this.Duration = "0";
                    this.TimeFormat = this.CurrentTime.Date;
                }

                //Last 30 days
                else if (this.cmbTimeRange.SelectedIndex == 1)
                {
                    this.Sign1 = ">=";
                    this.Sign2 = "<=";
                    this.Unit = "day";
                    this.Duration = "-30";
                    this.TimeFormat = this.CurrentTime;
                }

                //Last 365 days
                else if (this.cmbTimeRange.SelectedIndex == 2)
                {
                    this.Sign1 = ">=";
                    this.Sign2 = "<=";
                    this.Unit = "day";
                    this.Duration = "-365";
                    this.TimeFormat = this.CurrentTime;
                }

                //Lifetime
                else if (this.cmbTimeRange.SelectedIndex == 3)
                {
                    this.Sign1 = "<=";
                    this.Sign2 = "<=";
                    this.Unit = "second";
                    this.Duration = "0";
                    this.TimeFormat = this.CurrentTime;
                }
            }
        }

        //Setting textboxes
        private void SetTxtBox()
        {
            this.txtConfInc.Text = this.Ds.Tables[0].Rows[0]["Amount"].ToString();
            if (string.IsNullOrWhiteSpace(this.txtConfInc.Text)) this.txtConfInc.Text = "N/A";

            this.txtPendInc.Text = this.Ds.Tables[1].Rows[0]["Amount"].ToString();
            if (string.IsNullOrWhiteSpace(this.txtPendInc.Text)) this.txtPendInc.Text = "N/A";

            this.txtPayRcv.Text = this.Ds.Tables[2].Rows[0]["PayId"].ToString();
            if (string.IsNullOrWhiteSpace(this.txtPayRcv.Text)) this.txtPayRcv.Text = "N/A";

            this.txtDayBlock.Text = this.Ds.Tables[5].Rows[0]["BlockDay"].ToString();
            if (string.IsNullOrWhiteSpace(this.txtDayBlock.Text)) this.txtDayBlock.Text = "N/A";

            //Setting txtBoxes according to SelectedItem
            if (cmbUser.SelectedItem.ToString() == "Hospital")
            {
                this.txtDocSent.Text = this.Ds.Tables[3].Rows[0]["RepId"].ToString();
                if (string.IsNullOrWhiteSpace(this.txtDocSent.Text)) this.txtDocSent.Text = "N/A";

                this.txtBookRcv.Text = this.Ds.Tables[4].Rows[0]["HpBook"].ToString();
                if (string.IsNullOrWhiteSpace(this.txtBookRcv.Text)) this.txtBookRcv.Text = "N/A";

                this.txtSlotBlock.Text = "M: " + this.Ds.Tables[6].Rows[0]["Morning"].ToString() + " /    A: " + this.Ds.Tables[7].Rows[0]["Afternoon"].ToString() + " /    N: " + this.Ds.Tables[8].Rows[0]["Night"].ToString() + "";
                if (string.IsNullOrWhiteSpace(this.txtSlotBlock.Text)) this.txtSlotBlock.Text = "N/A";
            }

            else if (cmbUser.SelectedItem.ToString() == "Doctor")
            {
                this.txtDocSent.Text = this.Ds.Tables[3].Rows[0]["PresId"].ToString();
                if (string.IsNullOrWhiteSpace(this.txtDocSent.Text)) this.txtDocSent.Text = "N/A";

                this.txtBookRcv.Text = this.Ds.Tables[4].Rows[0]["DocBook"].ToString();
                if (string.IsNullOrWhiteSpace(this.txtBookRcv.Text)) this.txtBookRcv.Text = "N/A";

                this.txtSlotBlock.Text = this.Ds.Tables[6].Rows[0]["BlockSlot"].ToString();
                if (string.IsNullOrWhiteSpace(this.txtSlotBlock.Text)) this.txtSlotBlock.Text = "N/A";
            }
        }

        //Showing Hospital Info
        private void ShowHpInfo()
        {
            //Dynamic lblDoc 
            this.lblDoc.Text = "Reports Sent";
            this.lblDoc.Location = new Point(53, 96);

            //Calling SetTimeRange
            SetTimeRange();

            //Setting Time
            string sqlSpanTime = "(CONVERT(smalldatetime, Time) " + this.Sign1 + " CONVERT(smalldatetime, DATEADD(" + this.Unit + ", " + this.Duration + ", '" + this.TimeFormat + "')) and CONVERT(smalldatetime, Time) " + this.Sign2 + " CONVERT(smalldatetime, '" + this.TimeFormat + "'))";

            //Setting Search
            string sqlSearch;

            if (!string.IsNullOrWhiteSpace(this.txtSearch.Text))
            {
                sqlSearch = "and h.HpId = '" + this.txtSearch.Text + "'";
            }
            else
                sqlSearch = null;

            //Main query 
            string sql = @"select sum(Amount) Amount from HpPay h, HpBook where BIH = BookId and Paid = 'True' and " + sqlSpanTime +" "+ sqlSearch + ";";
            sql += @"select sum(Amount) Amount from HpPay h, HpBook where BIH = BookId and Paid = 'False' and " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(PayId) PayId from HpPay h, HpBook where BIH = BookId and Paid = 'True' and " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(RepId) RepId from Report h where " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(BookId) HpBook from HpBook h where " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(Id) BlockDay from HpBlock h where BlockDay = 'True' and " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(Morning) Morning from HpBlock h where Morning = 'True' and " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(Afternoon) Afternoon from HpBlock h where Afternoon = 'True' and " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(Night) Night from HpBlock h where Night = 'True' and " + sqlSpanTime + " " + sqlSearch + ";";

            try
            {
                this.Ds = DataAccess.GetDataSet(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }

            //Setting textboxes
            SetTxtBox();

        }

        //Showing Doctor Info
        private void ShowDocInfo()
        {
            //Dynamic lblDoc label
            this.lblDoc.Text = "Prescriptions Sent";
            this.lblDoc.Location = new Point(22, 96);
            
            //Calling SetTimeRange
            SetTimeRange();

            //Setting Time
            string sqlSpanTime = "(CONVERT(smalldatetime, Time) " + this.Sign1 + " CONVERT(smalldatetime, DATEADD(" + this.Unit + ", " + this.Duration + ", '" + this.TimeFormat + "')) and CONVERT(smalldatetime, Time) " + this.Sign2 + "CONVERT(smalldatetime, '" + this.CurrentTime + "'))";
            
            //Setting Search
            string sqlSearch;

            if (!string.IsNullOrWhiteSpace(this.txtSearch.Text))
            {
                sqlSearch = "and d.DocId = '" + this.txtSearch.Text + "'";
            }
            else
                sqlSearch = null;

            //Main query 
            string sql = @"select sum(Amount) Amount from DocPay d, DocBook where BID = BookId and Paid = 'True' and " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select sum(Amount) Amount from DocPay d, DocBook where BID = BookId and Paid = 'False' and " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(PayId) PayId from DocPay d, DocBook where BID = BookId and Paid = 'True' and " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(PresId) PresId from Prescription d where " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(BookId) DocBook from DocBook d where " + sqlSpanTime + " " + sqlSearch + ";";
            sql += @"select count(T.C) BlockDay from (select count(BlockDay) as C from DocBlock d where BlockDay = 'True' and " + sqlSpanTime + " " + sqlSearch + " group by CONVERT(date, Time)) as T;";
            sql += @"select count(Time) BlockSlot from DocBlock d where " + sqlSpanTime + " " + sqlSearch + ";";
            
            try
            {
                this.Ds = DataAccess.GetDataSet(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }

            //Setting textboxes
            SetTxtBox();

        }

        private void CmbUser_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedItem != null)
            {
                this.lblUser.Text = this.cmbUser.Text;
                this.lblUser.Visible = true;

                if (cmbTimeRange.SelectedItem != null)
                {
                    if (cmbUser.SelectedItem.ToString() == "Hospital")
                        ShowHpInfo();

                    else if (cmbUser.SelectedItem.ToString() == "Doctor")
                        ShowDocInfo();
                }
            }
        }

        private void CmbTimeRange_SelectedValueChanged(object sender, EventArgs e)
        {
           if (cmbUser.SelectedItem == null)
                MessageBox.Show("Select User First!");
            else
            {
                this.lblUser.Text = this.cmbUser.Text;
                this.lblUser.Visible = true;

                if (cmbUser.SelectedItem.ToString() == "Hospital")
                    ShowHpInfo();

                else if (cmbUser.SelectedItem.ToString() == "Doctor")
                    ShowDocInfo();
            }
        }
        
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedItem == null || cmbTimeRange.SelectedItem == null)
                MessageBox.Show("Select all the fields First!");
            else
            {
                if (cmbUser.SelectedItem.ToString() == "Hospital")
                    ShowHpInfo();

                else if (cmbUser.SelectedItem.ToString() == "Doctor")
                    ShowDocInfo();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdmin fa = new FormAdmin(this.GetId);
            fa.Visible = true;
        }

        private void FormChkStat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
