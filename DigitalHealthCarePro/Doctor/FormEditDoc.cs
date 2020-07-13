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
    public partial class FormEditDoc : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private bool ValidEmail { set; get; }
        private string PrevEmail { set; get; }
        private DataTable Dt { set; get; }
        public FormEditDoc(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;

            ShowInfo();
            this.cmbCountry.DataSource = DataAccess.GetCountry();
            this.ValidEmail = false;
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
            if (this.PrevEmail == this.txtDEmail.Text)
                ValidEmail = true;

            //If new email is different than previous own email
            else
            {
                string query = "select Email from Doctor where Email = '" + this.txtDEmail.Text + "';";
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

        //Finding valid slotmin input
        private bool ValidSlotMin()
        {
            int input = Int16.Parse(this.txtDSlotMin.Text);
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

        private void ShowInfo()
        {
            string sql = "select * from Doctor where Id = '"+ this.GetId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                this.txtDId.Text = this.Dt.Rows[0]["Id"].ToString();
                this.txtDPassword.Text = this.Dt.Rows[0]["Password"].ToString();
                this.txtDName.Text = this.Dt.Rows[0]["Name"].ToString();
                this.PrevEmail = this.txtDEmail.Text = this.Dt.Rows[0]["Email"].ToString();
                this.txtDAge.Text = this.Dt.Rows[0]["Age"].ToString();
                this.txtDQualifications.Text = this.Dt.Rows[0]["Qualifications"].ToString();
                this.txtDPhone.Text = this.Dt.Rows[0]["Phone"].ToString();
                this.txtDDept.Text = this.Dt.Rows[0]["Dept"].ToString();
                this.txtDAddressLn.Text = this.Dt.Rows[0]["AddressLn"].ToString();
                this.txtDCity.Text = this.Dt.Rows[0]["City"].ToString();
                this.cmbCountry.Text = this.Dt.Rows[0]["Country"].ToString();
                this.cmbDWeekStart.Text = this.Dt.Rows[0]["WeekStart"].ToString();
                this.cmbDWeekEnd.Text = this.Dt.Rows[0]["WeekEnd"].ToString();
                this.dtpDStartTime.Text = this.Dt.Rows[0]["StartTime"].ToString();
                this.dtpDCloseTime.Text = this.Dt.Rows[0]["CloseTime"].ToString();
                this.txtDFee.Text = this.Dt.Rows[0]["Fee"].ToString();
                this.txtDSlotMin.Text = this.Dt.Rows[0]["SlotMin"].ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidPass(this.txtDPassword.Text) && ValidSlotMin() && !string.IsNullOrWhiteSpace(this.txtDPassword.Text) && !string.IsNullOrWhiteSpace(this.txtDEmail.Text) && !string.IsNullOrWhiteSpace(this.txtDAge.Text) && !string.IsNullOrWhiteSpace(this.txtDQualifications.Text) && !string.IsNullOrWhiteSpace(this.txtDPhone.Text) && !string.IsNullOrWhiteSpace(this.txtDDept.Text) && !string.IsNullOrWhiteSpace(this.txtDAddressLn.Text) && !string.IsNullOrWhiteSpace(this.txtDCity.Text) && !string.IsNullOrWhiteSpace(this.cmbCountry.Text) && !string.IsNullOrWhiteSpace(this.txtDFee.Text) && !string.IsNullOrWhiteSpace(this.txtDSlotMin.Text) && this.cmbDWeekStart.SelectedIndex != -1 && this.cmbDWeekStart.SelectedIndex != -1)
            {
                ValidEmailCheck();

                if (ValidEmail)
                {
                    string sql = @"update Doctor
                    set Password = '" + this.txtDPassword.Text + @"',
                    Email = '" + this.txtDEmail.Text + @"',
                    Age = " + this.txtDAge.Text + @",
                    Qualifications = '" + this.txtDQualifications.Text + @"',
                    Phone = '" + this.txtDPhone.Text + @"',
                    Dept = '" + this.txtDDept.Text + @"',
                    AddressLn = '" + this.txtDAddressLn.Text + @"',
                    City = '" + this.txtDCity.Text + @"',
                    Country = '" + this.cmbCountry.Text + @"',
                    WeekStart = '" + this.cmbDWeekStart.Text + @"',
                    WeekEnd = '" + this.cmbDWeekEnd.Text + @"',
                    StartTime = '" + this.dtpDStartTime.Text + @"',
                    CloseTime = '" + this.dtpDCloseTime.Text + @"',
                    Fee = " + this.txtDFee.Text + @",
                    SlotMin = " + this.txtDSlotMin.Text + @"
                    where Id = '" + this.GetId + @"'";

                    try
                    {
                        DataAccess.ExecuteQuery(sql);
                        MessageBox.Show("Updated Succesfully!");
                        this.ShowInfo();
                    }
                    catch
                    {
                        MessageBox.Show("Error: Something went wrong!");
                    }
                }

                else 
                {
                    MessageBox.Show("Account with same email already exists!");
                    this.txtDEmail.Text = this.PrevEmail;
                }
            }

            else if (!ValidPass(this.txtDPassword.Text))
                InvalidPassMsg();

            else if (!ValidSlotMin())
                MessageBox.Show("Invalid Slot Duration! Valid inputs are: \n1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60");

            else
                MessageBox.Show("Enter all the fields!");
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

        private void FormEditDoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
