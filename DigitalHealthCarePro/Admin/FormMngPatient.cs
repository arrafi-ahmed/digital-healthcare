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
    public partial class FormMngPatient : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private int serial;
        private string userId;
        private string UserId
        {
            get { return this.userId; }
            set { this.userId = "Pat-" + value; }

        }
        private bool ValidEmail { set; get; }
        private string PrevEmail { set; get; }
        private DataRow Dr { get; set; }
        private DataTable Dt { get; set; }
        public FormMngPatient(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridView();

            this.ValidEmail = false;
        }

        private void PopulateGridView(string sql = "Select * from Patient;")
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvPatient.DataSource = this.Dt;
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
                string query = "select Email from Patient where Email = '" + this.txtEmail.Text + "';";
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
            string sql = "select * from Patient where Id ='" + this.txtId.Text + "';"; //Checking if the same id available in Dt

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
                if (ValidPass(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtName.Text) && !string.IsNullOrWhiteSpace(this.txtAge.Text) && !string.IsNullOrWhiteSpace(this.txtEmail.Text) && !string.IsNullOrWhiteSpace(this.txtPhone.Text) && !string.IsNullOrWhiteSpace(this.txtBloodG.Text) && !string.IsNullOrWhiteSpace(this.txtAddress.Text))
                {
                    ValidEmailCheck();

                    if (ValidEmail)
                    {
                        string sql2 = @"update Patient
                        set Password = '" + this.txtPassword.Text + @"',
                        Name = '" + this.txtName.Text + @"',
                        Age = " + this.txtAge.Text + @",
                        Email = '" + this.txtEmail.Text + @"',
                        Phone = '" + this.txtPhone.Text + @"',
                        BloodGroup = '" + this.txtBloodG.Text + @"',
                        Address = '" + this.txtAddress.Text + @"'
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
                string query = "select Id from Patient;"; //Checking if the table is empty
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
                string sql2 = "select Email from Patient where Email = '" + this.txtEmail.Text + "';";

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

                else if (ValidPass(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtPassword.Text) && !string.IsNullOrWhiteSpace(this.txtName.Text) && !string.IsNullOrWhiteSpace(this.txtAge.Text) && !string.IsNullOrWhiteSpace(this.txtEmail.Text) && !string.IsNullOrWhiteSpace(this.txtPhone.Text) && !string.IsNullOrWhiteSpace(this.txtBloodG.Text) && !string.IsNullOrWhiteSpace(this.txtAddress.Text))
                {
                    sql = @"insert into Patient
                    values ('" + this.UserId + "', '" + this.txtPassword.Text + "', '" + this.txtName.Text + "', " + this.txtAge.Text + ", '" + this.txtEmail.Text + "','" + this.txtPhone.Text + "', '" + this.txtBloodG.Text + "', '" + this.txtAddress.Text + "');";
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
        
        private void DgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvPatient.CurrentRow.Cells["Id"].Value.ToString();
                this.txtPassword.Text = this.dgvPatient.CurrentRow.Cells["Password"].Value.ToString();
                this.txtName.Text = this.dgvPatient.CurrentRow.Cells["PatName"].Value.ToString();
                this.txtAge.Text = this.dgvPatient.CurrentRow.Cells["Age"].Value.ToString();
                this.PrevEmail = this.txtEmail.Text = this.dgvPatient.CurrentRow.Cells["Email"].Value.ToString();
                this.txtPhone.Text = this.dgvPatient.CurrentRow.Cells["Phone"].Value.ToString();
                this.txtBloodG.Text = this.dgvPatient.CurrentRow.Cells["Blood"].Value.ToString();
                this.txtAddress.Text = this.dgvPatient.CurrentRow.Cells["Address"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvPatient.CurrentRow.Cells["Id"].Value.ToString();
            string sql = "delete from Patient where Id = '" + id + "';";
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
            string sql = "select * from Patient where Name = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
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

        private void FormMngPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
