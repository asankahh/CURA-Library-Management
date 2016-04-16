using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using CuraService.methods;
using System.Text;
using System.Security.Cryptography;

namespace CuraService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CuraService" in both code and config file together.
    public class CuraService : ICuraService
    {
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=CURA_V3.5.1;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

        /* Creating Objects of Classes */
        SELECT slct = new SELECT();
        INSERT insrt = new INSERT();
        DELETE dlt = new DELETE();
        UPDATE updt = new UPDATE();
        LOGIN lgn = new LOGIN();
        rndmbks rnd = new rndmbks();
        CRYPTO crpt = new CRYPTO();
        HTBKS htbks = new HTBKS();

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

        /* LOGIN */
        public int login_chkusr(string chkusr)
        {
            int avl = lgn.chkusravl(chkusr);
            return avl;


        }        

        public string login_chkpw(string chkpw)
        {
            string pwcnfm = lgn.GetUsrPW(chkpw);
            return pwcnfm;
        }        

        public string login_chksts(string chksts)
        {
            string stts = lgn.ChkAuth(chksts);
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
            int count = UpdateLibraryWImg(CuraID, Name, ISBN, Edition, Publisher, Category, Year, NoOfPages, Quantity, Gener, Advisor, Description, img);
            return count;
        }

        public int UpdateLibraryWImg(string CuraID, string Name, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description, byte[] img)
        {
            int count = 0;
            string categoryId = GetCategoryId(Category);
            if (categoryId != null)
            {
                conn.Open();
                string sql = "UPDATE Library SET Library_ID = '" + CuraID + "', Name = '" + Name + "', Genre = '" + Gener + "', Author = '" + Gener + "', Edition = '" + Edition + "', ISBN ='" + ISBN + "', Publish_Year = '" + Year + "', Publisher = '" + Publisher + "', Number_Of_Pages = '" + NoOfPages + "', Advisor = '" + Advisor + "', Description = '" + Description + "', L_Category_ID = '" + categoryId + "', Quantity = '" + Quantity + "', @img WHERE Library_ID = '" + CuraID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@img", img);
                count = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return count;
        }

        public int UpdateLibraryNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description)
        {
            int count = 0;
            string categoryId = GetCategoryId(Category);
            if (categoryId != null)
            {
                conn.Open();
                string sql = "UPDATE Library SET Library_ID = '" + CuraID + "', Name = '" + Name + "', Genre = '" + Gener + "', Author = '" + Gener + "', Edition = '" + Edition + "', ISBN ='" + ISBN + "', Publish_Year = '" + Year + "', Publisher = '" + Publisher + "', Number_Of_Pages = '" + NoOfPages + "', Advisor = '" + Advisor + "', Description = '" + Description + "', L_Category_ID = '" + categoryId + "', Quantity = '" + Quantity + "' WHERE Library_ID = '" + CuraID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                count = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return count;
        }

        public int DeleteLibrary(string sql)
        {
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
            int count = insrt.NewMemberWImg(MemberID, FirstName, LastName, Address1, Address2, City, PostalCode, PersonalEmail, WorkEmail, MobileNumber, HomeNumber, Gender, Birthday, Nationality, img);
            return count;
        }

        public int InsertMemberNoIMG(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = insrt.NewMember(MemberID, FirstName, LastName, Address1, Address2, City, PostalCode, PersonalEmail, WorkEmail, MobileNumber, HomeNumber, Gender, Birthday, Nationality);
            return count;
        }

        public int CheckMember(string memberID)
        {
            int i = slct.chkMmbr(memberID);
            return i;
        }

        public int UpdateMember(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = updt.UpdtMmbrWimg(MemberID, FirstName, LastName, Address1, Address2, City, PostalCode, PersonalEmail, WorkEmail, MobileNumber, HomeNumber, Gender, Birthday, Nationality, img);
            return count;
        }

        public int UpdateMemberNoIMG(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = updt.UpdtMmbr(MemberID, FirstName, LastName, Address1, Address2, City, PostalCode, PersonalEmail, WorkEmail, MobileNumber, HomeNumber, Gender, Birthday, Nationality);
            return count;
        }

        public int DeleteMember(string sql)
        {
            int i = dlt.deletemem(sql);
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
            int count = insrt.InsertStaffWImg(StaffID, FirstName, LastName, Address1, Address2, City, PostalCode, PersonalEmail, MobileNumber, HomeNumber, Gender, Birthday, Nationality, img);
            return count;
        }

        public int InsertStaffNoIMG(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = insrt.InsertStaff(StaffID, FirstName, LastName, Address1, Address2, City, PostalCode, PersonalEmail, MobileNumber, HomeNumber, Gender, Birthday, Nationality);
            return count;
        }

        public int CheckStaff(string staffID)
        {
            int i = slct.chkstf(staffID);
            return i;
        }

        public int UpdateStaff(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img)
        {
            int count = updt.UpdateStaffWImg(StaffID, FirstName, LastName, Address1, Address2, City, PostalCode, PersonalEmail, HomeNumber, Gender, Birthday, Nationality, img);
            return count;
        }

        public int UpdateStaffNoIMG(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality)
        {
            int count = updt.UpdateStaff(StaffID, FirstName, LastName, Address1, Address2, City, PostalCode, PersonalEmail, HomeNumber, Gender, Birthday, Nationality);
            return count;
        }

        public int DeleteStaff(string sql)
        {
            int i = dlt.DltStf(sql);
            return i;
        }

        public int newtrans(string type, string cat, string des, string amt)
        {
            int i = insrt.NewTransaction(type, cat, des, amt);
            return i;
        }

        public DataTable transldin()
        {
            DataTable transin = slct.SelectALLIncome();
            return transin;
        }

        public DataTable transldex()
        {
            DataTable transex = slct.SelectALLExpences();
            return transex;
        }

        public DataTable Selectin(string month)
        {
            DataTable DTin = slct.ViewIncome(month);
            return DTin;
        }

        public DataTable Selectex(string month)
        {
            DataTable DTex = slct.ViewExpences(month);
            return DTex;
        }

        public int barrownw(string mid, string bid, string dp, string rt)
        {
            int r = insrt.NewBarrow(mid, bid, dp, rt);
            return r;
        }

        public DataTable brrwls()
        {
            DataTable DTfl = slct.ViewBarrowal();
            return DTfl;
        }

        public DataTable StRes()
        {
            DataTable DTRes = slct.Reservation();
            return DTRes;
        }

        public int stResI(string mbrID, string mbrnm, string rsbk, string rsdt, string rqsdt)
        {
            int re = insrt.NewReservation(mbrID, mbrnm, rsbk, rsdt, rqsdt);
            return re;
        }

        public DataTable mRes()
        {
            DataTable DTmRes = slct.ViewRes();
            return DTmRes;
        }

        public int StReq(string ReqRply)
        {
            int Rq = slct.StfRplyRq(ReqRply);
            return Rq;
        }

        public DataTable MStReq()
        {
            DataTable DTReq = slct.StaffviewReq();
            return DTReq;
        }

        public int mReq(string mRq)
        {
            int mRqr = insrt.RequestWrite(mRq);
            return mRqr;
        }

        public DataTable mRqr()
        {
            DataTable DTmRq = slct.RequestView();
            return DTmRq;
        }        
        
        public int LgInsrt(string StaffID, string UserName, string Password, string Category)
        {
            string encryptd = crpt.encrypt(Password);
            int cnfrm = insrt.LoginInsert(StaffID, UserName, encryptd, Category);
            return cnfrm;
        }        

        public DataTable randomBooks()
        {
            DataTable randombooks = new DataTable("Random Books");
            randombooks = rnd.rndm();
            return randombooks;
        }

        public DataTable HitBooks()
        {
            DataTable Hitbooks = new DataTable("Hit Books");
            Hitbooks = htbks.htbks();
            return Hitbooks;
        }



        string ICuraService.GetCategoryName(string categoryId)
        {
            try
            {
                string sql = "SELECT l_Category_Name FROM library_category WHERE l_category_id='" + categoryId + "'";
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

        
    }
}
