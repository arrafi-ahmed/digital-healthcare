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
    public partial class FormEditPat : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private bool ValidEmail { set; get; }
        private string PrevEmail { set; get; }
        private DataTable Dt { set; get; }
        public FormEditPat(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            ShowInfo();

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
            if (this.PrevEmail == this.txtPEmail.Text)
                ValidEmail = true;

            //If new email is different than previous own email
            else
            {
                string query = "select Email from Patient where Email = '" + this.txtPEmail.Text + "';";
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
            string sql = "select * from Patient where Id = '" + this.GetId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);

                this.txtPId.Text = this.Dt.Rows[0]["Id"].ToString();
                this.txtPPassword.Text = this.Dt.Rows[0]["Password"].ToString();
                this.txtPName.Text = this.Dt.Rows[0]["Name"].ToString();
                this.txtPAge.Text = this.Dt.Rows[0]["Age"].ToString();
                this.txtPBloodG.Text = this.Dt.Rows[0]["BloodGroup"].ToString();
                this.PrevEmail = this.txtPEmail.Text = this.Dt.Rows[0]["Email"].ToString();
                this.txtPPhone.Text = this.Dt.Rows[0]["Phone"].ToString();
                this.txtPAddress.Text = this.Dt.Rows[0]["Address"].ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidPass(this.txtPPassword.Text) && !string.IsNullOrWhiteSpace(this.txtPPassword.Text) && !string.IsNullOrWhiteSpace(this.txtPAge.Text) && !string.IsNullOrWhiteSpace(this.txtPEmail.Text) && !string.IsNullOrWhiteSpace(this.txtPPhone.Text) && !string.IsNullOrWhiteSpace(this.txtPBloodG.Text) && !string.IsNullOrWhiteSpace(this.txtPAddress.Text))
            {
                ValidEmailCheck();

                if (ValidEmail)
                {
                    string sql = @"update Patient
                    set Password = '" + this.txtPPassword.Text + @"',
                    Name = '" + this.txtPName.Text + @"',
                    Age = " + this.txtPAge.Text + @",
                    Email = '" + this.txtPEmail.Text + @"',
                    Phone = '" + this.txtPPhone.Text + @"',
                    BloodGroup = '" + this.txtPBloodG.Text + @"',
                    Address = '" + this.txtPAddress.Text + @"'
                    where Id = '" + this.txtPId.Text + "';";

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
                    this.txtPEmail.Text = this.PrevEmail;
                }
            }

            else if (!ValidPass(this.txtPPassword.Text))
                InvalidPassMsg();

            else
                MessageBox.Show("Enter all the fields!");
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

        private void FormEditPat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
