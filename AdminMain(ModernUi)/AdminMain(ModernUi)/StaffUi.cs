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
    public partial class StaffUi : MetroForm
    {
        string picLoc;
        string itemID;
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        public StaffUi()
        {
            InitializeComponent();
            UpdateTableStaff();
        }

        public void UpdateClear()
        {
            pb_editStaff.Image = null;
            txt_editID.Text = "";
            txt_editFname.Text = "";
            txt_editLname.Text = "";
            txt_editAdd1.Text = "";
            txt_editAdd2.Text = "";
            txt_editCity.Text = "";
            txt_editPcode.Text = "";
            txt_editPemail.Text = "";           
            txt_editMobNumber.Text = "";
            txt_editPhoNumber.Text = "";
            cb_editGender.SelectedItem = "";
            dt_editBirthday.Text = null;
            txt_editNationality.Text = "";
        }

        public void UpdateTableStaff()
        {
            BindingSource bd = new BindingSource();
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                bd.DataSource = client.SelectStaff();
                this.gridview_Staff.DataSource = bd;
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Server Not Found! The connection to Microsoft SQL Server is Unavailable...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StaffUi_Load(object sender, EventArgs e)
        {
            
        }

        private void lnkStff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nw_Click(object sender, EventArgs e)
        {
            StaffUi_New StfUiN = new StaffUi_New();
            this.StyleManager.Clone(StfUiN);
            StfUiN.ShowDialog();
        }

        private void btn_updt_Click(object sender, EventArgs e)
        {
            //StaffUi_Update StfUiU = new StaffUi_Update();
            //this.StyleManager.Clone(StfUiU);
            //StfUiU.ShowDialog();
            pnl_updt.Visible = true;
        }

        private void btn_rmv_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Are you sure you want to remove this staff member?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            pnl_updt.Visible = false;

        }

        private void gridview_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string itemid = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview_Staff.Rows[e.RowIndex];

                lbl_staffID.Text = row.Cells["StaffID"].Value.ToString();
                itemID = lbl_staffID.Text;
                lbl_staffPnumber.Text = row.Cells["MobileNumber"].Value.ToString();
                lbl_staffEmail.Text = row.Cells["PersonalEmail"].Value.ToString();

                lbl_staffName.Text = row.Cells["FirstName"].Value.ToString();
                lbl_staffDOB.Text = row.Cells["Birthday"].Value.ToString();
                lbl_staffAdd1.Text = row.Cells["Add_L1"].Value.ToString();
                lbl_staffAdd2.Text = row.Cells["Add_L2"].Value.ToString();
                lbl_staffCity.Text = row.Cells["City"].Value.ToString();
                lbl_staffGender.Text = row.Cells["Gender"].Value.ToString();
                lbl_staffNationality.Text = row.Cells["Nationality"].Value.ToString();


                txt_editID.Text = row.Cells["StaffID"].Value.ToString();
                itemID = txt_editID.Text;
                txt_editFname.Text = row.Cells["FirstName"].Value.ToString();
                txt_editLname.Text = row.Cells["LastName"].Value.ToString();
                txt_editAdd1.Text = row.Cells["Add_L1"].Value.ToString();
                txt_editAdd2.Text = row.Cells["Add_L2"].Value.ToString();
                txt_editCity.Text = row.Cells["City"].Value.ToString();
                txt_editPcode.Text = row.Cells["Postalcode"].Value.ToString();
                txt_editPemail.Text = row.Cells["PersonalEmail"].Value.ToString();
                txt_editMobNumber.Text = row.Cells["MobileNumber"].Value.ToString();
                txt_editPhoNumber.Text = row.Cells["HomeNumber"].Value.ToString();
                cb_editGender.SelectedItem = row.Cells["Gender"].Value.ToString();
                dt_editBirthday.Text = row.Cells["Birthday"].Value.ToString();
                txt_editNationality.Text = row.Cells["Nationality"].Value.ToString();
            }

            byte[] img = client.getStaffImage(itemID);

            try
            {
                MemoryStream mstream = new MemoryStream(img);
                Image pic = Image.FromStream(mstream);

                pb_viewStaff.Image = pic;
                pb_editStaff.Image = pic;

            }
            catch (ArgumentException)
            {
                pb_editStaff.Image = null;

            }
        }

        private void btn_newStaff_Click(object sender, EventArgs e)
        {
            StaffUi_New MUiN = new StaffUi_New();
            StyleManager.Clone(MUiN);
            MUiN.ShowDialog();
        }

        private void btn_updateForm_Click(object sender, EventArgs e)
        {
            pnl_updt.Visible = true;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UpdateTableStaff();
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

                        if (pb_editStaff.Image == null || img == null)
                        {
                            count1 = client.UpdateStaffNoIMG(txt_editID.Text, txt_editFname.Text, txt_editLname.Text, txt_editAdd1.Text, txt_editAdd2.Text, txt_editCity.Text, txt_editPcode.Text, txt_editPemail.Text, txt_editMobNumber.Text, txt_editPhoNumber.Text, cb_editGender.Text, dt_editBirthday.Value.ToString(), txt_editNationality.Text);
                        }
                        else
                        {
                            count = client.UpdateStaff(txt_editID.Text, txt_editFname.Text, txt_editLname.Text, txt_editAdd1.Text, txt_editAdd2.Text, txt_editCity.Text, txt_editPcode.Text, txt_editPemail.Text, txt_editMobNumber.Text, txt_editPhoNumber.Text, cb_editGender.Text, dt_editBirthday.Value.ToString(), txt_editNationality.Text, img);
                        }

                        if (count == 1 || count1 == 1)
                        {
                            MetroMessageBox.Show(this, "Staff ID '" + txt_editID.Text + "' successfully updated! click OK to Continue. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateClear();
                            UpdateTableStaff();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "There has been an error updateing a Staff Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            UpdateTableStaff();
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        UpdateTableStaff();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There has been an error updateing a Staff Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UpdateClear();
                        UpdateTableStaff();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Unable to Update your Staff ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                if (!string.IsNullOrEmpty(txt_editID.Text))
                {

                    DialogResult dr = MetroMessageBox.Show(this, "Are you sure that you want to permanently delete the selected data?\n\nStaff ID: '" + txt_editID.Text + "'\nStaff Name: '" + txt_editFname.Text + "' ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (client.DeleteMember(txt_editID.Text) > 0)
                        {
                            MetroMessageBox.Show(this, "Staff ID: '" + txt_editID.Text + "' successfully deleted! click OK to Continue. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateClear();
                            UpdateTableStaff();
                            pb_viewStaff.Image = null;
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        UpdateClear();
                        UpdateTableStaff();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There has been an error deleting a Staff Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UpdateClear();
                        UpdateTableStaff();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "You must Select a Staff before Deleting!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_mDelete_Click(object sender, EventArgs e)
        {
            LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
            try
            {
                if (!string.IsNullOrEmpty(txt_editID.Text))
                {

                    DialogResult dr = MetroMessageBox.Show(this, "Are you sure that you want to permanently delete the selected data?\n\nStaff ID: '" + txt_editID.Text + "'\nStaff Name: '" + txt_editFname.Text + "' ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (client.DeleteMember(txt_editID.Text) > 0)
                        {
                            MetroMessageBox.Show(this, "Staff ID: '" + txt_editID.Text + "' successfully deleted! click OK to Continue. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateClear();
                            UpdateTableStaff();
                            pb_viewStaff.Image = null;
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        UpdateClear();
                        UpdateTableStaff();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There has been an error deleting a Staff Details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UpdateClear();
                        UpdateTableStaff();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "You must Select a Staff before Deleting!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is an error connecting to a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_editStaff_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files(*.*) | (*.*)";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picLoc = dlg.FileName.ToString();
                pb_editStaff.ImageLocation = picLoc;
            }
        }
    }
}
