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

namespace AdminMain_ModernUi_.LibCat
{
    public partial class LibraryThesis : MetroForm
    {
        string picLoc;
        string itemID;
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");


        public LibraryThesis()
        {
            InitializeComponent();
            UpdateTableThesis();
        }
        public void UpdateClearThesis()
        {
            pb_edit.Image = null;
            txt_editID.Text = "";
            txt_editName.Text = "";
            txt_editAuthor.Text = "";
            txt_editISBN.Text = "";
            txt_editEdition.Text = "";
            txt_editPublisher.Text = "";
            cb_editCatagory.SelectedItem = "";
            cb_editYear.SelectedItem = "";
            txt_editNoOfPage.Text = "";
            txt_editQuantity.Text = "";
            txt_editGener.Text = "";
            txt_editAdvisor.Text = "";
            txt_editDescription.Text = "";
        }

        public void UpdateTableThesis()
        {
            BindingSource bd = new BindingSource();
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                bd.DataSource = client.SelectLibrary("Thesis004");
                this.gridview.DataSource = bd;
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, "Server Not Found! The connection to Microsoft SQL Server is Unavailable..." + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnkThss_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_srch_Click(object sender, EventArgs e)
        {

        }

        private void btn_updt_Click(object sender, EventArgs e)
        {
            pnl_edtbk.Visible = true;
        }

        private void btn_rmv_Click(object sender, EventArgs e)
        {
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                if (!string.IsNullOrEmpty(txt_editID.Text))
                {

                    DialogResult dr = MetroMessageBox.Show(this, "Are you sure that you want to permanently delete the selected data?\n\nThesis Name: '" + txt_editName.Text + "'\nThesis ID: '" + txt_editID.Text + "'", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (client.DeleteLibrary(txt_editID.Text) > 0)
                        {
                            MetroMessageBox.Show(this, "Thesis ID: '" + txt_editID.Text + "' successfully deleted! click OK to Continue. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateClearThesis();
                            UpdateTableThesis();
                            pb_view.Image = null;
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        UpdateClearThesis();
                        UpdateTableThesis();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There has been an error deleting a Thesis Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UpdateClearThesis();
                        UpdateTableThesis();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "You must Select a Thesis before Deleting!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clse_Click(object sender, EventArgs e)
        {
            pnl_edtbk.Visible = false;
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemid = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];

                txt_editID.Text = row.Cells["LibraryID"].Value.ToString();
                itemID = txt_editID.Text;
                txt_editName.Text = row.Cells["ThesisName"].Value.ToString();
                txt_editAuthor.Text = row.Cells["Author"].Value.ToString();
                txt_editISBN.Text = row.Cells["ISBN"].Value.ToString();
                txt_editEdition.Text = row.Cells["Edition"].Value.ToString();
                txt_editPublisher.Text = row.Cells["Publisher"].Value.ToString();

                string category = client.GetCategoryName(row.Cells["CategoryID"].Value.ToString());
                cb_editCatagory.SelectedItem = category;

                cb_editYear.SelectedItem = row.Cells["PublishingYear"].Value.ToString();
                txt_editNoOfPage.Text = row.Cells["NumberOfPages"].Value.ToString();
                txt_editQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txt_editGener.Text = row.Cells["Genre"].Value.ToString();
                txt_editAdvisor.Text = row.Cells["Advisor"].Value.ToString();
                txt_editDescription.Text = row.Cells["Description"].Value.ToString();
            }

            byte[] img = client.getItemImage(itemID);

            try
            {
                MemoryStream mstream = new MemoryStream(img);
                Image pic = Image.FromStream(mstream);

                pb_view.Image = pic;
                pb_edit.Image = pic;

            }
            catch (ArgumentException)
            {
                pb_edit.Image = null;
                pb_view.Image = null;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            byte[] img = null;

            try
            {
                FileStream imgstream = new FileStream(picLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(imgstream);
                img = br.ReadBytes((int)imgstream.Length);
            }
            catch (ArgumentException)
            { }

            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

            try
            {
                if (!string.IsNullOrEmpty(txt_editID.Text))
                {
                    DialogResult dr = MetroMessageBox.Show(this, "The record has changed! do you want to save it?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        int count = 0;
                        int count1 = 0;

                        if (pb_edit.Image == null || img == null)
                        {
                            count1 = client.UpdateLibraryNoIMG(txt_editID.Text, txt_editName.Text, txt_editAuthor.Text, txt_editISBN.Text, txt_editEdition.Text, txt_editPublisher.Text, cb_editCatagory.Text, cb_editYear.Text, txt_editNoOfPage.Text, txt_editQuantity.Text, txt_editGener.Text, txt_editAdvisor.Text, txt_editDescription.Text);
                        }
                        else
                        {
                            count = client.UpdateLibrary(txt_editID.Text, txt_editName.Text, txt_editAuthor.Text, txt_editISBN.Text, txt_editEdition.Text, txt_editPublisher.Text, cb_editCatagory.Text, cb_editYear.Text, txt_editNoOfPage.Text, txt_editQuantity.Text, txt_editGener.Text, txt_editAdvisor.Text, txt_editDescription.Text, img);
                        }

                        if (count == 1 || count1 == 1)
                        {
                            MetroMessageBox.Show(this, "Book ID '" + txt_editID.Text + "' successfully updated! click OK to Continue. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateClearThesis();
                            UpdateTableThesis();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "There has been an error updateing a Thesis Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            UpdateTableThesis();
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        UpdateTableThesis();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There has been an error updateing a Thesis Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UpdateClearThesis();
                        UpdateTableThesis();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Unable to Update your Thesis ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_edit_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files(*.*) | (*.*)";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picLoc = dlg.FileName.ToString();
                pb_edit.ImageLocation = picLoc;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                if (!string.IsNullOrEmpty(txt_editID.Text))
                {

                    DialogResult dr = MetroMessageBox.Show(this, "Are you sure that you want to permanently delete the selected data?\n\nThesis Name: '" + txt_editName.Text + "'\nThesis ID: '" + txt_editID.Text + "'", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (client.DeleteLibrary(txt_editID.Text) > 0)
                        {
                            MetroMessageBox.Show(this, "Thesis ID: '" + txt_editID.Text + "' successfully deleted! click OK to Continue. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateClearThesis();
                            UpdateTableThesis();
                            pb_view.Image = null;
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        UpdateClearThesis();
                        UpdateTableThesis();

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There has been an error deleting a Thesis Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UpdateClearThesis();
                        UpdateTableThesis();
                    }

                }
                else
                {
                    MetroMessageBox.Show(this, "You must Select a Thesis before Deleting!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (cb_Search.Text == "By ID")
            {

                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Advisor,Description, Image FROM Library WHERE Library_ID LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Thesis004'");

                gridview.DataSource = bd;
            }
            else if (cb_Search.Text == "By Name")
            {

                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Advisor,Description, Image FROM Library WHERE Name LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Thesis004'");

                gridview.DataSource = bd;

            }
            else if (cb_Search.Text == "By Author")
            {
                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Advisor,Description,Image FROM Library WHERE Author LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Thesis004'");

                gridview.DataSource = bd;
            }
            else if (cb_Search.Text == "By Genre")
            {
                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Advisor,Description,Image FROM Library WHERE Genre LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Thesis004'");

                gridview.DataSource = bd;
            }
            else if (cb_Search.Text == "By Publisher")
            {
                BindingSource bd = new BindingSource();
                LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                bd.DataSource = client.SearchLibrary("SELECT Library_ID,Name,Genre,Author,Edition,ISBN,Publish_Year,Publisher,Number_Of_Pages,L_Category_ID,Quantity,Advisor,Description,Image FROM Library WHERE Publisher LIKE '" + txt_Search.Text + "%' AND L_Category_ID = 'Thesis004'");

                gridview.DataSource = bd;
            }
        }
    }
}
