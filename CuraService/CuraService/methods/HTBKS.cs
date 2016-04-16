using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuraService.methods
{
    class HTBKS
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

        public DataTable htbks()
        {
            DataTable Hitlist = new DataTable();
            conn.Open();
            string gtcnt = "SELECT Library_ID, COUNT(*) AS hits  FROM Barrowals GROUP BY Library_ID HAVING (COUNT(*) > 1) order by hits desc";
            SqlCommand gt = new SqlCommand(gtcnt, conn);
            SqlDataAdapter htlst = new SqlDataAdapter(gt);
            htlst.Fill(Hitlist);
            conn.Close();

            string hit0 = null;
            string hit1 = null;
            string hit2 = null;
            string hit3 = null;
            string hit4 = null;
            int rows = Hitlist.Select().Length;
     
            if (rows == 5)
            {
                hit0 = Hitlist.Rows[0][0].ToString();
                hit1 = Hitlist.Rows[1][0].ToString();
                hit2 = Hitlist.Rows[2][0].ToString();
                hit3 = Hitlist.Rows[3][0].ToString();
                hit4 = Hitlist.Rows[4][0].ToString();
            }
            else if (rows == 4)
            {
                hit0 = Hitlist.Rows[0][0].ToString();
                hit1 = Hitlist.Rows[1][0].ToString();
                hit2 = Hitlist.Rows[2][0].ToString();
                hit3 = Hitlist.Rows[3][0].ToString();
            }
            else if (rows == 3)
            {
                hit0 = Hitlist.Rows[0][0].ToString();
                hit1 = Hitlist.Rows[1][0].ToString();
                hit2 = Hitlist.Rows[2][0].ToString();
            }
            else if(rows == 2)
            {
                hit0 = Hitlist.Rows[0][0].ToString();
                hit1 = Hitlist.Rows[1][0].ToString();
            }
            else if (rows == 1)
            {
                hit0 = Hitlist.Rows[0][0].ToString();
            }


            DataTable HBK = new DataTable("HBK");
            HBK.Columns.Add("Name", typeof(string));
            HBK.Columns.Add("Author", typeof(string));
            HBK.Columns.Add("Image", typeof(byte[]));

            conn.Open();
            string gtdt = "SELECT Name,Author,Image FROM Library WHERE Library_ID IN('" + hit0 + "','" + hit1 + "','" + hit2 + "','" + hit3 + "','" + hit4 + "')";
            SqlCommand getdata = new SqlCommand(gtdt, conn);
            SqlDataAdapter data = new SqlDataAdapter(getdata);
            data.Fill(HBK);
            conn.Close();

            return HBK;
        }
    }
}
