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

        public static string fn;
        public static string ln;
        public static string un;
        public static string pw;
        public static string tp;

        RPG rpg = new RPG();

        public StaffUi_New()
        {
            InitializeComponent();
        }

        private void StaffUi_New_Load(object sender, EventArgs e)
        {
            /* Fill Combo Box with years */
            int year = DateTime.Now.Year;
            for (int i = year - 70; i <= year; i++)
            {
                cb_yr.Items.Add(i.ToString());
            }

            /* Fill Combo Box with Months */
            var months = new Dictionary<string, string>();
            months["01"] = "January";
            months["02"] = "February";
            months["03"] = "March";
            months["04"] = "April";
            months["05"] = "May";
            months["06"] = "June";
            months["07"] = "July";
            months["08"] = "August";
            months["09"] = "September";
            months["10"] = "October";
            months["11"] = "November";
            months["12"] = "December";

            cb_mnth.DataSource = new BindingSource(months, null);
            cb_mnth.DisplayMember = "Value";
            cb_mnth.ValueMember = "Key";

            /* Fill Combo Box with Dates */
            for (int i = 1; i <= 31; i++)
            {
                cb_dt.Items.Add(i.ToString());
            }
        }


        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            InsertClear();
            //lbl_dis.Text = cb_mnth.SelectedText.ToString();
            //lbl_val.Text = cb_mnth.SelectedValue.ToString();
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
                if (string.IsNullOrEmpty(txt_ID.Text) 
                    && string.IsNullOrEmpty(txt_Fname.Text) 
                    && string.IsNullOrEmpty(txt_Lname.Text) 
                    && string.IsNullOrEmpty(txt_Add1.Text) 
                    && string.IsNullOrEmpty(txt_Add2.Text) 
                    && string.IsNullOrEmpty(txt_City.Text) 
                    && string.IsNullOrEmpty(txt_Pcode.Text) 
                    && string.IsNullOrEmpty(txt_Pemail.Text) 
                    && string.IsNullOrEmpty(txt_MobNumber.Text) 
                    && string.IsNullOrEmpty(txt_PhoNumber.Text) 
                    && string.IsNullOrEmpty(cb_Gender.Text)
                    && string.IsNullOrEmpty(txt_Nationality.Text))
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
                //else if (String.IsNullOrEmpty(dt_Birthday.Value.ToString()))
                //{
                //    MetroMessageBox.Show(this, "Select Your Birthday", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                //}
                else if (!RX.IsMatch(txt_Pemail.Text))
                {
                    MetroMessageBox.Show(this, "Email Format is not currect. Please check again...", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    //LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
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
                        string dob = cb_yr.SelectedItem.ToString() + "-" + cb_mnth.SelectedValue.ToString() + "-" + cb_dt.SelectedItem.ToString(); ;
                        

                        if (pb_insertStaff.Image == null || img == null)
                        {
                            count1 = client.InsertStaffNoIMG(txt_ID.Text, txt_Fname.Text, txt_Lname.Text, txt_Add1.Text, txt_Add2.Text, txt_City.Text, txt_Pcode.Text, txt_Pemail.Text, txt_MobNumber.Text, txt_PhoNumber.Text, cb_Gender.Text, dob, txt_Nationality.Text);
                            ldcn = client.LgInsrt(id, un, pw, ct);
                        }
                        else
                        {
                            count = client.InsertStaff(txt_ID.Text, txt_Fname.Text, txt_Lname.Text, txt_Add1.Text, txt_Add2.Text, txt_City.Text, txt_Pcode.Text, txt_Pemail.Text, txt_MobNumber.Text, txt_PhoNumber.Text, cb_Gender.Text, dob, txt_Nationality.Text, img);
                            ldcn = client.LgInsrt(id, un, pw, ct);
                        }

                        if (count == 1 || count1 == 1)
                        {
                            Print();
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
            string pass = rpg.rndmpwrd();
            txt_Pwrd.Text = pass;
        }

        

        private void btn_ungen_Click(object sender, EventArgs e)
        {
            string fn = txt_Fname.Text;
            string id = txt_ID.Text;
            string s = fn + id;
            txt_Uname.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToLower(s);
        }



        private void Print()
        {
            fn = txt_Fname.Text;
            ln = txt_Lname.Text;
            un = txt_Uname.Text;
            pw = txt_Pwrd.Text;
            tp = cb_cat.Text;
            var print = new printcls();
            print.prnt();
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
            txt_Nationality.Text = "";
        }

        
    }
}
