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

namespace AdminMain_ModernUi_.LibCat.Digi
{
    public partial class DigiNew : MetroForm
    {
        string picLoc;
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        public DigiNew()
        {
            InitializeComponent();
        }

        public void InsertClear()
        {
            pb_insert.Image = null;
            txt_ID.Text = "";
            txt_Name.Text = "";
            txt_Author.Text = "";
            txt_ISBN.Text = "";
            txt_Edition.Text = "";
            txt_Publisher.Text = "";
            cb_Catagory.SelectedItem = "";
            cb_Year.SelectedItem = "";
            txt_pageCount.Text = "";
            txt_Quantity.Text = "";
            txt_Gener.Text = "";
            txt_Description.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
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

            try
            {
                if (String.IsNullOrEmpty(txt_ID.Text) && String.IsNullOrEmpty(txt_Name.Text) && String.IsNullOrEmpty(txt_Author.Text) && String.IsNullOrEmpty(txt_ISBN.Text) && String.IsNullOrEmpty(txt_Edition.Text) && String.IsNullOrEmpty(txt_Publisher.Text) && String.IsNullOrEmpty(txt_pageCount.Text) && String.IsNullOrEmpty(txt_Quantity.Text) && String.IsNullOrEmpty(txt_Gener.Text) &&
                   String.IsNullOrEmpty(txt_Description.Text) && String.IsNullOrEmpty(cb_Catagory.Text) && String.IsNullOrEmpty(cb_Year.Text))
                {
                    MetroMessageBox.Show(this, "All the field's are Required...", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                if (String.IsNullOrEmpty(txt_ID.Text))
                {
                    txt_ID.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Name.Text))
                {
                    txt_Name.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Author.Text))
                {
                    txt_Author.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_ISBN.Text))
                {
                    txt_ISBN.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Edition.Text))
                {
                    txt_Edition.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Publisher.Text))
                {
                    txt_Publisher.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_pageCount.Text))
                {
                    txt_pageCount.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Quantity.Text))
                {
                    txt_Quantity.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Gener.Text))
                {
                    txt_Gener.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Description.Text))
                {
                    txt_Description.WithError = true;
                }
                else if (String.IsNullOrEmpty(cb_Catagory.Text))
                {
                    MetroMessageBox.Show(this, "Select the book catagory", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(cb_Year.Text))
                {
                    MetroMessageBox.Show(this, "Select the book publishing year", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }


                else
                {
                    LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                    if (client.CheckLibrary(txt_ID.Text) > 0)
                    {
                        MetroMessageBox.Show(this, "Book ID:'" + txt_ID.Text + "' already add to the daatbase.\n\nPlease check it again", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        int count = 0;
                        int count1 = 0;

                        if (pb_insert.Image == null || img == null)
                        {
                            count1 = client.InsertLibraryNoIMG(txt_ID.Text, txt_Name.Text, txt_Author.Text, txt_ISBN.Text, txt_Edition.Text, txt_Publisher.Text, cb_Catagory.Text, cb_Year.Text, txt_pageCount.Text, txt_Quantity.Text, txt_Gener.Text, txt_Advisor.Text, txt_Description.Text);

                            //count1 = client.InsertLibraryNoIMG(txt_ID.Text, txt_Name.Text, txt_Author.Text, txt_ISBN.Text, txt_Edition.Text, txt_Publisher.Text, cb_Catagory.Text, cb_Year.Text, txt_pageCount.Text, txt_Quantity.Text, txt_Gener.Text, txt_Description.Text);
                        }
                        else
                        {
                            count = client.InsertLibrary(txt_ID.Text, txt_Name.Text, txt_Author.Text, txt_ISBN.Text, txt_Edition.Text, txt_Publisher.Text, cb_Catagory.Text, cb_Year.Text, txt_pageCount.Text, txt_Quantity.Text, txt_Gener.Text, txt_Advisor.Text, txt_Description.Text, img);

                            //count = client.InsertLibrary(txt_ID.Text, txt_Name.Text, txt_Author.Text, txt_ISBN.Text, txt_Edition.Text, txt_Publisher.Text, cb_Catagory.Text, cb_Year.Text, txt_pageCount.Text, txt_Quantity.Text, txt_Gener.Text, txt_Description.Text, img);
                        }

                        if (count == 1 || count1 == 1)
                        {
                            MetroMessageBox.Show(this, "Book ID:'" + txt_ID.Text + "'added successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InsertClear();
                        }

                        else
                        {
                            MetroMessageBox.Show(this, "There has been an error adding a Book Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_insert_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files(*.*) | (*.*)";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picLoc = dlg.FileName.ToString();
                pb_insert.ImageLocation = picLoc;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            InsertClear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
