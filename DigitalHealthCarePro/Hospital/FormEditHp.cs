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
    public partial class FormEditHp : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private bool ValidEmail { set; get; }
        private string PrevEmail { set; get; }
        private DataTable Dt { set; get; }
        public FormEditHp(string GetId)
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
            if (this.PrevEmail == this.txtHEmail.Text)
                ValidEmail = true;

            //If new email is different than previous own email
            else
            {
                string query = "select Email from Hospital where Email = '" + this.txtHEmail.Text + "';";
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

        private void ShowInfo()
        {
            string sql = "select * from Hospital where Id = '" + this.GetId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                this.txtHId.Text = this.Dt.Rows[0]["Id"].ToString();
                this.txtHPassword.Text = this.Dt.Rows[0]["Password"].ToString();
                this.txtHName.Text = this.Dt.Rows[0]["Name"].ToString();
                this.PrevEmail = this.txtHEmail.Text = this.Dt.Rows[0]["Email"].ToString();
                this.txtHPhone.Text = this.Dt.Rows[0]["Phone"].ToString();
                this.txtHAddressLn.Text = this.Dt.Rows[0]["AddressLn"].ToString();
                this.txtHCity.Text = this.Dt.Rows[0]["City"].ToString();
                this.cmbCountry.Text = this.Dt.Rows[0]["Country"].ToString();
                this.cmbHWeekStart.Text = this.Dt.Rows[0]["WeekStart"].ToString();
                this.cmbHWeekEnd.Text = this.Dt.Rows[0]["WeekEnd"].ToString();
                this.dtpHStartTime.Text = this.Dt.Rows[0]["StartTime"].ToString();
                this.dtpHCloseTime.Text = this.Dt.Rows[0]["CloseTime"].ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidPass(this.txtHPassword.Text) && !string.IsNullOrWhiteSpace(this.txtHPassword.Text) && !string.IsNullOrWhiteSpace(this.txtHEmail.Text) && !string.IsNullOrWhiteSpace(this.txtHPhone.Text) && !string.IsNullOrWhiteSpace(this.txtHAddressLn.Text) && !string.IsNullOrWhiteSpace(this.txtHCity.Text) && !string.IsNullOrWhiteSpace(this.cmbCountry.Text) && this.cmbHWeekStart.SelectedIndex != -1 && this.cmbHWeekStart.SelectedIndex != -1)
            {
                ValidEmailCheck();
                 
                if (ValidEmail)
                {
                    string sql = @"update Hospital
                    set Password = '" + this.txtHPassword.Text + @"',
                    Name = '" + this.txtHName.Text + @"',
                    Email = '" + this.txtHEmail.Text + @"',
                    Phone = '" + this.txtHPhone.Text + @"',
                    AddressLn = '" + this.txtHAddressLn.Text + @"',
                    City = '" + this.txtHCity.Text + @"',
                    Country = '" + this.cmbCountry.Text + @"',
                    WeekStart = '" + this.cmbHWeekStart.Text + @"',
                    WeekEnd = '" + this.cmbHWeekEnd.Text + @"',
                    StartTime = '" + this.dtpHStartTime.Text + @"',
                    CloseTime = '" + this.dtpHCloseTime.Text + @"'
                    where Id = '" + this.txtHId.Text + "';";

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
                    this.txtHEmail.Text = this.PrevEmail;
                }
            }

            else if (!ValidPass(this.txtHPassword.Text))
                InvalidPassMsg();

            else
                MessageBox.Show("Enter all the fields!");
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

        private void FormEditHp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
