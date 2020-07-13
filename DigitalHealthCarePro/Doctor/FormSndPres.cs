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
    public partial class FormSndPres : MetroFramework.Forms.MetroForm
    {
        private string GetId { get; set; }
        private string PatId { set; get; }
        private void SetTime()
        {
            DateTime today = DateTime.Now;
            this.txtDate.Text = today.ToString("yyyy-MM-dd hh:mm:ss");
        }
        private DataTable Dt { get; set; }
        public FormSndPres(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridViewE();
            this.SetTime();
        }
        public FormSndPres(string GetId, string PatId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PatId = PatId;
            this.PopulateGridViewE();
            this.SetTime();
        }

        //Showing particular users under specific logged in user
        private void PopulateGridViewE()
        {
            //If source is Recent Patient
            if (this.PatId != null)
            {
                //string sql = "select Id, Name, Age, BloodGroup, Phone, Email, Address from Patient where Id = (select TOP 1 PatId from DocBook where(DocId = '" + this.GetId + "' and (CONVERT(smalldatetime, '" + currentTime + "') >= CONVERT(smalldatetime, Time)) and (CONVERT(smalldatetime, '" + currentTime + "') <= CONVERT(smalldatetime, DATEADD(minute, +15, Time)))));";
                string sql = "select Id, Name, Age, BloodGroup, Phone, Email, Address from Patient where Id = (select TOP 1 PatId from DocBook where(DocId = '" + this.GetId + "' and PatId = '" + this.PatId + "'));";
                PopulateGridView(sql);
            }

            //If source is Doctor Dashboard
            else
            {
                //string sql = "Select distinct P.Id, max(bd.Time), p.Name, p.Age, p.Email, p.Phone, p.BloodGroup, p.Address, bd.DocId from Patient p, DocBook bd where (bd.DocId = '" + getId + "' and bd.PatId = p.Id) group by p.Id, p.Name, p.Age, p.Email, p.Phone, p.BloodGroup, p.Address, bd.DocId order by max(bd.Time) desc;";
                DateTime currentTime = DateTime.Now;
                string sql = "select Id, Name, Age, BloodGroup, Phone, Email, Address from Patient where Id = (select TOP 1 PatId from DocBook where(DocId = '" + this.GetId + "' and (CONVERT(smalldatetime, '" + currentTime + "') >= CONVERT(smalldatetime, Time)) and (CONVERT(smalldatetime, '" + currentTime + "') <= CONVERT(smalldatetime, DATEADD(minute, +15, Time)))));";
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select Id, Name, Age, BloodGroup, Phone, Email, Address from Patient where Id = (select TOP 1 PatId from DocBook where(DocId = '" + this.GetId + "' and PatId = '" + this.txtSearch.Text + "'));";
            this.PopulateGridView(sql);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtId.Text) || string.IsNullOrWhiteSpace(this.txtDetails.Text))
            {
                MessageBox.Show("Please input all the fields first!");
            }
            else
            {
                string sql = @"insert into Prescription
                ( Details, DocId, PatId, Time) VALUES( '" + this.txtDetails.Text + "', '" + this.GetId + "', '" + this.txtId.Text + "', '" + this.txtDate.Text + "');";
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

        private void FormSndPres_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
