using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CuraService
{
    class rndmbks
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

        public DataTable rndm()
        {
            DataTable RDT = new DataTable();
            conn.Open();
            string qury_gtdkid = "SELECT Library_ID FROM Library WHERE L_Category_ID = 'Book001'";
            SqlCommand cmd = new SqlCommand(qury_gtdkid, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(RDT);
            conn.Close();

            DataTable slctid = new DataTable();
            Random R = new Random();
            var slct = RDT.AsEnumerable().OrderBy(r => R.Next()).Take(8).ToArray();
            slctid = slct.CopyToDataTable();
            string id0 = slctid.Rows[0][0].ToString();
            string id1 = slctid.Rows[1][0].ToString();
            string id2 = slctid.Rows[2][0].ToString();
            string id3 = slctid.Rows[3][0].ToString();
            string id4 = slctid.Rows[4][0].ToString();
            string id5 = slctid.Rows[5][0].ToString();
            string id6 = slctid.Rows[6][0].ToString();
            string id7 = slctid.Rows[7][0].ToString();
            string slctdt = "SELECT Name, Author, Image FROM Library WHERE Library_ID IN ('"+id0+"','"+id1+"','"+id2+"','"+id3+"','"+id4+"','"+id5+"','"+id6+"','"+id7+"')";
            conn.Open();
            SqlCommand cmdbk = new SqlCommand(slctdt,conn);
            SqlDataAdapter dabk = new SqlDataAdapter(cmdbk);
            DataTable randombooks = new DataTable("RandomBooks");
            randombooks.Columns.Add("Name", typeof(string));
            randombooks.Columns.Add("Author", typeof(string));
            randombooks.Columns.Add("Image", typeof(byte[]));
            dabk.Fill(randombooks);
            conn.Close();
            return randombooks;
        }
    }
}
