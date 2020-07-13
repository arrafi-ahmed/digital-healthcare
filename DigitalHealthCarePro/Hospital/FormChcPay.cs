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
    public partial class FormChcPay : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private string Amount { set; get; }
        private string Gsql { set; get; }
        private DataTable Dt { get; set; }
        private DataSet Ds { get; set; }

        public FormChcPay(string GetId)
        {
            InitializeComponent();
            this.GetId = GetId;
            this.PopulateGridViewE();
        }

        private void PopulateGridViewE()
        {
            string sql = "select hp.PatId, hp.PayId, hp.Method, hp.Amount, hb.BookId, hb.Paid, hb.TestId, th.TestCharge from HpPay hp, HpBook hb, Test_Hp th  where (hp.BIH = hb.BookId and hb.TestId = th.TestId and th.HpId = hb.HpId and hp.HpId = '" + this.GetId + "');";
            PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvChkPayHp.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select hp.PatId, hp.PayId, hp.Method, hp.Amount, hb.BookId, hb.Paid, hb.TestId from HpPay hp, HpBook hb, Test_Hp th where (hp.BIH = hb.BookId and hb.TestId = th.TestId and th.HpId = hb.HpId and hp.HpId = '" + this.GetId + "' and hp.PatId = '" + this.txtSearch.Text + "');";
            PopulateGridView(sql);
        }
        
        //Save function
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.rbYes.Checked)
            {
                Gsql = @"UPDATE hb
                    SET hb.Paid = 'True'
                    FROM HpBook hb
                    WHERE hb.BookId = '" + this.txtId.Text + "';";
            }

            else if (this.rbNo.Checked)
            {
                Gsql = @"UPDATE hb
                    SET hb.Paid = 'False'
                    FROM HpBook hb
                    WHERE hb.BookId = '" + this.txtId.Text + "';";
            }

            //Checking if the grid view is empty
            if (this.txtId != null && this.dgvChkPayHp.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    this.Dt = DataAccess.GetDataTable(Gsql);
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

        private void DgvChkPayHp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvChkPayHp.CurrentRow.Cells["BookId"].Value.ToString();
                this.txtAmount.Text = this.dgvChkPayHp.CurrentRow.Cells["PaidAmount"].Value.ToString();
                this.txtFee.Text = this.dgvChkPayHp.CurrentRow.Cells["TestCharge"].Value.ToString();

                string rb = this.dgvChkPayHp.CurrentRow.Cells["Paid"].Value.ToString();

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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormHp fdc = new FormHp(this.GetId);
            fdc.Visible = true;
        }

        private void FormChcPay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
