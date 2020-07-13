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
    public partial class FormOwnRep : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private DataTable Dt { get; set; }

        public FormOwnRep(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridViewE();
        }

        //Showing particular users under specific logged in user
        private void PopulateGridViewE()
        {
            string sql = "select dc.Id, dc.Name, r.RepId, r.Time, r.Details from Report r, Hospital dc where (dc.Id = r.HpId and r.PatId='" + this.GetId + "') order by Time desc;";
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select dc.Id, dc.Name, r.RepId, r.Time, r.Details from Report r, Hospital dc where (dc.Id = r.HpId and r.PatId='" + this.GetId + "'and dc.Name = '" + this.txtSearch.Text + "') order by Time desc;";
            this.PopulateGridView(sql);
        }

        private void DgvAccessPres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvAccessPres.CurrentRow.Cells["repId"].Value.ToString();
                this.txtDetails.Text = this.dgvAccessPres.CurrentRow.Cells["repDetails"].Value.ToString();
                this.txtDate.Text = this.dgvAccessPres.CurrentRow.Cells["repTime"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
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

        private void FormOwnRep_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
