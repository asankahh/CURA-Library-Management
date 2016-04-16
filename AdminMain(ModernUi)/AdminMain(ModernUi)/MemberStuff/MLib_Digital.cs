using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using AdminMain_ModernUi_.Properties;

namespace AdminMain_ModernUi_.MemberStuff
{
    public partial class MLib_Digital : MetroForm
    {
        public MLib_Digital()
        {
            InitializeComponent();
        }

        private void lnkLbrry_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pb_sftwr_Click(object sender, EventArgs e)
        {
            Digi.SoftwareZone SZ = new Digi.SoftwareZone();
            StyleManager.Clone(SZ);
            SZ.ShowDialog();
        }        

        private void pb_sftwr_MouseHover(object sender, EventArgs e)
        {
            pb_sftwr.Image = Resources.Sftwr_h;
        }

        private void pb_sftwr_MouseLeave(object sender, EventArgs e)
        {
            pb_sftwr.Image = Resources.Sftwr;
        }

        private void pb_ebks_Click(object sender, EventArgs e)
        {
            Digi.eBooks eB = new Digi.eBooks();
            StyleManager.Clone(eB);
            eB.ShowDialog();
        }

        private void pb_ebks_MouseHover(object sender, EventArgs e)
        {
            pb_ebks.Image = Resources.ebks_h;
        }

        private void pb_ebks_MouseLeave(object sender, EventArgs e)
        {
            pb_ebks.Image = Resources.ebks;
        }

        private void pb_msc_Click(object sender, EventArgs e)
        {
            Digi.Music MC = new Digi.Music();
            StyleManager.Clone(MC);
            MC.ShowDialog();
        }

        private void pb_msc_MouseHover(object sender, EventArgs e)
        {
            pb_msc.Image = Resources.Msc_h;
        }

        private void pb_msc_MouseLeave(object sender, EventArgs e)
        {
            pb_msc.Image = Resources.Msc;
        }

        private void pb_alc_Click(object sender, EventArgs e)
        {
            Digi.ALectures AL = new Digi.ALectures();
            StyleManager.Clone(AL);
            AL.ShowDialog();
        }

        private void pb_alc_MouseHover(object sender, EventArgs e)
        {
            pb_alc.Image = Resources.Alecs_h;
        }

        private void pb_alc_MouseLeave(object sender, EventArgs e)
        {
            pb_alc.Image = Resources.Alecs;
        }

        private void pb_vlc_Click(object sender, EventArgs e)
        {
            Digi.Vlectures VL = new Digi.Vlectures();
            StyleManager.Clone(VL);
            VL.ShowDialog(VL);
        }

        private void pb_vlc_MouseHover(object sender, EventArgs e)
        {
            pb_vlc.Image = Resources.Vlecs_h;
        }

        private void pb_vlc_MouseLeave(object sender, EventArgs e)
        {
            pb_vlc.Image = Resources.Vlecs;
        }

        private void pb_gb_MouseHover(object sender, EventArgs e)
        {
            pb_gb.Image = Resources.gglbks_h;
        }

        private void pb_gb_MouseLeave(object sender, EventArgs e)
        {
            pb_gb.Image = Resources.gglbks;
        }

        private void pb_gb_Click(object sender, EventArgs e)
        {
            GoogleBooks GBUi = new GoogleBooks();
            this.StyleManager.Clone(GBUi);
            GBUi.ShowDialog();
        }
    }
}
