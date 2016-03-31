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
    public partial class RequestUi : MetroForm
    {
        public RequestUi()
        {
            InitializeComponent();
        }
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */


        private void RequestUi_Load(object sender, EventArgs e)
        {
            DataTable DTReq = new DataTable();
            DTReq = client.MStReq();
            metroGrid1.DataSource = DTReq;
            metroGrid1.Refresh();
            metroGrid1.Update();
        }

       
        private void btn_rply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mmbrnm.Text))
            {

                txt_mmbrnm.WithError = true;
                ErrRMN.SetError(txt_mmbrnm,"Please fill the field");
            }
            if (string.IsNullOrEmpty(txt_mmbrID.Text))
            {

                txt_mmbrID.WithError = true;
                ErrRMID.SetError(txt_mmbrID, "Please fill the field");
            }
            if (string.IsNullOrEmpty(txt_msg.Text))
            {

                txt_msg.WithError = true;
                ErrRMSG.SetError(txt_msg, "Please fill the field");
            }
            else
            {
               string ReqRply = cb_Reply.Text;
               int Rq = client.StReq(ReqRply);

                if (Rq != 0)
                {
                    MetroMessageBox.Show(this, "Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
;            }
        }

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_mmbrID.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_mmbrnm.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            txt_msg.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void txt_mmbrnm_Click(object sender, EventArgs e)
        {
            ErrRMN.Clear();

        }

        private void txt_mmbrID_Click(object sender, EventArgs e)
        {
            ErrRMID.Clear();
        }

        private void txt_msg_Click(object sender, EventArgs e)
        {
            ErrRMSG.Clear();
        }
    }
}
