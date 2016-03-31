using AdminMain_ModernUi_.Properties;
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

namespace AdminMain_ModernUi_.MemberStuff
{
    public partial class MemberLibrary : MetroForm
    {
        public MemberLibrary()
        {
            InitializeComponent();
        }

        private void MemberLibrary_Load(object sender, EventArgs e)
        {

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
