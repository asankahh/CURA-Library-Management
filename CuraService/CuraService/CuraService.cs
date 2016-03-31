using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace CuraService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CuraService" in both code and config file together.
    public class CuraService : ICuraService
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

        /* LOGIN */
        public int login_chkusr(string chkusr)
        {
            conn.Open();
            string qry = "SELECT COUNT(*) FROM LoginDetails WHERE UserName='" + chkusr + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            int avl = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            return avl;
        }

        public string login_chkpw(string chkpw)
        {
            conn.Open();
            string qry = "SELECT Password FROM LoginDetails WHERE UserName='" + chkpw + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            string pwcnfm = cmd.ExecuteScalar().ToString();
            conn.Close();
            return pwcnfm;
        }

        public string login_chksts(string chksts)
        {
            conn.Open();
            string qry = "SELECT States FROM LoginDetails WHERE UserName='" + chksts + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            string stts = cmd.ExecuteScalar().ToString();
            conn.Close();
            return stts;
        }

        /* Get Staff Data */
        public DataTable getstfdt(string usrnm)
        {
            DataTable DT = new DataTable("Staff","AllStaff");
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

        /* Get Member Data  */
        public DataTable gtmmbrdt(string usrnm)
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

        /*Select Book Data*/
        public DataTable getbkdata(string bkid)
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

        /* LIBRARY */
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
                qry= "SELECT Library_ID AS LibraryID, Name AS SoftwareName, Genre, Author AS Vendor, Edition AS Version, ISBN AS SerialNumber, Publish_Year AS PublishingYear, Publisher, Number_Of_Pages AS NumberOfDisk, L_Category_ID AS CategoryID, Quantity, Description, Image FROM Library WHERE L_Category_ID = '" + category + "'";
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

        public int InsertLibrary(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description, byte[] img)
        {
            int count = 0;
            try
            {
                string categoryId = GetCategoryId(Category);
                if (categoryId != null)
                {
                    conn.Open();
                    string sql = "INSERT INTO Library (Library_ID, Name, Genre, Author, Edition, ISBN, Publish_Year, Publisher, Number_Of_Pages, Advisor, Description, L_Category_ID, Quantity, Image) VALUES ('"+CuraID+ "', '"+Name+ "', '"+Gener+ "', '"+Author+ "', '"+Edition+ "', '"+ISBN+ "', '"+Year+ "', '"+Publisher+ "', '"+NoOfPages+ "', '"+Advisor+ "', '"+Description+ "', '"+categoryId+ "', '"+Quantity+ "', @img)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@img", img);
                    count = cmd.ExecuteNonQuery();
                    return count;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public int InsertLibraryNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description)
        {
            int count = 0;
            try
            {
                string categoryId = GetCategoryId(Category);
                if (categoryId != null)
                {
                    conn.Open();

                    string sql = "INSERT INTO Library (Library_ID, Name, Genre, Author, Edition, ISBN, Publish_Year, Publisher, Number_Of_Pages, Advisor, Description, L_Category_ID, Quantity) VALUES ('"+CuraID+"', '"+Name+"', '"+Gener+"', '"+Author+"', '"+Edition+"', '"+ISBN+"', '"+Year+"', '"+Publisher+"', '"+NoOfPages+"', '"+Advisor+"', '"+Description+"', '"+categoryId+"', '"+Quantity+"')";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    count = cmd.ExecuteNonQuery();
                    return count;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        string GetCategoryId(string categoryName)
        {
            try
            {
                string sql = "SELECT l_category_id FROM library_category WHERE l_category_name='"+categoryName+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    return dr["l_category_id"].ToString();
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                conn.Close();
            }            
        }

        string GetCategoryName(string categoryId)
        {
            try
            {
                string sql = "SELECT l_Category_Name FROM library_category WHERE l_category_id='"+categoryId+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr["l_Category_Name"].ToString();
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                conn.Close();
            }           
        }

        public int CheckLibrary(string bookID)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Library WHERE Library_ID = '" + bookID + "'", conn);
                SqlDataReader myReader;
                DataTable dbdataset = new DataTable("Library", "AllLibrary");
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                conn.Close();
            }           
        }

        public byte[] getItemImage(string itemID)
        {
            byte[] img = new byte[512];
            try
            {
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
            }
            finally
            {
                conn.Close();
            }

            return img;
        }

        public int UpdateLibrary(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description, byte[] img)
        {
            try
            {
                int count = 0;
                string categoryId = GetCategoryId(Category);
                if (categoryId != null)
                {
                    conn.Open();
                  
                    string sql = "UPDATE Library SET Library_ID = '"+CuraID+"', Name = '"+Name+"', Genre = '"+Gener+"', Author = '"+Gener+"', Edition = '"+Edition+"', ISBN ='"+ISBN+"', Publish_Year = '"+Year+"', Publisher = '"+Publisher+"', Number_Of_Pages = '"+NoOfPages+"', Advisor = '"+Advisor+"', Description = '"+Description+"', L_Category_ID = '"+categoryId+"', Quantity = '"+Quantity+"', Image = '"+img+"' WHERE Library_ID = '"+CuraID+"'";                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.CommandType = CommandType.Text;
                    //cmd.Connection = conn;

                    //cmd.Parameters.AddWithValue("@libraryID", CuraID);
                    //cmd.Parameters.AddWithValue("@Name", Name);
                    //cmd.Parameters.AddWithValue("@author", Author);
                    //cmd.Parameters.AddWithValue("@isbn", ISBN);
                    //cmd.Parameters.AddWithValue("@edition", Edition);
                    //cmd.Parameters.AddWithValue("@publisher", Publisher);
                    //cmd.Parameters.AddWithValue("@categoryID", categoryId);
                    //cmd.Parameters.AddWithValue("@PublishYear", Year);
                    //cmd.Parameters.AddWithValue("@numberOfPages", NoOfPages);
                    //cmd.Parameters.AddWithValue("@quantity", Quantity);
                    //cmd.Parameters.AddWithValue("@Genre", Gener);
                    //cmd.Parameters.AddWithValue("@advisor", Advisor);
                    //cmd.Parameters.AddWithValue("@description", Description);
                    //cmd.Parameters.AddWithValue("@img", img);

                    count = cmd.ExecuteNonQuery();

                    return count;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                conn.Close();
            }

        }

        //public int UpdateDigitalNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Description)
        //{

        //    int count = 0;
        //    //SqlConnection con = GetConnection();
        //    try
        //    {
        //        string categoryId = GetCategoryId(Category);
        //        if (categoryId != null)
        //        {
        //            conn.Open();

        //            string sql = "UPDATE Library SET Library_ID = @libraryID, Name = @Name, Genre = @Genre, Author = @author, Edition = @edition, ISBN = @isbn, Publish_Year = @PublishYear, Publisher = @publisher, Number_Of_Pages = @numberOfPages, Description = @description, L_Category_ID = @categoryID, Quantity = @quantity WHERE Library_ID = @libraryID";

        //            SqlCommand cmd = new SqlCommand(sql, conn);
        //            cmd.CommandType = CommandType.Text;
        //            cmd.Connection = conn;

        //            cmd.Parameters.AddWithValue("@libraryID", CuraID);//cmd.Parameters.AddWithValue("@libraryID", CuraID);
        //            cmd.Parameters.AddWithValue("@Name", Name);//cmd.Parameters.AddWithValue("@Name", Name);
        //            cmd.Parameters.AddWithValue("@author", Author);//cmd.Parameters.AddWithValue("@author", Author);
        //            cmd.Parameters.AddWithValue("@isbn", ISBN);//cmd.Parameters.AddWithValue("@isbn", ISBN);
        //            cmd.Parameters.AddWithValue("@edition", Edition);//cmd.Parameters.AddWithValue("@edition", Edition);
        //            //cmd.Parameters.AddWithValue("@publisher", Publisher);
        //            cmd.Parameters.AddWithValue("@publisher", Publisher);
        //            //cmd.Parameters.AddWithValue("@categoryID", categoryId);
        //            cmd.Parameters.AddWithValue("@categoryID", categoryId);
        //            //cmd.Parameters.AddWithValue("@PublishYear", Year);
        //            cmd.Parameters.AddWithValue("@PublishYear", Year);
        //            cmd.Parameters.AddWithValue("@numberOfPages", NoOfPages);
        //            cmd.Parameters.AddWithValue("@quantity", Quantity);
        //            cmd.Parameters.AddWithValue("@Genre", Gener);
        //            cmd.Parameters.AddWithValue("@description", Description);

                    
                    
                    
                    
                    
        //            //cmd.Parameters.AddWithValue("@numberOfPages", NoOfPages);
        //            //cmd.Parameters.AddWithValue("@quantity", Quantity);
        //            //cmd.Parameters.AddWithValue("@Genre", Gener);
        //            //cmd.Parameters.AddWithValue("@advisor", Advisor);
        //            //cmd.Parameters.AddWithValue("@description", Description);
        //            //cmd.Parameters.AddWithValue("@img", img);
        //            count = cmd.ExecuteNonQuery();

        //            return count;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        public int UpdateLibraryNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description)
        {
            int count = 0;
            //SqlConnection con = GetConnection();
            try
            {
                string categoryId = GetCategoryId(Category);
                if (categoryId != null)
                {
                    conn.Open();
                    string sql = "UPDATE Library SET Library_ID = '" + CuraID + "', Name = '" + Name + "', Genre = '" + Gener + "', Author = '" + Gener + "', Edition = '" + Edition + "', ISBN ='" + ISBN + "', Publish_Year = '" + Year + "', Publisher = '" + Publisher + "', Number_Of_Pages = '" + NoOfPages + "', Advisor = '" + Advisor + "', Description = '" + Description + "', L_Category_ID = '" + categoryId + "', Quantity = '" + Quantity + "' WHERE Library_ID = '" + CuraID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.CommandType = CommandType.Text;
                    //cmd.Connection = conn;

                    ////cmd.Parameters.AddWithValue("@libraryID", CuraID);
                    //cmd.Parameters.AddWithValue("@Name", Name);
                    //cmd.Parameters.AddWithValue("@author", Author);
                    //cmd.Parameters.AddWithValue("@isbn", ISBN);
                    //cmd.Parameters.AddWithValue("@edition", Edition);
                    //cmd.Parameters.AddWithValue("@publisher", Publisher);
                    //cmd.Parameters.AddWithValue("@categoryID", categoryId);
                    //cmd.Parameters.AddWithValue("@PublishYear", Year);
                    //cmd.Parameters.AddWithValue("@numberOfPages", NoOfPages);
                    //cmd.Parameters.AddWithValue("@quantity", Quantity);
                    ////cmd.Parameters.AddWithValue("@Genre", Gener);
                    //cmd.Parameters.AddWithValue("@advisor", Advisor);
                    //cmd.Parameters.AddWithValue("@description", Description);

                    count = cmd.ExecuteNonQuery();

                    return count;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public int DeleteLibrary(string sql)
        {
            //SqlConnection con = GetConnection();
            string qrydl = "DELETE FROM Library WHERE Library_ID='" + sql + "' ";
            SqlCommand cmd = new SqlCommand(qrydl, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public DataTable SearchLibrary(string sql)
        {
            //SqlConnection con = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            

            DataTable dbdataset = new DataTable("Library", "AllLibrary");
            sda.Fill(dbdataset);
            sda.Update(dbdataset);
            conn.Close();
            return dbdataset;
        }

        /* MEMBERS */
        public DataTable SelectMember()
        {
            //SqlConnection con = GetConnection();
            string qry = "SELECT Member_Id AS MemberID, M_FirstName AS FirstName, M_LastName AS LastName, Birthday, Gender, Pe_Email AS PersonalEmail, Add_L1, Add_L2, City, Postalcode, Nationality, Wo_Email AS WorkEmail, Pe_Num AS MobileNumber, Ho_Num AS HomeNumber FROM Member";

            conn.Open();
            SqlCommand cmd= new SqlCommand(qry, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dbdataset = new DataTable("Member", "AllMember");
            sda.Fill(dbdataset);
            sda.Update(dbdataset);
            conn.Close();
            return dbdataset;
        }

        public byte[] getMemberImage(string itemID)
        {
            byte[] img = new Byte[64];
            //SqlConnection con = GetConnection();
            try
            {
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
            }
            finally
            {
                conn.Close();
            }

            return img;
        }


        public int InsertMember(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            //SqlConnection con = GetConnection();
            try
            {
                conn.Open();

                string sql = "INSERT INTO Member (Member_Id, M_FirstName, M_LastName, Add_L1, Add_L2, City, Postalcode, Pe_Email, Wo_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality, Image) VALUES ('"+MemberID+"', '"+LastName+"', '"+FirstName+"', '"+Address1+"', '"+Address2+"', '"+City+"', '"+PostalCode+"', '"+PersonalEmail+"', '"+WorkEmail+"', '"+HomeNumber+"', '"+MobileNumber+"', '"+Gender+"', '"+Birthday+"', '"+Nationality+"', '"+img+"')";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.CommandType = CommandType.Text;
                    //cmd.Connection = conn;

                    //cmd.Parameters.AddWithValue("@memberID", MemberID);
                    //cmd.Parameters.AddWithValue("@lastName", FirstName);
                    //cmd.Parameters.AddWithValue("@firstName", LastName);
                    //cmd.Parameters.AddWithValue("@address", Address1);
                    //cmd.Parameters.AddWithValue("@address1", Address2);
                    //cmd.Parameters.AddWithValue("@city", City);
                    //cmd.Parameters.AddWithValue("@postalCode", PostalCode);
                    //cmd.Parameters.AddWithValue("@personalEmail", PersonalEmail);
                    //cmd.Parameters.AddWithValue("@workEmail", WorkEmail);
                    //cmd.Parameters.AddWithValue("@homeNumber", HomeNumber);
                    //cmd.Parameters.AddWithValue("@mobileNumber", MobileNumber);
                    //cmd.Parameters.AddWithValue("@gender", Gender);
                    //cmd.Parameters.AddWithValue("@birthday", Birthday);
                    //cmd.Parameters.AddWithValue("@nationality", Nationality);
                    //cmd.Parameters.AddWithValue("@img", img);

                    count = cmd.ExecuteNonQuery();

                    return count;
                                
            }
            finally
            {
                conn.Close();
            }
        }

        public int InsertMemberNoIMG(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = 0;
            //SqlConnection con = GetConnection();
            try
            {
                conn.Open();

                //string sql = "INSERT INTO Member (Member_Id, M_LastName, M_FirstName, Address, Address1, City, Postalcode, Personal_Email, Work_Email, Home_TelNumber, Personal_TelNmber, Gender, Birthday, Nationality) VALUES (@memberID, @lastName, @firstName, @address, @address1, @city, @postalCode, @personalEmail, @workEmail, @homeNumber, @mobileNumber, @gender, @birthday, @nationality)";
                string sql = "INSERT INTO Member (Member_Id, M_FirstName, M_LastName, Add_L1, Add_L2, City, Postalcode, Pe_Email, Wo_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality, Image) VALUES ('" + MemberID + "', '" + LastName + "', '" + FirstName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + PostalCode + "', '" + PersonalEmail + "', '" + WorkEmail + "', '" + HomeNumber + "', '" + MobileNumber + "', '" + Gender + "', '" + Birthday + "', '" + Nationality + "')";

                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = conn;

                //cmd.Parameters.AddWithValue("@memberID", MemberID);
                //cmd.Parameters.AddWithValue("@lastName", LastName);
                //cmd.Parameters.AddWithValue("@firstName", FirstName);              
                //cmd.Parameters.AddWithValue("@address", Address1);
                //cmd.Parameters.AddWithValue("@address1", Address2);
                //cmd.Parameters.AddWithValue("@city", City);
                //cmd.Parameters.AddWithValue("@postalCode", PostalCode);
                //cmd.Parameters.AddWithValue("@personalEmail", PersonalEmail);
                //cmd.Parameters.AddWithValue("@workEmail", WorkEmail);
                //cmd.Parameters.AddWithValue("@homeNumber", HomeNumber);
                //cmd.Parameters.AddWithValue("@mobileNumber", MobileNumber);              
                //cmd.Parameters.AddWithValue("@gender", Gender);
                //cmd.Parameters.AddWithValue("@birthday", Birthday);
                //cmd.Parameters.AddWithValue("@nationality", Nationality);              

                count = cmd.ExecuteNonQuery();

                return count;

            }
            finally
            {
                conn.Close();
            }
        }

        public int CheckMember(string memberID)
        {
            //SqlConnection con = GetConnection();
            try
            {
                conn.Open();
                string qry = "SELECT * FROM Staff WHERE Staff_Id ='" + memberID + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader myReader;
                //DataTable dbdataset = new DataTable("Member", "AllMember");
                myReader = cmd.ExecuteReader();                
                if (myReader.Read())
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                conn.Close();
            }
            
        }

        public int UpdateMember(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            //SqlConnection con = GetConnection();
            try
            {
                conn.Open();

                string sql = "UPDATE Member SET Member_Id = '"+MemberID+"', M_LastName ='"+LastName+"', M_FirstName = '"+FirstName+"', Add_L1 = '"+Address1+"', Add_L2 = '"+Address2+"', City = '"+City+"', Postalcode = '"+PostalCode+"', Pe_Email = '"+PersonalEmail+"', Wo_Email = '"+WorkEmail+"', Ho_Num = '"+HomeNumber+"', Pe_Num = '"+MobileNumber+"', Gender = '"+Gender+"', Birthday = '"+Birthday+"', Nationality = '"+Nationality+"', Image = '"+img+"' WHERE Member_Id = '"+MemberID+"'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = conn;

                //cmd.Parameters.AddWithValue("@memberID", MemberID);
                //cmd.Parameters.AddWithValue("@lastName", LastName);
                //cmd.Parameters.AddWithValue("@firstName", FirstName);
                //cmd.Parameters.AddWithValue("@address", Address1);
                //cmd.Parameters.AddWithValue("@address1", Address2);
                //cmd.Parameters.AddWithValue("@city", City);
                //cmd.Parameters.AddWithValue("@postalCode", PostalCode);
                //cmd.Parameters.AddWithValue("@personalEmail", PersonalEmail);
                //cmd.Parameters.AddWithValue("@workEmail", WorkEmail);
                //cmd.Parameters.AddWithValue("@homeNumber", HomeNumber);
                //cmd.Parameters.AddWithValue("@mobileNumber", MobileNumber);
                //cmd.Parameters.AddWithValue("@gender", Gender);
                //cmd.Parameters.AddWithValue("@birthday", Birthday);
                //cmd.Parameters.AddWithValue("@nationality", Nationality);
                //cmd.Parameters.AddWithValue("@img", img);

                count = cmd.ExecuteNonQuery();

                return count;

            }
            finally
            {
                conn.Close();
            }
        }

        public int UpdateMemberNoIMG(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = 0;
            //SqlConnection con = GetConnection();
            try
            {
                conn.Open();

                string sql = "UPDATE Member SET Member_Id = '" + MemberID + "', M_LastName ='" + LastName + "', M_FirstName = '" + FirstName + "', Add_L1 = '" + Address1 + "', Add_L2 = '" + Address2 + "', City = '" + City + "', Postalcode = '" + PostalCode + "', Pe_Email = '" + PersonalEmail + "', Wo_Email = '" + WorkEmail + "', Ho_Num = '" + HomeNumber + "', Pe_Num = '" + MobileNumber + "', Gender = '" + Gender + "', Birthday = '" + Birthday + "', Nationality = '" + Nationality + "' WHERE Member_Id = '" + MemberID + "'";

                //string sql = "UPDATE Member SET Member_Id = @memberID, M_LastName = @lastName, M_FirstName = @firstName, Add_L1 = @address, Add_2 = @address1, City = @city, Postalcode = @postalCode, Pe_Email = @personalEmail, Wo_Email = @workEmail, Ho_Num = @homeNumber, Pe_Num = @mobileNumber, Gender = @gender, Birthday = @birthday, Nationality = @nationality  WHERE Member_Id = @memberID ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = conn;

                //cmd.Parameters.AddWithValue("@memberID", MemberID);
                //cmd.Parameters.AddWithValue("@lastName", LastName);
                //cmd.Parameters.AddWithValue("@firstName", FirstName);
                //cmd.Parameters.AddWithValue("@address", Address1);
                //cmd.Parameters.AddWithValue("@address1", Address2);
                //cmd.Parameters.AddWithValue("@city", City);
                //cmd.Parameters.AddWithValue("@postalCode", PostalCode);
                //cmd.Parameters.AddWithValue("@personalEmail", PersonalEmail);
                //cmd.Parameters.AddWithValue("@workEmail", WorkEmail);
                //cmd.Parameters.AddWithValue("@homeNumber", HomeNumber);
                //cmd.Parameters.AddWithValue("@mobileNumber", MobileNumber);
                //cmd.Parameters.AddWithValue("@gender", Gender);
                //cmd.Parameters.AddWithValue("@birthday", Birthday);
                //cmd.Parameters.AddWithValue("@nationality", Nationality);

                count = cmd.ExecuteNonQuery();

                return count;

            }
            finally
            {
                conn.Close();
            }
        }

        public int DeleteMember(string sql)
        {
            //SqlConnection con = GetConnection();
            string qrydl = "DELETE FROM Member WHERE Member_Id='" + sql + "' ";
            SqlCommand cmd = new SqlCommand(qrydl, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        /* STAFF */
        public DataTable SelectStaff()
        {
            string qry = "SELECT Staff_Id AS StaffID, S_FirstName AS FirstName, S_LastName AS LastName, Birthday, Gender, Personal_Email AS PersonalEmail, Pe_Num AS MobileNumber, Ho_Num AS HomeNumber, Add_L1, Add_L2, City,Postalcode, Nationality FROM Staff";

            //SqlConnection con = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //string qry = "SELECT Staff_Id AS StaffID, S_FirstName AS FirstName, S_LastName AS LastName, Birthday, Gender, Personal_Email AS PersonalEmail, Pe_Num AS MobileNumber, Ho_Num AS HomeNumber, Add_L1, Add_L2, City,Postalcode, Nationality FROM Staff";
            //cmd = new SqlCommand(qry, conn);
            sda.SelectCommand = cmd;

            DataTable dbdataset = new DataTable("Staff", "AllStaff");
            sda.Fill(dbdataset);
            sda.Update(dbdataset);
            conn.Close();
            return dbdataset;
        }

        public byte[] getStaffImage(string itemID)
        {
            byte[] img = new Byte[64];
            //SqlConnection con = GetConnection();
            try
            {
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
            }
            finally
            {
                conn.Close();
            }

            return img;
        }

        public int InsertStaff(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            //SqlConnection con = GetConnection();
            try
            {
                conn.Open();
                string sql = "INSERT INTO Staff (Staff_Id, S_LastName, S_FirstName, Add_L1, Add_L2, City, Postalcode, Personal_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality, Image) VALUES ('" + StaffID + "', '" + FirstName + "', '" + LastName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + PostalCode + "', '" + PersonalEmail + "', '" + HomeNumber + "', '" + MobileNumber + "','" + Gender + "', '" + Birthday + "', '" + Nationality + "','" + img + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                count = cmd.ExecuteNonQuery();
                return count;
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = conn;
                //cmd.Parameters.AddWithValue("@staffID", StaffID);
                //cmd.Parameters.AddWithValue("@lastName", LastName);
                //cmd.Parameters.AddWithValue("@firstName", FirstName);
                //cmd.Parameters.AddWithValue("@address", Address1);
                //cmd.Parameters.AddWithValue("@address1", Address2);
                //cmd.Parameters.AddWithValue("@city", City);
                //cmd.Parameters.AddWithValue("@postalCode", PostalCode);
                //cmd.Parameters.AddWithValue("@personalEmail", PersonalEmail);
                //cmd.Parameters.AddWithValue("@homeNumber", HomeNumber);
                //cmd.Parameters.AddWithValue("@mobileNumber", MobileNumber);
                //cmd.Parameters.AddWithValue("@gender", Gender);
                //cmd.Parameters.AddWithValue("@birthday", Birthday);
                //cmd.Parameters.AddWithValue("@nationality", Nationality);
                //cmd.Parameters.AddWithValue("@img", img);
                //count = cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }


        public int InsertStaffNoIMG(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = 0;
            try
            {
                conn.Open();

                string sql = "INSERT INTO Staff (Staff_Id, S_FirstName, S_LastName, Add_L1, Add_L2, City, Postalcode, Personal_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality) VALUES ('" + StaffID + "', '" + FirstName + "', '" + LastName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + PostalCode + "', '" + PersonalEmail + "', '" + HomeNumber + "', '" + MobileNumber + "','" + Gender + "', '" + Birthday + "', '" + Nationality + "')";

                SqlCommand cmd = new SqlCommand(sql, conn);
                count = cmd.ExecuteNonQuery();                
                return count;
            }
            finally
            {
                conn.Close();
            }
        }

        public int CheckStaff(string staffID)
        {
            //SqlConnection con = GetConnection();
            try
            {
                conn.Open();
                string qry = "SELECT * FROM Staff WHERE Staff_Id ='" + staffID + "' ";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader myReader;
                DataTable dbdataset = new DataTable("Staff", "AllStaff");
                myReader = cmd.ExecuteReader();                
                if (myReader.Read())
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                conn.Close();
            }
            
        }


        public int UpdateStaff(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            //SqlConnection con = new SqlConnection("Data Source=BimalSirisena;Initial Catalog=Cura v2.1;Integrated Security=True");
            try
            {
                conn.Open();
                string sql = "UPDATE Staff SET Staff_Id = '"+StaffID+"', S_LastName = '"+LastName+"', S_FirstName = '"+FirstName+"', Add_L1 = '"+Address1+"', Add_L2 = '"+Address2+"', City = '"+City+"', Postalcode = '"+PostalCode+"', Personal_Email = '"+PersonalEmail+"', Ho_Num = '"+HomeNumber+"', Pe_Num = '"+PersonalEmail+"', Gender = '"+Gender+"', Birthday = '"+Birthday+"', Nationality = '"+Nationality+"', Image = '"+img+"' WHERE Staff_Id = '"+StaffID+"' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                count = cmd.ExecuteNonQuery();
                return count;
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = conn;

                //cmd.Parameters.AddWithValue("@staffID", StaffID);
                //cmd.Parameters.AddWithValue("@lastName", LastName);
                //cmd.Parameters.AddWithValue("@firstName", FirstName);
                //cmd.Parameters.AddWithValue("@address", Address1);
                //cmd.Parameters.AddWithValue("@address1", Address2);
                //cmd.Parameters.AddWithValue("@city", City);
                //cmd.Parameters.AddWithValue("@postalCode", PostalCode);
                //cmd.Parameters.AddWithValue("@personalEmail", PersonalEmail);
                //cmd.Parameters.AddWithValue("@homeNumber", HomeNumber);
                //cmd.Parameters.AddWithValue("@mobileNumber", MobileNumber);
                //cmd.Parameters.AddWithValue("@gender", Gender);
                //cmd.Parameters.AddWithValue("@birthday", Birthday);
                //cmd.Parameters.AddWithValue("@nationality", Nationality);
                //cmd.Parameters.AddWithValue("@img", img);
            }
            finally
            {
                conn.Close();
            }
        }


        public int UpdateStaffNoIMG(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = 0;
            //SqlConnection con = new SqlConnection("Data Source=BimalSirisena;Initial Catalog=Cura v2.1;Integrated Security=True");
            try
            {
                conn.Open();
                string sql = "UPDATE Staff SET Staff_Id = '" + StaffID + "', S_LastName = '" + LastName + "', S_FirstName = '" + FirstName + "', Add_L1 = '" + Address1 + "', Add_L2 = '" + Address2 + "', City = '" + City + "', Postalcode = '" + PostalCode + "', Personal_Email = '" + PersonalEmail + "', Ho_Num = '" + HomeNumber + "', Pe_Num = '" + PersonalEmail + "', Gender = '" + Gender + "', Birthday = '" + Birthday + "', Nationality = '" + Nationality + "' WHERE Staff_Id = '" + StaffID + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                count = cmd.ExecuteNonQuery();
                return count;
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = conn;

                //cmd.Parameters.AddWithValue("@staffID", StaffID);
                //cmd.Parameters.AddWithValue("@lastName", LastName);
                //cmd.Parameters.AddWithValue("@firstName", FirstName);
                //cmd.Parameters.AddWithValue("@address", Address1);
                //cmd.Parameters.AddWithValue("@address1", Address2);
                //cmd.Parameters.AddWithValue("@city", City);
                //cmd.Parameters.AddWithValue("@postalCode", PostalCode);
                //cmd.Parameters.AddWithValue("@personalEmail", PersonalEmail);
                //cmd.Parameters.AddWithValue("@homeNumber", HomeNumber);
                //cmd.Parameters.AddWithValue("@mobileNumber", MobileNumber);
                //cmd.Parameters.AddWithValue("@gender", Gender);
                //cmd.Parameters.AddWithValue("@birthday", Birthday);
                //cmd.Parameters.AddWithValue("@nationality", Nationality);



            }
            finally
            {
                conn.Close();
            }
        }

        public int DeleteStaff(string sql)
        {
            //SqlConnection con = GetConnection();
            string qry = "DELETE FROM Staff WHERE Staff_Id='" + sql + "' ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(qry, conn);            
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;

        }

        public int newtrans(string type, string cat, string des, string amt)
        {
            int i = 0;
            conn.Open();
            string qrynt = "INSERT INTO Transactions (Type,Category,Description,Amount)VALUES('" + type + "','" +cat + "','" +des + "','" + amt + "')";
            SqlCommand cmd = new SqlCommand(qrynt, conn);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public DataTable transldin()
        {
            DataTable transin = new DataTable("Transactions","AllTransactions");
            conn.Open();
            string qryin = "SELECT Type,Amount FROM Transactions WHERE Type='Income'";
            SqlDataAdapter SDAin = new SqlDataAdapter(qryin,conn);
            SDAin.Fill(transin);
            conn.Close();
            return transin;
       }

        public DataTable transldex()
        {
            DataTable transex = new DataTable("Transactions", "AllTransactions");
            conn.Open();
            string qryex = "SELECT Type,Amount FROM Transactions WHERE Type='Expence'";
            SqlDataAdapter SDAex = new SqlDataAdapter(qryex, conn);
            SDAex.Fill(transex);
            conn.Close();
            return transex;
        }

        public DataTable Selectin(string month)
        {
            DataTable DTin = new DataTable("Transaction", "TransactionIncome");
            conn.Open();
            string qryin = "SELECT Date,Amount FROM Transactions WHERE DATEPART(MONTH,Date) ='" + month + "'AND Type = 'Income'";
            SqlCommand cmdin = new SqlCommand(qryin,conn);
            SqlDataAdapter sdain = new SqlDataAdapter(cmdin);
            sdain.SelectCommand = cmdin;
            sdain.Fill(DTin);
            conn.Close();
            return DTin;
        }

        public DataTable Selectex(string month)
        {
            DataTable DTex = new DataTable("Transaction", "TransactionExpence");
            conn.Open();
            string qryex = "SELECT Date,Amount FROM Transactions WHERE DATEPART(MONTH,Date) ='" +month + "'AND Type = 'Expence'";
            SqlCommand cmdex = new SqlCommand(qryex,conn);
            SqlDataAdapter sdaex = new SqlDataAdapter();
            sdaex.SelectCommand = cmdex;
            sdaex.Fill(DTex);
            conn.Close();
            return DTex;
        }

        public int barrownw(string mid, string bid, string dp, string rt)
        {
            int r = 0;
            conn.Open();
            string qryin = "INSERT INTO Barrowals (Member_ID,Library_ID,Barrow_Date,Return_Date)VALUES('" +mid+ "','" +bid+ "','" +dp + "','" +rt+ "')";
            SqlCommand cmd = new SqlCommand(qryin,conn);
            r = cmd.ExecuteNonQuery();
            conn.Close();
            return r ;
        }

        public DataTable brrwls()
        {
            DataTable DTfl = new DataTable("Barrowals","AllBarrowals");
            conn.Open();
            string qry = "SELECT * FROM Barrowals";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter SDAfl = new SqlDataAdapter();
            SDAfl.SelectCommand = cmd;
            SDAfl.Fill(DTfl);
            conn.Close();
            return DTfl;
        }

        public DataTable StRes()
        {
            DataTable DTRes = new DataTable("Reservation","AllReservation");
            conn.Open();
            string qryRes = "SELECT* FROM Reservation ";
            SqlCommand cmdRes =new  SqlCommand(qryRes,conn);
            SqlDataAdapter sdaRes = new SqlDataAdapter();
            sdaRes.SelectCommand = cmdRes;
            sdaRes.Fill(DTRes);
            conn.Close();
            return DTRes;

        }

        public int stResI(string mbrID, string mbrnm, string rsbk, string rsdt, string rqsdt)
        {
            int re = 0;
            conn.Open();
            string qryRes = "INSERT INTO Reservation (Member_ID,Member_Name,Reserved_Date,Requested_date,)VALUES('" + mbrID + "','" + mbrnm + "','" + rsbk + "','" + rsdt + "','" + rqsdt + "')";
            SqlCommand cmdResI = new SqlCommand(qryRes, conn);
            re = cmdResI.ExecuteNonQuery();
            return re;
        }

        public DataTable mRes()
        {
            DataTable DTmRes = new DataTable("Reservation","AllReservaion");
            conn.Open();
            string qrymRes = "SELECT * FROM Reservation ";
            SqlCommand cmdmRes = new SqlCommand(qrymRes,conn);
            SqlDataAdapter SDAmRes = new SqlDataAdapter();
            SDAmRes.Fill(DTmRes);
            conn.Close();
            return DTmRes;
        }

        public int StReq(string ReqRply)
        {

            int Rq = 0;
            conn.Open();
            string qryRepMsg = "INSERT INTO Request_OR_Complain (Reply)'"+ ReqRply + "',";
            SqlCommand cmdStReq = new SqlCommand(qryRepMsg,conn);
            Rq = cmdStReq.ExecuteNonQuery();
            conn.Close();
            return Rq;   
                     
       }

        public DataTable MStReq()
        {
            DataTable DTReq = new DataTable("Request_OR_Complain", "AllRequest_OR_Complain");
            conn.Open();
            string qryReq = "SELECT  Member_ID,Member_Name,Request FROM Request_OR_Complain";
            SqlCommand cmdReq = new SqlCommand(qryReq,conn);
            SqlDataAdapter SDAReq = new SqlDataAdapter(cmdReq);
            SDAReq.Fill(DTReq);
            conn.Close();
            return DTReq;
        }

        public int mReq(string mRq)
        {
            int mRqr = 0;
            conn.Open();
            string qrymRq = "INSERT INTO Request_OR_Complain  (Request)'"+ mRq + "' ";
            SqlCommand cmdmRq = new SqlCommand(qrymRq,conn);
            mRqr = cmdmRq.ExecuteNonQuery();
            conn.Close();
            return mRqr;
        }

        public DataTable mRqr()
        {
            DataTable DTmRq = new DataTable("Request_OR_Complain", "AllRequest_OR_Complain");
            conn.Open();
            string qrymRq = "SELECT Date,Request,Reply FROM Request_OR_Complain";
            SqlCommand cmdmRq = new SqlCommand(qrymRq, conn);
            SqlDataAdapter SDAmRq = new SqlDataAdapter(cmdmRq);
            SDAmRq.Fill(DTmRq);
            conn.Close();
            return DTmRq;
        }

        //public int InsertDigital(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Description, byte[] img)
        //{

        //    int count = 0;
            
        //    try
        //    {
        //        string categoryId = GetCategoryId(Category);
        //        if (categoryId != null)
        //        {
        //            conn.Open();

        //            string sql = "INSERT INTO Library (Library_ID, Name, Genre, Author, Edition, ISBN, Publish_Year, Publisher, Number_Of_Pages, Description, L_Category_ID, Quantity, Image) VALUES (@libraryID, @Name, @Genre, @author, @edition, @isbn, @PublishYear, @publisher, @numberOfPages, @description, @categoryID, @quantity, @img)";

        //            SqlCommand cmd = new SqlCommand(sql, conn);
        //            cmd.CommandType = CommandType.Text;
        //            cmd.Connection = conn;

        //            cmd.Parameters.AddWithValue("@libraryID", CuraID);
        //            cmd.Parameters.AddWithValue("@Name", Name);
        //            cmd.Parameters.AddWithValue("@author", Author);
        //            cmd.Parameters.AddWithValue("@isbn", ISBN);
        //            cmd.Parameters.AddWithValue("@edition", Edition);
        //            cmd.Parameters.AddWithValue("@publisher", Publisher);
        //            cmd.Parameters.AddWithValue("@categoryID", categoryId);
        //            cmd.Parameters.AddWithValue("@PublishYear", Year);
        //            cmd.Parameters.AddWithValue("@numberOfPages", NoOfPages);
        //            cmd.Parameters.AddWithValue("@quantity", Quantity);
        //            cmd.Parameters.AddWithValue("@Genre", Gener);
        //            cmd.Parameters.AddWithValue("@description", Description);
        //            cmd.Parameters.AddWithValue("@img", img);

        //            count = cmd.ExecuteNonQuery();

        //            return count;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        //public int InsertDigitalNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Description)
        //{

        //    int count = 0;
        //    //SqlConnection con = GetConnection();
        //    try
        //    {
        //        string categoryId = GetCategoryId(Category);
        //        if (categoryId != null)
        //        {
        //            conn.Open();

        //            string sql = "INSERT INTO Library (Library_ID, Name, Genre, Author, Edition, ISBN, Publish_Year, Publisher, Number_Of_Pages, Description, L_Category_ID, Quantity) VALUES (@libraryID, @Name, @Genre, @author, @edition, @isbn, @PublishYear, @publisher, @numberOfPages, @description, @categoryID, @quantity)";

        //            SqlCommand cmd = new SqlCommand(sql, conn);
        //            cmd.CommandType = CommandType.Text;
        //            cmd.Connection = conn;

        //            cmd.Parameters.AddWithValue("@libraryID", CuraID);
        //            cmd.Parameters.AddWithValue("@Name", Name);
        //            cmd.Parameters.AddWithValue("@author", Author);
        //            cmd.Parameters.AddWithValue("@isbn", ISBN);
        //            cmd.Parameters.AddWithValue("@edition", Edition);
        //            cmd.Parameters.AddWithValue("@publisher", Publisher);
        //            cmd.Parameters.AddWithValue("@categoryID", categoryId);
        //            cmd.Parameters.AddWithValue("@PublishYear", Year);
        //            cmd.Parameters.AddWithValue("@numberOfPages", NoOfPages);
        //            cmd.Parameters.AddWithValue("@quantity", Quantity);
        //            cmd.Parameters.AddWithValue("@Genre", Gener);
        //            cmd.Parameters.AddWithValue("@description", Description);

        //            count = cmd.ExecuteNonQuery();

        //            return count;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //}

        //public int UpdateDigital(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Description, byte[] img)
        //{

        //    int count = 0;
        //    //SqlConnection con = GetConnection();
        //    try
        //    {
        //        string categoryId = GetCategoryId(Category);
        //        if (categoryId != null)
        //        {
        //            conn.Open();

        //            string sql = "UPDATE Library SET Library_ID = @libraryID, Name = @Name, Genre = @Genre, Author = @author, Edition = @edition, ISBN = @isbn, Publish_Year = @PublishYear, Publisher = @publisher, Number_Of_Pages = @numberOfPages, Description = @description, L_Category_ID = @categoryID, Quantity = @quantity, Image = @img WHERE Library_ID = @libraryID";

        //            SqlCommand cmd = new SqlCommand(sql, conn);
        //            cmd.CommandType = CommandType.Text;
        //            cmd.Connection = conn;

        //            cmd.Parameters.AddWithValue("@libraryID", CuraID);
        //            cmd.Parameters.AddWithValue("@Name", Name);
        //            cmd.Parameters.AddWithValue("@author", Author);
        //            cmd.Parameters.AddWithValue("@isbn", ISBN);
        //            cmd.Parameters.AddWithValue("@edition", Edition);
        //            cmd.Parameters.AddWithValue("@publisher", Publisher);
        //            cmd.Parameters.AddWithValue("@categoryID", categoryId);
        //            cmd.Parameters.AddWithValue("@PublishYear", Year);
        //            cmd.Parameters.AddWithValue("@numberOfPages", NoOfPages);
        //            cmd.Parameters.AddWithValue("@quantity", Quantity);
        //            cmd.Parameters.AddWithValue("@Genre", Gener);
        //            cmd.Parameters.AddWithValue("@description", Description);
        //            cmd.Parameters.AddWithValue("@img", img);

        //            count = cmd.ExecuteNonQuery();

        //            return count;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        

        public bool wcf()
        {
            return true;
        }

        public bool db()
        {
            try
            {
                conn.Open();
                return (conn.State == ConnectionState.Open);
            }
            finally
            {
                conn.Close();
            }
        }

        public int LgInsrt(string StaffID, string UserName, string Password, string Category)
        {
            int cnfrm = 0;
            conn.Open();
            string qryinsrt = "INSERT INTO LoginDetails(ID, UserName,Password,States) VALUES('" + StaffID + "','" + UserName + "','" + Password + "','" + Category + "')";
            SqlCommand cmd = new SqlCommand(qryinsrt, conn);
            cnfrm = cmd.ExecuteNonQuery();
            conn.Close();
            return cnfrm;
        }

        public DataTable randomBooks()
        {
            DataTable randombooks = new DataTable("Random Books");
            randombooks.Columns.Add("Name", typeof(string));
            randombooks.Columns.Add("Author", typeof(string));
            randombooks.Columns.Add("Image", typeof(byte[]));
            var rnd = new rndmbks();
            randombooks = rnd.rndm();
            return randombooks;
        }

        string ICuraService.GetCategoryName(string categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
