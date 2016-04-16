using AdminMain_ModernUi_.Properties;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminMain_ModernUi_.MemberStuff
{
    public partial class MemberLibrary : MetroForm
    {
        /* Create a object of Service */
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        string bknm0 = null;
        string athr0 = null;
        byte[] cvr0 = null;
        string bknm1 = null;
        string athr1 = null;
        byte[] cvr1 = null;
        string bknm2 = null;
        string athr2 = null;
        byte[] cvr2 = null;
        string bknm3 = null;
        string athr3 = null;
        byte[] cvr3 = null;
        string bknm4 = null;
        string athr4 = null;
        byte[] cvr4 = null;
        

        public MemberLibrary()
        {
            InitializeComponent();
        }

        private void MemberLibrary_Load(object sender, EventArgs e)
        {
            DataTable hbks = client.HitBooks();
            int rows = hbks.Select().Length;
            Suggetions(hbks, rows);
        }

        private void Suggetions(DataTable hbks, int rows)
        {
            if (rows == 5)
            {
                bknm0 = hbks.Rows[0][0].ToString();
                athr0 = hbks.Rows[0][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[0][2]))
                {
                    cvr0 = (byte[])hbks.Rows[0][2];
                }
                lbl_sgtn_bknm0.Text = bknm0;
                lbl_sgstn_athr0.Text = athr0;
                if (cvr0 != null)
                {
                    pb_sgtn0.Image = Image.FromStream(new MemoryStream(cvr0));
                }

                bknm1 = hbks.Rows[1][0].ToString();
                athr1 = hbks.Rows[1][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[1][2]))
                {
                    cvr1 = (byte[])hbks.Rows[1][2];
                }
                lbl_sgtn_bknm1.Text = bknm1;
                lbl_sgstn_athr1.Text = athr1;
                if (cvr1 != null)
                {
                    pb_sgtn1.Image = Image.FromStream(new MemoryStream(cvr1));
                }

                bknm2 = hbks.Rows[2][0].ToString();
                athr2 = hbks.Rows[2][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[2][2]))
                {
                    cvr2 = (byte[])hbks.Rows[2][2];
                }
                lbl_sgtn_bknm2.Text = bknm2;
                lbl_sgstn_athr2.Text = athr2;
                if (cvr2 != null)
                {
                    pb_sgtn2.Image = Image.FromStream(new MemoryStream(cvr2));
                }

                bknm3 = hbks.Rows[3][0].ToString();
                athr3 = hbks.Rows[3][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[3][2]))
                {
                    cvr3 = (byte[])hbks.Rows[3][2];
                }
                lbl_sgtn_bknm3.Text = bknm3;
                lbl_sgstn_athr3.Text = athr3;
                if (cvr3 != null)
                {
                    pb_sgtn3.Image = Image.FromStream(new MemoryStream(cvr3));
                }

                bknm4 = hbks.Rows[4][0].ToString();
                athr4 = hbks.Rows[4][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[4][2]))
                {
                    cvr4 = (byte[])hbks.Rows[4][2];
                }
                lbl_sgtn_bknm4.Text = bknm4;
                lbl_sgstn_athr4.Text = athr4;
                if (cvr4 != null)
                {
                    pb_sgtn4.Image = Image.FromStream(new MemoryStream(cvr4));
                }
            }

            if (rows == 4)
            {
                bknm0 = hbks.Rows[0][0].ToString();
                athr0 = hbks.Rows[0][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[0][2]))
                {
                    cvr0 = (byte[])hbks.Rows[0][2];
                }
                lbl_sgtn_bknm0.Text = bknm0;
                lbl_sgstn_athr0.Text = athr0;
                if (cvr0 != null)
                {
                    pb_sgtn0.Image = Image.FromStream(new MemoryStream(cvr0));
                }

                bknm1 = hbks.Rows[1][0].ToString();
                athr1 = hbks.Rows[1][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[1][2]))
                {
                    cvr1 = (byte[])hbks.Rows[1][2];
                }
                lbl_sgtn_bknm1.Text = bknm1;
                lbl_sgstn_athr1.Text = athr1;
                if (cvr1 != null)
                {
                    pb_sgtn1.Image = Image.FromStream(new MemoryStream(cvr1));
                }

                bknm2 = hbks.Rows[2][0].ToString();
                athr2 = hbks.Rows[2][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[2][2]))
                {
                    cvr2 = (byte[])hbks.Rows[2][2];
                }
                lbl_sgtn_bknm2.Text = bknm2;
                lbl_sgstn_athr2.Text = athr2;
                if (cvr2 != null)
                {
                    pb_sgtn2.Image = Image.FromStream(new MemoryStream(cvr2));
                }

                bknm3 = hbks.Rows[3][0].ToString();
                athr3 = hbks.Rows[3][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[3][2]))
                {
                    cvr3 = (byte[])hbks.Rows[3][2];
                }
                lbl_sgtn_bknm3.Text = bknm3;
                lbl_sgstn_athr3.Text = athr3;
                if (cvr3 != null)
                {
                    pb_sgtn3.Image = Image.FromStream(new MemoryStream(cvr3));
                }

                pnl4.Visible = false;

            }

            if (rows == 3)
            {
                bknm0 = hbks.Rows[0][0].ToString();
                athr0 = hbks.Rows[0][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[0][2]))
                {
                    cvr0 = (byte[])hbks.Rows[0][2];
                }
                lbl_sgtn_bknm0.Text = bknm0;
                lbl_sgstn_athr0.Text = athr0;
                if (cvr0 != null)
                {
                    pb_sgtn0.Image = Image.FromStream(new MemoryStream(cvr0));
                }

                bknm1 = hbks.Rows[1][0].ToString();
                athr1 = hbks.Rows[1][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[1][2]))
                {
                    cvr1 = (byte[])hbks.Rows[1][2];
                }
                lbl_sgtn_bknm1.Text = bknm1;
                lbl_sgstn_athr1.Text = athr1;
                if (cvr1 != null)
                {
                    pb_sgtn1.Image = Image.FromStream(new MemoryStream(cvr1));
                }

                bknm2 = hbks.Rows[2][0].ToString();
                athr2 = hbks.Rows[2][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[2][2]))
                {
                    cvr2 = (byte[])hbks.Rows[2][2];
                }
                lbl_sgtn_bknm2.Text = bknm2;
                lbl_sgstn_athr2.Text = athr2;
                if (cvr2 != null)
                {
                    pb_sgtn2.Image = Image.FromStream(new MemoryStream(cvr2));
                }
                pnl3.Visible = false;
                pnl4.Visible = false;

            }

            if (rows == 2)
            {
                bknm0 = hbks.Rows[0][0].ToString();
                athr0 = hbks.Rows[0][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[0][2]))
                {
                    cvr0 = (byte[])hbks.Rows[0][2];
                }
                lbl_sgtn_bknm0.Text = bknm0;
                lbl_sgstn_athr0.Text = athr0;
                if (cvr0 != null)
                {
                    pb_sgtn0.Image = Image.FromStream(new MemoryStream(cvr0));
                }

                bknm1 = hbks.Rows[1][0].ToString();
                athr1 = hbks.Rows[1][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[1][2]))
                {
                    cvr1 = (byte[])hbks.Rows[1][2];
                }
                lbl_sgtn_bknm1.Text = bknm1;
                lbl_sgstn_athr1.Text = athr1;
                if (cvr1 != null)
                {
                    pb_sgtn1.Image = Image.FromStream(new MemoryStream(cvr1));
                }

                pnl2.Visible = false;
                pnl3.Visible = false;
                pnl4.Visible = false;

            }
            if (rows == 1)
            {
                bknm0 = hbks.Rows[0][0].ToString();
                athr0 = hbks.Rows[0][1].ToString();
                if (!Convert.IsDBNull(hbks.Rows[0][2]))
                {
                    cvr0 = (byte[])hbks.Rows[0][2];
                }
                lbl_sgtn_bknm0.Text = bknm0;
                lbl_sgstn_athr0.Text = athr0;
                if (cvr0 != null)
                {
                    pb_sgtn0.Image = Image.FromStream(new MemoryStream(cvr0));
                }

                pnl1.Visible = false;
                pnl2.Visible = false;
                pnl3.Visible = false;
                pnl4.Visible = false;
            }
            if (rows == 0)
            {
                pnl_sgstn.Visible = false;
            }
        }

        private void lnkLbrry_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pb_bks_MouseHover(object sender, EventArgs e)
        {
            pb_bks.Image = Resources.Bks_h;
        }

        private void pb_bks_MouseLeave(object sender, EventArgs e)
        {
            pb_bks.Image = Resources.Bks;
        }

        private void pb_mgzns_MouseHover(object sender, EventArgs e)
        {
            pb_mgzns.Image = Resources.Mgzns_h;
        }

        private void pb_mgzns_MouseLeave(object sender, EventArgs e)
        {
            pb_mgzns.Image = Resources.Mgzns;
        }

        private void pb_nwspprs_MouseHover(object sender, EventArgs e)
        {
            pb_nwspprs.Image = Resources.Nwspprs_h;
        }

        private void pb_nwspprs_MouseLeave(object sender, EventArgs e)
        {
            pb_nwspprs.Image = Resources.Nwspprs;
        }

        private void pb_thss_MouseHover(object sender, EventArgs e)
        {
            pb_thss.Image = Resources.Thss_h;
        }

        private void pb_thss_MouseLeave(object sender, EventArgs e)
        {
            pb_thss.Image = Resources.Thss;
        }

        private void pb_jrnls_MouseHover(object sender, EventArgs e)
        {
            pb_jrnls.Image = Resources.Jrnls_h;
        }

        private void pb_jrnls_MouseLeave(object sender, EventArgs e)
        {
            pb_jrnls.Image = Resources.Jrnls;
        }

        private void pb_dgtlarchv_MouseHover(object sender, EventArgs e)
        {
            pb_dgtlarchv.Image = Resources.Dgtl_h;
        }

        private void pb_dgtlarchv_MouseLeave(object sender, EventArgs e)
        {
            pb_dgtlarchv.Image = Resources.Dgtl;
        }

        private void pb_bks_Click(object sender, EventArgs e)
        {
            MLib_Books_H MLBH = new MLib_Books_H();
            StyleManager.Clone(MLBH);
            MLBH.ShowDialog();
        }

        private void pb_mgzns_Click(object sender, EventArgs e)
        {
            MLib_Magazines MLM = new MLib_Magazines();
            StyleManager.Clone(MLM);
            MLM.ShowDialog();
        }

        private void pb_nwspprs_Click(object sender, EventArgs e)
        {
            MLib_Newspapers MLN = new MLib_Newspapers();
            StyleManager.Clone(MLN);
            MLN.ShowDialog();
        }

        private void pb_thss_Click(object sender, EventArgs e)
        {
            MLib_Thesis MLT = new MLib_Thesis();
            StyleManager.Clone(MLT);
            MLT.ShowDialog();
        }

        private void pb_jrnls_Click(object sender, EventArgs e)
        {
            MLib_Journals MLJ = new MLib_Journals();
            StyleManager.Clone(MLJ);
            MLJ.ShowDialog();
        }

        private void pb_dgtlarchv_Click(object sender, EventArgs e)
        {
            MLib_Digital MLD = new MLib_Digital();
            StyleManager.Clone(MLD);
            MLD.ShowDialog();
        }
    }
}
