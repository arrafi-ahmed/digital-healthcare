using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalHealthCarePro
{
    public partial class FormRegister : MetroFramework.Forms.MetroForm
    {
        private string Role { set; get; }
        private int serial;
        private string userId;
        private string UserId
        {
            get { return this.userId; }
            set
            {
                if (this.Role == "Doctor")
                    this.userId = "Doc-" + value;

                else if (this.Role == "Hospital")
                    this.userId = "Hpt-" + value;

                else if (this.Role == "Patient")
                    this.userId = "Pat-" + value;
            }
        }
        private DataTable Dt { get; set; }
        private DataRow Dr { get; set; }
        
        public FormRegister(string Role)
        {
            InitializeComponent();

            this.Role = Role;
            this.Text = "Register " + this.Role;

            //Dynamic Form size
            if (this.Role == "Doctor")
            {
                this.Size = new Size(760, 390);

                //Resetting Panel
                this.pnlHp.Visible = false;
                this.pnlPat.Visible = false;
                this.pnlDoc.Visible = true;

                this.cmbDCountry.DataSource = DataAccess.GetCountry();
            }
                
            else if (this.Role == "Hospital")
            {
                this.Size = new Size(692, 385);

                //Resetting Panel
                this.pnlPat.Visible = false;
                this.pnlDoc.Visible = false;
                this.pnlHp.Visible = true;
                
                this.cmbHCountry.DataSource = DataAccess.GetCountry();
            }

            else if (this.Role == "Patient")
            {
                this.Size = new Size(530, 405);

                //Resetting Panel
                this.pnlHp.Visible = false;
                this.pnlDoc.Visible = false;
                this.pnlPat.Visible = true;
            }
        }

        //Back button
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }
        
        //Show Login credentials
        private void ShowLoginInfo(MetroFramework.Controls.MetroTextBox txtUserId, MetroFramework.Controls.MetroTextBox txtPassword)
        {
            txtUserId.Text = this.UserId;

            MessageBox.Show(@"Your Login credentials: " + "\n\n"
                        + "Username: " + this.UserId + "\n"
                        + "Password: " + txtPassword.Text);

            //Take back to login page
            this.Visible = false;
            FormLogin fl = new FormLogin(this.UserId);
            fl.Visible = true;
        }
        
        //Generate Id
        private void GenerateId(string query)
        {
            //Auto generated UserId
            try
            {
                this.Dr = DataAccess.GetLastRow(query); //Checking if the table is empty
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            //Setting serial 
            if (Dr != null)
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
        }

        //Password Verification
        private bool ValidPass(string pass)
        {
            bool passLength = false, hasDigit = false, hasUpper = false, hasLower = false, hasSpecialChar = false;

            if (pass.Length >= 6)
                passLength = true;
            
            foreach(char c in pass)
            {
                if (char.IsDigit(c))
                    hasDigit = true;

                else if(char.IsUpper(c))
                    hasUpper = true;

                else if(char.IsLower(c))
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
            MessageBox.Show("Invalid Password! Recommended Password must include: \n" +
                               "Min length: 6 characters \n" +
                               "One Digit \n" +
                               "One Uppercase character \n" +
                               "One Lowercase character \n" +
                               "One Special character like \\ / ~ ! @ # $ % ^ & * ( ) - _ + = { [ ] } ; : ' \" |, < . > ? \n");
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
                if ( validSlotMin.Item1 == input || validSlotMin.Item2 == input)
                    return true;
            }
            return false;
        }

        //Create Doctor
        private void BtnCreateDoc_Click(object sender, EventArgs e)
        {
            //Generate Id
            string query = "select Id from Doctor;";    
            GenerateId(query);
            
            //Check if same email exists in DB
            string sql = "select Email from Doctor where Email = '"+ this.txtDEmail.Text + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }

            if (this.Dt.Rows.Count > 0)
                MessageBox.Show("Account with same email already exists!");

            else if (ValidPass(this.txtDPassword.Text) && ValidSlotMin() && !string.IsNullOrWhiteSpace(this.txtDPassword.Text) && !string.IsNullOrWhiteSpace(this.txtDName.Text) && !string.IsNullOrWhiteSpace(this.txtDEmail.Text) && !string.IsNullOrWhiteSpace(this.txtDAge.Text) && !string.IsNullOrWhiteSpace(this.txtDQualifications.Text) && !string.IsNullOrWhiteSpace(this.txtDPhone.Text) && !string.IsNullOrWhiteSpace(this.txtDDept.Text) && !string.IsNullOrWhiteSpace(this.txtDAddressLn.Text) && !string.IsNullOrWhiteSpace(this.txtDCity.Text) && !string.IsNullOrWhiteSpace(this.cmbDCountry.Text) && !string.IsNullOrWhiteSpace(this.txtDFee.Text) && !string.IsNullOrWhiteSpace(this.txtDSlotMin.Text) && this.cmbDWeekStart.SelectedIndex != -1 && this.cmbDWeekStart.SelectedIndex != -1)
            {
                bool checkInsert = false;

                //Insert into DB 
                string sql2 = @"insert into Doctor
                values ( '" + this.UserId + @"',
                        '" + this.txtDPassword.Text + @"',
                        '" + this.txtDName.Text + @"',
                        '" + this.txtDEmail.Text + @"',
                        " + this.txtDAge.Text + @",
                        '" + this.txtDQualifications.Text + @"',
                        '" + this.txtDPhone.Text + @"',
                        '" + this.txtDDept.Text + @"',
                        '" + this.txtDAddressLn.Text + @"',
                        '" + this.txtDCity.Text + @"',
                        '" + this.cmbDCountry.Text + @"',
                        '" + this.cmbDWeekStart.Text + @"',
                        '" + this.cmbDWeekEnd.Text + @"',
                        '" + this.dtpDStartTime.Text + @"',
                        '" + this.dtpDCloseTime.Text + @"',
                        " + this.txtDFee.Text + @",
                        " + this.txtDSlotMin.Text + ");";
                try
                {
                    DataAccess.ExecuteQuery(sql2);
                    MessageBox.Show("Added Successfully!");
                    checkInsert = true;
                }

                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }

                //Show Login credentials
                if (checkInsert)
                    ShowLoginInfo(txtDId, this.txtDPassword);   //Send txtId & Password
            }

            else if (!ValidPass(this.txtDPassword.Text))
                InvalidPassMsg();

            else if (!ValidSlotMin())
                MessageBox.Show("Invalid Slot Duration! Valid inputs are: \n1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60");

            else
                MessageBox.Show("Enter all the fields!");
        }

        //Create Hp
        private void BtnCreateHp_Click(object sender, EventArgs e)
        {
            //Generate Id
            string query = "select Id from Hospital;";
            GenerateId(query);

            //Check if same email exists in DB
            string sql = "select Email from Hospital where Email = '" + this.txtDEmail.Text + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            if (this.Dt.Rows.Count > 0)
                MessageBox.Show("Account with same email already exists!");

            else if (ValidPass(this.txtHPassword.Text) && !string.IsNullOrWhiteSpace(this.txtHPassword.Text) && !string.IsNullOrWhiteSpace(this.txtHName.Text) && !string.IsNullOrWhiteSpace(this.txtHEmail.Text) && !string.IsNullOrWhiteSpace(this.txtHPhone.Text) && !string.IsNullOrWhiteSpace(this.txtHAddressLn.Text) && !string.IsNullOrWhiteSpace(this.txtHCity.Text) && !string.IsNullOrWhiteSpace(this.cmbHCountry.Text) && this.cmbHWeekStart.SelectedIndex != -1 && this.cmbHWeekStart.SelectedIndex != -1)
            {
                bool checkInsert = false;

                //Insert into DB 
                string sql2 = @"insert into Hospital
                values ( '" + this.UserId + @"',
                        '" + this.txtHPassword.Text + @"',
                        '" + this.txtHName.Text + @"',
                        '" + this.txtHEmail.Text + @"',
                        '" + this.txtHPhone.Text + @"',
                        '" + this.txtHAddressLn.Text + @"',
                        '" + this.txtHCity.Text + @"',
                        '" + this.cmbHCountry.Text + @"',
                        '" + this.cmbHWeekStart.Text + @"',
                        '" + this.cmbHWeekEnd.Text + @"',
                        '" + this.dtpHStartTime.Text + @"',
                        '" + this.dtpHCloseTime.Text + "');";
                        
                try
                {
                    DataAccess.ExecuteQuery(sql2);
                    MessageBox.Show("Added Successfully!");
                    checkInsert = true;
                }

                catch 
                {
                    MessageBox.Show("Error: Something went wrong!");
                }

                //Show Login credentials
                if (checkInsert)
                    ShowLoginInfo(txtHId, this.txtHPassword);   //Send txtId & Password
            }

            else if (!ValidPass(this.txtHPassword.Text))
                InvalidPassMsg();

            else
                MessageBox.Show("Enter all the fields!");
        }

        //Create Patient
        private void BtnCreatePat_Click(object sender, EventArgs e)
        {
            //Generate Id
            string query = "select Id from Patient;";
            GenerateId(query);

            //Check if same email exists in DB
            string sql = "select Email from Patient where Email = '" + this.txtDEmail.Text + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
            
            if (this.Dt.Rows.Count > 0)
                MessageBox.Show("Account with same email already exists!");

            else if (ValidPass(this.txtPPassword.Text) && !string.IsNullOrWhiteSpace(this.txtPPassword.Text) && !string.IsNullOrWhiteSpace(this.txtPName.Text) && !string.IsNullOrWhiteSpace(this.txtPAge.Text) && !string.IsNullOrWhiteSpace(this.txtPEmail.Text) && !string.IsNullOrWhiteSpace(this.txtPPhone.Text) && !string.IsNullOrWhiteSpace(this.txtPBloodG.Text) && !string.IsNullOrWhiteSpace(this.txtPAddress.Text))
            {
                bool checkInsert = false;

                //Insert into DB 
                string sql2 = @"insert into Patient
                values ( '" + this.UserId + @"',
                        '" + this.txtPPassword.Text + @"',
                        '" + this.txtPName.Text + @"',
                        " + this.txtPAge.Text + @",
                        '" + this.txtPEmail.Text + @"',
                        '" + this.txtPPhone.Text + @"',
                        '" + this.txtPBloodG.Text + @"',
                        '" + this.txtPAddress.Text + "');";

                try
                {
                    DataAccess.ExecuteQuery(sql2);
                    MessageBox.Show("Added Successfully!");
                    checkInsert = true;
                }

                catch 
                {
                    MessageBox.Show("Error: Something went wrong!");
                }

                //Show Login credentials
                if (checkInsert)
                    ShowLoginInfo(txtPId, this.txtPPassword);   //Send txtId & Password
            }

            else if (!ValidPass(this.txtPPassword.Text))
                InvalidPassMsg();

            else
                MessageBox.Show("Enter all the fields!");
        }

        private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
