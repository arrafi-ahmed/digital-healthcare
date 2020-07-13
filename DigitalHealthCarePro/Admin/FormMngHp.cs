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
    public partial class FormMngHp : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private int serial;
        private string userId;
        private string UserId
        {
            get { return this.userId; }
            set { this.userId = "Hpt-" + value; }
        }
        private bool ValidEmail { set; get; }
        private string PrevEmail { set; get; }
        private DataRow Dr { get; set; }
        private DataTable Dt { get; set; }
        public FormMngHp(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridView();

            this.cmbCountry.DataSource = DataAccess.GetCountry();
            this.ValidEmail = false;
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

        //Password Verification
        private bool ValidPass(string pass)
        {
            bool passLength = false, hasDigit = false, hasUpper = false, hasLower = false, hasSpecialChar = false;

            if (pass.Length >= 6)
                passLength = true;

            foreach (char c in pass)
            {
                if (char.IsDigit(c))
                    hasDigit = true;

                else if (char.IsUpper(c))
                    hasUpper = true;

                else if (char.IsLower(c))
                    hasLower = true;
            }

            string specialChar = "\\/~!@#$%^&*()-_+={[]};:'\"|,<.>?";
            foreach (char c in specialChar)
            {
                if (pass.Contains(c))
                    hasSpecialChar = true;
            }

            if (passLength && hasDigit && hasUpper && hasLower && hasSpecialChar)
                return true;

            return false;
        }

        //Show message for invalid password input
        private void InvalidPassMsg()
        {
             MessageBox.Show("Invalid Password! Recommended Password must include: \n\n" +
                               "Min length 6 characters \n" +
                               "One Digit \n" +
                               "One Uppercase character \n" +
                               "One Lowercase character \n" +
                               "One Special character ( \\ / ~ ! @ # $ % ^ & * - _ + = { [ ] } ; : ' \" |, < . > ? )\n");
        }

        //Checking valid email
        private void ValidEmailCheck()
        {
            //If new email is same as previous own email
            if (this.PrevEmail == this.txtEmail.Text)
                ValidEmail = true;

            //If new email is different than previous own email
            else
            {
                string query = "select Email from Hospital where Email = '" + this.txtEmail.Text + "';";
                try
                {
                    this.Dt = DataAccess.GetDataTable(query);

                    if (this.Dt.Rows.Count > 0)  //Invalid if new email exist on db
                        ValidEmail = false;
                    else                                                            //Valid if new email doesnt exist on db
                        ValidEmail = true;
                }

                catch (Exception exc)
                {
                    MessageBox.Show("Error: Something went wrong!" + exc);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from Hospital where Id ='" + this.txtId.Text + "';"; //Checking if the same id available in Dt

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }

            //Update
            if (this.Dt.Rows.Count == 1)
            {
                if (ValidPass(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtName.Text) && !string.IsNullOrWhiteSpace(this.txtEmail.Text) && !string.IsNullOrWhiteSpace(this.txtPhone.Text) && !string.IsNullOrWhiteSpace(this.txtAddressLn.Text) && !string.IsNullOrWhiteSpace(this.txtCity.Text) && !string.IsNullOrWhiteSpace(this.cmbCountry.Text) && this.cmbWeekStart.SelectedIndex != -1 && this.cmbWeekStart.SelectedIndex != -1)
                {
                    ValidEmailCheck();

                    if (ValidEmail)
                    {
                        string sql2 = @"update Hospital
                        set Password = '" + this.txtPassword.Text + @"',
                        Name = '" + this.txtName.Text + @"',
                        Email = '" + this.txtEmail.Text + @"',
                        Phone = '" + this.txtPhone.Text + @"',
                        AddressLn = '" + this.txtAddressLn.Text + @"',
                        City = '" + this.txtCity.Text + @"',
                        Country = '" + this.cmbCountry.Text + @"',
                        WeekStart = '" + this.cmbWeekStart.Text + @"',
                        WeekEnd = '" + this.cmbWeekEnd.Text + @"',
                        StartTime = '" + this.dtpStartTime.Text + @"',
                        CloseTime = '" + this.dtpCloseTime.Text + @"'
                        where Id = '" + this.txtId.Text + "';";

                        try
                        {
                            if (ValidEmail)
                            {
                                DataAccess.ExecuteQuery(sql2);
                                MessageBox.Show("Updated Succesfully!");
                                this.PopulateGridView();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error: Something went wrong!");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Account with same email already exists!");
                        this.txtEmail.Text = this.PrevEmail;
                    }
                }

                else if (!ValidPass(this.txtPassword.Text))
                    InvalidPassMsg();

                else
                    MessageBox.Show("Enter all the fields!");
            }

            //Insert
            else
            {
                //Auto generated UserId
                string query = "select Id from Hospital;"; //Checking if the table is empty

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
                    string lastRowItem = this.Dr["Id"].ToString();
                    string trimValue = lastRowItem.Remove(0, 4);
                    this.serial = Int32.Parse(trimValue);
                }
                else
                    this.serial = 0;

                //Increamenting UserId
                this.UserId = (++this.serial).ToString("d2");

                //Check if same email exists in DB
                string sql2 = "select Email from Hospital where Email = '" + this.txtEmail.Text + "';";

                try
                {
                    this.Dt = DataAccess.GetDataTable(sql2);
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }

                if (this.Dt.Rows.Count > 0)
                    MessageBox.Show("Account with same email already exists!");

                else if (ValidPass(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtName.Text) && !string.IsNullOrWhiteSpace(this.txtEmail.Text) && !string.IsNullOrWhiteSpace(this.txtPhone.Text) && !string.IsNullOrWhiteSpace(this.txtAddressLn.Text) && !string.IsNullOrWhiteSpace(this.txtCity.Text) && !string.IsNullOrWhiteSpace(this.cmbCountry.Text) && this.cmbWeekStart.SelectedIndex != -1 && this.cmbWeekStart.SelectedIndex != -1)
                {
                    sql = @"insert into Hospital
                    values ('" + this.UserId + @"',
                            '" + this.txtPassword.Text + @"',
                            '" + this.txtName.Text + @"',
                            '" + this.txtEmail.Text + @"',
                            '" + this.txtPhone.Text + @"', 
                            '" + this.txtAddressLn.Text + @"',
                            '" + this.txtCity.Text + @"',
                            '" + this.cmbCountry.Text + @"',
                            '" + this.cmbWeekStart.Text + @"',
                            '" + this.cmbWeekEnd.Text + @"',
                            '" + this.dtpStartTime.Text + @"',
                            '" + this.dtpCloseTime.Text + "');";
                    try
                    {
                        DataAccess.ExecuteQuery(sql);
                        MessageBox.Show("Added Successfully!");
                        this.PopulateGridView();
                    }
                    catch
                    {
                        MessageBox.Show("Error: Something went wrong!");
                    }
                }

                else if (!ValidPass(this.txtPassword.Text))
                    InvalidPassMsg();

                else
                    MessageBox.Show("Enter all the fields!");
            }
        }

        private void DgvHp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvHp.CurrentRow.Cells["Id"].Value.ToString();
                this.txtPassword.Text = this.dgvHp.CurrentRow.Cells["Password"].Value.ToString();
                this.txtName.Text = this.dgvHp.CurrentRow.Cells["HpName"].Value.ToString();
                this.PrevEmail = this.txtEmail.Text = this.dgvHp.CurrentRow.Cells["Email"].Value.ToString();
                this.txtPhone.Text = this.dgvHp.CurrentRow.Cells["Phone"].Value.ToString();
                this.txtAddressLn.Text = this.dgvHp.CurrentRow.Cells["AddressLn"].Value.ToString();
                this.txtCity.Text = this.dgvHp.CurrentRow.Cells["City"].Value.ToString();
                this.cmbCountry.Text = this.dgvHp.CurrentRow.Cells["Country"].Value.ToString();
                this.cmbWeekStart.Text = this.dgvHp.CurrentRow.Cells["WeekStart"].Value.ToString();
                this.cmbWeekEnd.Text = this.dgvHp.CurrentRow.Cells["WeekEnd"].Value.ToString();
                this.dtpStartTime.Text = this.dgvHp.CurrentRow.Cells["StartTime"].Value.ToString();
                this.dtpCloseTime.Text = this.dgvHp.CurrentRow.Cells["CloseTime"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Hospital where Name = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvHp.CurrentRow.Cells["Id"].Value.ToString();
            string sql = "delete from Hospital where Id = '" + id + "';";
            try
            {
                DataAccess.ExecuteQuery(sql);
                MessageBox.Show("Deleted Successfully!");
                this.PopulateGridView();
            }
            catch 
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdmin fa = new FormAdmin(this.GetId);
            fa.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormMngHp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
