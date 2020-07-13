using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalHealthCarePro
{
    public partial class FormAbout : MetroFramework.Forms.MetroForm
    {
        public FormAbout()
        {
            InitializeComponent();
            richTxtDes.Enter += RichTxtDes_Enter;
        }

        private void RichTxtDes_Enter(object sender, EventArgs e)
        {
            metroLabel1.Focus();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            fl.Visible = true;
        }

        private void FormAbout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
