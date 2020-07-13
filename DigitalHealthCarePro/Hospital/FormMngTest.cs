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
    public partial class FormMngTest : MetroFramework.Forms.MetroForm
    {
        private int serial;
        private string testId;
        private string TestId
        {
            get { return this.testId; }
            set { this.testId = "Tst-" + value; }
        }
        private string GetId { set; get; }
        private DataRow Dr { get; set; }
        private DataTable Dt { get; set; }
        public FormMngTest(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridViewAllTestE();

            tabMngTest.SelectedTab = this.tabAllTest;
            pnlAddTest.Visible = true;
            pnlUpdtOwnTest.Visible = false;
        }

        private void PopulateGridViewAllTestE()
        {
            string sql = "select * from HpTest";
            PopulateGridViewAllTest(sql);
        }
        private void PopulateGridViewOwnTestE()
        {
            string sql = "select t.*, h.TestName from Test_Hp t, HpTest h where h.TestId = t.TestId and HpId = '"+ this.GetId +"';";
            PopulateGridViewOwnTest(sql);
        }

        private void PopulateGridViewAllTest(string sql)
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvAllTest.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void PopulateGridViewOwnTest(string sql)
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvOwnTest.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            //Auto generated Test Id
            string query = "select TestId from HpTest ORDER BY CAST(SUBSTRING(TestId, CHARINDEX('-', TestId) + 1, LEN(TestId)) AS INT);"; //Checking if the table is empty

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
                string lastRowItem = this.Dr["TestId"].ToString();
                string trimValue = lastRowItem.Remove(0, 4);
                this.serial = Int32.Parse(trimValue);
            }
            else
                this.serial = 0;

            //Increamenting TestId
            this.TestId = (++this.serial).ToString("d2");

            //Check if TestName exists
            string sql = "select TestName from HpTest where Testname = '"+ this.txtNewTest.Text + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            if (this.Dt.Rows.Count == 1)
                MessageBox.Show("Test containing same name already exists!");

            else if (string.IsNullOrWhiteSpace(this.txtNewTest.Text))
                MessageBox.Show("Please input a valid Test Name!");

            else
            {
                //Inserting data 
                string sql2 = "insert into HpTest values ('" + this.TestId + "', '" + this.txtNewTest.Text + "');";

                try
                {
                    DataAccess.ExecuteQuery(sql2);
                    MessageBox.Show("New Test added succesfully!");
                    PopulateGridViewAllTestE();
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }
        }

        private void TabMngTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabAllTest == tabMngTest.SelectedTab)
            {
                this.PopulateGridViewAllTestE();
                pnlAddTest.Visible = true;
                pnlUpdtOwnTest.Visible = false;
                pnlAddOwnTest.Visible = true;
            }

            else if (this.tabOwnTest == tabMngTest.SelectedTab)
            {
                this.PopulateGridViewOwnTestE();
                pnlAddTest.Visible = false;
                pnlAddOwnTest.Visible = false;
                pnlUpdtOwnTest.Visible = true;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (this.tabAllTest == tabMngTest.SelectedTab)
            {
                string sql = "select * from HpTest where TestName = '"+ this.txtSearch.Text + "';";
                PopulateGridViewAllTest(sql);
            }

            else if (this.tabOwnTest == tabMngTest.SelectedTab)
            {
                string sql = "select t.*, h.TestName from Test_Hp t, HpTest h where TestName = '" + this.txtSearch.Text + "' and HpId = '" + this.GetId + "' and t.TestId = h.TestId;";
                PopulateGridViewOwnTest(sql);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtChargeUpdate.Text))
                MessageBox.Show("Please input new charge amount!");
            else
            {
                int charge = Int16.Parse(this.txtChargeUpdate.Text);
                int slotM = Int16.Parse(this.txtSlotM.Text);
                int slotA = Int16.Parse(this.txtSlotA.Text);
                int slotN = Int16.Parse(this.txtSlotN.Text);

                //Check if update charge is empty
                if (string.IsNullOrWhiteSpace(this.txtChargeUpdate.Text))
                    MessageBox.Show("Select a Test charge first!");
                else
                {
                    string testId = this.dgvOwnTest.CurrentRow.Cells["TestIdO"].Value.ToString();
                    string sql = "update Test_Hp set TestCharge =  " + charge + ", Morning = '"+ slotM + "', Afternoon = '" + slotA + "', Night = '" + slotN + "' where TestId = '" + testId + "';";

                    try
                    {
                        DataAccess.ExecuteQuery(sql);
                        MessageBox.Show("Test details successfully updated!");
                        this.PopulateGridViewOwnTestE();
                    }
                    catch
                    {
                        MessageBox.Show("Error: Something went wrong!");
                    }
                }
            }
        }

        private void BtnAddOwn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtOwnTestId.Text))
                MessageBox.Show("Please select a Test from the list!");

            else if (string.IsNullOrWhiteSpace(this.txtCharge.Text))
                MessageBox.Show("Please input the charged amount!");

            else
            {
                //Check if TestId exists
                string sql = "select TestId from Test_Hp where TestId = '" + this.txtOwnTestId.Text + "' and HpId = '" + this.GetId + "';";

                try
                {
                    this.Dt = DataAccess.GetDataTable(sql);
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
                
                if (this.Dt.Rows.Count == 1)
                    MessageBox.Show("Test containing same Id already exists!");

                //If fields are null
                else if (string.IsNullOrWhiteSpace(this.slotMorning.Text) || string.IsNullOrWhiteSpace(this.txtCharge.Text) || string.IsNullOrWhiteSpace(this.slotAfternoon.Text) || string.IsNullOrWhiteSpace(this.slotNight.Text))
                {
                    MessageBox.Show("Input all the fields!");
                }

                //Insert into db
                else
                {
                    int charge = Int16.Parse(this.txtCharge.Text);
                    string sql2 = "insert into Test_Hp values ('" + this.GetId + "' , '" + this.txtOwnTestId.Text + "', " + charge + ", '"+ this.slotMorning.Text + "', '" + this.slotAfternoon.Text + "', '" + this.slotNight.Text + "');";

                    try
                    {
                        DataAccess.ExecuteQuery(sql2);
                        MessageBox.Show("Own Test added succesfully!");

                        tabMngTest.SelectedTab = this.tabOwnTest;
                    }
                    catch
                    {
                        MessageBox.Show("Error: Something went wrong!");
                    }
                }
            }
        }

        private void DgvAllTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCharge.Text = null;
            if (this.txtOwnTestId.Text != null)
                this.txtOwnTestId.Text = dgvAllTest.CurrentRow.Cells["TestIdD"].Value.ToString();
        }

        private void DgvOwnTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCharge.Text = null;
            if (this.txtOwnTestIdO.Text != null)
                this.txtOwnTestIdO.Text = dgvOwnTest.CurrentRow.Cells["TestIdO"].Value.ToString();

            if (this.txtChargeUpdate.Text != null)
                this.txtChargeUpdate.Text = dgvOwnTest.CurrentRow.Cells["TestCharge"].Value.ToString();

            if (this.txtSlotN.Text != null)
                this.txtSlotN.Text = dgvOwnTest.CurrentRow.Cells["slotN"].Value.ToString();

            if (this.txtSlotA.Text != null)
                this.txtSlotA.Text = dgvOwnTest.CurrentRow.Cells["slotA"].Value.ToString();

            if (this.txtSlotM.Text != null)
                this.txtSlotM.Text = dgvOwnTest.CurrentRow.Cells["slotM"].Value.ToString();
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormHp fh = new Hospital.FormHp(GetId);
            fh.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormMngTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
