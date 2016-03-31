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
        public Reservation_Ui()
        {
            InitializeComponent();
        }

        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */

        private void lnkRsrvtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reply_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(txt_rply.Text))
            {
                txt_rply.WithError = true;
                ErrResRly.SetError(txt_rply, "Please fill the field");
            }
            else
            {
                string mbrID = txt_mmbrID.Text;
                string mbrnm = txt_mmbrnm.Text;
                string rsbk = txt_rsvrvbk.Text;
                string rsdt = txt_rsrvddt.Text;
                string rqsdt = txt_rqstddt.Text;

                int re = client.stResI(mbrID, mbrnm, rsbk, rsdt, rqsdt);
                if (re != 0)
                {
                    MetroMessageBox.Show(this, "Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

           

        private void Reservation_Ui_Load(object sender, EventArgs e)
        {

            DataTable DTRes = new DataTable();
            DTRes = client.StRes();
            metroGrid1.DataSource = DTRes;            
            metroGrid1.Refresh();
            metroGrid1.Update();
        }

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_mmbrID.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_mmbrnm.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            txt_rsvrvbk.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            txt_rsrvddt.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            txt_rqstddt.Text = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void txt_rply_Click(object sender, EventArgs e)
        {
            ErrResRly.Clear();
        }
    }
}
