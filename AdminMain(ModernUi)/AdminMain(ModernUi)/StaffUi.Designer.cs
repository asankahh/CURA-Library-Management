namespace AdminMain_ModernUi_
{
    partial class StaffUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffUi));
            this.lnkStff = new MetroFramework.Controls.MetroLink();
            this.gridview_Staff = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_Refresh = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_updateForm = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_mDelete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_newStaff = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lbl_staffNationality = new MetroFramework.Controls.MetroLabel();
            this.lbl_staffEmail = new MetroFramework.Controls.MetroLabel();
            this.lbl_staffPnumber = new MetroFramework.Controls.MetroLabel();
            this.lbl_staffGender = new MetroFramework.Controls.MetroLabel();
            this.lbl_staffAdd2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_staffAdd1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_staffDOB = new MetroFramework.Controls.MetroLabel();
            this.lbl_staffID = new MetroFramework.Controls.MetroLabel();
            this.lbl_staffCity = new MetroFramework.Controls.MetroLabel();
            this.lbl_staffName = new MetroFramework.Controls.MetroLabel();
            this.pb_viewStaff = new System.Windows.Forms.PictureBox();
            this.pnl_updt = new MetroFramework.Controls.MetroPanel();
            this.btn_Delete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cb_editGender = new MetroFramework.Controls.MetroComboBox();
            this.txt_editID = new MetroFramework.Controls.MetroTextBox();
            this.lbl_14 = new MetroFramework.Controls.MetroLabel();
            this.lbl_10 = new MetroFramework.Controls.MetroLabel();
            this.lbl_15 = new MetroFramework.Controls.MetroLabel();
            this.lbl_12 = new MetroFramework.Controls.MetroLabel();
            this.lbl_13 = new MetroFramework.Controls.MetroLabel();
            this.lbl_6 = new MetroFramework.Controls.MetroLabel();
            this.lbl_7 = new MetroFramework.Controls.MetroLabel();
            this.lbl_8 = new MetroFramework.Controls.MetroLabel();
            this.lbl_2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_3 = new MetroFramework.Controls.MetroLabel();
            this.lbl_4 = new MetroFramework.Controls.MetroLabel();
            this.lbl_5 = new MetroFramework.Controls.MetroLabel();
            this.lbl_1 = new MetroFramework.Controls.MetroLabel();
            this.txt_editNationality = new MetroFramework.Controls.MetroTextBox();
            this.dt_editBirthday = new MetroFramework.Controls.MetroDateTime();
            this.txt_editPhoNumber = new MetroFramework.Controls.MetroTextBox();
            this.txt_editMobNumber = new MetroFramework.Controls.MetroTextBox();
            this.txt_editPemail = new MetroFramework.Controls.MetroTextBox();
            this.txt_editPcode = new MetroFramework.Controls.MetroTextBox();
            this.txt_editCity = new MetroFramework.Controls.MetroTextBox();
            this.txt_editAdd2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_editAdd1 = new MetroFramework.Controls.MetroTextBox();
            this.txt_editLname = new MetroFramework.Controls.MetroTextBox();
            this.txt_editFname = new MetroFramework.Controls.MetroTextBox();
            this.btn_Close = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_Update = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pb_editStaff = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_Staff)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewStaff)).BeginInit();
            this.pnl_updt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkStff
            // 
            this.lnkStff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkStff.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkStff.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkStff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkStff.ImageSize = 32;
            this.lnkStff.Location = new System.Drawing.Point(24, 34);
            this.lnkStff.Name = "lnkStff";
            this.lnkStff.Size = new System.Drawing.Size(90, 37);
            this.lnkStff.TabIndex = 3;
            this.lnkStff.Text = "⬅  Staff";
            this.lnkStff.UseSelectable = true;
            this.lnkStff.UseStyleColors = true;
            this.lnkStff.Click += new System.EventHandler(this.lnkStff_Click);
            // 
            // gridview_Staff
            // 
            this.gridview_Staff.AllowUserToResizeRows = false;
            this.gridview_Staff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview_Staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_Staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridview_Staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_Staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_Staff.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_Staff.EnableHeadersVisualStyles = false;
            this.gridview_Staff.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridview_Staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview_Staff.Location = new System.Drawing.Point(42, 98);
            this.gridview_Staff.Name = "gridview_Staff";
            this.gridview_Staff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_Staff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_Staff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_Staff.Size = new System.Drawing.Size(647, 506);
            this.gridview_Staff.TabIndex = 5;
            this.gridview_Staff.UseStyleColors = true;
            this.gridview_Staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_Staff_CellContentClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_Refresh);
            this.metroPanel1.Controls.Add(this.btn_updateForm);
            this.metroPanel1.Controls.Add(this.btn_mDelete);
            this.metroPanel1.Controls.Add(this.btn_newStaff);
            this.metroPanel1.Controls.Add(this.lbl_staffNationality);
            this.metroPanel1.Controls.Add(this.lbl_staffEmail);
            this.metroPanel1.Controls.Add(this.lbl_staffPnumber);
            this.metroPanel1.Controls.Add(this.lbl_staffGender);
            this.metroPanel1.Controls.Add(this.lbl_staffAdd2);
            this.metroPanel1.Controls.Add(this.lbl_staffAdd1);
            this.metroPanel1.Controls.Add(this.lbl_staffDOB);
            this.metroPanel1.Controls.Add(this.lbl_staffID);
            this.metroPanel1.Controls.Add(this.lbl_staffCity);
            this.metroPanel1.Controls.Add(this.lbl_staffName);
            this.metroPanel1.Controls.Add(this.pb_viewStaff);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(750, 98);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(413, 554);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = null;
            this.btn_Refresh.Location = new System.Drawing.Point(7, 499);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(53, 33);
            this.btn_Refresh.TabIndex = 20;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseSelectable = true;
            this.btn_Refresh.UseStyleColors = true;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_updateForm
            // 
            this.btn_updateForm.Image = null;
            this.btn_updateForm.Location = new System.Drawing.Point(66, 499);
            this.btn_updateForm.Name = "btn_updateForm";
            this.btn_updateForm.Size = new System.Drawing.Size(110, 33);
            this.btn_updateForm.TabIndex = 17;
            this.btn_updateForm.Text = "Update";
            this.btn_updateForm.UseSelectable = true;
            this.btn_updateForm.UseStyleColors = true;
            this.btn_updateForm.UseVisualStyleBackColor = true;
            this.btn_updateForm.Click += new System.EventHandler(this.btn_updateForm_Click);
            // 
            // btn_mDelete
            // 
            this.btn_mDelete.Image = null;
            this.btn_mDelete.Location = new System.Drawing.Point(298, 499);
            this.btn_mDelete.Name = "btn_mDelete";
            this.btn_mDelete.Size = new System.Drawing.Size(110, 33);
            this.btn_mDelete.TabIndex = 18;
            this.btn_mDelete.Text = "Remove";
            this.btn_mDelete.UseSelectable = true;
            this.btn_mDelete.UseVisualStyleBackColor = true;
            this.btn_mDelete.Click += new System.EventHandler(this.btn_mDelete_Click);
            // 
            // btn_newStaff
            // 
            this.btn_newStaff.Image = null;
            this.btn_newStaff.Location = new System.Drawing.Point(182, 499);
            this.btn_newStaff.Name = "btn_newStaff";
            this.btn_newStaff.Size = new System.Drawing.Size(110, 33);
            this.btn_newStaff.TabIndex = 19;
            this.btn_newStaff.Text = "New";
            this.btn_newStaff.UseSelectable = true;
            this.btn_newStaff.UseVisualStyleBackColor = true;
            this.btn_newStaff.Click += new System.EventHandler(this.btn_newStaff_Click);
            // 
            // lbl_staffNationality
            // 
            this.lbl_staffNationality.AutoSize = true;
            this.lbl_staffNationality.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffNationality.Location = new System.Drawing.Point(9, 442);
            this.lbl_staffNationality.Name = "lbl_staffNationality";
            this.lbl_staffNationality.Size = new System.Drawing.Size(167, 19);
            this.lbl_staffNationality.TabIndex = 15;
            this.lbl_staffNationality.Text = "..............[Nationality]..............";
            // 
            // lbl_staffEmail
            // 
            this.lbl_staffEmail.AutoSize = true;
            this.lbl_staffEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffEmail.Location = new System.Drawing.Point(159, 83);
            this.lbl_staffEmail.Name = "lbl_staffEmail";
            this.lbl_staffEmail.Size = new System.Drawing.Size(133, 19);
            this.lbl_staffEmail.TabIndex = 14;
            this.lbl_staffEmail.Text = "..............[email]..............";
            // 
            // lbl_staffPnumber
            // 
            this.lbl_staffPnumber.AutoSize = true;
            this.lbl_staffPnumber.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffPnumber.Location = new System.Drawing.Point(159, 50);
            this.lbl_staffPnumber.Name = "lbl_staffPnumber";
            this.lbl_staffPnumber.Size = new System.Drawing.Size(194, 19);
            this.lbl_staffPnumber.TabIndex = 13;
            this.lbl_staffPnumber.Text = "..............[Phone Number]..............";
            // 
            // lbl_staffGender
            // 
            this.lbl_staffGender.AutoSize = true;
            this.lbl_staffGender.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffGender.Location = new System.Drawing.Point(9, 405);
            this.lbl_staffGender.Name = "lbl_staffGender";
            this.lbl_staffGender.Size = new System.Drawing.Size(146, 19);
            this.lbl_staffGender.TabIndex = 12;
            this.lbl_staffGender.Text = "..............[Gender]..............";
            // 
            // lbl_staffAdd2
            // 
            this.lbl_staffAdd2.AutoSize = true;
            this.lbl_staffAdd2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffAdd2.Location = new System.Drawing.Point(9, 334);
            this.lbl_staffAdd2.Name = "lbl_staffAdd2";
            this.lbl_staffAdd2.Size = new System.Drawing.Size(162, 19);
            this.lbl_staffAdd2.TabIndex = 11;
            this.lbl_staffAdd2.Text = "..............[Address 2]..............";
            // 
            // lbl_staffAdd1
            // 
            this.lbl_staffAdd1.AutoSize = true;
            this.lbl_staffAdd1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffAdd1.Location = new System.Drawing.Point(9, 297);
            this.lbl_staffAdd1.Name = "lbl_staffAdd1";
            this.lbl_staffAdd1.Size = new System.Drawing.Size(162, 19);
            this.lbl_staffAdd1.TabIndex = 10;
            this.lbl_staffAdd1.Text = "..............[Address 1]..............";
            // 
            // lbl_staffDOB
            // 
            this.lbl_staffDOB.AutoSize = true;
            this.lbl_staffDOB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffDOB.Location = new System.Drawing.Point(9, 262);
            this.lbl_staffDOB.Name = "lbl_staffDOB";
            this.lbl_staffDOB.Size = new System.Drawing.Size(152, 19);
            this.lbl_staffDOB.TabIndex = 9;
            this.lbl_staffDOB.Text = "..............[Birthday]..............";
            // 
            // lbl_staffID
            // 
            this.lbl_staffID.AutoSize = true;
            this.lbl_staffID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffID.Location = new System.Drawing.Point(159, 20);
            this.lbl_staffID.Name = "lbl_staffID";
            this.lbl_staffID.Size = new System.Drawing.Size(146, 19);
            this.lbl_staffID.TabIndex = 8;
            this.lbl_staffID.Text = "..............[Staff ID]..............";
            // 
            // lbl_staffCity
            // 
            this.lbl_staffCity.AutoSize = true;
            this.lbl_staffCity.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffCity.Location = new System.Drawing.Point(9, 368);
            this.lbl_staffCity.Name = "lbl_staffCity";
            this.lbl_staffCity.Size = new System.Drawing.Size(125, 19);
            this.lbl_staffCity.TabIndex = 7;
            this.lbl_staffCity.Text = "..............[City]..............";
            // 
            // lbl_staffName
            // 
            this.lbl_staffName.AutoSize = true;
            this.lbl_staffName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_staffName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_staffName.Location = new System.Drawing.Point(9, 220);
            this.lbl_staffName.Name = "lbl_staffName";
            this.lbl_staffName.Size = new System.Drawing.Size(244, 25);
            this.lbl_staffName.TabIndex = 6;
            this.lbl_staffName.Text = "..............[Display Name]..............";
            // 
            // pb_viewStaff
            // 
            this.pb_viewStaff.Location = new System.Drawing.Point(3, 3);
            this.pb_viewStaff.Name = "pb_viewStaff";
            this.pb_viewStaff.Size = new System.Drawing.Size(150, 200);
            this.pb_viewStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_viewStaff.TabIndex = 5;
            this.pb_viewStaff.TabStop = false;
            this.pb_viewStaff.Tag = "";
            // 
            // pnl_updt
            // 
            this.pnl_updt.Controls.Add(this.btn_Delete);
            this.pnl_updt.Controls.Add(this.cb_editGender);
            this.pnl_updt.Controls.Add(this.txt_editID);
            this.pnl_updt.Controls.Add(this.lbl_14);
            this.pnl_updt.Controls.Add(this.lbl_10);
            this.pnl_updt.Controls.Add(this.lbl_15);
            this.pnl_updt.Controls.Add(this.lbl_12);
            this.pnl_updt.Controls.Add(this.lbl_13);
            this.pnl_updt.Controls.Add(this.lbl_6);
            this.pnl_updt.Controls.Add(this.lbl_7);
            this.pnl_updt.Controls.Add(this.lbl_8);
            this.pnl_updt.Controls.Add(this.lbl_2);
            this.pnl_updt.Controls.Add(this.lbl_3);
            this.pnl_updt.Controls.Add(this.lbl_4);
            this.pnl_updt.Controls.Add(this.lbl_5);
            this.pnl_updt.Controls.Add(this.lbl_1);
            this.pnl_updt.Controls.Add(this.txt_editNationality);
            this.pnl_updt.Controls.Add(this.dt_editBirthday);
            this.pnl_updt.Controls.Add(this.txt_editPhoNumber);
            this.pnl_updt.Controls.Add(this.txt_editMobNumber);
            this.pnl_updt.Controls.Add(this.txt_editPemail);
            this.pnl_updt.Controls.Add(this.txt_editPcode);
            this.pnl_updt.Controls.Add(this.txt_editCity);
            this.pnl_updt.Controls.Add(this.txt_editAdd2);
            this.pnl_updt.Controls.Add(this.txt_editAdd1);
            this.pnl_updt.Controls.Add(this.txt_editLname);
            this.pnl_updt.Controls.Add(this.txt_editFname);
            this.pnl_updt.Controls.Add(this.btn_Close);
            this.pnl_updt.Controls.Add(this.btn_Update);
            this.pnl_updt.Controls.Add(this.pb_editStaff);
            this.pnl_updt.HorizontalScrollbarBarColor = true;
            this.pnl_updt.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_updt.HorizontalScrollbarSize = 10;
            this.pnl_updt.Location = new System.Drawing.Point(249, 34);
            this.pnl_updt.Name = "pnl_updt";
            this.pnl_updt.Size = new System.Drawing.Size(656, 619);
            this.pnl_updt.TabIndex = 7;
            this.pnl_updt.VerticalScrollbarBarColor = true;
            this.pnl_updt.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_updt.VerticalScrollbarSize = 10;
            this.pnl_updt.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = null;
            this.btn_Delete.Location = new System.Drawing.Point(490, 385);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 33);
            this.btn_Delete.TabIndex = 157;
            this.btn_Delete.Text = "Remove";
            this.btn_Delete.UseSelectable = true;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cb_editGender
            // 
            this.cb_editGender.FormattingEnabled = true;
            this.cb_editGender.ItemHeight = 23;
            this.cb_editGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cb_editGender.Location = new System.Drawing.Point(172, 451);
            this.cb_editGender.Name = "cb_editGender";
            this.cb_editGender.Size = new System.Drawing.Size(240, 29);
            this.cb_editGender.TabIndex = 156;
            this.cb_editGender.UseSelectable = true;
            this.cb_editGender.UseStyleColors = true;
            // 
            // txt_editID
            // 
            // 
            // 
            // 
            this.txt_editID.CustomButton.Image = null;
            this.txt_editID.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editID.CustomButton.Name = "";
            this.txt_editID.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editID.CustomButton.TabIndex = 1;
            this.txt_editID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editID.CustomButton.UseSelectable = true;
            this.txt_editID.CustomButton.Visible = false;
            this.txt_editID.Enabled = false;
            this.txt_editID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editID.Lines = new string[0];
            this.txt_editID.Location = new System.Drawing.Point(172, 26);
            this.txt_editID.MaxLength = 32767;
            this.txt_editID.Name = "txt_editID";
            this.txt_editID.PasswordChar = '\0';
            this.txt_editID.PromptText = "Staff ID";
            this.txt_editID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editID.SelectedText = "";
            this.txt_editID.SelectionLength = 0;
            this.txt_editID.SelectionStart = 0;
            this.txt_editID.ShortcutsEnabled = true;
            this.txt_editID.Size = new System.Drawing.Size(240, 29);
            this.txt_editID.TabIndex = 155;
            this.txt_editID.UseSelectable = true;
            this.txt_editID.UseStyleColors = true;
            this.txt_editID.WaterMark = "Staff ID";
            this.txt_editID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_14
            // 
            this.lbl_14.AutoSize = true;
            this.lbl_14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_14.Location = new System.Drawing.Point(7, 548);
            this.lbl_14.Name = "lbl_14";
            this.lbl_14.Size = new System.Drawing.Size(75, 19);
            this.lbl_14.TabIndex = 154;
            this.lbl_14.Text = "Nationality";
            this.lbl_14.UseStyleColors = true;
            // 
            // lbl_10
            // 
            this.lbl_10.AutoSize = true;
            this.lbl_10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_10.Location = new System.Drawing.Point(7, 375);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Size = new System.Drawing.Size(105, 19);
            this.lbl_10.TabIndex = 152;
            this.lbl_10.Text = "Mobile Number";
            this.lbl_10.UseStyleColors = true;
            // 
            // lbl_15
            // 
            this.lbl_15.AutoSize = true;
            this.lbl_15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_15.Location = new System.Drawing.Point(7, 417);
            this.lbl_15.Name = "lbl_15";
            this.lbl_15.Size = new System.Drawing.Size(149, 19);
            this.lbl_15.TabIndex = 151;
            this.lbl_15.Text = "Phone number (Home)";
            this.lbl_15.UseStyleColors = true;
            // 
            // lbl_12
            // 
            this.lbl_12.AutoSize = true;
            this.lbl_12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_12.Location = new System.Drawing.Point(7, 458);
            this.lbl_12.Name = "lbl_12";
            this.lbl_12.Size = new System.Drawing.Size(54, 19);
            this.lbl_12.TabIndex = 150;
            this.lbl_12.Text = "Gender";
            this.lbl_12.UseStyleColors = true;
            // 
            // lbl_13
            // 
            this.lbl_13.AutoSize = true;
            this.lbl_13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_13.Location = new System.Drawing.Point(7, 501);
            this.lbl_13.Name = "lbl_13";
            this.lbl_13.Size = new System.Drawing.Size(60, 19);
            this.lbl_13.TabIndex = 149;
            this.lbl_13.Text = "Birthday";
            this.lbl_13.UseStyleColors = true;
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_6.Location = new System.Drawing.Point(7, 242);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(33, 19);
            this.lbl_6.TabIndex = 148;
            this.lbl_6.Text = "City";
            this.lbl_6.UseStyleColors = true;
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_7.Location = new System.Drawing.Point(7, 286);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(81, 19);
            this.lbl_7.TabIndex = 147;
            this.lbl_7.Text = "Postal Code";
            this.lbl_7.UseStyleColors = true;
            // 
            // lbl_8
            // 
            this.lbl_8.AutoSize = true;
            this.lbl_8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_8.Location = new System.Drawing.Point(7, 330);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(105, 19);
            this.lbl_8.TabIndex = 146;
            this.lbl_8.Text = "eMail (Personal)";
            this.lbl_8.UseStyleColors = true;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_2.Location = new System.Drawing.Point(7, 72);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(75, 19);
            this.lbl_2.TabIndex = 145;
            this.lbl_2.Text = "First Name";
            this.lbl_2.UseStyleColors = true;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_3.Location = new System.Drawing.Point(7, 117);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(74, 19);
            this.lbl_3.TabIndex = 144;
            this.lbl_3.Text = "Last Name";
            this.lbl_3.UseStyleColors = true;
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_4.Location = new System.Drawing.Point(7, 157);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(95, 19);
            this.lbl_4.TabIndex = 143;
            this.lbl_4.Text = "Address line 1";
            this.lbl_4.UseStyleColors = true;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_5.Location = new System.Drawing.Point(7, 199);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(95, 19);
            this.lbl_5.TabIndex = 142;
            this.lbl_5.Text = "Address line 2";
            this.lbl_5.UseStyleColors = true;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_1.Location = new System.Drawing.Point(7, 36);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(23, 19);
            this.lbl_1.TabIndex = 141;
            this.lbl_1.Text = "ID";
            this.lbl_1.UseStyleColors = true;
            // 
            // txt_editNationality
            // 
            // 
            // 
            // 
            this.txt_editNationality.CustomButton.Image = null;
            this.txt_editNationality.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editNationality.CustomButton.Name = "";
            this.txt_editNationality.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editNationality.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editNationality.CustomButton.TabIndex = 1;
            this.txt_editNationality.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editNationality.CustomButton.UseSelectable = true;
            this.txt_editNationality.CustomButton.Visible = false;
            this.txt_editNationality.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editNationality.Lines = new string[0];
            this.txt_editNationality.Location = new System.Drawing.Point(172, 541);
            this.txt_editNationality.MaxLength = 32767;
            this.txt_editNationality.Name = "txt_editNationality";
            this.txt_editNationality.PasswordChar = '\0';
            this.txt_editNationality.PromptText = "Nationality";
            this.txt_editNationality.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editNationality.SelectedText = "";
            this.txt_editNationality.SelectionLength = 0;
            this.txt_editNationality.SelectionStart = 0;
            this.txt_editNationality.ShortcutsEnabled = true;
            this.txt_editNationality.Size = new System.Drawing.Size(240, 29);
            this.txt_editNationality.TabIndex = 140;
            this.txt_editNationality.UseSelectable = true;
            this.txt_editNationality.UseStyleColors = true;
            this.txt_editNationality.WaterMark = "Nationality";
            this.txt_editNationality.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editNationality.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dt_editBirthday
            // 
            this.dt_editBirthday.Location = new System.Drawing.Point(172, 495);
            this.dt_editBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_editBirthday.Name = "dt_editBirthday";
            this.dt_editBirthday.Size = new System.Drawing.Size(240, 29);
            this.dt_editBirthday.TabIndex = 139;
            this.dt_editBirthday.UseStyleColors = true;
            // 
            // txt_editPhoNumber
            // 
            // 
            // 
            // 
            this.txt_editPhoNumber.CustomButton.Image = null;
            this.txt_editPhoNumber.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editPhoNumber.CustomButton.Name = "";
            this.txt_editPhoNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editPhoNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editPhoNumber.CustomButton.TabIndex = 1;
            this.txt_editPhoNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editPhoNumber.CustomButton.UseSelectable = true;
            this.txt_editPhoNumber.CustomButton.Visible = false;
            this.txt_editPhoNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editPhoNumber.Lines = new string[0];
            this.txt_editPhoNumber.Location = new System.Drawing.Point(172, 411);
            this.txt_editPhoNumber.MaxLength = 10;
            this.txt_editPhoNumber.Name = "txt_editPhoNumber";
            this.txt_editPhoNumber.PasswordChar = '\0';
            this.txt_editPhoNumber.PromptText = "Home phone number";
            this.txt_editPhoNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editPhoNumber.SelectedText = "";
            this.txt_editPhoNumber.SelectionLength = 0;
            this.txt_editPhoNumber.SelectionStart = 0;
            this.txt_editPhoNumber.ShortcutsEnabled = true;
            this.txt_editPhoNumber.Size = new System.Drawing.Size(240, 29);
            this.txt_editPhoNumber.TabIndex = 138;
            this.txt_editPhoNumber.UseSelectable = true;
            this.txt_editPhoNumber.UseStyleColors = true;
            this.txt_editPhoNumber.WaterMark = "Home phone number";
            this.txt_editPhoNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editPhoNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editMobNumber
            // 
            // 
            // 
            // 
            this.txt_editMobNumber.CustomButton.Image = null;
            this.txt_editMobNumber.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editMobNumber.CustomButton.Name = "";
            this.txt_editMobNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editMobNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editMobNumber.CustomButton.TabIndex = 1;
            this.txt_editMobNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editMobNumber.CustomButton.UseSelectable = true;
            this.txt_editMobNumber.CustomButton.Visible = false;
            this.txt_editMobNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editMobNumber.Lines = new string[0];
            this.txt_editMobNumber.Location = new System.Drawing.Point(172, 367);
            this.txt_editMobNumber.MaxLength = 10;
            this.txt_editMobNumber.Name = "txt_editMobNumber";
            this.txt_editMobNumber.PasswordChar = '\0';
            this.txt_editMobNumber.PromptText = "Mobile phone number";
            this.txt_editMobNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editMobNumber.SelectedText = "";
            this.txt_editMobNumber.SelectionLength = 0;
            this.txt_editMobNumber.SelectionStart = 0;
            this.txt_editMobNumber.ShortcutsEnabled = true;
            this.txt_editMobNumber.Size = new System.Drawing.Size(240, 29);
            this.txt_editMobNumber.TabIndex = 137;
            this.txt_editMobNumber.UseSelectable = true;
            this.txt_editMobNumber.UseStyleColors = true;
            this.txt_editMobNumber.WaterMark = "Mobile phone number";
            this.txt_editMobNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editMobNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editPemail
            // 
            // 
            // 
            // 
            this.txt_editPemail.CustomButton.Image = null;
            this.txt_editPemail.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editPemail.CustomButton.Name = "";
            this.txt_editPemail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editPemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editPemail.CustomButton.TabIndex = 1;
            this.txt_editPemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editPemail.CustomButton.UseSelectable = true;
            this.txt_editPemail.CustomButton.Visible = false;
            this.txt_editPemail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editPemail.Lines = new string[0];
            this.txt_editPemail.Location = new System.Drawing.Point(172, 322);
            this.txt_editPemail.MaxLength = 32767;
            this.txt_editPemail.Name = "txt_editPemail";
            this.txt_editPemail.PasswordChar = '\0';
            this.txt_editPemail.PromptText = "Personal email";
            this.txt_editPemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editPemail.SelectedText = "";
            this.txt_editPemail.SelectionLength = 0;
            this.txt_editPemail.SelectionStart = 0;
            this.txt_editPemail.ShortcutsEnabled = true;
            this.txt_editPemail.Size = new System.Drawing.Size(240, 29);
            this.txt_editPemail.TabIndex = 135;
            this.txt_editPemail.UseSelectable = true;
            this.txt_editPemail.UseStyleColors = true;
            this.txt_editPemail.WaterMark = "Personal email";
            this.txt_editPemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editPemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editPcode
            // 
            // 
            // 
            // 
            this.txt_editPcode.CustomButton.Image = null;
            this.txt_editPcode.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editPcode.CustomButton.Name = "";
            this.txt_editPcode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editPcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editPcode.CustomButton.TabIndex = 1;
            this.txt_editPcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editPcode.CustomButton.UseSelectable = true;
            this.txt_editPcode.CustomButton.Visible = false;
            this.txt_editPcode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editPcode.Lines = new string[0];
            this.txt_editPcode.Location = new System.Drawing.Point(172, 277);
            this.txt_editPcode.MaxLength = 8;
            this.txt_editPcode.Name = "txt_editPcode";
            this.txt_editPcode.PasswordChar = '\0';
            this.txt_editPcode.PromptText = "Postal Code or ZIP";
            this.txt_editPcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editPcode.SelectedText = "";
            this.txt_editPcode.SelectionLength = 0;
            this.txt_editPcode.SelectionStart = 0;
            this.txt_editPcode.ShortcutsEnabled = true;
            this.txt_editPcode.Size = new System.Drawing.Size(240, 29);
            this.txt_editPcode.TabIndex = 134;
            this.txt_editPcode.UseSelectable = true;
            this.txt_editPcode.UseStyleColors = true;
            this.txt_editPcode.WaterMark = "Postal Code or ZIP";
            this.txt_editPcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editPcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editCity
            // 
            // 
            // 
            // 
            this.txt_editCity.CustomButton.Image = null;
            this.txt_editCity.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editCity.CustomButton.Name = "";
            this.txt_editCity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editCity.CustomButton.TabIndex = 1;
            this.txt_editCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editCity.CustomButton.UseSelectable = true;
            this.txt_editCity.CustomButton.Visible = false;
            this.txt_editCity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editCity.Lines = new string[0];
            this.txt_editCity.Location = new System.Drawing.Point(172, 232);
            this.txt_editCity.MaxLength = 32767;
            this.txt_editCity.Name = "txt_editCity";
            this.txt_editCity.PasswordChar = '\0';
            this.txt_editCity.PromptText = "City";
            this.txt_editCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editCity.SelectedText = "";
            this.txt_editCity.SelectionLength = 0;
            this.txt_editCity.SelectionStart = 0;
            this.txt_editCity.ShortcutsEnabled = true;
            this.txt_editCity.Size = new System.Drawing.Size(240, 29);
            this.txt_editCity.TabIndex = 133;
            this.txt_editCity.UseSelectable = true;
            this.txt_editCity.UseStyleColors = true;
            this.txt_editCity.WaterMark = "City";
            this.txt_editCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editAdd2
            // 
            // 
            // 
            // 
            this.txt_editAdd2.CustomButton.Image = null;
            this.txt_editAdd2.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editAdd2.CustomButton.Name = "";
            this.txt_editAdd2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editAdd2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editAdd2.CustomButton.TabIndex = 1;
            this.txt_editAdd2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editAdd2.CustomButton.UseSelectable = true;
            this.txt_editAdd2.CustomButton.Visible = false;
            this.txt_editAdd2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editAdd2.Lines = new string[0];
            this.txt_editAdd2.Location = new System.Drawing.Point(172, 190);
            this.txt_editAdd2.MaxLength = 50;
            this.txt_editAdd2.Name = "txt_editAdd2";
            this.txt_editAdd2.PasswordChar = '\0';
            this.txt_editAdd2.PromptText = "Address line 2";
            this.txt_editAdd2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editAdd2.SelectedText = "";
            this.txt_editAdd2.SelectionLength = 0;
            this.txt_editAdd2.SelectionStart = 0;
            this.txt_editAdd2.ShortcutsEnabled = true;
            this.txt_editAdd2.Size = new System.Drawing.Size(240, 29);
            this.txt_editAdd2.TabIndex = 132;
            this.txt_editAdd2.UseSelectable = true;
            this.txt_editAdd2.UseStyleColors = true;
            this.txt_editAdd2.WaterMark = "Address line 2";
            this.txt_editAdd2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editAdd2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editAdd1
            // 
            // 
            // 
            // 
            this.txt_editAdd1.CustomButton.Image = null;
            this.txt_editAdd1.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editAdd1.CustomButton.Name = "";
            this.txt_editAdd1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editAdd1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editAdd1.CustomButton.TabIndex = 1;
            this.txt_editAdd1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editAdd1.CustomButton.UseSelectable = true;
            this.txt_editAdd1.CustomButton.Visible = false;
            this.txt_editAdd1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editAdd1.Lines = new string[0];
            this.txt_editAdd1.Location = new System.Drawing.Point(172, 148);
            this.txt_editAdd1.MaxLength = 50;
            this.txt_editAdd1.Name = "txt_editAdd1";
            this.txt_editAdd1.PasswordChar = '\0';
            this.txt_editAdd1.PromptText = "Address line 1";
            this.txt_editAdd1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editAdd1.SelectedText = "";
            this.txt_editAdd1.SelectionLength = 0;
            this.txt_editAdd1.SelectionStart = 0;
            this.txt_editAdd1.ShortcutsEnabled = true;
            this.txt_editAdd1.Size = new System.Drawing.Size(240, 29);
            this.txt_editAdd1.TabIndex = 131;
            this.txt_editAdd1.UseSelectable = true;
            this.txt_editAdd1.UseStyleColors = true;
            this.txt_editAdd1.WaterMark = "Address line 1";
            this.txt_editAdd1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editAdd1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editLname
            // 
            // 
            // 
            // 
            this.txt_editLname.CustomButton.Image = null;
            this.txt_editLname.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editLname.CustomButton.Name = "";
            this.txt_editLname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editLname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editLname.CustomButton.TabIndex = 1;
            this.txt_editLname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editLname.CustomButton.UseSelectable = true;
            this.txt_editLname.CustomButton.Visible = false;
            this.txt_editLname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editLname.Lines = new string[0];
            this.txt_editLname.Location = new System.Drawing.Point(172, 108);
            this.txt_editLname.MaxLength = 32767;
            this.txt_editLname.Name = "txt_editLname";
            this.txt_editLname.PasswordChar = '\0';
            this.txt_editLname.PromptText = "Last name or Surname";
            this.txt_editLname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editLname.SelectedText = "";
            this.txt_editLname.SelectionLength = 0;
            this.txt_editLname.SelectionStart = 0;
            this.txt_editLname.ShortcutsEnabled = true;
            this.txt_editLname.Size = new System.Drawing.Size(240, 29);
            this.txt_editLname.TabIndex = 130;
            this.txt_editLname.UseSelectable = true;
            this.txt_editLname.UseStyleColors = true;
            this.txt_editLname.WaterMark = "Last name or Surname";
            this.txt_editLname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editLname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editFname
            // 
            // 
            // 
            // 
            this.txt_editFname.CustomButton.Image = null;
            this.txt_editFname.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editFname.CustomButton.Name = "";
            this.txt_editFname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editFname.CustomButton.TabIndex = 1;
            this.txt_editFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editFname.CustomButton.UseSelectable = true;
            this.txt_editFname.CustomButton.Visible = false;
            this.txt_editFname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editFname.Lines = new string[0];
            this.txt_editFname.Location = new System.Drawing.Point(172, 65);
            this.txt_editFname.MaxLength = 32767;
            this.txt_editFname.Name = "txt_editFname";
            this.txt_editFname.PasswordChar = '\0';
            this.txt_editFname.PromptText = "First Name";
            this.txt_editFname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editFname.SelectedText = "";
            this.txt_editFname.SelectionLength = 0;
            this.txt_editFname.SelectionStart = 0;
            this.txt_editFname.ShortcutsEnabled = true;
            this.txt_editFname.Size = new System.Drawing.Size(240, 29);
            this.txt_editFname.TabIndex = 129;
            this.txt_editFname.UseSelectable = true;
            this.txt_editFname.UseStyleColors = true;
            this.txt_editFname.WaterMark = "First Name";
            this.txt_editFname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = null;
            this.btn_Close.Location = new System.Drawing.Point(490, 433);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(110, 33);
            this.btn_Close.TabIndex = 64;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseSelectable = true;
            this.btn_Close.UseStyleColors = true;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = null;
            this.btn_Update.Location = new System.Drawing.Point(490, 333);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 33);
            this.btn_Update.TabIndex = 65;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseSelectable = true;
            this.btn_Update.UseStyleColors = true;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // pb_editStaff
            // 
            this.pb_editStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_editStaff.Location = new System.Drawing.Point(436, 27);
            this.pb_editStaff.Name = "pb_editStaff";
            this.pb_editStaff.Size = new System.Drawing.Size(210, 280);
            this.pb_editStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_editStaff.TabIndex = 63;
            this.pb_editStaff.TabStop = false;
            this.pb_editStaff.Tag = "";
            this.pb_editStaff.Click += new System.EventHandler(this.pb_editStaff_Click);
            // 
            // StaffUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_updt);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.gridview_Staff);
            this.Controls.Add(this.lnkStff);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "StaffUi";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "StaffUi";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.StaffUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_Staff)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewStaff)).EndInit();
            this.pnl_updt.ResumeLayout(false);
            this.pnl_updt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkStff;
        private MetroFramework.Controls.MetroGrid gridview_Staff;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pb_viewStaff;
        private MetroFramework.Controls.MetroLabel lbl_staffNationality;
        private MetroFramework.Controls.MetroLabel lbl_staffEmail;
        private MetroFramework.Controls.MetroLabel lbl_staffPnumber;
        private MetroFramework.Controls.MetroLabel lbl_staffGender;
        private MetroFramework.Controls.MetroLabel lbl_staffAdd2;
        private MetroFramework.Controls.MetroLabel lbl_staffAdd1;
        private MetroFramework.Controls.MetroLabel lbl_staffDOB;
        private MetroFramework.Controls.MetroLabel lbl_staffID;
        private MetroFramework.Controls.MetroLabel lbl_staffCity;
        private MetroFramework.Controls.MetroLabel lbl_staffName;
        private MetroFramework.Controls.MetroPanel pnl_updt;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Close;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Update;
        private System.Windows.Forms.PictureBox pb_editStaff;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Delete;
        private MetroFramework.Controls.MetroComboBox cb_editGender;
        private MetroFramework.Controls.MetroTextBox txt_editID;
        private MetroFramework.Controls.MetroLabel lbl_14;
        private MetroFramework.Controls.MetroLabel lbl_10;
        private MetroFramework.Controls.MetroLabel lbl_15;
        private MetroFramework.Controls.MetroLabel lbl_12;
        private MetroFramework.Controls.MetroLabel lbl_13;
        private MetroFramework.Controls.MetroLabel lbl_6;
        private MetroFramework.Controls.MetroLabel lbl_7;
        private MetroFramework.Controls.MetroLabel lbl_8;
        private MetroFramework.Controls.MetroLabel lbl_2;
        private MetroFramework.Controls.MetroLabel lbl_3;
        private MetroFramework.Controls.MetroLabel lbl_4;
        private MetroFramework.Controls.MetroLabel lbl_5;
        private MetroFramework.Controls.MetroLabel lbl_1;
        private MetroFramework.Controls.MetroTextBox txt_editNationality;
        private MetroFramework.Controls.MetroDateTime dt_editBirthday;
        private MetroFramework.Controls.MetroTextBox txt_editPhoNumber;
        private MetroFramework.Controls.MetroTextBox txt_editMobNumber;
        private MetroFramework.Controls.MetroTextBox txt_editPemail;
        private MetroFramework.Controls.MetroTextBox txt_editPcode;
        private MetroFramework.Controls.MetroTextBox txt_editCity;
        private MetroFramework.Controls.MetroTextBox txt_editAdd2;
        private MetroFramework.Controls.MetroTextBox txt_editAdd1;
        private MetroFramework.Controls.MetroTextBox txt_editLname;
        private MetroFramework.Controls.MetroTextBox txt_editFname;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Refresh;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_updateForm;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_mDelete;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_newStaff;
    }
}