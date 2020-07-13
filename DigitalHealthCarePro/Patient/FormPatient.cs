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
    public partial class FormPatient : MetroFramework.Forms.MetroForm
    {
        private string GetId { set; get; }
        private DataTable Dt { set; get; }

        public FormPatient(string GetId)
        {
            InitializeComponent();
            this.GetId = this.lblId.Text = GetId;
            ShowGreetings("Patient");
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

        private void TileFindDoc_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormFndDoc ffd = new FormFndDoc(this.GetId);
            ffd.Visible = true;
        }

        private void TileFindHp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormFndHp ffdc = new FormFndHp(this.GetId);
            ffdc.Visible = true;
        }
        
        private void TileOwnPres_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            FormOwnPres fop = new FormOwnPres(this.GetId);
            fop.Visible = true;
        }

        private void OwnReport_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormOwnRep fore = new FormOwnRep(this.GetId);
            fore.Visible = true;
        }

        private void TileMakePayment_Click(object sender, EventArgs e) 
        {
            this.Visible = false;
            FormMakePay fmpy = new FormMakePay(this.GetId);
            fmpy.Visible = true;
        }

        private void BtnEditHp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEditPat fep = new FormEditPat(this.GetId);
            fep.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
