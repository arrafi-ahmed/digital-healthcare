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
    public partial class FormChkPay : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private string Fee { set; get; }
        private string Gsql { set; get; }
        private DataTable Dt { get; set; }
        private DataSet Ds { get; set; }
        public FormChkPay(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.PopulateGridViewE();
        }

        private void PopulateGridViewE()
        {
            string sql = "select dp.PatId, dp.PayId, dp.Method, dp.Amount, bd.BookId, bd.Paid, d.Fee from DocPay dp, DocBook bd, Doctor d where (dp.BID = bd.BookId and dp.DocId = d.Id and dp.DocId = '" + this.GetId + "');";
            PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvChkPayDoc.DataSource = this.Dt;

                if (this.Dt.Rows.Count > 0)
                    this.Fee = this.Dt.Rows[0]["Fee"].ToString(); //Setting fee value from query
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }
        
        private void DgvChkPayDoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvChkPayDoc.CurrentRow.Cells["BookId"].Value.ToString();
                this.txtAmount.Text = this.dgvChkPayDoc.CurrentRow.Cells["Amount"].Value.ToString();
                this.txtFee.Text = this.dgvChkPayDoc.CurrentRow.Cells["ChargedFee"].Value.ToString();

                string rb = this.dgvChkPayDoc.CurrentRow.Cells["Paid"].Value.ToString();
                if (rb == "True")
                    this.rbYes.Checked = true;
                else
                    this.rbNo.Checked = true;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        //Save function
        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            if (this.rbYes.Checked)
            {
                Gsql = @"UPDATE bd
                    SET bd.Paid = 1,
                    bd.Valid = 1
                    FROM DocBook bd
                    WHERE bd.BookId = '" + this.txtId.Text + "';";
            }

            else if (this.rbNo.Checked)
            {
                Gsql = @"UPDATE bd
                    SET bd.Paid = 0,
                    bd.Valid = 0
                    FROM DocBook bd
                    WHERE bd.BookId = '" + this.txtId.Text + "';";
            }

            //Checking if the grid view is empty
            if(this.txtId != null && this.dgvChkPayDoc.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    DataAccess.GetDataTable(Gsql);
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
                    
                MessageBox.Show("Payment status updated!");
                this.PopulateGridViewE();
            }
            else
                MessageBox.Show("Select a payment first!");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select dp.PatId, dp.PayId, dp.Method, dp.Amount, bd.BookId, bd.Paid, d.Fee from DocPay dp, DocBook bd, Doctor d where (dp.BID = bd.BookId and dp.DocId = d.Id and dp.DocId = '" + this.GetId + "' and dp.PatId = '" + this.txtSearch.Text + "');";
            PopulateGridView(sql);
        }

        private void BtnChkIncome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChkStat fcs = new FormChkStat(this.GetId);
            fcs.Visible = true;
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

        private void FormChkPay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
