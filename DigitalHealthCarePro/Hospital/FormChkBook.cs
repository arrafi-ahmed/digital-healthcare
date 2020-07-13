using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalHealthCarePro.Hospital
{
    public partial class FormChkBook : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private string TestId { set; get; }
        private int [] SlotA { set; get; }
        private string Slot { set; get; }
        private DataTable Dt { set; get; }
        private DataSet Ds { set; get; }

        public FormChkBook(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;

            //Reset Block Info
            this.blockDateInfo.Visible = false;
            this.blockSlotInfo.Visible = false;

            //Setting min and max date in dtpBookHp
            this.dtpChkBookHp.MinDate = DateTime.Now;
            this.dtpChkBookHp.MaxDate = DateTime.Now.AddDays(30);

            PopulateTestName();
        }

        //Populate test names
        private void PopulateTestName()
        {
            this.cmbTest.Items.Clear();

            string sql = "select TestName from HpTest where TestId in (select TestId from Test_Hp where HpId = '"+ this.GetId +"');";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                foreach (DataRow Dr in this.Dt.Rows)
                {
                    this.cmbTest.Items.Add(Dr["TestName"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        //Setting Slot
        private void SetSlotValue()
        {
            //Set int Slot
            SlotA = new int[3];
            if (this.cmbSlot.Text == "Morning")
                SlotA[0] = 1;
            else
                SlotA[0] = 0;

            if (this.cmbSlot.Text == "Afternoon")
                SlotA[1] = 1;
            else
                SlotA[1] = 0;

            if (this.cmbSlot.Text == "Night")
                SlotA[2] = 1;
            else
                SlotA[2] = 0;
         }

        //Set slot
        private void SetSlot() {

            //Set string Slot
            if (this.cmbSlot.Text == "Morning")
                Slot = "M";

            else if (this.cmbSlot.Text == "Afternoon")
                Slot = "A";

            else if (this.cmbSlot.Text == "Night")
                Slot = "N";
        }

        //Show all Slot info
        private void ShowAllSlotInfo()
        {
            //Total slots
            string sql = "select Morning, Afternoon, Night from Test_Hp where HpId = '" + this.GetId + "' and TestId = '" + this.TestId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                if (this.Dt.Rows.Count > 0)
                {
                    this.totalSlotsM.Text = this.Dt.Rows[0]["Morning"].ToString();
                    this.totalSlotsA.Text = this.Dt.Rows[0]["Afternoon"].ToString();
                    this.totalSlotsN.Text = this.Dt.Rows[0]["Night"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
           
            //Booked slots 
            DateTime HpBook = DateTime.ParseExact(this.dtpChkBookHp.Text, "dddd , dd , MMMM , yyyy", null);    //Collecting time
            SetSlot();                                                                                         //Setting slot

            string sql2 = "select count(Slot) as Slot from HpBook where Slot = 'M' and Time = '" + HpBook.Date + "' and HpId = '" + this.GetId + "' and TestId = '" + this.TestId + "';";
            string sql3 = "select count(Slot) as Slot from HpBook where Slot = 'A' and Time = '" + HpBook.Date + "' and HpId = '" + this.GetId + "' and TestId = '" + this.TestId + "';";
            string sql4 = "select count(Slot) as Slot from HpBook where Slot = 'N' and Time = '" + HpBook.Date + "' and HpId = '" + this.GetId + "' and TestId = '" + this.TestId + "';";

            try
            {
                this.Ds = DataAccess.GetDataSet(sql2 + sql3 + sql4);

                this.bookedSlotsM.Text = this.Ds.Tables[0].Rows[0]["Slot"].ToString();
                this.bookedSlotsA.Text = this.Ds.Tables[1].Rows[0]["Slot"].ToString();
                this.bookedSlotsN.Text = this.Ds.Tables[2].Rows[0]["Slot"].ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            //Available slots
            int totalM = Int16.Parse(this.totalSlotsM.Text);
            int totalA = Int16.Parse(this.totalSlotsA.Text);
            int totalN = Int16.Parse(this.totalSlotsN.Text);

            int bookedM = Int16.Parse(this.bookedSlotsM.Text);
            int bookedA = Int16.Parse(this.bookedSlotsA.Text);
            int bookedN = Int16.Parse(this.bookedSlotsN.Text);

            int availM = totalM - bookedM;
            int availA = totalA - bookedA;
            int availN = totalN - bookedN;

            this.availableSlotsM.Text = availM.ToString();
            this.availableSlotsA.Text = availA.ToString();
            this.availableSlotsN.Text = availN.ToString();
        }

        //Show blocked info
        private void ShowBlockedInfo()
        {
            DateTime BlockDay = DateTime.ParseExact(this.dtpChkBookHp.Text, "dddd , dd , MMMM , yyyy", null);


            string sql = "select BlockDay, Morning, Afternoon, Night from HpBlock where Time = '" + BlockDay.Date + "' and HpId = '" + this.GetId + "' and TestId = '" + this.TestId + "';";

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

        //Set TestId
        private void SetTestId()
        {
            string query = "select TestId from HpTest where TestName = '" + this.cmbTest.Text + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(query);

                if (this.Dt.Rows.Count > 0)
                {
                    TestId = this.Dt.Rows[0]["TestId"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnBlockSlot_Click(object sender, EventArgs e)
        {
            DateTime BlockDate = DateTime.ParseExact(this.dtpChkBookHp.Text, "dddd , dd , MMMM , yyyy", null);

            //TestId
            SetTestId();

            //Check if selected booking already exisit
            if (!string.IsNullOrWhiteSpace(this.cmbSlot.Text))
            {
                string sql = "select " + this.cmbSlot.Text + " as Slot, Id, BlockDay from HpBlock where Time = '" + BlockDate + "' and HpId = '" + this.GetId + "' and TestId = '" + this.TestId + "';";

                try
                {
                    this.Dt = DataAccess.GetDataTable(sql);
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }
            
            //Check if fields are empty
            if (string.IsNullOrWhiteSpace(this.cmbTest.Text) || string.IsNullOrWhiteSpace(this.cmbSlot.Text))
                MessageBox.Show("Please select all the fields first!");

            //Update row if same booking exists
            else if (this.Dt.Rows.Count > 0)
            {
                //Check if the date is already blocked
                if (this.blockDateInfo.Visible)
                    MessageBox.Show("Selected date is already blocked for the test!");

                //Check if the slot is already blocked
                else if (this.blockSlotInfo.Visible)
                    MessageBox.Show("Selected slot is already blocked for the test!");

                //Else update
                else
                {
                    string sql2 = "update HpBlock set " + this.cmbSlot.Text + " = 1 where Id = " + this.Dt.Rows[0]["Id"] + ";";

                    try
                    {
                        DataAccess.ExecuteQuery(sql2);
                        MessageBox.Show("Another slot successfully blocked!");
                    }
                    catch
                    {
                        MessageBox.Show("Error: Something went wrong!");
                    }
                }
            }

            //Insert in db
            else if (this.Dt.Rows.Count == 0)
            {
                //Setting slot value
                SetSlotValue();

                //Insert into HpBlock
                string sql3 = "insert into HpBlock values ('" + BlockDate.Date + "', '" + this.GetId + "', '" + this.TestId + "', 0, '" + SlotA[0] + "', '" + SlotA[1] + "', '" + SlotA[2] + "')";

                try
                {
                    DataAccess.ExecuteQuery(sql3);
                    MessageBox.Show("Slot successfully blocked!");
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }

            ShowBlockedInfo();
        }

        private void BtnBlockDay_Click(object sender, EventArgs e)
        {
            DateTime BlockDate = DateTime.ParseExact(this.dtpChkBookHp.Text, "dddd , dd , MMMM , yyyy", null);

            //TestId
            SetTestId();

            //Check if selected booking already exisit
            string sql = "select Id, BlockDay from HpBlock where Time = '" + BlockDate + "' and HpId = '" + this.GetId + "' and TestId = '" + this.TestId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            if (string.IsNullOrWhiteSpace(this.cmbTest.Text)) 
                MessageBox.Show("Please select a test first!");

            //Update row if same booking exists
            else if (this.Dt.Rows.Count > 0)
            {
                //Check if the date is already blocked
                if (this.blockDateInfo.Visible)
                    MessageBox.Show("Selected date is already blocked for the test!");

                //Else update
                else
                {
                    string sql2 = "update HpBlock set BlockDay = 1 where Id = " + this.Dt.Rows[0]["Id"] + ";";

                    try
                    {
                        DataAccess.ExecuteQuery(sql2);
                        MessageBox.Show("Day blocked successfully!");
                    }
                    catch
                    {
                        MessageBox.Show("Error: Something went wrong!");
                    }
                }
            }

            //Insert in db
            else if (this.Dt.Rows.Count == 0)
            {
                //Insert into HpBlock
                string sql3 = "insert into HpBlock values ('" + BlockDate.Date + "', '" + this.GetId + "', '" + this.TestId + "', 1, 0, 0, 0)";

                try
                {
                    DataAccess.ExecuteQuery(sql3);
                    MessageBox.Show("Day successfully blocked!");
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }

            ShowBlockedInfo();
        }

        private void DtpChkBookHp_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Reset Block Info
                this.blockDateInfo.Visible = false;
                this.blockSlotInfo.Visible = false;

                //TestId
                SetTestId();

                //Setting min and max date in dtpBookHp
                this.dtpChkBookHp.MinDate = DateTime.Now;
                this.dtpChkBookHp.MaxDate = DateTime.Now.AddDays(30);

                //If cmbTest and cmbSlot is selected
                if (!string.IsNullOrWhiteSpace(this.cmbTest.Text))
                {
                    ShowAllSlotInfo();
                    ShowBlockedInfo();
                }
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void CmbSlot_SelectedValueChanged(object sender, EventArgs e)
        {
            //Reset Block Info
            this.blockDateInfo.Visible = false;
            this.blockSlotInfo.Visible = false;

            //TestId
            SetTestId();

            //If cmbTest, dtpBookHp and cmbSlot is selected
            if (!string.IsNullOrWhiteSpace(this.cmbTest.Text) || !string.IsNullOrWhiteSpace(this.cmbSlot.Text))
                ShowBlockedInfo();
        }

        private void CmbTest_SelectedValueChanged(object sender, EventArgs e)
        {
            //Reset Block Info
            this.blockDateInfo.Visible = false;
            this.blockSlotInfo.Visible = false;

            //TestId
            SetTestId();

            //If cmbslot is selected
            if (!string.IsNullOrWhiteSpace(this.cmbTest.Text))
            {
                ShowAllSlotInfo();
                ShowBlockedInfo();
            } 
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormHp fh = new FormHp(this.GetId);
            fh.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormChkBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
