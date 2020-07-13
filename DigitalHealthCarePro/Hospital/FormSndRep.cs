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
    public partial class FormSndRep : MetroFramework.Forms.MetroForm
    {
        private string GetId { get; set; }
        private string PatId { set; get; }
        private DataTable Dt { get; set; }

        //If source is Hp Dashboard
        public FormSndRep(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridViewE();
            this.SetTime();
        }

        //If source is Recent Patient
        public FormSndRep(string GetId, string PatId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PatId = PatId;
            this.PopulateGridViewE();
            this.SetTime();
            //Shorter form for one patient dgvPatient
            this.Size = new Size(1200, 578);
            this.dgvPatient.Size = new Size(1156, 45);
        }

        private void SetTime()
        {
            DateTime today = DateTime.Now;
            this.txtDate.Text = today.ToString("yyyy-MM-dd hh:mm:ss");
        }

        //Showing particular users under specific logged in user
        private void PopulateGridViewE()
        {
            //If source is Recent Patient
            if (this.PatId != null)
            {
                string sql = "select Id, Name, Age, BloodGroup, Phone, Email, Address from Patient where Id = (select TOP 1 PatId from HpBook where(HpId = '" + this.GetId + "' and PatId = '" + this.PatId + "'));";
                PopulateGridView(sql);
            }

            //If source is Hp Dashboard
            else
            {
                DateTime currentTime = DateTime.Now;
                string sql = "select Id, Name, Age, BloodGroup, Phone, Email, Address from Patient where Id IN (select PatId from HpBook where(HpId = '" + this.GetId + "' and (CONVERT(smalldatetime, '" + currentTime.Date + "') = CONVERT(smalldatetime, Time)) ));";
                PopulateGridView(sql);
            }
        }
        
        private void PopulateGridView(string sql)
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

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtId.Text) || string.IsNullOrWhiteSpace(this.txtDetails.Text))
                MessageBox.Show("Please input all the fields first!");

            else
            {
                string sql = @"insert into Report
                ( Details, HpId, PatId, Time) VALUES( '" + this.txtDetails.Text + "', '" + this.GetId + "', '" + this.txtId.Text + "', '" + this.txtDate.Text + "');";

                try
                {
                    DataAccess.ExecuteQuery(sql);
                    MessageBox.Show("Sent Successfully!");
                    this.PopulateGridViewE();
                }
                catch 
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select Id, Name, Age, BloodGroup, Phone, Email, Address from Patient where Id = (select TOP 1 PatId from HpBook where(HpId = '" + this.GetId + "' and PatId = '" + this.txtSearch.Text + "'));";
            this.PopulateGridView(sql);
        }

        private void DgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvPatient.CurrentRow.Cells["Id"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormHp fdc = new FormHp(this.GetId);
            fdc.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormSndRep_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
