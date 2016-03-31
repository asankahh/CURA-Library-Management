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

namespace AdminMain_ModernUi_.MemberStuff.Digi
{
    public partial class Vlectures : MetroForm
    {
        string itemID;
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        public Vlectures()
        {
            InitializeComponent();
            UpdateTableVidLec();
        }

        public void UpdateTableVidLec()
        {
            BindingSource bd = new BindingSource();
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                bd.DataSource = client.SelectLibrary("VidLec010");
                this.gridview.DataSource = bd;
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, "Server Not Found! The connection to Microsoft SQL Server is Unavailable..." + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnkbck_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (cb_Search.Text == "By ID")
            {

                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Description, Image FROM Library WHERE Library_ID LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'VidLec010'");

                gridview.DataSource = bd;
            }
            else if (cb_Search.Text == "By Name")
            {

                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Description, Image FROM Library WHERE Name LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'VidLec010'");

                gridview.DataSource = bd;

            }
            else if (cb_Search.Text == "By Genre")
            {
                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Description, Image FROM Library WHERE Genre LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'VidLec010'");

                gridview.DataSource = bd;
            }
            else if (cb_Search.Text == "By Publisher")
            {
                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Description,Image FROM Library WHERE Publisher LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'VidLec010'");

                gridview.DataSource = bd;
            }
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemid = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];

                txt_hide.Text = row.Cells["LibraryID"].Value.ToString();
                itemID = txt_hide.Text;

            }

            byte[] img = client.getItemImage(itemID);

            try
            {
                MemoryStream mstream = new MemoryStream(img);
                Image pic = Image.FromStream(mstream);

                pb_viewVidLec.Image = pic;

            }
            catch (ArgumentException)
            {

                pb_viewVidLec.Image = null;
            }
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
    }
}
