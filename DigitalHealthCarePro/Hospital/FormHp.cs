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
    public partial class FormHp : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private DataTable Dt { set; get; }
        public FormHp(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            ShowGreetings("Hospital");
        }

        private void ShowGreetings(string user)
        {
            //Greeting section
            DateTime currentTime = DateTime.Now;
            string greeting, name;

            if (currentTime.Hour >= 04 && currentTime.Hour <= 11)
                greeting = "Good Morning";

            else if (currentTime.Hour >= 12 && currentTime.Hour <= 17)
                greeting = "Good Afternoon";

            else if (currentTime.Hour >= 18 && currentTime.Hour <= 21)
                greeting = "Good Evening";

            else
                greeting = "Welcome";

            //Name section
            string sql = "select Name from " + user + " where Id = '" + this.GetId + "';";

            try
            {
                this.Dt = DataAccess.GetDataTable(sql);
                name = this.Dt.Rows[0]["Name"].ToString();

                //Message
                this.lblGreeting.Text = greeting + ", " + name;
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong!");
            }
        }

        private void TileRecentPatient_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormRcntPat frp = new FormRcntPat(this.GetId);
            frp.Visible = true;
        }

        private void TileSendRep_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormSndRep fsr = new FormSndRep(this.GetId);
            fsr.Visible = true;
        }

        private void TileCheckPay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChcPay fcp = new FormChcPay(this.GetId);
            fcp.Visible = true;
        }

        private void TileMngTest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMngTest fmt = new FormMngTest(this.GetId);
            fmt.Visible = true;
        }

        private void TileCheckBooking_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChkBook fcb = new FormChkBook(this.GetId);
            fcb.Visible = true;
        }

        private void TileAccessReport_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAccessRep far = new FormAccessRep(this.GetId);
            far.Visible = true;
        }

        private void TileAccessPres_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAccessPres fap = new FormAccessPres(this.GetId);
            fap.Visible = true;
        }

        private void TileChkStat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChkStat fcs = new FormChkStat(this.GetId);
            fcs.Visible = true;
        }

        private void BtnEditHp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEditHp feh = new FormEditHp(this.GetId);
            feh.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormHp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
