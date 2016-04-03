using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CuraService.methods
{
    class LOGIN
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

        public static string encrptdpw;
        CRYPTO crpt = new CRYPTO();

        public int chkusravl(string chkusr)
        {
            conn.Open();
            string qry = "SELECT COUNT(*) FROM LoginDetails WHERE UserName='" + chkusr + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            int avl = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            return avl;
        }

        public string GetUsrPW(string chkusr)
        {
            conn.Open();
            string qry = "SELECT Password FROM LoginDetails WHERE UserName='" + chkusr + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            encrptdpw = cmd.ExecuteScalar().ToString();
            conn.Close();
            string decrptdpw = crpt.decrypt(encrptdpw);
            return decrptdpw;
            //return encrptdpw;
        }

        public string ChkAuth(string chkusr)
        {
            conn.Open();
            string qry = "SELECT States FROM LoginDetails WHERE UserName='" + chkusr + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            string stts = cmd.ExecuteScalar().ToString();
            conn.Close();
            return stts;
        }
    }
}
