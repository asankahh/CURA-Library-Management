using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using CuraService.methods;

namespace CuraService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CuraService" in both code and config file together.
    public class CuraService : ICuraService
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);
        SELECT slct = new methods.SELECT();
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
            DataTable DT = slct.GetStaffData(usrnm);
            return DT;
        }

        /* Get Member Data  */
        public DataTable gtmmbrdt(string usrnm)
        {
            DataTable DT = slct.GetMemberData(usrnm);
            return DT;
        }


        /*Select Book Data*/
        public DataTable getbkdata(string bkid)
        {
            DataTable DTT = slct.GetBookData(bkid);
            return DTT;
        }

        /* LIBRARY */
        public DataTable SelectLibrary(string category)
        {
            DataTable dbdataset = slct.SelectLibrary(category);
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
                    string sql = "INSERT INTO Library (Library_ID, Name, Genre, Author, Edition, ISBN, Publish_Year, Publisher, Number_Of_Pages, Advisor, Description, L_Category_ID, Quantity, Image) VALUES ('" + CuraID + "', '" + Name + "', '" + Gener + "', '" + Author + "', '" + Edition + "', '" + ISBN + "', '" + Year + "', '" + Publisher + "', '" + NoOfPages + "', '" + Advisor + "', '" + Description + "', '" + categoryId + "', '" + Quantity + "', @img)";
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

                    string sql = "INSERT INTO Library (Library_ID, Name, Genre, Author, Edition, ISBN, Publish_Year, Publisher, Number_Of_Pages, Advisor, Description, L_Category_ID, Quantity) VALUES ('" + CuraID + "', '" + Name + "', '" + Gener + "', '" + Author + "', '" + Edition + "', '" + ISBN + "', '" + Year + "', '" + Publisher + "', '" + NoOfPages + "', '" + Advisor + "', '" + Description + "', '" + categoryId + "', '" + Quantity + "')";

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
            string catid = slct.CategoryID(categoryName);
            return catid;
        }

        string GetCategoryName(string categoryId)
        {
            string catnm = slct.CategoryName(categoryId);
            return catnm;
        }

        public int CheckLibrary(string bookID)
        {
            int i = slct.ChkLib(bookID);
            return i;
        }

        public byte[] getItemImage(string itemID)
        {
            byte[] img = slct.SelectImage(itemID);
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
                    string sql = "UPDATE Library SET Library_ID = '" + CuraID + "', Name = '" + Name + "', Genre = '" + Gener + "', Author = '" + Gener + "', Edition = '" + Edition + "', ISBN ='" + ISBN + "', Publish_Year = '" + Year + "', Publisher = '" + Publisher + "', Number_Of_Pages = '" + NoOfPages + "', Advisor = '" + Advisor + "', Description = '" + Description + "', L_Category_ID = '" + categoryId + "', Quantity = '" + Quantity + "', Image = '" + img + "' WHERE Library_ID = '" + CuraID + "'"; SqlCommand cmd = new SqlCommand(sql, conn);
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

        public int UpdateLibraryNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description)
        {
            int count = 0;

            try
            {
                string categoryId = GetCategoryId(Category);
                if (categoryId != null)
                {
                    conn.Open();
                    string sql = "UPDATE Library SET Library_ID = '" + CuraID + "', Name = '" + Name + "', Genre = '" + Gener + "', Author = '" + Gener + "', Edition = '" + Edition + "', ISBN ='" + ISBN + "', Publish_Year = '" + Year + "', Publisher = '" + Publisher + "', Number_Of_Pages = '" + NoOfPages + "', Advisor = '" + Advisor + "', Description = '" + Description + "', L_Category_ID = '" + categoryId + "', Quantity = '" + Quantity + "' WHERE Library_ID = '" + CuraID + "'";
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
            DataTable dbdataset = slct.slctMmber();
            return dbdataset;
        }


        public byte[] getMemberImage(string itemID)
        {
            byte[] img = slct.GtMmbrImage(itemID);
            return img;
        }

        

        public int InsertMember(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            //SqlConnection con = GetConnection();
            try
            {
                conn.Open();

                string sql = "INSERT INTO Member (Member_Id, M_FirstName, M_LastName, Add_L1, Add_L2, City, Postalcode, Pe_Email, Wo_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality, Image) VALUES ('" + MemberID + "', '" + LastName + "', '" + FirstName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + PostalCode + "', '" + PersonalEmail + "', '" + WorkEmail + "', '" + HomeNumber + "', '" + MobileNumber + "', '" + Gender + "', '" + Birthday + "', '" + Nationality + "', @img)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@img", img);
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
                //

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
            int i = slct.chkMmbr(memberID);
            return i;
        }        

        public int UpdateMember(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
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
            DataTable dbdataset = slct.slctstff();
            return dbdataset;
        }        

        public byte[] getStaffImage(string itemID)
        {
            byte[] img = slct.stfimg(itemID);
            return img;
        }

        

        public int InsertStaff(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            try
            {
                conn.Open();
                string sql = "INSERT INTO Staff (Staff_Id, S_LastName, S_FirstName, Add_L1, Add_L2, City, Postalcode, Personal_Email, Ho_Num, Pe_Num, Gender, Birthday, Nationality, Image) VALUES ('" + StaffID + "', '" + FirstName + "', '" + LastName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + PostalCode + "', '" + PersonalEmail + "', '" + HomeNumber + "', '" + MobileNumber + "','" + Gender + "', '" + Birthday + "', '" + Nationality + "',@img)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@img", img);
                count = cmd.ExecuteNonQuery();
                return count;
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
            int i = slct.chkstf(staffID);
            return i;
        }        

        public int UpdateStaff(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = 0;
            //SqlConnection con = new SqlConnection("Data Source=BimalSirisena;Initial Catalog=Cura v2.1;Integrated Security=True");
            try
            {
                conn.Open();
                string sql = "UPDATE Staff SET Staff_Id = '" + StaffID + "', S_LastName = '" + LastName + "', S_FirstName = '" + FirstName + "', Add_L1 = '" + Address1 + "', Add_L2 = '" + Address2 + "', City = '" + City + "', Postalcode = '" + PostalCode + "', Personal_Email = '" + PersonalEmail + "', Ho_Num = '" + HomeNumber + "', Pe_Num = '" + PersonalEmail + "', Gender = '" + Gender + "', Birthday = '" + Birthday + "', Nationality = '" + Nationality + "', Image = @img WHERE Staff_Id = '" + StaffID + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@img", img);
                count = cmd.ExecuteNonQuery();
                return count;
                
            }
            finally
            {
                conn.Close();
            }
        }


        public int UpdateStaffNoIMG(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = 0;
            
            try
            {
                conn.Open();
                string sql = "UPDATE Staff SET Staff_Id = '" + StaffID + "', S_LastName = '" + LastName + "', S_FirstName = '" + FirstName + "', Add_L1 = '" + Address1 + "', Add_L2 = '" + Address2 + "', City = '" + City + "', Postalcode = '" + PostalCode + "', Personal_Email = '" + PersonalEmail + "', Ho_Num = '" + HomeNumber + "', Pe_Num = '" + PersonalEmail + "', Gender = '" + Gender + "', Birthday = '" + Birthday + "', Nationality = '" + Nationality + "' WHERE Staff_Id = '" + StaffID + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                count = cmd.ExecuteNonQuery();
                return count;
                



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
            string qrynt = "INSERT INTO Transactions (Type,Category,Description,Amount)VALUES('" + type + "','" + cat + "','" + des + "','" + amt + "')";
            SqlCommand cmd = new SqlCommand(qrynt, conn);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public DataTable transldin()
        {
            DataTable transin = new DataTable("Transactions", "AllTransactions");
            conn.Open();
            string qryin = "SELECT Type,Amount FROM Transactions WHERE Type='Income'";
            SqlDataAdapter SDAin = new SqlDataAdapter(qryin, conn);
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
            SqlCommand cmdin = new SqlCommand(qryin, conn);
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
            string qryex = "SELECT Date,Amount FROM Transactions WHERE DATEPART(MONTH,Date) ='" + month + "'AND Type = 'Expence'";
            SqlCommand cmdex = new SqlCommand(qryex, conn);
            SqlDataAdapter sdaex = new SqlDataAdapter();
            sdaex.SelectCommand = cmdex;
            sdaex.Fill(DTex);
            conn.Close();
            return DTex;
        }

        public int barrownw(string mid, string bid, string dp, string rt)
        {

            conn.Open();
            string qryin = "INSERT INTO Barrowals (Member_ID,Library_ID,Barrow_Date,Return_Date)VALUES('" + mid + "','" + bid + "','" + dp + "','" + rt + "')";
            SqlCommand cmd = new SqlCommand(qryin, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r;
        }

        public DataTable brrwls()
        {
            DataTable DTfl = new DataTable("Barrowals", "AllBarrowals");
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
            DataTable DTRes = new DataTable("Reservation", "AllReservation");
            conn.Open();
            string qryRes = "SELECT* FROM Reservation ";
            SqlCommand cmdRes = new SqlCommand(qryRes, conn);
            SqlDataAdapter sdaRes = new SqlDataAdapter();
            sdaRes.SelectCommand = cmdRes;
            sdaRes.Fill(DTRes);
            conn.Close();
            return DTRes;

        }

        public int stResI(string mbrID, string mbrnm, string rsbk, string rsdt, string rqsdt)
        {

            conn.Open();
            string qryRes = "INSERT INTO Reservation (Member_ID,Member_Name,Reserved_Date,Requested_date,)VALUES('" + mbrID + "','" + mbrnm + "','" + rsbk + "','" + rsdt + "','" + rqsdt + "')";
            SqlCommand cmdResI = new SqlCommand(qryRes, conn);
            int re = cmdResI.ExecuteNonQuery();
            return re;
        }

        public DataTable mRes()
        {
            DataTable DTmRes = new DataTable("Reservation", "AllReservaion");
            conn.Open();
            string qrymRes = "SELECT * FROM Reservation ";
            SqlCommand cmdmRes = new SqlCommand(qrymRes, conn);
            SqlDataAdapter SDAmRes = new SqlDataAdapter(cmdmRes);
            SDAmRes.Fill(DTmRes);
            conn.Close();
            return DTmRes;
        }

        public int StReq(string ReqRply)
        {


            conn.Open();
            string qryRepMsg = "INSERT INTO Request_OR_Complain (Reply)'" + ReqRply + "',";
            SqlCommand cmdStReq = new SqlCommand(qryRepMsg, conn);
            int Rq = cmdStReq.ExecuteNonQuery();
            conn.Close();
            return Rq;

        }

        public DataTable MStReq()
        {
            DataTable DTReq = new DataTable("Request_OR_Complain", "AllRequest_OR_Complain");
            conn.Open();
            string qryReq = "SELECT  Member_ID,Member_Name,Request FROM Request_OR_Complain";
            SqlCommand cmdReq = new SqlCommand(qryReq, conn);
            SqlDataAdapter SDAReq = new SqlDataAdapter(cmdReq);
            SDAReq.Fill(DTReq);
            conn.Close();
            return DTReq;
        }

        public int mReq(string mRq)
        {
            int mRqr = 0;
            conn.Open();
            string qrymRq = "INSERT INTO Request_OR_Complain  (Request)'" + mRq + "' ";
            SqlCommand cmdmRq = new SqlCommand(qrymRq, conn);
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
            var rnd = new rndmbks();
            randombooks = rnd.rndm();
            return randombooks;
        }

        string ICuraService.GetCategoryName(string categoryId)
        {
            try
            {
                //SqlConnection con = GetConnection();
                string sql = "SELECT l_Category_Name FROM library_category WHERE l_category_id='" + categoryId + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@id", categoryId);
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
    }
}
