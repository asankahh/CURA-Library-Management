using AdminMain_ModernUi_.Properties;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdminMain_ModernUi_
{
    public partial class MAdminUi : MetroForm
    {

        /* Create a object of Service */
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */

        public MAdminUi()
        {
            Thread t1 = new Thread(new ThreadStart(SplashScreen));
            t1.Start();
            Thread.Sleep(4800);
            InitializeComponent(); 
            this.StyleManager = msm_adminUi;

            t1.Abort();
        }

        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        public static string stid;

        private void AdminUi_Load(object sender, EventArgs e)
        {
            string usrnm = login.chkusr;
            string fn = null;
            string ln = null;
            DataTable DTC = new DataTable();
            DTC=  client.getstfdt(usrnm);     
            if (DTC!=null)
            {
                fn = DTC.Rows[0][1].ToString();
                ln = DTC.Rows[0][2].ToString();
                stid = DTC.Rows[0][0].ToString();
            }
            lbl_UN.Text = fn + " " + ln;   
        }


        private void pb_sttngs_Click(object sender, EventArgs e)
        {
            pnl_sttng.Visible = true;
        }

        private void lnksttngs_Click(object sender, EventArgs e)
        {
            pnl_sttng.Visible = false;
        }


        private void rb_drk_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_drk.Checked)
            {
                msm_adminUi.Theme = MetroThemeStyle.Dark;
            }
        }

        private void rb_lght_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_lght.Checked)
            {
                msm_adminUi.Theme = MetroThemeStyle.Light;
            }
        }        
                

        private void pb_lbrry_Click(object sender, EventArgs e)
        {
            LibraryUi LU = new LibraryUi();
            this.StyleManager.Clone(LU);
            LU.ShowDialog();
        }

        private void pb_rvws_Click(object sender, EventArgs e)
        {
            ReviewsUi RvUi = new ReviewsUi();
            this.StyleManager.Clone(RvUi);
            RvUi.ShowDialog();
        }

        private void pb_rqsts_Click(object sender, EventArgs e)
        {
            RequestUi RqUi = new RequestUi();
            this.StyleManager.Clone(RqUi);
            RqUi.ShowDialog();
        }

        private void pb_rsrvtn_Click(object sender, EventArgs e)
        {
            Reservation_Ui RvUi = new Reservation_Ui();
            this.StyleManager.Clone(RvUi);
            RvUi.ShowDialog();
        }

        private void pb_accnt_Click(object sender, EventArgs e)
        {
            AccountsUi AcUi = new AccountsUi();
            this.StyleManager.Clone(AcUi);
            AcUi.ShowDialog();
        }

        private void pb_stff_Click(object sender, EventArgs e)
        {
            StaffUi StUi = new StaffUi();
            this.StyleManager.Clone(StUi);
            StUi.ShowDialog();
        }

        private void pb_gb_Click(object sender, EventArgs e)
        {
            GoogleBooks GBUi = new GoogleBooks();
            this.StyleManager.Clone(GBUi);
            GBUi.ShowDialog();
        }

        private void btn_styleaplly_Click(object sender, EventArgs e)
        {
            int st = 0;
            string style = cb_style.Text;
            switch(style)
            {
                case "Black":
                    st = 1;
                    break;

                case "White":
                    st = 2;
                    break;

                case "Silver":
                    st = 3;
                    break;

                case "Blue":
                    st = 4;
                    break;

                case "Green":
                    st = 5;
                    break;

                case "Lime":
                    st = 6;
                    break;

                case "Teal":
                    st = 7;
                    break;

                case "Orange":
                    st = 8;
                    break;

                case "Brown":
                    st = 9;
                    break;

                case "Pink":
                    st = 10;
                    break;

                case "Magenta":
                    st = 11;
                    break;

                case "Purple":
                    st = 12;
                    break;

                case "Red":
                    st = 13;
                    break;

                case "Yellow":
                    st = 14;
                    break;

            }
            
            

            msm_adminUi.Style = (MetroColorStyle)st;
            pnl_sttng.Visible = false;
        }


        
        


        private void pb_lbrry_MouseHover(object sender, EventArgs e)
        {
            pb_lbrry.Image = Resources.lib_h;
        }

        private void pb_lbrry_MouseLeave(object sender, EventArgs e)
        {
            pb_lbrry.Image = Resources.lib;
        }

        private void pb_rvws_MouseHover(object sender, EventArgs e)
        {
            pb_rvws.Image = Resources.rvws_h;
        }

        private void pb_rvws_MouseLeave(object sender, EventArgs e)
        {
            pb_rvws.Image = Resources.rvws;
        }

        private void pb_rqsts_MouseHover(object sender, EventArgs e)
        {
            pb_rqsts.Image = Resources.rqsts_h;
        }

        private void pb_rqsts_MouseLeave(object sender, EventArgs e)
        {
            pb_rqsts.Image = Resources.rqsts;
        }

        private void pb_rsrvtn_MouseHover(object sender, EventArgs e)
        {
            pb_rsrvtn.Image = Resources.rsrvtn_h;
        }

        private void pb_rsrvtn_MouseLeave(object sender, EventArgs e)
        {
            pb_rsrvtn.Image = Resources.rsrvtn;
        }

        private void pb_accnt_MouseHover(object sender, EventArgs e)
        {
            pb_accnt.Image = Resources.Accnts_h;
        }

        private void pb_accnt_MouseLeave(object sender, EventArgs e)
        {
            pb_accnt.Image = Resources.Accnts;
        }

        private void pb_stff_MouseHover(object sender, EventArgs e)
        {
            pb_stff.Image = Resources.stff_h;
        }

        private void pb_stff_MouseLeave(object sender, EventArgs e)
        {
            pb_stff.Image = Resources.stff;
        }

        private void pb_mmbrs_MouseHover(object sender, EventArgs e)
        {
            pb_mmbrs.Image = Resources.mmbr_h;
        }

        private void pb_mmbrs_MouseLeave(object sender, EventArgs e)
        {
            pb_mmbrs.Image = Resources.mmbr;
        }

        private void pb_hlp_MouseHover(object sender, EventArgs e)
        {
            pb_gb.Image = Resources.gglbks_h;
        }

        private void pb_hlp_MouseLeave(object sender, EventArgs e)
        {
            pb_gb.Image = Resources.gglbks;
        }

        private void pb_usr_Click(object sender, EventArgs e)
        {
            
        }

        private void pb_logot_Click(object sender, EventArgs e)
        {
            
        }

        private void pb_set_Click(object sender, EventArgs e)
        {
            pnl_sttng.Visible = true;
        }

        private void lnk_lgot_Click(object sender, EventArgs e)
        {
            login lg = new login();
            Hide();
            lg.ShowDialog();
            Close();
        }

        private void pb_set_MouseHover(object sender, EventArgs e)
        {
            pb_set.Image = Resources.Settings_h;
        }

        private void pb_set_MouseLeave(object sender, EventArgs e)
        {
            pb_set.Image = Resources.Settings;
        }

        private void pb_mmbrs_Click(object sender, EventArgs e)
        {
            MembersUi MUi = new MembersUi();
            this.StyleManager.Clone(MUi);
            MUi.ShowDialog();
        }
        

        //Metro Tile Hover and Leave actions End
    }
}
