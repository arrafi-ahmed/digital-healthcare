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
    public partial class FormDoctor : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private DataTable Dt { set; get; }
        public FormDoctor(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            ShowGreetings("Doctor");
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

        private void TileSendPres_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormSndPres fsp = new FormSndPres(this.GetId);
            fsp.Visible = true;
        }

        private void TileAccessRep_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAccessRep far = new FormAccessRep(this.GetId);
            far.Visible = true;
        }

        private void TileCheckPay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChkPay fcp = new FormChkPay(this.GetId);
            fcp.Visible = true;
        }

        private void TileAccessPres_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAccessPres fap = new FormAccessPres(this.GetId);
            fap.Visible = true;
        }

        private void TileCheckBooking_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChkBook fcp = new FormChkBook(this.GetId);
            fcp.Visible = true;
        }

        private void TileRecentPat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormRcntPat frp = new FormRcntPat(this.GetId);
            frp.Visible = true;
        }

        private void TileCheckStat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChkStat fcs = new FormChkStat(this.GetId);
            fcs.Visible = true;
        }

        private void BtnEditDoc_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEditDoc fed = new FormEditDoc(this.GetId);
            fed.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
