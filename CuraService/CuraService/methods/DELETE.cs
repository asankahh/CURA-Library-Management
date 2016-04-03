using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace CuraService.methods
{
    class DELETE
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

        public int DltStf(string sql)
        {
            string qry = "DELETE FROM Staff WHERE Staff_Id='" + sql + "' ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(qry, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int deletemem(string sql)
        {
            string qrydl = "DELETE FROM Member WHERE Member_Id='" + sql + "' ";
            SqlCommand cmd = new SqlCommand(qrydl, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
