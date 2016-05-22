using Google.API.Search;
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
using System.Diagnostics;



namespace AdminMain_ModernUi_
{
    public partial class GoogleBooks : MetroForm
    {
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */

        DataTable gb = new DataTable();
        string sk = "alexander the great";
        string m0 = null;
        string m1 = null;
        string m2 = null;
        string m3 = null;
        string m4 = null;
        string m5 = null;
        string m6 = null;
        string m7 = null;
        string m8 = null;
        string m9 = null;
        string m10 = null;
        string m11 = null;
        string m12 = null;
        string m13 = null;
        string m14 = null;
        string m15 = null;
        string m16 = null;
        string m17 = null;
        string m18 = null;
        string m19 = null;

        public GoogleBooks()
        {
            InitializeComponent();
            
        }

        private void lnk_bck_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void GoogleBooks_Load(object sender, EventArgs e)
        {
            GB();
        }        

        private void btn_srch_Click(object sender, EventArgs e)
        {
            sk = txt_srch.Text;
            GB();
        }        

        private void lnk_m0_MouseClick(object sender, MouseEventArgs e)
        {   
             Process.Start(m0);
        }

        private void lnk_m1_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start(m1);
        }

        private void lnk_m2_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start(m2);
        }

        private void lnk_m3_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start(m3);
        }

        private void lnk_m4_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start(m4);
        }        

        private void lnk_m5_Click(object sender, EventArgs e)
        {
            Process.Start(m5);
        }

        private void lnk_m6_Click(object sender, EventArgs e)
        {
            Process.Start(m6);
        }

        private void lnk_m7_Click(object sender, EventArgs e)
        {
            Process.Start(m7);
        }

        private void lnk_m8_Click(object sender, EventArgs e)
        {
            Process.Start(m8);
        }

        private void lnk_m9_Click(object sender, EventArgs e)
        {
            Process.Start(m9);
        }

        private void lnk_m10_Click(object sender, EventArgs e)
        {
            Process.Start(m10);
        }

        private void lnk_m11_Click(object sender, EventArgs e)
        {
            Process.Start(m11);
        }

        private void lnk_m12_Click(object sender, EventArgs e)
        {
            Process.Start(m12);
        }

        private void lnk_m13_Click(object sender, EventArgs e)
        {
            Process.Start(m13);
        }

        private void lnk_m14_Click(object sender, EventArgs e)
        {
            Process.Start(m14);
        }

        private void lnk_m15_Click(object sender, EventArgs e)
        {
            Process.Start(m15);
        }

        private void lnk_m16_Click(object sender, EventArgs e)
        {
            Process.Start(m16);
        }

        private void lnk_m17_Click(object sender, EventArgs e)
        {
            Process.Start(m17);
        }

        private void lnk_m18_Click(object sender, EventArgs e)
        {
            Process.Start(m18);
        }

        private void lnk_m19_Click(object sender, EventArgs e)
        {
            Process.Start(m19);
        }

        private void GB()
        {
            gb = client.gb(sk);
            GoogleBookLoad();
        }


        private void GoogleBookLoad()
        {
            int b = 0;
            int a = 1;
            int m = 2;
            int p = 3;
            //pnl_sgstn0
            lbl_bknm0.Text = gb.Rows[0][b].ToString();
            lbl_athr0.Text = gb.Rows[0][a].ToString();
            m0 = gb.Rows[0][m].ToString();
            pb_bkcvr0.ImageLocation = gb.Rows[0][p].ToString();
            //pnl_sgstn1
            lbl_bknm1.Text = gb.Rows[1][0].ToString();
            lbl_athr1.Text = gb.Rows[1][1].ToString();
            m1 = gb.Rows[1][2].ToString();
            pb_bkcvr1.ImageLocation = gb.Rows[1][3].ToString();
            //pnl_sgstn2
            lbl_bknm2.Text = gb.Rows[2][0].ToString();
            lbl_athr2.Text = gb.Rows[2][1].ToString();
            m2 = gb.Rows[2][2].ToString();
            pb_bkcvr2.ImageLocation = gb.Rows[2][3].ToString();
            //pnl_sgstn3
            lbl_bknm3.Text = gb.Rows[3][0].ToString();
            lbl_athr3.Text = gb.Rows[3][1].ToString();
            m3 = gb.Rows[3][2].ToString();
            pb_bkcvr3.ImageLocation = gb.Rows[3][3].ToString();
            //pnl_sgstn4
            lbl_bknm4.Text = gb.Rows[4][0].ToString();
            lbl_athr4.Text = gb.Rows[4][1].ToString();
            m4 = gb.Rows[4][2].ToString();
            pb_bkcvr4.ImageLocation = gb.Rows[4][3].ToString();

            //pnl_sgstn5
            lbl_bknm5.Text = gb.Rows[5][b].ToString();
            lbl_athr5.Text = gb.Rows[5][a].ToString();
            m5 = gb.Rows[5][m].ToString();
            pb_bkcvr5.ImageLocation = gb.Rows[5][p].ToString();

            //pnl_sgstn6
            lbl_bknm6.Text = gb.Rows[6][b].ToString();
            lbl_athr6.Text = gb.Rows[6][a].ToString();
            m6 = gb.Rows[6][m].ToString();
            pb_bkcvr6.ImageLocation = gb.Rows[6][p].ToString();

            //pnl_sgstn7
            lbl_bknm7.Text = gb.Rows[7][b].ToString();
            lbl_athr7.Text = gb.Rows[7][a].ToString();
            m7 = gb.Rows[7][m].ToString();
            pb_bkcvr7.ImageLocation = gb.Rows[7][p].ToString();

            //pnl_sgstn8
            lbl_bknm8.Text = gb.Rows[8][b].ToString();
            lbl_athr8.Text = gb.Rows[8][a].ToString();
            m8 = gb.Rows[8][m].ToString();
            pb_bkcvr8.ImageLocation = gb.Rows[8][p].ToString();

            //pnl_sgstn9
            lbl_bknm9.Text = gb.Rows[9][b].ToString();
            lbl_athr9.Text = gb.Rows[9][a].ToString();
            m9 = gb.Rows[9][m].ToString();
            pb_bkcvr9.ImageLocation = gb.Rows[9][p].ToString();

            //pnl_sgstn10
            lbl_bknm10.Text = gb.Rows[10][b].ToString();
            lbl_athr10.Text = gb.Rows[10][a].ToString();
            m10 = gb.Rows[10][m].ToString();
            pb_bkcvr10.ImageLocation = gb.Rows[10][p].ToString();

            //pnl_sgstn11
            lbl_bknm11.Text = gb.Rows[11][b].ToString();
            lbl_athr11.Text = gb.Rows[11][a].ToString();
            m11 = gb.Rows[11][m].ToString();
            pb_bkcvr11.ImageLocation = gb.Rows[11][p].ToString();

            //pnl_sgstn12
            lbl_bknm12.Text = gb.Rows[12][b].ToString();
            lbl_athr12.Text = gb.Rows[12][a].ToString();
            m12 = gb.Rows[12][m].ToString();
            pb_bkcvr12.ImageLocation = gb.Rows[12][p].ToString();

            //pnl_sgstn13
            lbl_bknm13.Text = gb.Rows[13][b].ToString();
            lbl_athr13.Text = gb.Rows[13][a].ToString();
            m13 = gb.Rows[13][m].ToString();
            pb_bkcvr13.ImageLocation = gb.Rows[13][p].ToString();

            //pnl_sgstn14
            lbl_bknm14.Text = gb.Rows[14][b].ToString();
            lbl_athr14.Text = gb.Rows[14][a].ToString();
            m14 = gb.Rows[14][m].ToString();
            pb_bkcvr14.ImageLocation = gb.Rows[14][p].ToString();

            //pnl_sgstn15
            lbl_bknm15.Text = gb.Rows[15][b].ToString();
            lbl_athr15.Text = gb.Rows[15][a].ToString();
            m15 = gb.Rows[15][m].ToString();
            pb_bkcvr15.ImageLocation = gb.Rows[15][p].ToString();

            //pnl_sgstn16
            lbl_bknm16.Text = gb.Rows[16][b].ToString();
            lbl_athr16.Text = gb.Rows[16][a].ToString();
            m16 = gb.Rows[16][m].ToString();
            pb_bkcvr16.ImageLocation = gb.Rows[16][p].ToString();

            //pnl_sgstn17
            lbl_bknm17.Text = gb.Rows[17][b].ToString();
            lbl_athr17.Text = gb.Rows[17][a].ToString();
            m17 = gb.Rows[17][m].ToString();
            pb_bkcvr17.ImageLocation = gb.Rows[17][p].ToString();

            //pnl_sgstn18
            lbl_bknm18.Text = gb.Rows[18][b].ToString();
            lbl_athr18.Text = gb.Rows[18][a].ToString();
            m18 = gb.Rows[18][m].ToString();
            pb_bkcvr18.ImageLocation = gb.Rows[18][p].ToString();

            //pnl_sgstn19
            lbl_bknm19.Text = gb.Rows[19][b].ToString();
            lbl_athr19.Text = gb.Rows[19][a].ToString();
            m19 = gb.Rows[19][m].ToString();
            pb_bkcvr19.ImageLocation = gb.Rows[19][p].ToString();
        }

        
    }

}
