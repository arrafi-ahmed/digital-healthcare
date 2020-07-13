using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalHealthCarePro.Doctor
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
        }

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

            this.txtDocSent.Text = this.Ds.Tables[3].Rows[0]["PresId"].ToString();
            if (string.IsNullOrWhiteSpace(this.txtDocSent.Text)) this.txtDocSent.Text = "N/A";

            this.txtBookRcv.Text = this.Ds.Tables[4].Rows[0]["DocBook"].ToString();
            if (string.IsNullOrWhiteSpace(this.txtBookRcv.Text)) this.txtBookRcv.Text = "N/A";

            this.txtSlotBlock.Text = this.Ds.Tables[6].Rows[0]["BlockSlot"].ToString();
            if (string.IsNullOrWhiteSpace(this.txtSlotBlock.Text)) this.txtSlotBlock.Text = "N/A";
        }

        private void CmbTimeRange_SelectedValueChanged(object sender, EventArgs e)
        {
            //Calling SetTimeRange
            SetTimeRange();

            //Setting Time
            string sqlSpanTime = "(CONVERT(smalldatetime, Time) " + this.Sign1 + " CONVERT(smalldatetime, DATEADD(" + this.Unit + ", " + this.Duration + ", '" + this.TimeFormat + "')) and CONVERT(smalldatetime, Time) " + this.Sign2 + "CONVERT(smalldatetime, '" + this.CurrentTime + "'))";

            //Setting sqlGetId
            string sqlGetId = "and d.DocId = '" + this.GetId + "'";


            //Main query 
            string sql = @"select sum(Amount) Amount from DocPay d, DocBook where BID = BookId and Paid = 'True' and " + sqlSpanTime + " " + sqlGetId + ";";
            sql += @"select sum(Amount) Amount from DocPay d, DocBook where BID = BookId and Paid = 'False' and " + sqlSpanTime + " " + sqlGetId + ";";
            sql += @"select count(PayId) PayId from DocPay d, DocBook where BID = BookId and Paid = 'True' and " + sqlSpanTime + " " + sqlGetId + ";";
            sql += @"select count(PresId) PresId from Prescription d where " + sqlSpanTime + " " + sqlGetId + ";";
            sql += @"select count(BookId) DocBook from DocBook d where " + sqlSpanTime + " " + sqlGetId + ";";
            sql += @"select count(T.C) BlockDay from (select count(BlockDay) as C from DocBlock d where BlockDay = 'True' and " + sqlSpanTime + " " + sqlGetId + " group by CONVERT(date, Time)) as T;";
            sql += @"select count(Time) BlockSlot from DocBlock d where " + sqlSpanTime + " " + sqlGetId + ";";

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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormDoctor fd = new FormDoctor(this.GetId);
            fd.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormChkStat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
