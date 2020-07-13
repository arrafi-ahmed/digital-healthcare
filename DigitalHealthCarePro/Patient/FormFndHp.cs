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
    public partial class FormFndHp : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private string PrevTestName { set; get; }
        private int PrevTestIndex { set; get; }
        private bool PrevTest { set; get; }
        private bool Accessed { set; get; }
        private List<int> FeeList { set; get; }
        private bool SetFilter { set; get; }
        private DataTable Dt { get; set; }

        public FormFndHp(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridView();

            this.pnlSearch.Visible = false;
        }

        private void PopulateGridView(string sql = "Select * from Hospital;")
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvHp.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void PopulateTestName()
        {
            this.cmbTest.Items.Clear();

            string sql = "select TestName, TestCharge from HpTest h, Test_Hp t where h.TestId = t.TestId and HpId = '" + this.txtId.Text + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                this.FeeList = new List<int>();
                foreach (DataRow Dr in this.Dt.Rows)
                {
                    this.cmbTest.Items.Add(Dr["TestName"].ToString());
                    this.FeeList.Add(Int32.Parse(Dr["TestCharge"].ToString()));
                }
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (SetFilter)
            {
                string searchName = null, searchCountry = null, searchCity = null, searchTest = null;

                if (!string.IsNullOrWhiteSpace(this.txtSearch.Text))
                    searchName = "Name = '" + this.txtSearch.Text + "'";

                if (this.cmbSearchCountry.SelectedIndex != -1)
                {
                    if (!string.IsNullOrWhiteSpace(this.txtSearch.Text))
                        searchCountry = " and Country = '" + this.cmbSearchCountry.Text + "'";
                    else
                        searchCountry = " Country = '" + this.cmbSearchCountry.Text + "'";
                }

                if (!string.IsNullOrWhiteSpace(this.txtSearchCity.Text))
                {
                    if (!string.IsNullOrWhiteSpace(this.txtSearchCity.Text) || this.cmbSearchCountry.SelectedIndex != -1 || !string.IsNullOrWhiteSpace(this.txtSearch.Text))
                        searchCity = " and City = '" + this.txtSearchCity.Text + "'";
                    else
                        searchCity = " City = '" + this.txtSearchCity.Text + "'";
                }

                if (this.cmbSearchTest.SelectedIndex != -1)
                {
                    if (this.cmbSearchTest.SelectedIndex != 0 || !string.IsNullOrWhiteSpace(this.txtSearchCity.Text) || this.cmbSearchCountry.SelectedIndex != -1 || !string.IsNullOrWhiteSpace(this.txtSearch.Text))
                        searchTest = " and Id in (select HpId from Test_Hp where TestId IN (select TestId from HpTest where TestName = '"+ this.cmbSearchTest.Text + "'))";

                    else 
                        searchTest = " Id in (select HpId from Test_Hp where TestId IN (select TestId from HpTest where TestName = '" + this.cmbSearchTest.Text + "'))";
                }

                string sql = "select * from Hospital where " + searchName + " " + searchCountry + " " + searchCity + " " + searchTest + ";";
                this.PopulateGridView(sql);
            }

            else
            {
                string sql = "select * from Hospital where Name = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
        }

        private void DgvHp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvHp.CurrentRow.Cells["Id"].Value.ToString();
                this.txtName.Text = this.dgvHp.CurrentRow.Cells["HpName"].Value.ToString();
                this.txtEmail.Text = this.dgvHp.CurrentRow.Cells["Email"].Value.ToString();
                this.txtPhone.Text = this.dgvHp.CurrentRow.Cells["Phone"].Value.ToString();
                this.txtAddress.Text = this.dgvHp.CurrentRow.Cells["AddressLn"].Value.ToString() + ", " + this.dgvHp.CurrentRow.Cells["City"].Value.ToString() + ", " + this.dgvHp.CurrentRow.Cells["Country"].Value.ToString();
                this.txtOpeningHr.Text = this.dgvHp.CurrentRow.Cells["WeekStart"].Value.ToString() + "-" + this.dgvHp.CurrentRow.Cells["WeekEnd"].Value.ToString() + ", " + this.dgvHp.CurrentRow.Cells["StartTime"].Value.ToString() + "-" + this.dgvHp.CurrentRow.Cells["CloseTime"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            PopulateTestName();

            bool resetTest = false;

            if (PrevTest)
            {
                foreach (string testName in cmbTest.Items)
                {
                    if (testName == this.PrevTestName)
                    {
                        this.cmbTest.SelectedValue = this.PrevTestName;
                        break;
                    }

                    else
                        resetTest = true;
                }
            }

            if (resetTest)
            {
                //Reset test info
                this.cmbTest.ResetText();
                this.txtFee.Clear();
            }

            Accessed = false;

            if (!Accessed && !resetTest && cmbTest.SelectedIndex != -1)
            {
                cmbTest.SelectedIndex = 0;
                Accessed = true;
            }
               
            if (this.cmbSearchTest.SelectedIndex != -1)
                this.cmbTest.Text = this.cmbSearchTest.Text;

            Accessed = true;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtId.Text))
                MessageBox.Show("Please select a Hospital first!");

            else if (this.cmbTest.SelectedIndex == -1)
                MessageBox.Show("Please select an available test!");

            else
            {
                this.Visible = false;
                FormBookHp fbh = new FormBookHp(this.lblId.Text, this.txtId.Text, this.cmbTest.Text);
                fbh.Visible = true;
            }
        }
        
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            this.pnlSearch.Visible = true;
            this.btnSearch.Location = new Point(767, 234);
            this.cmbSearchCountry.DataSource = DataAccess.GetCountry();
            SetFilter = true;

            //Populate cmbSearchTest
            string query = "select TestName from HpTest;";

            try
            {
                this.Dt = DataAccess.GetDataTable(query);

                foreach (DataRow Dr in this.Dt.Rows)
                    this.cmbSearchTest.Items.Add(Dr["TestName"].ToString());
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void CmbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbTest.SelectedIndex > -1)
                this.txtFee.Text = FeeList[cmbTest.SelectedIndex].ToString();

            if (Accessed)
            {
                this.PrevTestIndex = this.cmbTest.SelectedIndex;
                this.PrevTestName = this.cmbTest.Items[PrevTestIndex].ToString();
                PrevTest = true;
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
            FormPatient fp = new FormPatient(this.GetId);
            fp.Visible = true;
        }

        private void FormFndHp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }    
}
