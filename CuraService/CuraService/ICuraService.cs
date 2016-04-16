using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CuraService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITestService" in both code and config file together.
    [ServiceContract]
    public interface ICuraService
    {
        /* CHECK CONNECTIONS */ 
        /*WCF Connection*/
        [OperationContract]//1
        bool wcf();/*NEW*/

        /*DB Connection*/
        [OperationContract]//2
        bool db();/*NEW*/

        /* LOGIN */
        /*Check username availability*/
        [OperationContract]//3
        int login_chkusr(string chkusr);

        /* check password avaialability and mach with input*/
        [OperationContract]//4
        string login_chkpw(string chkpw);

        /* check authorization level and open corrosponding window */
        [OperationContract]//5
        string login_chksts(string chksts);

        /* Get Admin And Staff Data */
        [OperationContract]//6
        DataTable getstfdt(string usrnm);

        /* Get Member Data */
        [OperationContract]//7
        DataTable gtmmbrdt(string usrnm);

        /*Select Book Data*/
        [OperationContract]//8
        DataTable getbkdata(string bkid);

        /* Insert Data into Loging Details Table */
        [OperationContract]//9
        int LgInsrt(string StaffID, string UserName, string Password, string Category);/*NEW*/

        /* Member Library Home randomly selected books */
        [OperationContract]//10
        DataTable randomBooks();/*NEW*/

        /* LIBRARY */

        [OperationContract]//11
        DataTable SelectLibrary(string category);

        [OperationContract]//12
        int InsertLibrary(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description, byte[] img);

        [OperationContract]//13
        int InsertLibraryNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description);

        [OperationContract]//14
        int UpdateLibrary(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description, byte[] img);

        [OperationContract]//15
        int UpdateLibraryNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Advisor, string Description);

        [OperationContract]//16
        byte[] getItemImage(string itemID);

        [OperationContract]//17
        int CheckLibrary(string sql);

        [OperationContract]//18
        string GetCategoryName(string categoryId);

        [OperationContract]//19
        int DeleteLibrary(string sql);

        [OperationContract]//20
        DataTable SearchLibrary(string sql);

        [OperationContract]//21
        DataTable HitBooks();

        //[OperationContract]//21
        //int InsertDigital(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Description, byte[] img);

        //[OperationContract]//22
        //int InsertDigitalNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Description);

        //[OperationContract]//23
        //int UpdateDigital(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Description, byte[] img);

        //[OperationContract]//24
        //int UpdateDigitalNoIMG(string CuraID, string Name, string Author, string ISBN, string Edition, string Publisher, string Category, string Year, string NoOfPages, string Quantity, string Gener, string Description);



        /* MEMBERS */

        [OperationContract]//25
        DataTable SelectMember();

        [OperationContract]//26
        byte[] getMemberImage(string itemID);

        [OperationContract]//27
        int InsertMember(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img);

        [OperationContract]//28
        int InsertMemberNoIMG(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality);

        [OperationContract]//29
        int CheckMember(string sql);

        [OperationContract]//30
        int UpdateMember(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img);

        [OperationContract]//31
        int UpdateMemberNoIMG(string MemberID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string WorkEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality);

        [OperationContract]//32
        int DeleteMember(string sql);


        /* STAFF */

        [OperationContract]//33
        DataTable SelectStaff();

        [OperationContract]//34
        byte[] getStaffImage(string itemID);

        [OperationContract]//35
        int InsertStaff(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img);

        [OperationContract]//36
        int InsertStaffNoIMG(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality);

        [OperationContract]//37
        int CheckStaff(string sql);

        [OperationContract]//38
        int UpdateStaff(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality, byte[] img );

        [OperationContract]//39
        int UpdateStaffNoIMG(string StaffID, string FirstName, string LastName, string Address1, string Address2, string City, string PostalCode, string PersonalEmail, string MobileNumber, string HomeNumber, string Gender, string Birthday, string Nationality);

        [OperationContract]//40
        int DeleteStaff(string sql);

        /*Transactions*/
        /*NEW Transaction*/
        [OperationContract]//41
        int newtrans(string type, string cat , string des, string amt);

        /* Income */
        [OperationContract]//42
        DataTable transldin();

        /*Expences*/
        [OperationContract]//43
        DataTable transldex();

        [OperationContract]//44
        DataTable Selectin(string month);

        [OperationContract]//45
        DataTable Selectex(string month);

        /*Barrowals*/
        /*New Barrow*/
        [OperationContract]//46
        int barrownw(string mid, string bid,string dp, string rt);

        /*Barrowls DataTable Fill*/
        [OperationContract]//47
        DataTable brrwls();

        [OperationContract]//48
        DataTable StRes();

        [OperationContract]//49
        int stResI(string mbrID, string mbrnm, string rsbk, string rsdt, string rqsdt);

        [OperationContract]//50
        DataTable mRes();

        [OperationContract]//51
        int StReq(string ReqRply);

        [OperationContract]//52
        DataTable MStReq();

        [OperationContract]//53
        int mReq(string mRq);

        [OperationContract]//55
        DataTable mRqr();

    }
}
