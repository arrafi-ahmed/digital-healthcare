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
    public partial class FormMngDoctor : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private int serial;
        private string userId;
        private string UserId
        {
            get { return this.userId; }
            set { this.userId = "Doc-" + value; }
        }
        private bool ValidEmail { set; get; }
        private string PrevEmail { set; get; }
        private DataRow Dr { get; set; }
        private DataTable Dt { get; set; }
        public FormMngDoctor(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridView();

            this.cmbCountry.DataSource = DataAccess.GetCountry();
            this.ValidEmail = false;
        }

        private void PopulateGridView(string sql = "Select * from Doctor;")
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvDoctor.DataSource = this.Dt;
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
                string query = "select Email from Doctor where Email = '" + this.txtEmail.Text + "';";
                try
                {
                    this.Dt = DataAccess.GetDataTable(query);

                    if (this.Dt.Rows.Count > 0)  //Invalid if new email exist on db
                        ValidEmail = false;
                    else                         //Valid if new email doesnt exist on db
                        ValidEmail = true;
                }

                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }
        }

        //Finding valid slotmin input
        private bool ValidSlotMin()
        {
            int input = Int16.Parse(this.txtSlotMin.Text);
            var validSlotMins = new List<Tuple<int, int>>(); //List with 2 int inputting at same time

            for (int i = 1; i <= 6; i++)    //Finding 60's multiplicity
            {
                if (60 % i == 0)
                {
                    int j = 60 / i;
                    validSlotMins.Add(new Tuple<int, int>(i, j));
                }
            }

            foreach (var validSlotMin in validSlotMins)
            {
                if (validSlotMin.Item1 == input || validSlotMin.Item2 == input)
                    return true;
            }
            return false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from Doctor where Id ='" + this.txtId.Text + "';"; //Checking if the same id available in Dt
            
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
                if ( ValidPass(this.txtPassword.Text) && ValidSlotMin() && !string.IsNullOrWhiteSpace(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtName.Text) && !string.IsNullOrWhiteSpace(this.txtEmail.Text) && !string.IsNullOrWhiteSpace(this.txtAge.Text) && !string.IsNullOrWhiteSpace(this.txtQualifications.Text) && !string.IsNullOrWhiteSpace(this.txtPhone.Text) && !string.IsNullOrWhiteSpace(this.txtDept.Text) && !string.IsNullOrWhiteSpace(this.txtAddressLn.Text) && !string.IsNullOrWhiteSpace(this.txtCity.Text) && !string.IsNullOrWhiteSpace(this.cmbCountry.Text) && !string.IsNullOrWhiteSpace(this.txtFee.Text) && !string.IsNullOrWhiteSpace(this.txtSlotMin.Text) && this.cmbWeekStart.SelectedIndex != -1 && this.cmbWeekStart.SelectedIndex != -1)
                {
                    ValidEmailCheck();
                    
                    if (ValidEmail)
                    {
                        string sql2 = @"update Doctor
                        set Password = '" + this.txtPassword.Text + @"',
                        Name = '" + this.txtName.Text + @"',
                        Email = '" + this.txtEmail.Text + @"',
                        Age = " + this.txtAge.Text + @",
                        Qualifications = '" + this.txtQualifications.Text + @"',
                        Phone = '" + this.txtPhone.Text + @"',
                        Dept = '" + this.txtDept.Text + @"',
                        AddressLn = '" + this.txtAddressLn.Text + @"',
                        City = '" + this.txtCity.Text + @"',
                        Country = '" + this.cmbCountry.Text + @"',
                        WeekStart = '" + this.cmbWeekStart.Text + @"',
                        WeekEnd = '" + this.cmbWeekEnd.Text + @"',
                        StartTime = '" + this.dtpStartTime.Text + @"',
                        CloseTime = '" + this.dtpCloseTime.Text + @"',
                        Fee = " + this.txtFee.Text + @",
                        SlotMin = " + this.txtSlotMin.Text + @"
                        where Id = '" + this.txtId.Text + @"'";

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

                else if (!ValidSlotMin())
                    MessageBox.Show("Invalid Slot Duration! Valid inputs are: \n1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60");

                else
                    MessageBox.Show("Enter all the fields!");
            }

            //Insert
            else
            {
                //Auto generated UserId
                string query = "select Id from Doctor;"; //Checking if the table is empty
                
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
                string sql2 = "select Email from Doctor where Email = '" + this.txtEmail.Text + "';";

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

                else if (ValidPass(this.txtPassword.Text) && ValidSlotMin() && !string.IsNullOrWhiteSpace(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtName.Text) && !string.IsNullOrWhiteSpace(this.txtEmail.Text) && !string.IsNullOrWhiteSpace(this.txtAge.Text) && !string.IsNullOrWhiteSpace(this.txtQualifications.Text) && !string.IsNullOrWhiteSpace(this.txtPhone.Text) && !string.IsNullOrWhiteSpace(this.txtDept.Text) && !string.IsNullOrWhiteSpace(this.txtAddressLn.Text) && !string.IsNullOrWhiteSpace(this.txtCity.Text) && !string.IsNullOrWhiteSpace(this.cmbCountry.Text) && !string.IsNullOrWhiteSpace(this.txtFee.Text) && !string.IsNullOrWhiteSpace(this.txtSlotMin.Text) && this.cmbWeekStart.SelectedIndex != -1 && this.cmbWeekStart.SelectedIndex != -1)
                {
                    sql = @"insert into Doctor
                    values ( '" + this.UserId + @"',
                            '" + this.txtPassword.Text + @"',
                            '" + this.txtName.Text + @"',
                            '" + this.txtEmail.Text + @"',
                            " + this.txtAge.Text + @",
                            '" + this.txtQualifications.Text + @"',
                            '" + this.txtPhone.Text + @"',
                            '" + this.txtDept.Text + @"',
                            '" + this.txtAddressLn.Text + @"',
                            '" + this.txtCity.Text + @"',
                            '" + this.cmbCountry.Text + @"',
                            '" + this.cmbWeekStart.Text + @"',
                            '" + this.cmbWeekEnd.Text + @"',
                            '" + this.dtpStartTime.Text + @"',
                            '" + this.dtpCloseTime.Text + @"',
                            " + this.txtFee.Text + @",
                            " + this.txtSlotMin.Text + ");";
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

                else if (!ValidSlotMin())
                    MessageBox.Show("Invalid Slot Duration! Valid inputs are: \n1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60");

                else
                    MessageBox.Show("Enter all the fields!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvDoctor.CurrentRow.Cells["Id"].Value.ToString();
            string sql = "delete from Doctor where Id = '" + id + "';";
            
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Doctor where Name = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void DgvDoctor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvDoctor.CurrentRow.Cells["Id"].Value.ToString();
                this.txtDept.Text = this.dgvDoctor.CurrentRow.Cells["Dept"].Value.ToString();
                this.txtPassword.Text = this.dgvDoctor.CurrentRow.Cells["Password"].Value.ToString();
                this.txtName.Text = this.dgvDoctor.CurrentRow.Cells["DocName"].Value.ToString();
                this.PrevEmail = this.txtEmail.Text = this.dgvDoctor.CurrentRow.Cells["Email"].Value.ToString();
                this.txtAge.Text = this.dgvDoctor.CurrentRow.Cells["Age"].Value.ToString();
                this.txtFee.Text = this.dgvDoctor.CurrentRow.Cells["Fee"].Value.ToString();
                this.txtPhone.Text = this.dgvDoctor.CurrentRow.Cells["Phone"].Value.ToString();
                this.txtAddressLn.Text = this.dgvDoctor.CurrentRow.Cells["AddressLn"].Value.ToString();
                this.txtCity.Text = this.dgvDoctor.CurrentRow.Cells["City"].Value.ToString();
                this.cmbCountry.Text = this.dgvDoctor.CurrentRow.Cells["Country"].Value.ToString();
                this.cmbWeekStart.Text = this.dgvDoctor.CurrentRow.Cells["WeekStart"].Value.ToString();
                this.cmbWeekEnd.Text = this.dgvDoctor.CurrentRow.Cells["WeekEnd"].Value.ToString();
                this.dtpStartTime.Text = this.dgvDoctor.CurrentRow.Cells["StartTime"].Value.ToString();
                this.dtpCloseTime.Text = this.dgvDoctor.CurrentRow.Cells["CloseTime"].Value.ToString();
                this.txtQualifications.Text = this.dgvDoctor.CurrentRow.Cells["Qualifications"].Value.ToString();
                this.txtSlotMin.Text = this.dgvDoctor.CurrentRow.Cells["SlotDuration"].Value.ToString();
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

        private void FormMngDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}