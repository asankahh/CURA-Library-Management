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
    public partial class Barrow_new : MetroForm
    {
        public Barrow_new()
        {
            InitializeComponent();
        }
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */

        private void dt_pck_ValueChanged(object sender, EventArgs e)
        {
            DateTime barday = dt_pck.Value.Date;
            DateTime retday = barday.AddDays(14);
            txt_rte.Text = retday.ToString();
        }

        private void btncls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_bkid.Text = "";
            txt_mid.Text = "";
            txt_rte.Text = "";
        }

        private void btn_sv_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_mid.Text))
            {
                txt_mid.WithError = true;
                ErrmID.SetError(txt_mid, "Please fill the required filed");
            }
            if (String.IsNullOrEmpty(txt_bkid.Text))
            {
                txt_bkid.WithError = true;
                ErrbID.SetError(txt_bkid, "Please fill the required filed");
            }

            else

            {
                string mid = txt_mid.Text;
                string bid = txt_bkid.Text;
                string dp = dt_pck.Text;
                string rt = txt_rte.Text;
                int r = client.barrownw(mid, bid, dp, rt);

                if (r != 0)
                {
                    MetroMessageBox.Show(this, "Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void txt_mid_Click(object sender, EventArgs e)
        {
            ErrmID.Clear();
        }

        private void txt_bkid_Click(object sender, EventArgs e)
        {
            ErrbID.Clear();
        }
    }
}
        

            
    

