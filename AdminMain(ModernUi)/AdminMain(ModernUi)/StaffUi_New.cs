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
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace AdminMain_ModernUi_
{
    public partial class StaffUi_New : MetroForm
    {
        string picLoc;
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");



        public StaffUi_New()
        {
            InitializeComponent();
        }

        public void InsertClear()
        {
            pb_insertStaff.Image = null;
            txt_ID.Text = "";
            txt_Fname.Text = "";
            txt_Lname.Text = "";
            txt_Add1.Text = "";
            txt_Add2.Text = "";
            txt_City.Text = "";
            txt_Pcode.Text = "";
            txt_Pemail.Text = "";
            txt_MobNumber.Text = "";
            txt_PhoNumber.Text = "";
            cb_Gender.SelectedItem = "";
            dt_Birthday.Text = null;
            txt_Nationality.Text = "";
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_stfusrimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files(*.*) | (*.*)";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picLoc = dlg.FileName.ToString();
                //txt_imagePath.Text = picLoc;
                pb_insertStaff.ImageLocation = picLoc;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Regex RX = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

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
                if (String.IsNullOrEmpty(txt_ID.Text) && String.IsNullOrEmpty(txt_Fname.Text) && String.IsNullOrEmpty(txt_Lname.Text) && String.IsNullOrEmpty(txt_Add1.Text) && String.IsNullOrEmpty(txt_Add2.Text) && String.IsNullOrEmpty(txt_City.Text) && String.IsNullOrEmpty(txt_Pcode.Text) && String.IsNullOrEmpty(txt_Pemail.Text) &&
                   String.IsNullOrEmpty(txt_MobNumber.Text) && String.IsNullOrEmpty(txt_PhoNumber.Text) && String.IsNullOrEmpty(cb_Gender.Text) && String.IsNullOrEmpty(dt_Birthday.Text) && String.IsNullOrEmpty(txt_Nationality.Text))
                {
                    MetroMessageBox.Show(this, "All the field's are Required...", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                if (String.IsNullOrEmpty(txt_ID.Text))
                {
                    txt_ID.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Fname.Text))
                {
                    txt_Fname.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Lname.Text))
                {
                    txt_Lname.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Add1.Text))
                {
                    txt_Add1.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Add2.Text))
                {
                    txt_Add2.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_City.Text))
                {
                    txt_City.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Pcode.Text))
                {
                    txt_Pcode.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Pemail.Text))
                {
                    txt_Pemail.WithError = true;
                }                
                if (String.IsNullOrEmpty(txt_MobNumber.Text))
                {
                    txt_MobNumber.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_PhoNumber.Text))
                {
                    txt_PhoNumber.WithError = true;
                }
                if (String.IsNullOrEmpty(txt_Nationality.Text))
                {
                    txt_Nationality.WithError = true;
                }

                else if (String.IsNullOrEmpty(cb_Gender.Text))
                {
                    MetroMessageBox.Show(this, "Please Select the Gender", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(dt_Birthday.Value.ToString()))
                {
                    MetroMessageBox.Show(this, "Select Your Birthday", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (!RX.IsMatch(txt_Pemail.Text))
                {
                    MetroMessageBox.Show(this, "Email Format is not currect. Please check again...", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }                


                else
                {
                    LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
                    if (client.CheckStaff(txt_ID.Text) > 0)
                    {
                        MetroMessageBox.Show(this, "Member ID:'" + txt_ID.Text + "' already add to the daatbase.\n\nPlease check it again", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        int count = 0;
                        int count1 = 0;

                        int ldcn = 0;
                        string un = txt_Uname.Text;
                        string pw = txt_Pwrd.Text;
                        string ct = cb_cat.Text;
                        string id = txt_ID.Text;

                        if (pb_insertStaff.Image == null || img == null)
                        {
                            count1 = client.InsertStaffNoIMG(txt_ID.Text, txt_Fname.Text, txt_Lname.Text, txt_Add1.Text, txt_Add2.Text, txt_City.Text, txt_Pcode.Text, txt_Pemail.Text, txt_MobNumber.Text, txt_PhoNumber.Text, cb_Gender.Text, dt_Birthday.Value.ToString(), txt_Nationality.Text);
                            ldcn = client.LgInsrt(id, un, pw, ct);
                        }
                        else
                        {
                            count = client.InsertStaff(txt_ID.Text, txt_Fname.Text, txt_Lname.Text, txt_Add1.Text, txt_Add2.Text, txt_City.Text, txt_Pcode.Text, txt_Pemail.Text, txt_MobNumber.Text, txt_PhoNumber.Text, cb_Gender.Text, dt_Birthday.Value.ToString(), txt_Nationality.Text, img);
                            ldcn = client.LgInsrt(id, un, pw, ct);
                        }

                        if (count == 1 || count1 == 1)
                        {
                            //prnt();
                            MetroMessageBox.Show(this, "Member ID:'" + txt_ID.Text + "'added successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InsertClear();
                        }

                        else
                        {
                            MetroMessageBox.Show(this, "There has been an error adding a Member Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            InsertClear();
        }

        private void txt_MobNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_PhoNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


        private void btn_pwgen_Click(object sender, EventArgs e)
        {
            string[] characters = { "A", "B", "C", "D", "E", " F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            Random R = new Random();
            string pass = null;
            for(int i = 0; i<8;i++)
            {
                pass += characters[R.Next(0, characters.Length)];
            }
            txt_Pwrd.Text = pass;
        }

        public static string fn;
        public static string ln;
        public static string un;
        public static string pw;
        public static string tp;

        private void print_Click(object sender, EventArgs e)
        {
            fn = txt_Fname.Text;
            ln = txt_Lname.Text;
            un = txt_Uname.Text;
            pw = txt_Pwrd.Text;
            tp = cb_cat.Text;
            var print = new printcls();
            print.prnt();
        }

        private void btn_ungen_Click(object sender, EventArgs e)
        {
            string fn = txt_Fname.Text;
            string id = txt_ID.Text;
            string s = fn + id;
            txt_Uname.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToLower(s);
        }



        


    }
}
