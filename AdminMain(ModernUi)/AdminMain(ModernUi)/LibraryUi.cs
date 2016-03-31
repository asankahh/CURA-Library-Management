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

namespace AdminMain_ModernUi_
{
    public partial class LibraryUi : MetroForm
    {
        public LibraryUi()
        {
            InitializeComponent();
        }

        private void lnkLbrry_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnk_new_Click(object sender, EventArgs e)
        {
            LibraryUi_New LUiN = new LibraryUi_New();
            StyleManager.Clone(LUiN);
            LUiN.ShowDialog();
        }


        private void pb_bks_Click(object sender, EventArgs e)
        {
            LibCat.LibraryBooks LB = new LibCat.LibraryBooks();
            StyleManager.Clone(LB);
            LB.ShowDialog();
        }
        private void pb_bks_MouseHover(object sender, EventArgs e)
        {
            pb_bks.Image = Resources.Bks_h;
        }
        private void pb_bks_MouseLeave(object sender, EventArgs e)
        {
            pb_bks.Image = Resources.Bks;
        }

        
        private void pb_mgzns_Click(object sender, EventArgs e)
        {
            LibCat.LibraryMagazines LM = new LibCat.LibraryMagazines();
            StyleManager.Clone(LM);
            LM.ShowDialog();
        }
        private void pb_mgzns_MouseHover(object sender, EventArgs e)
        {
            pb_mgzns.Image = Resources.Mgzns_h;
        }
        private void pb_mgzns_MouseLeave(object sender, EventArgs e)
        {
            pb_mgzns.Image = Resources.Mgzns;
        }


        private void pb_nwspprs_Click(object sender, EventArgs e)
        {
            LibCat.LibraryNewspapers LN = new LibCat.LibraryNewspapers();
            StyleManager.Clone(LN);
            LN.ShowDialog();
        }
        private void pb_nwspprs_MouseHover(object sender, EventArgs e)
        {
            pb_nwspprs.Image = Resources.Nwspprs_h;
        }
        private void pb_nwspprs_MouseLeave(object sender, EventArgs e)
        {
            pb_nwspprs.Image = Resources.Nwspprs;
        }

        private void pb_thss_Click(object sender, EventArgs e)
        {
            LibCat.LibraryThesis LT = new LibCat.LibraryThesis();
            StyleManager.Clone(LT);
            LT.ShowDialog();
        }
        private void pb_thss_MouseHover(object sender, EventArgs e)
        {
            pb_thss.Image = Resources.Thss_h;
        }
        private void pb_thss_MouseLeave(object sender, EventArgs e)
        {
            pb_thss.Image = Resources.Thss;
        }

        private void pb_jrnls_Click(object sender, EventArgs e)
        {
            LibCat.LibraryJournals LJ = new LibCat.LibraryJournals();
            StyleManager.Clone(LJ);
            LJ.ShowDialog();
        }
        private void pb_jrnls_MouseHover(object sender, EventArgs e)
        {
            pb_jrnls.Image = Resources.Jrnls_h;
        }
        private void pb_jrnls_MouseLeave(object sender, EventArgs e)
        {
            pb_jrnls.Image = Resources.Jrnls;
        }

        private void pb_dgtlarchv_Click(object sender, EventArgs e)
        {
            LibCat.LibraryDigital LD = new LibCat.LibraryDigital();
            StyleManager.Clone(LD);
            LD.ShowDialog();
        }
        private void pb_dgtlarchv_MouseHover(object sender, EventArgs e)
        {
            pb_dgtlarchv.Image = Resources.Dgtl_h;
        }
        private void pb_dgtlarchv_MouseLeave(object sender, EventArgs e)
        {
            pb_dgtlarchv.Image = Resources.Dgtl;
        }

        
    }
}
