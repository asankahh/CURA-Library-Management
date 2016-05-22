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
    public partial class MemLib_Books_Reserve : MetroForm
    {
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        string mid = MMemberUi.mid;
        string bid = MLib_Books.bid;
        public MemLib_Books_Reserve()
        {
            InitializeComponent();
        }

        private void MemLib_Books_Reserve_Load(object sender, EventArgs e)
        {
            pb_cvr.Image = MLib_Books.pic;
            lbl_bknm.Text = MLib_Books.booknm;
            lbl_athr.Text = MLib_Books.author;
        }

        private void lnk_rsrv_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            string cdate = DateTime.Now.ToShortDateString();
            string rdate = dt_pick.Value.ToShortDateString();
            string msg = txt_nt.Text;

            int cnfrm = client.MemberReserve(cdate, rdate, mid, msg, bid);
            if (cnfrm == 1)
            {
                MetroMessageBox.Show(this, "Your request for'" + lbl_bknm.Text + "'sent successfully. Staff will contact you as soon as possible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MetroMessageBox.Show(this, "There are some errors. try again in few minuts.if you seeing this more than once contact system adminstrator", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }        
    }
}
