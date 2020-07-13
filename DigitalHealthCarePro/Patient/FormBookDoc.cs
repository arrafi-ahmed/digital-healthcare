using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalHealthCarePro.Patient
{
    public partial class FormBookDoc : MetroFramework.Forms.MetroForm
    {
        private int serial;
        private string bookId;
        private string BookId
        {
            get { return this.bookId; }
            set { this.bookId = "Bid-" + value; }
        }
        private DateTime PrevTime { set; get; }
        private DateTime LatestTime { set; get; }
        private int Rm { set; get; }
        private int Div { set; get; }
        private int SlotMin { set; get; }
        private MetroFramework.Controls.MetroCheckBox[] VarCb { get; set; }
        private string GetId { set; get; }
        private string DocId { set; get; }
        private string StartTime { set; get; }
        private string CloseTime { set; get; }
        private bool SlotRangeOverflow { set; get; }
        private bool SlotUnavailable { set; get; }
        private bool AccessedBtnBookedSlot { set; get; }
        private bool FirstAccessed { set; get; }
        private DataTable Dt { set; get; }
        private DataRow Dr { get; set; }
        private DataSet Ds { set; get; }
        
        public FormBookDoc(string GetId, string DocId)
        {
            InitializeComponent();
            this.GetId = this.lblIdPat.Text = GetId;
            this.DocId = this.lblIdDoc.Text = DocId;

            this.SlotUnavailable = false;
        }

        private void FormBookDoc_Load(object sender, EventArgs e)
        {
            this.ShowDynamicRB();
            this.ShowInfo();

            FirstAccessed = false;
            if(!FirstAccessed)
                this.SetDtp();  //Set Min and max limit of dtp
        }

        private void SetDtp()
        {
            Rm = this.dtpBookDoc.Value.Minute % SlotMin;     //Setting reminder bfr entering operation

            //Setting min and max date in dtpBookDoc
            if (!FirstAccessed)
            {
                this.dtpBookDoc.MinDate = DateTime.Now.AddMinutes(SlotMin - Rm);
                this.dtpBookDoc.MinDate = DateTime.Now.AddSeconds(-1);
            }
                
            this.dtpBookDoc.MaxDate = DateTime.Now.AddDays(30);
        }

        private void ShowInfo()
        {
            string sql = "Select Name, Dept, WeekStart, WeekEnd, StartTime, CloseTime, Fee, Phone from Doctor where Id = '" + this.DocId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                if (this.Dt.Rows.Count > 0)
                {
                    this.lblName.Text = this.Dt.Rows[0]["Name"].ToString();
                    this.lblDept.Text = this.Dt.Rows[0]["Dept"].ToString();
                    this.lblVisitHr.Text = this.Dt.Rows[0]["WeekStart"].ToString() + "-" + this.Dt.Rows[0]["WeekEnd"].ToString() + "/" + this.Dt.Rows[0]["StartTime"].ToString() + "-" + this.Dt.Rows[0]["CloseTime"].ToString();
                    this.lblFee.Text = this.Dt.Rows[0]["Fee"].ToString();
                    this.lblPhone.Text = this.Dt.Rows[0]["Phone"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void ShowDynamicRB()
        {
            //Setting start time and close time
            string sql = "select StartTime, CloseTime, SlotMin from Doctor where Id = '" + this.DocId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                this.StartTime = this.Dt.Rows[0]["StartTime"].ToString();
                this.CloseTime = this.Dt.Rows[0]["CloseTime"].ToString();
                this.SlotMin = Int16.Parse(this.Dt.Rows[0]["SlotMin"].ToString());
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            //Calculating the differance between times
            TimeSpan sTime = Convert.ToDateTime(StartTime).TimeOfDay;
            TimeSpan cTime = Convert.ToDateTime(CloseTime).TimeOfDay;
            TimeSpan sub = cTime > sTime ? cTime - sTime : cTime - sTime + TimeSpan.FromDays(1);
            int subMin = (int)sub.TotalMinutes;

            this.Div = subMin / this.SlotMin;

            //Creating array of Div amounts radio button dynamically
            VarCb = new MetroFramework.Controls.MetroCheckBox[Div];

            for (int i = 0; i < Div; i++)
            {
                VarCb[i] = new MetroFramework.Controls.MetroCheckBox();

                int rowN = 12;      //Number of slots in each row
                int topMg = 300;    //Top margin
                int height = 370;

                if (i < rowN)
                {
                    VarCb[i].Top += topMg;
                    VarCb[i].Left = 50 + (i + 1) * 80;
                    this.Height = height;
                }

                else if (i >= rowN && i < rowN * 2)
                {
                    VarCb[i].Top += topMg + 30;
                    VarCb[i].Left = 50 + (i - rowN + 1) * 80;
                    this.Height = height + 30;
                }

                else if (i >= rowN * 2 && i < rowN * 3)
                {
                    VarCb[i].Top += topMg + 60;
                    VarCb[i].Left = 50 + (i - rowN * 2 + 1) * 80;
                    this.Height = height + 60;
                }

                else if (i >= rowN * 3 && i < rowN * 4)
                {
                    VarCb[i].Top += topMg + 90;
                    VarCb[i].Left = 50 + (i - rowN * 3 + 1) * 80;
                    this.Height = height + 90;
                }

                else if (i >= rowN * 4 && i < rowN * 5)
                {
                    VarCb[i].Top += topMg + 120;
                    VarCb[i].Left = 50 + (i - rowN * 4 + 1) * 80;
                    this.Height = height + 120;
                }

                VarCb[i].Enabled = false;
                VarCb[i].Width = 70;                                //Setting neccesary width
                VarCb[i].Text = sTime.Hours.ToString("d2") + ":"+sTime.Minutes.ToString("d2") + ":00";     //Setting radio button text
                sTime = sTime.Add(TimeSpan.FromMinutes(SlotMin));   //Adding slotMin amounts of time to radio button text
                this.Controls.Add(VarCb[i]);                        //Adding the radio button to form
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //Converting string of dtpBookDoc to DateTIme
            DateTime BookDoc = DateTime.ParseExact(this.dtpBookDoc.Text, "dddd , dd , MMMM , yyyy,    ( HH:mm tt )", null);
            
            //Auto generated Booking Id
            string query = "select BookId from DocBook ORDER BY CAST(SUBSTRING(BookId, CHARINDEX('-', BookId) + 1, LEN(BookId)) AS INT);";      //Checking if the table is empty

            try
            {
                this.Dr = DataAccess.GetLastRow(query);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
           
            //Setting serial 
            if (this.Dr != null)
            {
                //Accessing last serial
                string lastRowItem = this.Dr["BookId"].ToString();
                string trimValue = lastRowItem.Remove(0, 4);
                this.serial = Int32.Parse(trimValue);
            }

            else
                this.serial = 0;

            //Increamenting BookId
            this.BookId = (++this.serial).ToString("d2");

            //Check if booking exist
            if (!AccessedBtnBookedSlot)
                MessageBox.Show("Please check booked slots for new date!");

            //Confirm btn action
            else
            {
                string currentTime = dtpBookDoc.Value.ToString("HH:mm")+":00";
                this.SlotRangeOverflow = false;

                for (int j = 0; j < VarCb.Length; j++)
                {
                    if (VarCb[j].Text == currentTime && VarCb[j].Checked)
                    {
                        this.SlotUnavailable = true;
                        this.SlotRangeOverflow = false;
                        break;
                    }

                    if (VarCb[j].Text != currentTime && !VarCb[j].Checked)
                        this.SlotRangeOverflow = true;

                    else if (VarCb[j].Text == currentTime)
                    {
                        this.SlotRangeOverflow = false;
                        break;
                    }
                }

                if(this.SlotRangeOverflow)
                    MessageBox.Show("Selected time is out of slot range, Please select valid one!");

                else if (this.SlotUnavailable)
                    MessageBox.Show("Selected slot is unavailable, Please select another one!");

                else
                {
                    //Opening payment page
                    this.Visible = false;
                    FormMakePay fmp = new FormMakePay(this.GetId, this.BookId, this.lblIdDoc.Text, this.lblFee.Text, BookDoc);
                    fmp.Visible = true;
                }
            }
            
        }

        private void BtnAvailableSlots_Click(object sender, EventArgs e)
        {
            AccessedBtnBookedSlot = true;

            //Restoring checked value after selecting different date
            for (int i = 0; i < Div; i++)
                VarCb[i].Checked = false;

            //Restoring SlotUnavailable
            this.SlotUnavailable = false;

            //Generating current Date
            string currentDate = dtpBookDoc.Value.ToString("yyyy-MM-dd");

            //Collecting only date part of Time col from table
            string sql = "select Time, Valid from DocBook where (DocId = '" + this.DocId + "' and CONVERT(date, Time) = CONVERT(date, '" + currentDate + "'));";
            sql += "select Time, BlockDay from DocBlock where(DocId = '" + this.DocId + "' and CONVERT(date, Time) = CONVERT(date, '" + currentDate + "')); ";

            try
            {
                this.Ds = DataAccess.GetDataSet(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            //Comparing checkbox value with table 0 time by linear search
            for (int i = 0; i < this.Ds.Tables[0].Rows.Count; i++)
            {
                TimeSpan bdHM = Convert.ToDateTime(this.Ds.Tables[0].Rows[i]["Time"].ToString()).TimeOfDay;
                for (int j = 0; j < VarCb.Length; j++)
                {
                    //If checkbox and table time is equal then checked set to true
                    if (VarCb[j].Text == bdHM.ToString() && this.Ds.Tables[0].Rows[i]["Valid"].ToString() == "True")
                        VarCb[j].Checked = true;
                }
            }

            //Comparing checkbox value with table 1 time by linear search
            for (int i = 0; i < this.Ds.Tables[1].Rows.Count; i++)
            {
                TimeSpan adHM = Convert.ToDateTime(this.Ds.Tables[1].Rows[i]["Time"].ToString()).TimeOfDay; //For checking each checkbox
                string blockDay = this.Ds.Tables[1].Rows[i]["BlockDay"].ToString();                         //For checking if whole day is blocked

                //Whole day block
                if (blockDay == "True")
                {
                    for (int j = 0; j < VarCb.Length; j++)
                        VarCb[j].Checked = true;
                }

                //Specific slot block
                else
                {
                    for (int j = 0; j < VarCb.Length; j++)
                    {
                        //If checkbox and table time is equal then checked set to true
                        if (VarCb[j].Text == adHM.ToString())
                            VarCb[j].Checked = true;
                    }
                }
            }
        }

        private void DtpBookDoc_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((this.LatestTime - this.dtpBookDoc.Value).Days > 0 || (this.LatestTime - this.dtpBookDoc.Value).Days < 0)
                    AccessedBtnBookedSlot = false;

                else if ((this.LatestTime - this.dtpBookDoc.Value).Days == 0 && AccessedBtnBookedSlot)
                    AccessedBtnBookedSlot = true;

                //Main Part
                if (FirstAccessed)
                {
                    this.SlotUnavailable = false;

                    if (FirstAccessed)
                        this.SetDtp();  //Set Min and max limit of dtp

                    //Go into operation if time is within min and max range
                    if (this.dtpBookDoc.Value >= this.dtpBookDoc.MinDate && this.dtpBookDoc.Value <= this.dtpBookDoc.MaxDate)
                    {
                        //If reminder 0, then returns same min time
                        if (Rm == 0)
                            return;

                        //Special case for dtpBookDoc.Value = MaxDate
                        if (this.PrevTime < this.dtpBookDoc.Value && this.dtpBookDoc.Value.ToString() == this.dtpBookDoc.MaxDate.ToString())
                        {
                            //Special case for 00 min contained to reduce dtp time
                            if (this.PrevTime.Minute.ToString() == "0")
                            {
                                this.dtpBookDoc.Value = this.PrevTime.AddMinutes(-SlotMin);
                            }
                            //Special case for non 00 min contained to reduce dtp time
                            else if (this.PrevTime.Minute.ToString() != "0")
                            {
                                this.dtpBookDoc.Value = this.dtpBookDoc.Value.AddMinutes(-Rm);
                            }
                        }

                        //Special case for 59 sec to reduce dtp time
                        else if (this.dtpBookDoc.Value.Minute.ToString() == "59" && this.PrevTime < this.dtpBookDoc.Value)
                        {
                            if (this.dtpBookDoc.Value.AddHours(-1) > this.dtpBookDoc.MinDate)
                                this.dtpBookDoc.Value = this.dtpBookDoc.Value.AddHours(-1);
                            this.dtpBookDoc.Value = this.dtpBookDoc.Value.AddMinutes(-Rm);
                        }

                        //Adding Slotmins amount of time
                        else if (this.PrevTime < this.dtpBookDoc.Value)
                        {
                            if (this.dtpBookDoc.Value.AddMinutes(SlotMin - Rm) < this.dtpBookDoc.MaxDate)
                                this.dtpBookDoc.Value = this.dtpBookDoc.Value.AddMinutes(SlotMin - Rm);
                            else
                                this.dtpBookDoc.Value = this.dtpBookDoc.Value.AddMinutes(-Rm);
                        }

                        //Removing Slotmins amount of time
                        else if (this.PrevTime > this.dtpBookDoc.Value)
                        {
                            //MessageBox.Show("this.dtpBookDoc.Value.AddMinutes(-Rm) :" + this.dtpBookDoc.Value.AddMinutes(-Rm) +"\n"+ "this.dtpBookDoc.MinDate :" + this.dtpBookDoc.MinDate);
                            if (this.dtpBookDoc.Value.AddMinutes(-Rm) >= this.dtpBookDoc.MinDate)
                                this.dtpBookDoc.Value = this.dtpBookDoc.Value.AddMinutes(-Rm);
                            else
                                this.dtpBookDoc.Value = this.dtpBookDoc.Value.AddMinutes(SlotMin - Rm);
                        }

                        this.PrevTime = this.dtpBookDoc.Value;               //Setting PrevTime before changing dtp again
                        this.Rm = this.dtpBookDoc.Value.Minute % SlotMin;    //Setting reminder before changing dtp again
                    }
                }
                this.LatestTime = this.dtpBookDoc.Value;
                FirstAccessed = true;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormPatient fp = new FormPatient(this.GetId);
            fp.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormBookDoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
