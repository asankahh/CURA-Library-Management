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

namespace AdminMain_ModernUi_
{
    public partial class ReviewsUi : MetroForm
    {
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        string rid = null;
        string mnm = null;
        string bnm = null;
        public ReviewsUi()
        {
            InitializeComponent();
        }

        private void lnkRvws_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReviewsUi_Load(object sender, EventArgs e)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = client.ShowReview();
            grd.DataSource = bd;
        }

        private void grd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rw = grd.Rows[e.RowIndex];
            rid = rw.Cells["R_ID"].Value.ToString();
            string mid = rw.Cells["M_ID"].Value.ToString(); 
            string bid = rw.Cells["B_ID"].Value.ToString();
            string rvw = rw.Cells["Review"].Value.ToString();
            string rt = rw.Cells["Rating"].Value.ToString();
            mnm = client.getmembername(mid);          
            bnm = client.getbookname(bid);

            txt_mmbrnm.Text = mnm;
            txt_mmbrID.Text = mid;
            txt_bknm.Text = bnm;
            txt_msg.Text = rvw;

            if(rt=="1")
            {
                r1.Image = Resources.star_sel;
            }
            if(rt=="2")
            {
                r1.Image = Resources.star_sel;
                r2.Image = Resources.star_sel;
            }
            if (rt == "3")
            {
                r1.Image = Resources.star_sel;
                r2.Image = Resources.star_sel;
                r3.Image = Resources.star_sel;
            }
            if (rt == "4")
            {
                r1.Image = Resources.star_sel;
                r2.Image = Resources.star_sel;
                r3.Image = Resources.star_sel;
                r4.Image = Resources.star_sel;
            }
            if (rt == "5")
            {
                r1.Image = Resources.star_sel;
                r2.Image = Resources.star_sel;
                r3.Image = Resources.star_sel;
                r4.Image = Resources.star_sel;
                r5.Image = Resources.star_sel;

            }
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Deleting Review. are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            int cnfrm = client.DeleteReview(rid);
            if (cnfrm == 1)
            {
                MetroMessageBox.Show(this, "Review from '"+mnm+"' about'" + bnm + "'deleted successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MetroMessageBox.Show(this, "There are some errors. try again in few minuts.if you seeing this more than once contact system adminstrator", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
