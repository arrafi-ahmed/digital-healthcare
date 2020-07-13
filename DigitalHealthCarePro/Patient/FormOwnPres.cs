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
    public partial class FormOwnPres : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private DataTable Dt { get; set; }
        public FormOwnPres(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridViewE();
        }

        //Showing particular users under specific logged in user
        private void PopulateGridViewE()
        {
            string sql = "select d.Id, d.Name, pr.PresId, pr.Time, pr.Details from Prescription pr, Doctor d where (d.Id = pr.DocId and pr.PatId='" + this.GetId + "') order by Time desc;";
            PopulateGridView(sql);
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
            string sql = "select d.Id, d.Name, pr.PresId, pr.Time, pr.Details from Prescription pr, Doctor d where (d.Id = pr.DocId and pr.PatId='" + this.GetId + "'and d.Name = '" + this.txtSearch.Text + "') order by Time desc;";
            this.PopulateGridView(sql);
        }

        private void DgvAccessPres_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormPatient fp = new FormPatient(this.GetId);
            fp.Visible = true;
        }

        private void FormOwnPres_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
