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
    class UPDATE
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

        public int UpdateStaff(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = 0;
            conn.Open();
            string sql = "UPDATE Staff SET Staff_Id = '" + StaffID + "', S_LastName = '" + LastName + "', S_FirstName = '" + FirstName + "', Add_L1 = '" + Address1 + "', Add_L2 = '" + Address2 + "', City = '" + City + "', Postalcode = '" + PostalCode + "', Personal_Email = '" + PersonalEmail + "', Ho_Num = '" + HomeNumber + "', Pe_Num = '" + PersonalEmail + "', Gender = '" + Gender + "', Birthday = '" + Birthday + "', Nationality = '" + Nationality + "' WHERE Staff_Id = '" + StaffID + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public int UpdateStaffWImg(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            conn.Open();
            string sql = "UPDATE Staff SET Staff_Id = '" + StaffID + "', S_LastName = '" + LastName + "', S_FirstName = '" + FirstName + "', Add_L1 = '" + Address1 + "', Add_L2 = '" + Address2 + "', City = '" + City + "', Postalcode = '" + PostalCode + "', Personal_Email = '" + PersonalEmail + "', Ho_Num = '" + HomeNumber + "', Pe_Num = '" + PersonalEmail + "', Gender = '" + Gender + "', Birthday = '" + Birthday + "', Nationality = '" + Nationality + "', Image = @img WHERE Staff_Id = '" + StaffID + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@img", img);
            count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public int UpdtMmbrWimg(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            conn.Open();
            string sql = "UPDATE Member SET Member_Id = '" + MemberID + "', M_LastName ='" + LastName + "', M_FirstName = '" + FirstName + "', Add_L1 = '" + Address1 + "', Add_L2 = '" + Address2 + "', City = '" + City + "', Postalcode = '" + PostalCode + "', Pe_Email = '" + PersonalEmail + "', Wo_Email = '" + WorkEmail + "', Ho_Num = '" + HomeNumber + "', Pe_Num = '" + MobileNumber + "', Gender = '" + Gender + "', Birthday = '" + Birthday + "', Nationality = '" + Nationality + "', Image = @img WHERE Member_Id = '" + MemberID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@img", img);
            count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public int UpdtMmbr(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = 0;
            conn.Open();
            string sql = "UPDATE Member SET Member_Id = '" + MemberID + "', M_LastName ='" + LastName + "', M_FirstName = '" + FirstName + "', Add_L1 = '" + Address1 + "', Add_L2 = '" + Address2 + "', City = '" + City + "', Postalcode = '" + PostalCode + "', Pe_Email = '" + PersonalEmail + "', Wo_Email = '" + WorkEmail + "', Ho_Num = '" + HomeNumber + "', Pe_Num = '" + MobileNumber + "', Gender = '" + Gender + "', Birthday = '" + Birthday + "', Nationality = '" + Nationality + "' WHERE Member_Id = '" + MemberID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public int StResStat(string stid,string stat,string rid)
        {
            conn.Open();
            string qry = "UPDATE Reservation SET Staff_ID='" + stid + "',Status='" + stat + "' WHERE Reservation_ID='" + rid + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            int cnfrm = cmd.ExecuteNonQuery();
            conn.Close();
            return cnfrm;
        }

        public int rtrnbk(string br_id, string date)
        {
            conn.Open();
            string qry = "UPDATE Barrowals SET Status='Returned' WHERE Br_ID='" + br_id + "' ";
            SqlCommand cmd = new SqlCommand(qry, conn);
            int cnfrm = cmd.ExecuteNonQuery();
            conn.Close();
            return cnfrm;
        }


    }
}
