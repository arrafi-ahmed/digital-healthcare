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
    public partial class FormAccessPres : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private string PatId { set; get; }
        private DataTable Dt { get; set; }
        public FormAccessPres(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridViewE();
        }
        public FormAccessPres(string GetId, string PatId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PatId = PatId;
            this.PopulateGridViewE();
        }

        //Showing particular users under specific logged in user
        private void PopulateGridViewE()
        {
            //If source is Recent Patient
            if (this.PatId != null)
            {
                string sql = "select PatId, PresId, Time, Details from Prescription where PatId = (select TOP 1 PatId from DocBook where (DocId = '" + this.GetId + "' and PatId = '" + this.PatId + "'));";
                PopulateGridView(sql);
            }

            //If source is Doctor Dashboard
            else
            {
                DateTime currentTime = DateTime.Now;
                string sql = "select PatId, PresId, Time, Details from Prescription where PatId = (select TOP 1 PatId from  DocBook where ((DocId = '" + this.GetId + "') and (CONVERT(smalldatetime, '" + currentTime + "') >= CONVERT(smalldatetime, Time)) and (CONVERT(smalldatetime, '" + currentTime + "') <= CONVERT(smalldatetime, DATEADD(minute, +15, Time)))));";
                PopulateGridView(sql);
            }
        }

        private void PopulateGridView(string sql)
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvAccessPres.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
           
        }

        private void DgvAccessPres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvAccessPres.CurrentRow.Cells["presId"].Value.ToString();
                this.txtDetails.Text = this.dgvAccessPres.CurrentRow.Cells["presDetails"].Value.ToString();
                this.txtDate.Text = this.dgvAccessPres.CurrentRow.Cells["presTime"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select PatId, PresId, Time, Details from Prescription where (PatId = '" + this.txtSearch.Text + "' and DocId = '" + this.GetId + "');";
            this.PopulateGridView(sql);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtId.Text) || string.IsNullOrWhiteSpace(this.txtDetails.Text))
            {
                MessageBox.Show("Please input all the fields first!");
            }

            else
            {
                string sql = @"update Prescription
                set Details = '" + this.txtDetails.Text + @"',
                Time = '" + this.txtDate.Text + @"'
                where PresId = '" + this.txtId.Text + "';";

                try
                {
                    DataAccess.ExecuteQuery(sql);
                    MessageBox.Show("Updated Succesfully!");
                    this.PopulateGridViewE();
                }

                catch 
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }
        }

        private void BtnPatDetails_Click(object sender, EventArgs e)
        {
            if (this.dgvAccessPres.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                string patId = this.dgvAccessPres.CurrentRow.Cells["PatientId"].Value.ToString();
                string sql = "select * from Patient where Id = '" + patId + "';";

                try
                {
                    this.Dt = DataAccess.GetDataTable(sql);

                    DateTime currentTime = DateTime.Now;
                    MessageBox.Show("Name: " + this.Dt.Rows[0]["Name"].ToString() + "\n" + "Age: " + this.Dt.Rows[0]["Age"].ToString() + "\n" + "Blood Group: " + this.Dt.Rows[0]["BloodGroup"].ToString() + "\n" + "Phone: " + this.Dt.Rows[0]["Phone"].ToString() + "\n" + "Email: " + this.Dt.Rows[0]["Email"].ToString() + "\n" + "Address: " + this.Dt.Rows[0]["Address"].ToString() + "\n");
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }

            else
                MessageBox.Show("Please select Patient from the list first!");
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

        private void FormAccessPres_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
