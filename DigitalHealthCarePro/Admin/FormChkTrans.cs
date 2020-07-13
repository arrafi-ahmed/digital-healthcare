using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalHealthCarePro.Admin
{
    public partial class FormChkTrans : MetroFramework.Forms.MetroForm
    {
        private string GetId { get; set; }
        private DataTable Dt { get; set; }
        public FormChkTrans(string GetId)
        {
            InitializeComponent();
            this.GetId = GetId;
            this.PopulateGridViewDocE();
            this.PopulateGridViewHpE();

            tabPay.SelectedTab = this.tabPayDoc;
        }

        //Doctor gridview
        private void PopulateGridViewDocE()
        {
            string sql = "select dp.*, bd.Paid from DocPay dp, DocBook bd where dp.BID = bd.BookId;";
            PopulateGridViewDoc(sql);

        }
        private void PopulateGridViewDoc(string sql)
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvPayDoc.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        //Hospital gridview
        private void PopulateGridViewHpE()
        {
            string sql = "select hp.*, hb.Paid from HpPay hp, HpBook hb where hp.BIH = hb.BookId;";
            PopulateGridViewHp(sql);
        }

        private void PopulateGridViewHp(string sql)
        {
            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                this.dgvPayHp.DataSource = this.Dt;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void TabPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabPayHp == tabPay.SelectedTab)
                PopulateGridViewHpE();

            else if (this.tabPayDoc == tabPay.SelectedTab)
                PopulateGridViewDocE();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (this.tabPayHp == tabPay.SelectedTab)
            {
                string sql = "select hp.*, hb.Paid from HpPay hp, HpBook hb where (hp.BIH = hb.BookId and hp.PatId = '" + this.txtSearch.Text + "');";
                PopulateGridViewHp(sql);
            }
            else if (this.tabPayDoc == tabPay.SelectedTab)
            {
                string sql = "select dp.*, bd.Paid from DocPay dp, DocBook bd where (dp.BID = bd.BookId and dp.PatId = '" + this.txtSearch.Text + "');";
                PopulateGridViewDoc(sql);
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdmin fa = new FormAdmin(this.GetId);
            fa.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormChkTrans_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
