using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminMain_ModernUi_
{
    public partial class Reservation_Ui : MetroForm
    {

        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */

        string stid = null;
        string mid = null;
        string mname = null;
        string bid = null;
        string bname = null;
        string rid = null;

        public Reservation_Ui()
        {
            InitializeComponent();
        }
        

        private void Reservation_Ui_Load(object sender, EventArgs e)
        {
            if(MAdminUi.stid != null)
            {
                stid = MAdminUi.stid;
            }
            else if (MStaffUi.stid != null)
            {
                stid = MStaffUi.stid;
            }
            DataTable DTRes = new DataTable();
            DTRes = client.StRes();
            grd.DataSource = DTRes;
            grd.Refresh();
            grd.Update();
        }

        private void grd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = grd.Rows[e.RowIndex];

            mid = row.Cells["Member_ID"].Value.ToString();
            mname = client.getmembername(mid);

            bid = row.Cells["Book_ID"].Value.ToString();
            bname = client.getbookname(bid);

            rid = row.Cells["Reservation_ID"].Value.ToString();
            string rsd = row.Cells["Reserved_Date"].Value.ToString();
            string rqd = row.Cells["Requested_Date"].Value.ToString();
            string msg = row.Cells["Message"].Value.ToString();

            txt_mmbrID.Text = mid;
            txt_mmbrnm.Text = mname;
            txt_rqstddt.Text = rqd;
            txt_rsrvddt.Text = rsd;
            txt_rsvrvbk.Text = bname;
            txt_nts.Text = msg;          
        }


        private void lnkRsrvtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reply_Click(object sender, EventArgs e)
        {
            string stat = txt_rply.Text;
            int cnfrm = client.SetResStat(stid, stat, rid);
            if (cnfrm != 0)
            {
                MetroMessageBox.Show(this, "Your response for " + mname+ "'s reservation recorded successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MetroMessageBox.Show(this, "There are some errors. try again in few minuts.if you seeing this more than once contact system adminstrator", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }


            //if (txt_rply.Text==null)
            //{                
            //    ErrResRly.SetError(txt_rply, "Please select your reply");
            //}
            //else
            //{
            //    string mbrID = txt_mmbrID.Text;
            //    string mbrnm = txt_mmbrnm.Text;
            //    string rsbk = txt_rsvrvbk.Text;
            //    string rsdt = txt_rsrvddt.Text;
            //    string rqsdt = txt_rqstddt.Text;

            //    int re = client.stResI(mbrID, mbrnm, rsbk, rsdt, rqsdt);
            //    if (re != 0)
            //    {
            //        MetroMessageBox.Show(this, "Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //}
        }

           

        

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_mmbrID.Text = grd.SelectedRows[0].Cells[0].Value.ToString();
            txt_mmbrnm.Text = grd.SelectedRows[0].Cells[1].Value.ToString();
            txt_rsvrvbk.Text = grd.SelectedRows[0].Cells[2].Value.ToString();
            txt_rsrvddt.Text = grd.SelectedRows[0].Cells[3].Value.ToString();
            txt_rqstddt.Text = grd.SelectedRows[0].Cells[4].Value.ToString();
        }

        

        
    }
}
