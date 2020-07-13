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
    public partial class FormBookHp : MetroFramework.Forms.MetroForm
    {
        private int serial;
        private string bookId;
        private string BookId
        {
            get { return this.bookId; }
            set { this.bookId = "Bih-" + value; }
        }
        private string GetId { set; get; }
        private string HpId { set; get; }
        private string TestId { set; get; }
        private string Slot { set; get; }
        private int AvailableSlot { set; get; }
        private DataTable Dt { set; get; }
        private DataRow Dr { get; set; }
        
        public FormBookHp(string GetId, string HpId, string TestName)
        {
            InitializeComponent();
            this.GetId = this.lblIdPat.Text = GetId;
            this.HpId = HpId;

            if (string.IsNullOrWhiteSpace(TestName))
                PopulateTestName();

            else
            {
                this.cmbTest.Items.Add(TestName);
                this.cmbTest.SelectedIndex = 0;
            }
           

            //Reset Block Info
            this.blockDateInfo.Visible = false;
            this.blockSlotInfo.Visible = false;
        }

        private void ShowInfo()
        {
            string sql = "Select * from Hospital where Id = '" + this.HpId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                this.lblIdHp.Text = this.Dt.Rows[0]["Id"].ToString();
                this.lblName.Text = this.Dt.Rows[0]["Name"].ToString();
                this.lblOpenHr.Text = this.Dt.Rows[0]["WeekStart"].ToString() + "-" + this.Dt.Rows[0]["WeekEnd"].ToString() + " / " + this.Dt.Rows[0]["StartTime"].ToString() + "-" + this.Dt.Rows[0]["CloseTime"].ToString();
                this.lblPhone.Text = this.Dt.Rows[0]["Phone"].ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void FormBookHp_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void PopulateTestName()
        {
            this.cmbTest.Items.Clear();

            string sql = "select TestName from HpTest where TestId IN (select TestId from Test_Hp where HpId = '" + this.HpId + "');";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                foreach (DataRow Dr in this.Dt.Rows)
                    this.cmbTest.Items.Add(Dr["TestName"].ToString());
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        //Setting Slot
        private void SetSlot()
        {
            if (this.cmbSlot.Text == "Morning")
                Slot = "M";
            else if (this.cmbSlot.Text == "Afternoon")
                Slot = "A";
            else if (this.cmbSlot.Text == "Night")
                Slot = "N";
            else
                Slot = null;
        }

        private void ShowSlotInfo()
        {
            //Total slots
            string slot = this.cmbSlot.Text;
            string sql = "select " + slot + " from Test_Hp where HpId = '" + this.HpId + "' and TestId = (select TestId from HpTest where TestName = '" + this.cmbTest.Text + "');";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            if (this.Dt.Rows.Count > 0)
            {
                this.totalSlots.Text = this.Dt.Rows[0][slot].ToString();

                //Booked slots
                DateTime HpBook = DateTime.ParseExact(this.dtpBookHp.Text, "dddd , dd , MMMM , yyyy", null);    //Collecting time
                SetSlot();                                                                                      //Setting slot
                string sql2 = "select count(Slot) as Slot from HpBook where Slot = '" + this.Slot + "' and Time = '" + HpBook.Date + "' and HpId = '" + this.HpId + "' and TestId = '" + this.TestId + "'";

                try
                {
                    this.Dt = DataAccess.GetDataTable(sql2);

                    this.bookedSlots.Text = this.Dt.Rows[0]["Slot"].ToString();
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
               

                //Available slots
                int totalS = Int16.Parse(this.totalSlots.Text);
                int bookedS = Int16.Parse(this.bookedSlots.Text);
                AvailableSlot = totalS - bookedS;
                this.availableSlots.Text = AvailableSlot.ToString();
            }
            else
                this.availableSlots.Text = "N/A";
        }

        //Show blocked info
        private void ShowBlockedInfo()
        {
            DateTime BlockDay = DateTime.ParseExact(this.dtpBookHp.Text, "dddd , dd , MMMM , yyyy", null);

            string sql = "select BlockDay, Morning, Afternoon, Night from HpBlock where Time = '" + BlockDay.Date + "' and HpId = '" + this.HpId + "' and TestId = '" + this.TestId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            //If dt contains data
            if (this.Dt.Rows.Count > 0)
            {
                if (this.Dt.Rows[0]["BlockDay"].ToString() == "True")
                {
                    this.blockDateInfo.Visible = true;
                    this.blockSlotInfo.Visible = false;
                }

                else if (this.Dt.Rows[0]["Morning"].ToString() == "True" && this.cmbSlot.Text == "Morning")
                {
                    this.blockDateInfo.Visible = false;
                    this.blockSlotInfo.Visible = true;
                }

                else if (this.Dt.Rows[0]["Afternoon"].ToString() == "True" && this.cmbSlot.Text == "Afternoon")
                {
                    this.blockDateInfo.Visible = false;
                    this.blockSlotInfo.Visible = true;
                }

                else if (this.Dt.Rows[0]["Night"].ToString() == "True" && this.cmbSlot.Text == "Night")
                {
                    this.blockDateInfo.Visible = false;
                    this.blockSlotInfo.Visible = true;
                }
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //Converting string of dtpBookHp to DateTIme
            DateTime HpBook = DateTime.ParseExact(this.dtpBookHp.Text, "dddd , dd , MMMM , yyyy", null);

            //Auto generated Booking Id
            string query = "select BookId from HpBook ORDER BY CAST(SUBSTRING(BookId, CHARINDEX('-', BookId) + 1, LEN(BookId)) AS INT);"; //Checking if the table is empty

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

            //Setting slot
            SetSlot();

            //Validation for Confirm btn
            if (string.IsNullOrWhiteSpace(this.cmbSlot.Text) || string.IsNullOrWhiteSpace(this.cmbTest.Text))
                MessageBox.Show("Select Test and Slot first!");

            else if (this.AvailableSlot == 0)
                MessageBox.Show("All slots are booked!");

            else if(this.blockDateInfo.Visible == true || this.blockSlotInfo.Visible == true)
                MessageBox.Show("Selected slot is blocked for booking!");

            else
            {
                //Opening payment page
                this.Visible = false;
                FormMakePay fmp = new FormMakePay(this.GetId, this.BookId, this.HpId, this.lblFee.Text, HpBook, this.TestId, this.Slot);
                fmp.Visible = true;
            }
        }

        private void CmbSlot_SelectedValueChanged(object sender, EventArgs e)
        {
            //Reset Block Info
            this.blockDateInfo.Visible = false;
            this.blockSlotInfo.Visible = false;

            //If cmbTest is empty
            if (string.IsNullOrWhiteSpace(this.cmbTest.Text))
                MessageBox.Show("Please select a Test name first!");

            //If cmbTest is selected
            else
                ShowSlotInfo();

            if (!string.IsNullOrWhiteSpace(this.cmbTest.Text) || !string.IsNullOrWhiteSpace(this.cmbSlot.Text))
                ShowBlockedInfo();
        }

        private void DtpBookHp_ValueChanged(object sender, EventArgs e)
        {
            //Reset Block Info
            this.blockDateInfo.Visible = false;
            this.blockSlotInfo.Visible = false;

            //Setting min and max date in dtpBookDoc
            this.dtpBookHp.MinDate = DateTime.Now;
            this.dtpBookHp.MaxDate = DateTime.Now.AddDays(30);

            //If cmbTest and cmbSlot is selected
            if (!string.IsNullOrWhiteSpace(this.cmbTest.Text) && !string.IsNullOrWhiteSpace(this.cmbSlot.Text))
            {
                ShowSlotInfo();
                ShowBlockedInfo();
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

        private void CmbTest_SelectedValueChanged(object sender, EventArgs e)
        {
            //Reset Block Info
            this.blockDateInfo.Visible = false;
            this.blockSlotInfo.Visible = false;

            //TestId
            string query = "select TestId from HpTest where TestName = '" + this.cmbTest.Text + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(query);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            if (this.Dt.Rows.Count > 0)
                TestId = this.Dt.Rows[0]["TestId"].ToString();

            //If cmbslot is selected
            if (!string.IsNullOrWhiteSpace(this.cmbSlot.Text))
                ShowSlotInfo();

            if (!string.IsNullOrWhiteSpace(this.cmbTest.Text))
                ShowBlockedInfo();

            //Setting fee and testid fields
            string sql = "select TestCharge from Test_Hp where TestId = '" + this.TestId + "' and HpId = '" + this.HpId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                this.lblTestId.Text = this.TestId;
                this.lblFee.Text = this.Dt.Rows[0]["TestCharge"].ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void FormBookHp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
