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
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        public static string name;
        public static string email;
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

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
            DataTable DTfl = new DataTable();
            DTfl = client.brrwls();
            metroGrid1.DataSource = DTfl;          
            metroGrid1.Refresh();
            metroGrid1.Update();
            conn.Open();
            string qry = "SELECT Member_ID, Return_Date FROM Barrowals WHERE Return_Date <= Convert(Date, GetDate()) AND M_Sent = 0";
            SqlCommand cmd = new SqlCommand(qry,conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            grd_late.DataSource = dt;
            grd_late.Refresh();
            grd_late.Update();
        }

        private void grd_late_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = grd_late.Rows[e.RowIndex];
            string mid = grd_late.Rows[e.RowIndex].Cells[0].Value.ToString();
            string qry = "SELECT M_FirstName, Pe_Email FROM Member WHERE Member_Id = '"+mid+"'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);            
            name = dt1.Rows[0][0].ToString();
            email = dt1.Rows[0][1].ToString();
            Notifier mlsndr = new Notifier();
            mlsndr.ShowDialog();
            conn.Close();
        }

        private void btn_ret_Click(object sender, EventArgs e)
        {

        }
    }
}
