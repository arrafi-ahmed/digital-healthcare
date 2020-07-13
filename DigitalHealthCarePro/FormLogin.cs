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
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        private DataTable Dt { get; set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(string getId)
        {
            InitializeComponent();
            this.txtId.Text = getId;
        }

        //Login button
        private void TileLogin_Click(object sender, EventArgs e)
        {
            //If all fields are okay
            if (!string.IsNullOrWhiteSpace(this.txtId.Text) && !string.IsNullOrWhiteSpace(this.txtPassword.Text) && this.cmbRole.SelectedIndex != -1)
            {
                if (LoginConfirmation())
                {
                    MessageBox.Show("Login Succesfull!");

                    //Check Role Condition
                    if(this.cmbRole.Text == "Admin")
                    {
                        this.Visible = false;
                        Admin.FormAdmin fa = new Admin.FormAdmin(this.txtId.Text);
                        fa.Visible = true;
                    }

                    else if (this.cmbRole.Text == "Doctor")
                    {
                        this.Visible = false;
                        Doctor.FormDoctor fd = new Doctor.FormDoctor(this.txtId.Text);
                        fd.Visible = true;
                    }

                    else if (this.cmbRole.Text == "Patient")
                    {
                        this.Visible = false;
                        Patient.FormPatient fp = new Patient.FormPatient(this.txtId.Text);
                        fp.Visible = true;
                    }

                    else if(this.cmbRole.Text == "Hospital")
                    {
                        this.Visible = false;
                        Hospital.FormHp fh = new Hospital.FormHp(this.txtId.Text);
                        fh.Visible = true;
                    }

                }

                else
                    MessageBox.Show("Invalid Credentials");
            }

            else
                MessageBox.Show("Enter all the fields first!");
        }

        //Check id and password
        private bool LoginConfirmation()
        {
            try
            {
                string sql = "select Id, Name, Password from " + this.cmbRole.Text + " where (Id = '" + this.txtId.Text + "' and Password = '" + this.txtPassword.Text + "');";
                this.Dt = DataAccess.GetDataTable(sql);
            }
            catch 
            {
                MessageBox.Show("Error: Something went wrong!");
            }

            if (this.Dt.Rows.Count == 1)
                return true;

            return false;
        }

        //Signup button
        private void TileSignUp_Click(object sender, EventArgs e)
        {
            if(this.cmbRole.SelectedItem == null)
                MessageBox.Show("Select a role to Sign Up!");

            else if(this.cmbRole.Text == "Doctor" || this.cmbRole.Text == "Hospital" || this.cmbRole.Text == "Patient")
            {
                this.Visible = false;
                FormRegister fr = new FormRegister(this.cmbRole.Text);
                fr.Visible = true;
            }
            else
                MessageBox.Show("Selected role is not allowed to Sign Up!");
        }

        private void LblAbout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAbout fa = new FormAbout();
            fa.Visible = true;
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
