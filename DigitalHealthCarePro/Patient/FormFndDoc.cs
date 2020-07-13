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
    public partial class FormFndDoc : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private string DocId { set; get; }
        private bool SetFilter { set; get; }
        private DataTable Dt { get; set; }
        public FormFndDoc(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridView();

            this.pnlSearch.Visible = false;
        }

        private void PopulateGridView(string sql = "Select * from Doctor;")
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvDoctor.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void DgvDoctor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.DocId = this.txtId.Text = this.dgvDoctor.CurrentRow.Cells["Id"].Value.ToString();
                this.txtDept.Text = this.dgvDoctor.CurrentRow.Cells["Dept"].Value.ToString();
                this.txtName.Text = this.dgvDoctor.CurrentRow.Cells["DocName"].Value.ToString();
                this.txtEmail.Text = this.dgvDoctor.CurrentRow.Cells["Email"].Value.ToString();
                this.txtAge.Text = this.dgvDoctor.CurrentRow.Cells["Age"].Value.ToString();
                this.txtQualification.Text = this.dgvDoctor.CurrentRow.Cells["Qualifications"].Value.ToString();
                this.txtPhone.Text = this.dgvDoctor.CurrentRow.Cells["Phone"].Value.ToString();
                this.txtFee.Text = this.dgvDoctor.CurrentRow.Cells["Fee"].Value.ToString();
                this.txtAddress.Text = this.dgvDoctor.CurrentRow.Cells["AddressLn"].Value.ToString() + ", " + this.dgvDoctor.CurrentRow.Cells["City"].Value.ToString() + ", " + this.dgvDoctor.CurrentRow.Cells["Country"].Value.ToString();
                this.txtVisitingHr.Text = this.dgvDoctor.CurrentRow.Cells["WeekStart"].Value.ToString() + "-" + this.dgvDoctor.CurrentRow.Cells["WeekEnd"].Value.ToString() + ", " + this.dgvDoctor.CurrentRow.Cells["StartTime"].Value.ToString() + "-" + this.dgvDoctor.CurrentRow.Cells["CloseTime"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtId.Text))
                MessageBox.Show("Select a Doctor first!");
            else 
            {
                this.Visible = false;
                FormBookDoc fbd = new FormBookDoc(this.GetId, this.DocId);
                fbd.Visible = true;
            }
        }

        //Custom Search
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (SetFilter)
            {
                string searchName = null, searchCountry = null, searchCity = null, searchDept = null;

                if (!string.IsNullOrWhiteSpace(this.txtSearch.Text))
                    searchName = "Name = '" + this.txtSearch.Text + "'";

                if (this.cmbSearchCountry.SelectedIndex != -1)
                {
                    if (!string.IsNullOrWhiteSpace(this.txtSearch.Text))
                        searchCountry = " and Country = '" + this.cmbSearchCountry.Text + "'";
                    else
                        searchCountry = " Country = '" + this.cmbSearchCountry.Text + "'";
                }
                    
                if (!string.IsNullOrWhiteSpace(this.txtSearchCity.Text))
                {
                    if (!string.IsNullOrWhiteSpace(this.txtSearchCity.Text) || this.cmbSearchCountry.SelectedIndex != -1 || !string.IsNullOrWhiteSpace(this.txtSearch.Text))
                        searchCity = " and City = '" + this.txtSearchCity.Text + "'";
                    else
                        searchCity = " City = '" + this.txtSearchCity.Text + "'";
                }

                if (!string.IsNullOrWhiteSpace(this.txtSearchDept.Text))
                {
                    if (!string.IsNullOrWhiteSpace(this.txtSearchDept.Text) || !string.IsNullOrWhiteSpace(this.txtSearchCity.Text) || this.cmbSearchCountry.SelectedIndex != -1 || !string.IsNullOrWhiteSpace(this.txtSearch.Text))
                        searchDept = " and Dept = '" + this.txtSearchDept.Text + "'";
                    else
                        searchDept = " Dept = '" + this.txtSearchDept.Text + "'";
                }
                
                string sql = "select * from Doctor where " + searchName + " " + searchCountry +" "+ searchCity + " "+ searchDept + ";";
                this.PopulateGridView(sql);
            }

            else
            {
                string sql = "select * from Doctor where Name = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            this.pnlSearch.Visible = true;
            this.btnSearch.Location = new Point(770, 218);
            this.cmbSearchCountry.DataSource = DataAccess.GetCountry();
            SetFilter = true;
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

        private void FormFndDoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
