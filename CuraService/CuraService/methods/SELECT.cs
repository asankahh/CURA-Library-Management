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
    class SELECT
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);


        public DataTable GetStaffData(string usrnm)
        {
            DataTable DT = new DataTable("Staff", "AllStaff");
            conn.Open();
            string qry_gt_id = "SELECT ID FROM LoginDetails WHERE Username='" + usrnm + "'";
            SqlCommand cmdid = new SqlCommand(qry_gt_id, conn);
            string id = cmdid.ExecuteScalar().ToString();
            string qry_gt_nm = "SELECT * FROM Staff WHERE Staff_ID='" + id + "'";
            SqlCommand cmd = new SqlCommand(qry_gt_nm, conn);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            DA.Update(DT);
            conn.Close();
            return DT;
        }

        public DataTable GetMemberData(string usrnm)
        {
            DataTable DT = new DataTable("Member", "AllMember");
            conn.Open();
            string qry_gt_id = "SELECT ID FROM LoginDetails WHERE Username='" + usrnm + "'";
            SqlCommand cmdid = new SqlCommand(qry_gt_id, conn);
            string id = cmdid.ExecuteScalar().ToString();
            string qry_gt_nm = "SELECT * FROM Member WHERE Member_Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(qry_gt_nm, conn);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            DA.Update(DT);
            conn.Close();
            return DT;
        }

        public DataTable GetBookData(string bkid)
        {
            DataTable DTT = new DataTable("Library", "AllLib");
            conn.Open();
            string qry_dt = "SELECT * FROM Library WHERE Library_ID='" + bkid + "'";
            SqlCommand cmd = new SqlCommand(qry_dt, conn);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DTT);
            DA.Update(DTT);
            conn.Close();
            return DTT;
        }

        public DataTable SelectLibrary(string category)
        {
            string qry = null;

            if (category == "Book001")
            {
                qry = "SELECT Library_ID AS LibraryID, Name AS BookName, Genre, Author, Edition, ISBN, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfPages, L_Category_ID AS CategoryID, Quantity, Image FROM Library WHERE L_Category_ID = '" + category + "' ";
            }
            else if (category == "Journal002")
            {
                qry = "SELECT Library_ID AS LibraryID, Name AS JournalName, Genre, Author, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfPages, L_Category_ID AS CategoryID, Quantity, Advisor, Description, Image FROM Library WHERE L_Category_ID = '" + category + "' ";
            }
            else if (category == "Magaz005")
            {
                qry = "SELECT Library_ID AS LibraryID, Name AS MagazineName, Genre, Author, Edition, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfPages, L_Category_ID AS CategoryID, Quantity, Description, Image FROM Library WHERE L_Category_ID = '" + category + "' ";
            }
            else if (category == "Newspa003")
            {
                qry = "SELECT Library_ID AS LibraryID, Name AS NewspaperName, Genre, Author, Edition, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfPages, L_Category_ID AS CategoryID, Quantity, Description, Image FROM Library WHERE L_Category_ID = '" + category + "' ";
            }
            else if (category == "Thesis004")
            {
                qry = "SELECT Library_ID AS LibraryID, Name AS ThesisName, Genre, Author, Edition, ISBN, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfPages, L_Category_ID AS CategoryID, Quantity, Advisor, Description, Image FROM Library WHERE L_Category_ID = '" + category + "' ";
            }
            else if (category == "Soft006")
            {
                qry = "SELECT Library_ID AS LibraryID, Name AS SoftwareName, Genre, Author AS Vendor, Edition AS Version, ISBN AS SerialNumber, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfDisk, L_Category_ID AS CategoryID, Quantity, Description, Image FROM Library WHERE L_Category_ID = '" + category + "'";
            }
            else if (category == "Ebooks007")
            {
                qry = "SELECT Library_ID AS LibraryID, Name AS EBookName, Genre, Author AS Vendor, Edition AS Version, ISBN AS SerialNumber, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfDisk, L_Category_ID AS CategoryID, Quantity, Description, Image FROM Library WHERE L_Category_ID = '" + category + "' ";
            }
            else if (category == "Music008")
            {
                qry = "SELECT Library_ID AS LibraryID, Name AS AlbumName, Genre, Author AS Vendor, Edition AS Version, ISBN AS SerialNumber, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfDisk, L_Category_ID AS CategoryID, Quantity, Description, Image FROM Library WHERE L_Category_ID = '" + category + "' ";
            }
            else if (category == "AudLec009")
            {
                qry = "SELECT Library_ID AS LibraryID, Name, Genre, Author AS Vendor, Edition AS Version, ISBN AS SerialNumber, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfDisk, L_Category_ID AS CategoryID, Quantity, Description, Image FROM Library WHERE L_Category_ID = '" + category + "' ";
            }
            else if (category == "VidLec010")
            {
                qry = "SELECT Library_ID AS LibraryID, Name, Genre, Author AS Vendor, Edition AS Version, ISBN AS SerialNumber, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfDisk, L_Category_ID AS CategoryID, Quantity, Description, Image FROM Library WHERE L_Category_ID = '" + category + "' ";
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dbdataset = new DataTable("Library", "AllLibrary");
            sda.Fill(dbdataset);
            sda.Update(dbdataset);
            conn.Close();
            return dbdataset;
        }

        public string CategoryID(string categoryName)
        {
            string catid = null;
            string sql = "SELECT l_category_id FROM library_category WHERE l_category_name='" + categoryName + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                catid = dr["l_category_id"].ToString();
            }
            conn.Close();
            return catid;
        }

        public string CategoryName(string categoryId)
        {
            string catnm = null;
            string sql = "SELECT l_Category_Name FROM library_category WHERE l_category_id='" + categoryId + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                catnm = dr["l_Category_Name"].ToString();
            }
            conn.Close();
            return catnm;
        }

        public int ChkLib(string bookID)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Library WHERE Library_ID = '" + bookID + "'", conn);
            SqlDataReader myReader;
            DataTable dbdataset = new DataTable("Library", "AllLibrary");
            conn.Open();
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                i = 1;
            }
            conn.Close();
            return i;
        }

        public byte[] SelectImage(string itemID)
        {
            byte[] img = new byte[512];
            conn.Open();
            string query = "SELECT Image FROM Library WHERE Library_ID = '" + itemID + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!Convert.IsDBNull(rdr["Image"]))
                {
                    img = (byte[])rdr["Image"];
                }
            }
            conn.Close();
            return img;
        }

        public DataTable slctMmber()
        {
            string qry = "SELECT Member_Id AS MemberID, M_FirstName AS FirstName, M_LastName AS LastName, Birthday, Gender, Pe_Email AS PersonalEmail, Add_L1, Add_L2, City, Postalcode, Nationality, Wo_Email AS WorkEmail, Pe_Num AS MobileNumber, Ho_Num AS HomeNumber FROM Member";
            conn.Open();
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dbdataset = new DataTable("Member", "AllMember");
            sda.Fill(dbdataset);
            sda.Update(dbdataset);
            conn.Close();
            return dbdataset;
        }

        public byte[] GtMmbrImage(string itemID)
        {
            byte[] img = new Byte[64];
            conn.Open();
            string query = "SELECT Image FROM Member WHERE Member_Id = '" + itemID + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!Convert.IsDBNull(rdr["Image"]))
                {
                    img = (byte[])rdr["Image"];
                }
            }
            conn.Close();
            return img;
        }

        public int chkMmbr(string memberID)
        {
            int i = 0;
            conn.Open();
            string qry = "SELECT * FROM Staff WHERE Staff_Id ='" + memberID + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader myReader;

            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                i = 1;
            }
            conn.Close();
            return i;
        }

        public DataTable slctstff()
        {
            string qry = "SELECT Staff_Id AS StaffID, S_FirstName AS FirstName, S_LastName AS LastName, Birthday, Gender, Personal_Email AS PersonalEmail, Pe_Num AS MobileNumber, Ho_Num AS HomeNumber, Add_L1, Add_L2, City,Postalcode, Nationality FROM Staff";
            conn.Open();
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dbdataset = new DataTable("Staff", "AllStaff");
            sda.Fill(dbdataset);
            sda.Update(dbdataset);
            conn.Close();
            return dbdataset;
        }

        public byte[] stfimg(string itemID)
        {
            byte[] img = new Byte[64];
            conn.Open();
            string query = "SELECT Image FROM Staff WHERE Staff_Id = '" + itemID + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!Convert.IsDBNull(rdr["Image"]))
                {
                    img = (byte[])rdr["Image"];
                }
            }
            conn.Close();
            return img;
        }

        public int chkstf(string staffID)
        {
            int i = 0;
            conn.Open();
            string qry = "SELECT * FROM Staff WHERE Staff_Id ='" + staffID + "' ";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader myReader;
            DataTable dbdataset = new DataTable("Staff", "AllStaff");
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                i = 0;
            }
            conn.Close();
            return i;
        }
    }
}
