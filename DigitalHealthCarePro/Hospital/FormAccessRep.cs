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
    public partial class FormAccessRep : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private string PatId { set; get; }
        private DataTable Dt { get; set; }

        public FormAccessRep(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridViewE();
        }

        public FormAccessRep(string GetId, string PatId)
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
                string sql = "select PatId, RepId, Time, Details from Report where PatId = (select TOP 1 PatId from HpBook where (HpId = '" + this.GetId + "' and PatId = '" + this.PatId + "'));";
                PopulateGridView(sql);
            }

            //If source is Hp Dashboard
            else
            {
                DateTime currentTime = DateTime.Now;
                string sql = "select PatId, RepId, Time, Details from Report where PatId IN (select PatId from HpBook where ((HpId = '" + this.GetId + "') and (CONVERT(smalldatetime, '" + currentTime.Date + "') = CONVERT(smalldatetime, Time)) ));";
                PopulateGridView(sql);
            }
        }

        private void PopulateGridView(string sql)
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvAccessRep.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select PatId, RepId, Time, Details from Report where (PatId = '" + this.txtSearch.Text + "' and PatId IN (select PatId from HpBook where HpId = '" + this.GetId + "'));";
            this.PopulateGridView(sql);
        }

        private void DgvAccessRep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = this.dgvAccessRep.CurrentRow.Cells["repId"].Value.ToString();
            this.txtDetails.Text = this.dgvAccessRep.CurrentRow.Cells["repDetails"].Value.ToString();
            this.txtDate.Text = this.dgvAccessRep.CurrentRow.Cells["repTime"].Value.ToString();
        }

        private void BtnPatDetails_Click(object sender, EventArgs e)
        {
            if (this.dgvAccessRep.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                string patId = this.dgvAccessRep.CurrentRow.Cells["PatientId"].Value.ToString();
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.txtId.Text) || string.IsNullOrWhiteSpace(this.txtDetails.Text))
            {
                MessageBox.Show("Select all the fields first!");
            }
            else
            {
                string sql = @"update Report
                set Details = '" + this.txtDetails.Text + @"',
                Time = '" + this.txtDate.Text + @"'
                where RepId = '" + this.txtId.Text + "';";

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

        private void FormAccessRep_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
