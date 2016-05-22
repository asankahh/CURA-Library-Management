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

namespace AdminMain_ModernUi_.MemberStuff
{
    public partial class MemLib_Books_Review : MetroForm
    {
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        public MemLib_Books_Review()
        {
            InitializeComponent();
        }

        string mid = MMemberUi.mid;
        string bid = MLib_Books.itemID;
        string bknm = MLib_Books.booknm;
        int rt = 0;

        private void MemLib_Books_Review_Load(object sender, EventArgs e)
        {
            lbl_bknm.Text = bknm;
        }

        private void btn_sbmt_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Submitting a review", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            int cnfrm = client.WriteReview(bid, mid, txt_rev.Text, rt);
            if (cnfrm == 1)
            {                
                MetroMessageBox.Show(this, "Your review about'"+bknm+"'added successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MetroMessageBox.Show(this, "There are some errors. try again in few minuts.if you seeing this more than once contact system adminstrator", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void r1_MouseHover(object sender, EventArgs e)
        {
            r1.Image = Resources.star_hov;
        }

        private void r2_MouseHover(object sender, EventArgs e)
        {
            r1.Image = Resources.star_hov;
            r2.Image = Resources.star_hov;
        }

        private void r3_MouseHover(object sender, EventArgs e)
        {
            r1.Image = Resources.star_hov;
            r2.Image = Resources.star_hov;
            r3.Image = Resources.star_hov;
        }

        private void r4_MouseHover(object sender, EventArgs e)
        {
            r1.Image = Resources.star_hov;
            r2.Image = Resources.star_hov;
            r3.Image = Resources.star_hov;
            r4.Image = Resources.star_hov;
        }

        private void r5_MouseHover(object sender, EventArgs e)
        {
            r1.Image = Resources.star_hov;
            r2.Image = Resources.star_hov;
            r3.Image = Resources.star_hov;
            r4.Image = Resources.star_hov;
            r5.Image = Resources.star_hov;
        }

        private void r1_MouseLeave(object sender, EventArgs e)
        {
            if (rt == 0)
            {
                r1.Image = Resources.star_def;
                r2.Image = Resources.star_def;
                r3.Image = Resources.star_def;
                r4.Image = Resources.star_def;
                r5.Image = Resources.star_def;
            }
        }

        private void r2_MouseLeave(object sender, EventArgs e)
        {
            if (rt == 0)
            {
                r1.Image = Resources.star_def;
                r2.Image = Resources.star_def;
                r3.Image = Resources.star_def;
                r4.Image = Resources.star_def;
                r5.Image = Resources.star_def;
            }
        }

        private void r3_MouseLeave(object sender, EventArgs e)
        {
            if (rt == 0)
            {
                r1.Image = Resources.star_def;
                r2.Image = Resources.star_def;
                r3.Image = Resources.star_def;
                r4.Image = Resources.star_def;
                r5.Image = Resources.star_def;
            }
        }

        private void r4_MouseLeave(object sender, EventArgs e)
        {
            if(rt==0)
            {
                r1.Image = Resources.star_def;
                r2.Image = Resources.star_def;
                r3.Image = Resources.star_def;
                r4.Image = Resources.star_def;
                r5.Image = Resources.star_def;
            }            
        }

        private void r5_MouseLeave(object sender, EventArgs e)
        {
            if(rt==0)
            {
                r1.Image = Resources.star_def;
                r2.Image = Resources.star_def;
                r3.Image = Resources.star_def;
                r4.Image = Resources.star_def;
                r5.Image = Resources.star_def;
            }            
        }

        private void r1_Click(object sender, EventArgs e)
        {
            rt = 1;
            r1.Image = Resources.star_sel;
            r2.Image = Resources.star_def;
            r3.Image = Resources.star_def;
            r4.Image = Resources.star_def;
            r5.Image = Resources.star_def;
        }

        private void r2_Click(object sender, EventArgs e)
        {
            rt = 2;
            r1.Image = Resources.star_sel;
            r2.Image = Resources.star_sel;
            r3.Image = Resources.star_def;
            r4.Image = Resources.star_def;
            r5.Image = Resources.star_def;
        }

        private void r3_Click(object sender, EventArgs e)
        {
            rt = 3;
            r1.Image = Resources.star_sel;
            r2.Image = Resources.star_sel;
            r3.Image = Resources.star_sel;
            r4.Image = Resources.star_def;
            r5.Image = Resources.star_def;
        }

        private void r4_Click(object sender, EventArgs e)
        {
            rt = 4;
            r1.Image = Resources.star_sel;
            r2.Image = Resources.star_sel;
            r3.Image = Resources.star_sel;
            r4.Image = Resources.star_sel;
            r5.Image = Resources.star_def;
        }

        private void r5_Click(object sender, EventArgs e)
        {
            rt = 5;
            r1.Image = Resources.star_sel;
            r2.Image = Resources.star_sel;
            r3.Image = Resources.star_sel;
            r4.Image = Resources.star_sel;
            r5.Image = Resources.star_sel;
        }
    }
}
