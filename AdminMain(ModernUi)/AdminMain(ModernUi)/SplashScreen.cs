using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminMain_ModernUi_
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int srvr = login.wcfck;
            int db = login.dbck;

            mpb.Increment(1);

            if (mpb.Value == 2)
            {
                lbl_ldng.Text = "Loading.......";
            }

            if (mpb.Value == 20)
            {
                lbl_ldng.Text = "Connecting to the CURA server.......";
            }

            if (mpb.Value == 30)
            {
                if (srvr == 1)
                {
                    lbl_ldng.Text = "Server Connected.......";
                }
            }

            if (mpb.Value == 35)
            {
                lbl_ldng.Text = "Connecting to the CURA database.......";
            }


            if (mpb.Value == 50)
            {
                if (db == 1)
                {
                    lbl_ldng.Text = "Database Connected.......";
                }
            }

            if (mpb.Value == 65)
            {
                lbl_ldng.Text = "Loading files.......";
            }

            if (mpb.Value == 90)
            {
                lbl_ldng.Text = "Welcome to CURA Library Manager !!";
            }

            if (mpb.Value == 100)
            {
                timer.Stop();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }


    }
}
