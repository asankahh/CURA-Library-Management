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

namespace AdminMain_ModernUi_
{
    public partial class MembersUi : MetroForm
    {
        string picLoc;
        string itemID;
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        public MembersUi()
        {
            InitializeComponent();
            UpdateTableMember();
        }

        public void UpdateClear()
        {
            pb_editMember.Image = null;
            txt_editID.Text = "";
            txt_editFname.Text = "";
            txt_editLname.Text = "";
            txt_editAdd1.Text = "";
            txt_editAdd2.Text = "";
            txt_editCity.Text = "";
            txt_editPcode.Text = "";
            txt_editPemail.Text = "";
            txt_editWemail.Text = "";
            txt_editMobNumber.Text = "";
            txt_editPhoNumber.Text = "";
            cb_editGender.SelectedItem = "";
            dt_editBirthday.Text = null;
            txt_editNationality.Text = "";
        }

        public void UpdateTableMember()
        {
            BindingSource bd = new BindingSource();
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                bd.DataSource = client.SelectMember();
                this.gridview_Member.DataSource = bd;
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Server Not Found! The connection to Microsoft SQL Server is Unavailable...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnk_mmbrs_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_nw_Click(object sender, EventArgs e)
        {
            MembersUi_New MUiN = new MembersUi_New();
            StyleManager.Clone(MUiN);
            MUiN.ShowDialog();
        }

        private void btn_updt_Click(object sender, EventArgs e)
        {
            pnl_updt.Visible = true;
        }

        private void btn_rmv_Click(object sender, EventArgs e)
        {
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                if (!string.IsNullOrEmpty(txt_editID.Text))
                {

                    DialogResult dr = MetroMessageBox.Show(this, "Are you sure that you want to permanently delete the selected data?\n\nMember ID: '" + txt_editID.Text + "'\nMember Name: '" + txt_editFname.Text + "' ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (client.DeleteMember(txt_editID.Text) > 0)
                        {
                            MetroMessageBox.Show(this, "Member ID: '" + txt_editID.Text + "' successfully deleted! click OK to Continue. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateClear();
                            UpdateTableMember();
                            pb_viewMember.Image = null;
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        UpdateClear();
                        UpdateTableMember();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There has been an error deleting a Member Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UpdateClear();
                        UpdateTableMember();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "You must Select a Member before Deleting!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
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

                        if (pb_editMember.Image == null || img == null)
                        {
                            count1 = client.UpdateMemberNoIMG(txt_editID.Text, txt_editFname.Text, txt_editLname.Text, txt_editAdd1.Text, txt_editAdd2.Text, txt_editCity.Text, txt_editPcode.Text, txt_editPemail.Text, txt_editWemail.Text, txt_editMobNumber.Text, txt_editPhoNumber.Text, cb_editGender.Text, dt_editBirthday.Value.ToString(), txt_editNationality.Text);
                        }
                        else
                        {
                            count = client.UpdateMember(txt_editID.Text, txt_editFname.Text, txt_editLname.Text, txt_editAdd1.Text, txt_editAdd2.Text, txt_editCity.Text, txt_editPcode.Text, txt_editPemail.Text, txt_editWemail.Text, txt_editMobNumber.Text, txt_editPhoNumber.Text, cb_editGender.Text, dt_editBirthday.Value.ToString(), txt_editNationality.Text, img);
                        }

                        if (count == 1 || count1 == 1)
                        {
                            MetroMessageBox.Show(this, "Member ID '" + txt_editID.Text + "' successfully updated! click OK to Continue. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateClear();
                            UpdateTableMember();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "There has been an error updateing a Member Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            UpdateTableMember();
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        UpdateTableMember();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There has been an error updateing a Member Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UpdateClear();
                        UpdateTableMember();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Unable to Update your Member ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            pnl_updt.Visible = false;
        }

        private void pnl_updt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridview_Member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable rs = new DataTable();

            string itemid = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview_Member.Rows[e.RowIndex];

                lbl_memberID.Text = row.Cells["MemberID"].Value.ToString();
                itemID = lbl_memberID.Text;
                lbl_memberPnumber.Text = row.Cells["MobileNumber"].Value.ToString();
                lbl_memberEmail.Text = row.Cells["PersonalEmail"].Value.ToString();

                lbl_memberName.Text = row.Cells["FirstName"].Value.ToString();
                lbl_memberDOB.Text = row.Cells["Birthday"].Value.ToString();
                lbl_memberAdd1.Text = row.Cells["Add_L1"].Value.ToString();
                lbl_memberAdd2.Text = row.Cells["Add_L1"].Value.ToString();
                lbl_memberCity.Text = row.Cells["City"].Value.ToString();
                lbl_memberGender.Text = row.Cells["Gender"].Value.ToString();
                lbl_memberNationality.Text = row.Cells["Nationality"].Value.ToString();


                txt_editID.Text = row.Cells["MemberID"].Value.ToString();
                itemID = txt_editID.Text;
                txt_editFname.Text = row.Cells["FirstName"].Value.ToString();
                txt_editLname.Text = row.Cells["LastName"].Value.ToString(); 
                txt_editAdd1.Text = row.Cells["Add_L1"].Value.ToString();
                txt_editAdd2.Text = row.Cells["Add_L2"].Value.ToString();
                txt_editCity.Text = row.Cells["City"].Value.ToString();
                txt_editPcode.Text = row.Cells["Postalcode"].Value.ToString();
                txt_editPemail.Text = row.Cells["PersonalEmail"].Value.ToString();
                txt_editWemail.Text = row.Cells["WorkEmail"].Value.ToString();
                txt_editMobNumber.Text = row.Cells["MobileNumber"].Value.ToString();
                txt_editPhoNumber.Text = row.Cells["HomeNumber"].Value.ToString();
                cb_editGender.SelectedItem = row.Cells["Gender"].Value.ToString();
                dt_editBirthday.Text = row.Cells["Birthday"].Value.ToString();
                txt_editNationality.Text = row.Cells["Nationality"].Value.ToString();
            }

            byte[] img = client.getMemberImage(itemID);

            try
            {
                MemoryStream mstream = new MemoryStream(img);
                Image pic = Image.FromStream(mstream);

                pb_viewMember.Image = pic;
                pb_editMember.Image = pic;

            }
            catch (ArgumentException)
            {
                pb_editMember.Image = null;
                
            }
        }

        private void dt_mmb_bdy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click_1(object sender, EventArgs e)
        {
            UpdateTableMember();
        }

        private void pb_editMember_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files(*.*) | (*.*)";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picLoc = dlg.FileName.ToString();
                pb_editMember.ImageLocation = picLoc;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                if (!string.IsNullOrEmpty(txt_editID.Text))
                {

                    DialogResult dr = MetroMessageBox.Show(this, "Are you sure that you want to permanently delete the selected data?\n\nMember ID: '" + txt_editID.Text + "'\nMember Name: '" + txt_editFname.Text + "' ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (client.DeleteMember(txt_editID.Text) > 0)
                        {
                            MetroMessageBox.Show(this, "Member ID: '" + txt_editID.Text + "' successfully deleted! click OK to Continue. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateClear();
                            UpdateTableMember();
                            pb_viewMember.Image = null;
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        UpdateClear();
                        UpdateTableMember();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There has been an error deleting a Member Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UpdateClear();
                        UpdateTableMember();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "You must Select a Member before Deleting!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
