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
    public partial class BarrowelsReturns : MetroForm
    {
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */

        /* Database String */
        //public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        public static string name;
        public static string email;
        string brid = null;
        /* create secondary database object */
       // SqlConnection conn = new SqlConnection(dbstrng);

        public BarrowelsReturns()
        {
            InitializeComponent();
        }

        private void lnkbrrrtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_brrw_Click(object sender, EventArgs e)
        {
            Barrow_new BN = new Barrow_new();
            StyleManager.Clone(BN);
            BN.ShowDialog();
        }
        DataTable DTfl = new DataTable();
        private void BarrowelsReturns_Load(object sender, EventArgs e)
        {
            gridload();
        }

        private void gridload()
        {
            DataTable DTfl = new DataTable();
            DTfl = client.brrwls();
            grd.DataSource = DTfl;
            grd.Refresh();
            grd.Update();

            DataTable dt = client.GetLate();
            grd_late.DataSource = dt;
            grd_late.Refresh();
            grd_late.Update();
        }

        private void grd_late_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = grd_late.Rows[e.RowIndex];
            string mid = grd_late.Rows[e.RowIndex].Cells[0].Value.ToString();            
            DataTable dt1 = client.AllMemberData(mid);            
            name = dt1.Rows[0][1].ToString();
            email = dt1.Rows[0][7].ToString();

            Notifier mlsndr = new Notifier();
            this.StyleManager.Clone(mlsndr);
            mlsndr.ShowDialog();
        }

        private void grd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = grd.Rows[e.RowIndex];
            brid = r.Cells["Br_ID"].Value.ToString();
            lbl_slct.Text = "Barrowal ID " + brid + " selected";
        }

        private void btn_ret_Click(object sender, EventArgs e)
        {
            string date = dt_pck.Value.ToShortDateString();
            int cnfrm = client.RtrnBk(brid,date);
            gridload();
        }

        
    }
}
