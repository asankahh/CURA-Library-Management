using AdminMain_ModernUi_.Properties;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminMain_ModernUi_
{
    public partial class MMemberUi : MetroForm
    {
        /* Create a object of Service */
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        public MMemberUi()
        {
            Thread t1 = new Thread(new ThreadStart(SplashScreen));
            t1.Start();
            Thread.Sleep(4800);

            InitializeComponent();
            this.StyleManager = msm_member;

            t1.Abort();

        }

        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        public static string usrnm;
        public static string mid;
        public static string ln;
        public static string fn;
        public static string adrs1;
        public static string adrs2;
        public static string ct;
        public static string pstlcd;
        public static string p_ml;
        public static string w_ml;
        public static string h_tp;
        public static string p_tp;
        public static string gndr;
        public static string bd;
        public static string ntnlt;
        public static byte[] dp;


        private void MMemberUi_Load(object sender, EventArgs e)
        {
            usrnm = login.chkusr;
            DataTable DTC = new DataTable();
            DTC = client.gtmmbrdt(usrnm);
            if(DTC!=null)
            {
                mid = DTC.Rows[0][0].ToString();
                ln = DTC.Rows[0][1].ToString();
                fn = DTC.Rows[0][2].ToString();
                adrs1 = DTC.Rows[0][3].ToString();
                adrs2 = DTC.Rows[0][4].ToString();
                ct = DTC.Rows[0][5].ToString();
                pstlcd = DTC.Rows[0][6].ToString();
                p_ml = DTC.Rows[0][7].ToString();
                w_ml = DTC.Rows[0][8].ToString();
                h_tp = DTC.Rows[0][9].ToString();
                p_tp = DTC.Rows[0][10].ToString();
                gndr = DTC.Rows[0][11].ToString();
                bd = DTC.Rows[0][12].ToString();
                ntnlt = DTC.Rows[0][13].ToString();
                dp = (byte[])DTC.Rows[0][15];
            }
            lbl_nm.Text = fn + " " + ln;
            lbl_UN.Text = lbl_nm.Text;
            lbl_mid.Text = mid;
            lbl_add1.Text = adrs1;
            lbl_add2.Text = adrs2;
            lbl_ct.Text = ct;
            lbl_bd.Text = bd;
            lbl_gndr.Text = gndr;
            lbl_ntnlty.Text = ntnlt;
            pb_usrimg.Image = Image.FromStream(new MemoryStream(dp));
        }

        private void pb_lbrry_Click(object sender, EventArgs e)
        {
            MemberStuff.MemberLibrary ML = new MemberStuff.MemberLibrary();
            this.StyleManager.Clone(ML);
            ML.ShowDialog();
        }

        private void lnksttngs_Click(object sender, EventArgs e)
        {
            pnl_sttng.Visible = false;
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

        private void rb_drk_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_drk.Checked)
            {
                msm_member.Theme = MetroThemeStyle.Dark;
            }
        }

        private void rb_lght_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_lght.Checked)
            {
                msm_member.Theme = MetroThemeStyle.Light;
            }
        }

        private void btn_stylepally_Click(object sender, EventArgs e)
        {
            int st = 0;
            string style = cb_style.Text;
            switch (style)
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
            msm_member.Style = (MetroColorStyle)st;
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

        private void pb_rqsts_Click(object sender, EventArgs e)
        {
            MemberStuff.MemReq MRQ = new MemberStuff.MemReq();
            StyleManager.Clone(MRQ);
            MRQ.ShowDialog();
        }

        private void pb_rvws_Click(object sender, EventArgs e)
        {
            MemberStuff.MemRev MRV = new MemberStuff.MemRev();
            StyleManager.Clone(MRV);
            MRV.ShowDialog();
        }

        private void pb_rsrvtn_Click(object sender, EventArgs e)
        {
            MemberStuff.MemRes MRS = new MemberStuff.MemRes();
            StyleManager.Clone(MRS);
            MRS.ShowDialog();
        }

        
    }
}
