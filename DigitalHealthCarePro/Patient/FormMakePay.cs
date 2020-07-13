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
    public partial class FormMakePay : MetroFramework.Forms.MetroForm
    {
        private int serial;
        private string payId;
        private string PayId
        {
            get { return this.payId; }
            set
            {
                if (this.tabPayHp == tabPay.SelectedTab)
                    this.payId = "Pih-" + value;

                else if (this.tabPayDoc == tabPay.SelectedTab)
                    this.payId = "Pid-" + value;
            }
        }
        private string BookId { get; set; }
        private string PassedId { get; set; }
        private int Fee { get; set; }
        private int Amount { get; set; }
        private string GetId { get; set; }
        private string TestId { get; set; }
        private string Slot { get; set; }
        private DateTime BookTime { get; set; }
        private DataTable Dt { get; set; }
        private DataRow Dr { get; set; }
        public FormMakePay(string GetId)
        {
            InitializeComponent();
            this.GetId = GetId;

            //Custom code for resized form if accessed through Patient Dashboard
            ConvertForm();

            this.PopulateGridViewDocE();
            this.PopulateGridViewHpE();
        }

        //Constructor Source BookDoc
        public FormMakePay(string GetId, string BookId, string PassedId, string Fee, DateTime BookTime)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.BookId = txtBookId.Text = BookId; 
            this.PassedId = this.txtId.Text = PassedId;
            this.txtFee.Text = Fee;
            this.BookTime = BookTime;
            this.cmbRole.Text = "Doctor";

            tabPay.SelectedTab = this.tabPayDoc;
            this.PopulateGridViewDocE();
            this.PopulateGridViewHpE();
        }

        //Constructor Source BookHp 
        public FormMakePay(string GetId, string BookId, string PassedId, string Fee, DateTime BookTime, string TestId, string Slot)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            this.BookId = txtBookId.Text = BookId;
            this.PassedId = this.txtId.Text = PassedId;
            this.txtFee.Text = Fee;
            this.BookTime = BookTime;
            this.TestId = TestId;
            this.Slot = Slot;
            this.cmbRole.Text = "Hospital";

            tabPay.SelectedTab = this.tabPayHp;
            this.PopulateGridViewDocE();
            this.PopulateGridViewHpE();
        }

        //Convert form
        private void ConvertForm()
        {
            this.Text = "Recent Payments";
            this.Size = new Size(755, 460);
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Location = new Point(50%, 50% );
            this.lblRcntPay.Visible = false;
            this.tabPay.Size = new Size(714, 325);
            this.tabPay.Location = new Point(4, 0);
            this.dgvPayHp.Size = new Size(702, 288);
            this.dgvPayDoc.Size = new Size(702, 288);
            this.pnlPay.Visible = false;
            this.pnlTopBar.Location = new Point(431, 55);
            this.pnlRcntPay.Location = new Point(22, 105);
        }

        //Doctor gridview
        private void PopulateGridViewDocE()
        {
            string sql = "select dp.*, bd.Paid from DocPay dp, DocBook bd where dp.BID = bd.BookId and dp.PatId = '" + this.GetId + "';";
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
            string sql = "select hp.*, hb.Paid from HpPay hp, HpBook hb where hp.BIH = hb.BookId and hp.PatId = '" + this.GetId + "';";
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
        
        //Loading grid view of Hp tab
        private void TabPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabPayHp == tabPay.SelectedTab)
                PopulateGridViewHpE();

            else if(this.tabPayDoc == tabPay.SelectedTab)
                PopulateGridViewDocE();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            //Auto generated Pay Id
            if (this.tabPayHp == tabPay.SelectedTab)    //Check if HpPay table
            {
                string query = "select PayId from HpPay ORDER BY CAST(SUBSTRING(PayId, CHARINDEX('-', PayId) + 1, LEN(PayId)) AS INT);";    //Checking if the table is empty

                try
                {
                    this.Dr = DataAccess.GetLastRow(query);
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }

            else if (this.tabPayDoc == tabPay.SelectedTab)    //Check if DocPay table
            {
                string query = "select PayId from DocPay ORDER BY CAST(SUBSTRING(PayId, CHARINDEX('-', PayId) + 1, LEN(PayId)) AS INT);";    //Checking if the table is empty

                try
                {
                    this.Dr = DataAccess.GetLastRow(query);
                }
                catch
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }

            //Setting serial 
            if (this.Dr != null)
            {
                //Accessing last serial
                string lastRowItem = this.Dr["PayId"].ToString();
                string trimValue = lastRowItem.Remove(0, 4);
                this.serial = Int32.Parse(trimValue);
            }

            else
                this.serial = 0;

            //Increamenting PayId
            this.PayId = (++this.serial).ToString("d2");

            //Converting currency from string to int
            if (!string.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                this.Fee = Int32.Parse(this.txtFee.Text);
                this.Amount = Int32.Parse(this.txtAmount.Text);
            }

            DateTime currentTime = DateTime.Now;

            //Pay Doctor if all fields are okay
            if (this.cmbRole.Text == "Doctor" && this.Fee.ToString() == this.txtAmount.Text && !string.IsNullOrWhiteSpace(this.cmbMethod.Text) && !string.IsNullOrWhiteSpace(this.txtACNo.Text))
            {
                string sql = @"insert into DocPay
                                (PayId, Amount, Method, PatId, ACNo, DocId, BID) 
                                values ( '" + this.PayId + "', " + this.Amount + ", '" + this.cmbMethod.Text + "', '" + this.GetId + "', '" + this.txtACNo.Text + "', '" + this.PassedId + "', '" + this.BookId + "');";

                string sql2 = @"insert into DocBook
                                 values ( '" + this.BookId + "','" + this.BookTime + "','" + this.GetId + "','" + this.PassedId + "', 0, '"+ currentTime + "', 1 );";
                try
                {
                    DataAccess.ExecuteQuery(sql);
                    DataAccess.ExecuteQuery(sql2);
                    MessageBox.Show("Payment processing and slot booked temporarily!");
                    this.PopulateGridViewDocE();
                }
                catch 
                {
                    MessageBox.Show("Error: Something went wrong!");
                }

                //After payment hide payment panel and resize the form
                ConvertForm();
            }

            //Pay Hospital if all fields are okay
            else if (this.cmbRole.Text == "Hospital" && this.Fee.ToString() == this.txtAmount.Text && !string.IsNullOrWhiteSpace(this.cmbMethod.Text) && !string.IsNullOrWhiteSpace(this.txtACNo.Text))
            {
                string sql = @"insert into HpPay
                                (PayId, Amount, Method, PatId, ACNo, HpId, BIH) 
                                values ( '" + this.PayId + "', " + this.Amount + ", '" + this.cmbMethod.Text + "', '" + this.GetId + "', '" + this.txtACNo.Text + "', '" + this.PassedId + "', '" + this.BookId + "');";

                string sql2 = @"insert into HpBook
                                 values ( '" + this.BookId + "','" + this.BookTime.Date + "','" + this.GetId + "','" + this.PassedId + "', 0, '" + this.TestId + "', '" + this.Slot + "' );";
                try
                {
                    DataAccess.ExecuteQuery(sql);
                    DataAccess.ExecuteQuery(sql2);
                    MessageBox.Show("Payment processing and slot booked temporarily!");
                    this.PopulateGridViewHpE();

                    //After payment hide payment panel and resize the form
                    ConvertForm();
                }

                catch 
                {
                    MessageBox.Show("Error: Something went wrong!");
                }
            }

            //Check if fee == amount
            else if (this.Fee.ToString() != this.txtAmount.Text && !string.IsNullOrWhiteSpace(this.txtAmount.Text))
                MessageBox.Show("Payment amount is incorrect!");

            //Check null value of cmbMethod and txtACNo
            else if (string.IsNullOrWhiteSpace(this.txtAmount.Text) || string.IsNullOrWhiteSpace(this.cmbMethod.Text) || string.IsNullOrWhiteSpace(this.txtACNo.Text))
                MessageBox.Show("Enter all the fields!");
        }

        //Search function
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (this.tabPayHp == tabPay.SelectedTab)
            {
                string sql = "select hp.*, hb.Paid from HpPay hp, HpBook hb where (hp.BIH = hb.BookId and hp.PatId = '" + this.GetId + "' and hp.PayId = '" + this.txtSearch.Text + "');";
                PopulateGridViewHp(sql);
            }

            else if (this.tabPayDoc == tabPay.SelectedTab)
            {
                string sql = "select dp.*, bd.Paid from DocPay dp, DocBook bd where (dp.BID = bd.BookId and dp.PatId = '" + this.GetId + "' and dp.PayId = '" + this.txtSearch.Text + "');";
                PopulateGridViewDoc(sql);
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

        private void FormMakePay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
