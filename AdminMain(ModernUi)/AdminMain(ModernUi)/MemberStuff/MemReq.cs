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
    public partial class MemReq : MetroForm
    {
        public MemReq()
        {
            InitializeComponent();
        }
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */


        private void lnkcls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MemReq_Load(object sender, EventArgs e)
        {
            DataTable DTmRq = new DataTable();
            DTmRq = client.mRqr();
            grd_rq.DataSource = DTmRq;
            grd_rq.Refresh();
            grd_rq.Update();
        }

        private void btn_sbmt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_msg.Text))
            {

                txt_msg.WithError = true;
                ErrMReq.SetError(txt_msg, "Please fill the field");
            }
            else
            {
                string mRq = txt_msg.Text;
                int mRqr = client.mReq(mRq);

                if (mRqr != 0)
                {
                    MetroMessageBox.Show(this, "Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        }
    }
}
