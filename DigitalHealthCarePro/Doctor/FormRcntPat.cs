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
    public partial class FormRcntPat : MetroFramework.Forms.MetroForm
    {
        private string GetId { get; set; }
        private string PatId { get; set; }
        private DataTable Dt { get; set; }

        public FormRcntPat(string GetId)
        {
            InitializeComponent();
            this.GetId = lblId.Text = GetId;
            PopulateGridViewE();
        }

        private void PopulateGridViewE()
        {
            DateTime currentTime = DateTime.Now;
            string sql = "select Id, Name, Age, BloodGroup, Phone, Email, Address from Patient where Id IN (select PatId from DocBook where ((DocId = '" + this.GetId + "') and (CONVERT(smalldatetime, Time) <= CONVERT(smalldatetime, '" + currentTime + "')) and (CONVERT(smalldatetime, Time) >= CONVERT(smalldatetime, DATEADD(day, -30, '" + currentTime + "')))));";
            PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvRcntPat.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select Id, Name, Age, BloodGroup, Phone, Email, Address from Patient where Id IN (select PatId from DocBook where (PatId = '" + this.txtSearch.Text +"' and DocId = '" + this.GetId + "'));";
            PopulateGridView(sql);
        }

        private void BtnAccessRep_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtPatId.Text))
            {
                this.Visible = false;
                this.PatId = this.txtPatId.Text;
                FormAccessRep far = new FormAccessRep(this.GetId, this.PatId);
                far.Visible = true;
            }
            else
                MessageBox.Show("Pleaes select Patient first from the list!");
        }

        private void BtnSndPres_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtPatId.Text))
            {
                this.Visible = false;
                this.PatId = this.txtPatId.Text;
                FormSndPres fsp = new FormSndPres(this.GetId, this.PatId);
                fsp.Visible = true;
            }
            else
                MessageBox.Show("Pleaes select Patient first from the list!");
        }

        private void BtnAccessPres_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtPatId.Text))
            {
                this.Visible = false;
                this.PatId = this.txtPatId.Text;
                FormAccessPres fap = new FormAccessPres(this.GetId, this.PatId);
                fap.Visible = true;
            }
            else
                MessageBox.Show("Pleaes select Patient first from the list!");
        }

        private void DgvRcntPat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtPatId.Text = this.dgvRcntPat.CurrentRow.Cells["PatientId"].Value.ToString();
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

        private void FormRcntPat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
