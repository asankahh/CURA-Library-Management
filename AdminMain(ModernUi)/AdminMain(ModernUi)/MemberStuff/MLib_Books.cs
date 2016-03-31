using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace AdminMain_ModernUi_.MemberStuff
{
    public partial class MLib_Books : MetroForm
    {
        string itemID;
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        public MLib_Books()
        {
            InitializeComponent();
            UpdateTableBook();
        }

        public void UpdateTableBook()
        {
            BindingSource bd = new BindingSource();
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                bd.DataSource = client.SelectLibrary("Book001");
                this.gridview_Book.DataSource = bd;
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Server Not Found! The connection to Microsoft SQL Server is Unavailable...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnkbks_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnk_rsrv_Click(object sender, EventArgs e)
        {
            MemLib_Books_Reserve MLBR = new MemLib_Books_Reserve();
            StyleManager.Clone(MLBR);
            MLBR.ShowDialog();

        }

        private void lnk_rvw_Click(object sender, EventArgs e)
        {
            MemLib_Books_Review MLRV = new MemLib_Books_Review();
            StyleManager.Clone(MLRV);
            MLRV.ShowDialog();
        }

        private void gridview_Book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemid = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview_Book.Rows[e.RowIndex];

                txt_hide.Text = row.Cells["LibraryID"].Value.ToString();
                itemID = txt_hide.Text;
               
            }

            byte[] img = client.getItemImage(itemID);

            try
            {
                MemoryStream mstream = new MemoryStream(img);
                Image pic = Image.FromStream(mstream);

                pb_viewBook.Image = pic;
               
            }
            catch (ArgumentException)
            {

                pb_viewBook.Image = null;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (cb_Search.Text == "By ID")
            {

                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity, Image FROM Library WHERE Library_ID LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Book001'");

                gridview_Book.DataSource = bd;
            }
            else if (cb_Search.Text == "By Name")
            {

                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity, Image FROM Library WHERE Name LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Book001'");

                gridview_Book.DataSource = bd;

            }
            else if (cb_Search.Text == "By Author")
            {
                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Image FROM Library WHERE Author LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Book001'");

                gridview_Book.DataSource = bd;
            }
            else if (cb_Search.Text == "By Genre")
            {
                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Image FROM Library WHERE Genre LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Book001'");

                gridview_Book.DataSource = bd;
            }
            else if (cb_Search.Text == "By Publisher")
            {
                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Image FROM Library WHERE Publisher LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Book001'");

                gridview_Book.DataSource = bd;
            }
        }
        public static string bid;
        //public static string form;
        private void gridview_Book_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            DataGridViewRow row = gridview_Book.Rows[e.RowIndex];
            bid = row.Cells["LibraryID"].Value.ToString();
            LibCat.LibShw LS = new LibCat.LibShw();
            StyleManager.Clone(LS);
            LS.ShowDialog();
        }
    }
}
