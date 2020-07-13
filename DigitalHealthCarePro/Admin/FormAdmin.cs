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
    public partial class FormAdmin : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private DataTable Dt { set; get; }

        public FormAdmin(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            ShowGreetings("Admin");
        }

        private void ShowGreetings(string user)
        {
            //Greeting section
            DateTime currentTime = DateTime.Now;
            string greeting, name;

            if(currentTime.Hour >= 04 && currentTime.Hour <= 11)
                greeting = "Good Morning";

            else if (currentTime.Hour >= 12 && currentTime.Hour <= 17)
                greeting = "Good Afternoon";

            else if (currentTime.Hour >= 18 && currentTime.Hour <= 21)
                greeting = "Good Evening";

            else
                greeting = "Welcome";

            //Name section
            string sql = "select Name from "+ user +" where Id = '"+ this.GetId +"';";

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

        //Core Code 
        private void TileDoctor_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMngDoctor fmd = new FormMngDoctor(this.GetId);
            fmd.Visible = true;
        }

        private void TilePatient_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMngPatient fmp = new FormMngPatient(this.GetId);
            fmp.Visible = true;
        }
        
        private void TileHospital_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMngHp fh = new FormMngHp(this.GetId);
            fh.Visible = true;
        }

        private void TileChkStat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChkStat fcs = new FormChkStat(this.GetId);
            fcs.Visible = true;
        }

        private void TileCheckTransaction_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormChkTrans fct = new FormChkTrans(this.GetId);
            fct.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
