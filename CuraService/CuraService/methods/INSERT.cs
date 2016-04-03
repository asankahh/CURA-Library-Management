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
    class INSERT
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

        public int LoginInsert(string StaffID, string UserName, string crypted, string Category)
        {
            int cnfrm = 0;
            conn.Open();
            string qryinsrt = "INSERT INTO LoginDetails(ID, UserName,Password,States) VALUES('" + StaffID + "','" + UserName + "','" + crypted + "','" + Category + "')";
            SqlCommand cmd = new SqlCommand(qryinsrt, conn);
            cnfrm = cmd.ExecuteNonQuery();
            conn.Close();
            return cnfrm;
        }

        public int RequestWrite(string mRq)
        {
            int mRqr = 0;
            conn.Open();
            string qrymRq = "INSERT INTO Request_OR_Complain  (Request)'" + mRq + "' ";
            SqlCommand cmdmRq = new SqlCommand(qrymRq, conn);
            mRqr = cmdmRq.ExecuteNonQuery();
            conn.Close();
            return mRqr;
        }

        public int NewReservation(string mbrID, string mbrnm, string rsbk, string rsdt, string rqsdt)
        {
            conn.Open();
            string qryRes = "INSERT INTO Reservation (Member_ID,Member_Name,Reserved_Date,Requested_date,)VALUES('" + mbrID + "','" + mbrnm + "','" + rsbk + "','" + rsdt + "','" + rqsdt + "')";
            SqlCommand cmdResI = new SqlCommand(qryRes, conn);
            int re = cmdResI.ExecuteNonQuery();
            return re;
        }

        public int NewBarrow(string mid, string bid, string dp, string rt)
        {
            conn.Open();
            string qryin = "INSERT INTO Barrowals (Member_ID,Library_ID,Barrow_Date,Return_Date)VALUES('" + mid + "','" + bid + "','" + dp + "','" + rt + "')";
            SqlCommand cmd = new SqlCommand(qryin, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r;
        }

        public int NewTransaction(string type, string cat, string des, string amt)
        {
            int i = 0;
            conn.Open();
            string qrynt = "INSERT INTO Transactions (Type,Category,Description,Amount)VALUES('" + type + "','" + cat + "','" + des + "','" + amt + "')";
            SqlCommand cmd = new SqlCommand(qrynt, conn);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int InsertStaff(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = 0;
            conn.Open();
            string sql = "INSERT INTO Staff (Staff_Id, S_FirstName, S_LastName, Add_L1, Add_L2, City, Postalcode, Personal_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality) VALUES ('" + StaffID + "', '" + FirstName + "', '" + LastName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + PostalCode + "', '" + PersonalEmail + "', '" + HomeNumber + "', '" + MobileNumber + "','" + Gender + "', '" + Birthday + "', '" + Nationality + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public int InsertStaffWImg(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            conn.Open();
            string sql = "INSERT INTO Staff (Staff_Id, S_LastName, S_FirstName, Add_L1, Add_L2, City, Postalcode, Personal_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality, Image) VALUES ('" + StaffID + "', '" + FirstName + "', '" + LastName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + PostalCode + "', '" + PersonalEmail + "', '" + HomeNumber + "', '" + MobileNumber + "','" + Gender + "', '" + Birthday + "', '" + Nationality + "',@img)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@img", img);
            count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public int NewMemberWImg(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            conn.Open();
            string sql = "INSERT INTO Member (Member_Id, M_FirstName, M_LastName, Add_L1, Add_L2, City, Postalcode, Pe_Email, Wo_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality, Image) VALUES ('" + MemberID + "', '" + LastName + "', '" + FirstName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + PostalCode + "', '" + PersonalEmail + "', '" + WorkEmail + "', '" + HomeNumber + "', '" + MobileNumber + "', '" + Gender + "', '" + Birthday + "', '" + Nationality + "', @img)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@img", img);
            count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public int NewMember(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = 0;
            conn.Open();
            string sql = "INSERT INTO Member (Member_Id, M_FirstName, M_LastName, Add_L1, Add_L2, City, Postalcode, Pe_Email, Wo_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality, Image) VALUES ('" + MemberID + "', '" + LastName + "', '" + FirstName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + PostalCode + "', '" + PersonalEmail + "', '" + WorkEmail + "', '" + HomeNumber + "', '" + MobileNumber + "', '" + Gender + "', '" + Birthday + "', '" + Nationality + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }
    }
}
