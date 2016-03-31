namespace AdminMain_ModernUi_
{
    partial class MembersUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersUi));
            this.lnk_mmbrs = new MetroFramework.Controls.MetroLink();
            this.pnl_vw = new MetroFramework.Controls.MetroPanel();
            this.btn_Refresh = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lbl_memberNationality = new MetroFramework.Controls.MetroLabel();
            this.lbl_memberEmail = new MetroFramework.Controls.MetroLabel();
            this.lbl_memberPnumber = new MetroFramework.Controls.MetroLabel();
            this.lbl_memberGender = new MetroFramework.Controls.MetroLabel();
            this.lbl_memberAdd2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_memberAdd1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_memberDOB = new MetroFramework.Controls.MetroLabel();
            this.lbl_memberID = new MetroFramework.Controls.MetroLabel();
            this.lbl_memberCity = new MetroFramework.Controls.MetroLabel();
            this.lbl_memberName = new MetroFramework.Controls.MetroLabel();
            this.pb_viewMember = new System.Windows.Forms.PictureBox();
            this.btn_updateForm = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_mDelete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_newMember = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.gridview_Member = new MetroFramework.Controls.MetroGrid();
            this.pnl_updt = new MetroFramework.Controls.MetroPanel();
            this.btn_Delete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cb_editGender = new MetroFramework.Controls.MetroComboBox();
            this.txt_editID = new MetroFramework.Controls.MetroTextBox();
            this.lbl_14 = new MetroFramework.Controls.MetroLabel();
            this.lbl_9 = new MetroFramework.Controls.MetroLabel();
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
            this.txt_editWemail = new MetroFramework.Controls.MetroTextBox();
            this.txt_editPemail = new MetroFramework.Controls.MetroTextBox();
            this.txt_editPcode = new MetroFramework.Controls.MetroTextBox();
            this.txt_editCity = new MetroFramework.Controls.MetroTextBox();
            this.txt_editAdd2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_editAdd1 = new MetroFramework.Controls.MetroTextBox();
            this.txt_editLname = new MetroFramework.Controls.MetroTextBox();
            this.txt_editFname = new MetroFramework.Controls.MetroTextBox();
            this.btn_Close = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_Update = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pb_editMember = new System.Windows.Forms.PictureBox();
            this.pnl_vw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_Member)).BeginInit();
            this.pnl_updt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editMember)).BeginInit();
            this.SuspendLayout();
            // 
            // lnk_mmbrs
            // 
            this.lnk_mmbrs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk_mmbrs.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnk_mmbrs.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnk_mmbrs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnk_mmbrs.ImageSize = 32;
            this.lnk_mmbrs.Location = new System.Drawing.Point(24, 34);
            this.lnk_mmbrs.Name = "lnk_mmbrs";
            this.lnk_mmbrs.Size = new System.Drawing.Size(119, 37);
            this.lnk_mmbrs.TabIndex = 1;
            this.lnk_mmbrs.Text = "⬅  Members";
            this.lnk_mmbrs.UseSelectable = true;
            this.lnk_mmbrs.UseStyleColors = true;
            this.lnk_mmbrs.Click += new System.EventHandler(this.lnk_mmbrs_Click);
            // 
            // pnl_vw
            // 
            this.pnl_vw.Controls.Add(this.btn_Refresh);
            this.pnl_vw.Controls.Add(this.lbl_memberNationality);
            this.pnl_vw.Controls.Add(this.lbl_memberEmail);
            this.pnl_vw.Controls.Add(this.lbl_memberPnumber);
            this.pnl_vw.Controls.Add(this.lbl_memberGender);
            this.pnl_vw.Controls.Add(this.lbl_memberAdd2);
            this.pnl_vw.Controls.Add(this.lbl_memberAdd1);
            this.pnl_vw.Controls.Add(this.lbl_memberDOB);
            this.pnl_vw.Controls.Add(this.lbl_memberID);
            this.pnl_vw.Controls.Add(this.lbl_memberCity);
            this.pnl_vw.Controls.Add(this.lbl_memberName);
            this.pnl_vw.Controls.Add(this.pb_viewMember);
            this.pnl_vw.Controls.Add(this.btn_updateForm);
            this.pnl_vw.Controls.Add(this.btn_mDelete);
            this.pnl_vw.Controls.Add(this.btn_newMember);
            this.pnl_vw.HorizontalScrollbarBarColor = true;
            this.pnl_vw.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_vw.HorizontalScrollbarSize = 10;
            this.pnl_vw.Location = new System.Drawing.Point(748, 95);
            this.pnl_vw.Name = "pnl_vw";
            this.pnl_vw.Size = new System.Drawing.Size(413, 552);
            this.pnl_vw.TabIndex = 8;
            this.pnl_vw.VerticalScrollbarBarColor = true;
            this.pnl_vw.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_vw.VerticalScrollbarSize = 10;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = null;
            this.btn_Refresh.Location = new System.Drawing.Point(7, 497);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(53, 33);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseSelectable = true;
            this.btn_Refresh.UseStyleColors = true;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.metroTextButton1_Click_1);
            // 
            // lbl_memberNationality
            // 
            this.lbl_memberNationality.AutoSize = true;
            this.lbl_memberNationality.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_memberNationality.Location = new System.Drawing.Point(9, 442);
            this.lbl_memberNationality.Name = "lbl_memberNationality";
            this.lbl_memberNationality.Size = new System.Drawing.Size(167, 19);
            this.lbl_memberNationality.TabIndex = 15;
            this.lbl_memberNationality.Text = "..............[Nationality]..............";
            // 
            // lbl_memberEmail
            // 
            this.lbl_memberEmail.AutoSize = true;
            this.lbl_memberEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_memberEmail.Location = new System.Drawing.Point(159, 83);
            this.lbl_memberEmail.Name = "lbl_memberEmail";
            this.lbl_memberEmail.Size = new System.Drawing.Size(133, 19);
            this.lbl_memberEmail.TabIndex = 14;
            this.lbl_memberEmail.Text = "..............[email]..............";
            // 
            // lbl_memberPnumber
            // 
            this.lbl_memberPnumber.AutoSize = true;
            this.lbl_memberPnumber.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_memberPnumber.Location = new System.Drawing.Point(159, 50);
            this.lbl_memberPnumber.Name = "lbl_memberPnumber";
            this.lbl_memberPnumber.Size = new System.Drawing.Size(194, 19);
            this.lbl_memberPnumber.TabIndex = 13;
            this.lbl_memberPnumber.Text = "..............[Phone Number]..............";
            // 
            // lbl_memberGender
            // 
            this.lbl_memberGender.AutoSize = true;
            this.lbl_memberGender.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_memberGender.Location = new System.Drawing.Point(9, 405);
            this.lbl_memberGender.Name = "lbl_memberGender";
            this.lbl_memberGender.Size = new System.Drawing.Size(146, 19);
            this.lbl_memberGender.TabIndex = 12;
            this.lbl_memberGender.Text = "..............[Gender]..............";
            // 
            // lbl_memberAdd2
            // 
            this.lbl_memberAdd2.AutoSize = true;
            this.lbl_memberAdd2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_memberAdd2.Location = new System.Drawing.Point(9, 334);
            this.lbl_memberAdd2.Name = "lbl_memberAdd2";
            this.lbl_memberAdd2.Size = new System.Drawing.Size(162, 19);
            this.lbl_memberAdd2.TabIndex = 11;
            this.lbl_memberAdd2.Text = "..............[Address 2]..............";
            // 
            // lbl_memberAdd1
            // 
            this.lbl_memberAdd1.AutoSize = true;
            this.lbl_memberAdd1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_memberAdd1.Location = new System.Drawing.Point(9, 297);
            this.lbl_memberAdd1.Name = "lbl_memberAdd1";
            this.lbl_memberAdd1.Size = new System.Drawing.Size(162, 19);
            this.lbl_memberAdd1.TabIndex = 10;
            this.lbl_memberAdd1.Text = "..............[Address 1]..............";
            // 
            // lbl_memberDOB
            // 
            this.lbl_memberDOB.AutoSize = true;
            this.lbl_memberDOB.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_memberDOB.Location = new System.Drawing.Point(9, 262);
            this.lbl_memberDOB.Name = "lbl_memberDOB";
            this.lbl_memberDOB.Size = new System.Drawing.Size(152, 19);
            this.lbl_memberDOB.TabIndex = 9;
            this.lbl_memberDOB.Text = "..............[Birthday]..............";
            // 
            // lbl_memberID
            // 
            this.lbl_memberID.AutoSize = true;
            this.lbl_memberID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_memberID.Location = new System.Drawing.Point(159, 20);
            this.lbl_memberID.Name = "lbl_memberID";
            this.lbl_memberID.Size = new System.Drawing.Size(171, 19);
            this.lbl_memberID.TabIndex = 8;
            this.lbl_memberID.Text = "..............[Member ID]..............";
            // 
            // lbl_memberCity
            // 
            this.lbl_memberCity.AutoSize = true;
            this.lbl_memberCity.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_memberCity.Location = new System.Drawing.Point(9, 368);
            this.lbl_memberCity.Name = "lbl_memberCity";
            this.lbl_memberCity.Size = new System.Drawing.Size(125, 19);
            this.lbl_memberCity.TabIndex = 7;
            this.lbl_memberCity.Text = "..............[City]..............";
            // 
            // lbl_memberName
            // 
            this.lbl_memberName.AutoSize = true;
            this.lbl_memberName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_memberName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_memberName.Location = new System.Drawing.Point(9, 220);
            this.lbl_memberName.Name = "lbl_memberName";
            this.lbl_memberName.Size = new System.Drawing.Size(283, 25);
            this.lbl_memberName.TabIndex = 6;
            this.lbl_memberName.Text = "..............[Display Name]..............";
            // 
            // pb_viewMember
            // 
            this.pb_viewMember.Location = new System.Drawing.Point(4, 4);
            this.pb_viewMember.Name = "pb_viewMember";
            this.pb_viewMember.Size = new System.Drawing.Size(150, 200);
            this.pb_viewMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_viewMember.TabIndex = 5;
            this.pb_viewMember.TabStop = false;
            this.pb_viewMember.Tag = "";
            // 
            // btn_updateForm
            // 
            this.btn_updateForm.Image = null;
            this.btn_updateForm.Location = new System.Drawing.Point(66, 497);
            this.btn_updateForm.Name = "btn_updateForm";
            this.btn_updateForm.Size = new System.Drawing.Size(110, 33);
            this.btn_updateForm.TabIndex = 4;
            this.btn_updateForm.Text = "Update";
            this.btn_updateForm.UseSelectable = true;
            this.btn_updateForm.UseStyleColors = true;
            this.btn_updateForm.UseVisualStyleBackColor = true;
            this.btn_updateForm.Click += new System.EventHandler(this.btn_updt_Click);
            // 
            // btn_mDelete
            // 
            this.btn_mDelete.Image = null;
            this.btn_mDelete.Location = new System.Drawing.Point(298, 497);
            this.btn_mDelete.Name = "btn_mDelete";
            this.btn_mDelete.Size = new System.Drawing.Size(110, 33);
            this.btn_mDelete.TabIndex = 4;
            this.btn_mDelete.Text = "Remove";
            this.btn_mDelete.UseSelectable = true;
            this.btn_mDelete.UseVisualStyleBackColor = true;
            this.btn_mDelete.Click += new System.EventHandler(this.btn_rmv_Click);
            // 
            // btn_newMember
            // 
            this.btn_newMember.Image = null;
            this.btn_newMember.Location = new System.Drawing.Point(182, 497);
            this.btn_newMember.Name = "btn_newMember";
            this.btn_newMember.Size = new System.Drawing.Size(110, 33);
            this.btn_newMember.TabIndex = 4;
            this.btn_newMember.Text = "New";
            this.btn_newMember.UseSelectable = true;
            this.btn_newMember.UseVisualStyleBackColor = true;
            this.btn_newMember.Click += new System.EventHandler(this.btn_nw_Click);
            // 
            // gridview_Member
            // 
            this.gridview_Member.AllowUserToResizeRows = false;
            this.gridview_Member.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview_Member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_Member.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridview_Member.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_Member.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_Member.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_Member.EnableHeadersVisualStyles = false;
            this.gridview_Member.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridview_Member.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview_Member.Location = new System.Drawing.Point(40, 95);
            this.gridview_Member.Name = "gridview_Member";
            this.gridview_Member.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_Member.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_Member.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview_Member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_Member.Size = new System.Drawing.Size(687, 512);
            this.gridview_Member.TabIndex = 7;
            this.gridview_Member.UseStyleColors = true;
            this.gridview_Member.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_Member_CellContentClick);
            // 
            // pnl_updt
            // 
            this.pnl_updt.Controls.Add(this.btn_Delete);
            this.pnl_updt.Controls.Add(this.cb_editGender);
            this.pnl_updt.Controls.Add(this.txt_editID);
            this.pnl_updt.Controls.Add(this.lbl_14);
            this.pnl_updt.Controls.Add(this.lbl_9);
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
            this.pnl_updt.Controls.Add(this.txt_editWemail);
            this.pnl_updt.Controls.Add(this.txt_editPemail);
            this.pnl_updt.Controls.Add(this.txt_editPcode);
            this.pnl_updt.Controls.Add(this.txt_editCity);
            this.pnl_updt.Controls.Add(this.txt_editAdd2);
            this.pnl_updt.Controls.Add(this.txt_editAdd1);
            this.pnl_updt.Controls.Add(this.txt_editLname);
            this.pnl_updt.Controls.Add(this.txt_editFname);
            this.pnl_updt.Controls.Add(this.btn_Close);
            this.pnl_updt.Controls.Add(this.btn_Update);
            this.pnl_updt.Controls.Add(this.pb_editMember);
            this.pnl_updt.HorizontalScrollbarBarColor = true;
            this.pnl_updt.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_updt.HorizontalScrollbarSize = 10;
            this.pnl_updt.Location = new System.Drawing.Point(242, 33);
            this.pnl_updt.Name = "pnl_updt";
            this.pnl_updt.Size = new System.Drawing.Size(661, 635);
            this.pnl_updt.TabIndex = 16;
            this.pnl_updt.VerticalScrollbarBarColor = true;
            this.pnl_updt.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_updt.VerticalScrollbarSize = 10;
            this.pnl_updt.Visible = false;
            this.pnl_updt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_updt_Paint);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = null;
            this.btn_Delete.Location = new System.Drawing.Point(492, 393);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 33);
            this.btn_Delete.TabIndex = 129;
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
            this.cb_editGender.Location = new System.Drawing.Point(177, 501);
            this.cb_editGender.Name = "cb_editGender";
            this.cb_editGender.Size = new System.Drawing.Size(240, 29);
            this.cb_editGender.TabIndex = 128;
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
            this.txt_editID.Location = new System.Drawing.Point(177, 33);
            this.txt_editID.MaxLength = 32767;
            this.txt_editID.Name = "txt_editID";
            this.txt_editID.PasswordChar = '\0';
            this.txt_editID.PromptText = "Member ID";
            this.txt_editID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editID.SelectedText = "";
            this.txt_editID.SelectionLength = 0;
            this.txt_editID.SelectionStart = 0;
            this.txt_editID.ShortcutsEnabled = true;
            this.txt_editID.Size = new System.Drawing.Size(240, 29);
            this.txt_editID.TabIndex = 127;
            this.txt_editID.UseSelectable = true;
            this.txt_editID.UseStyleColors = true;
            this.txt_editID.WaterMark = "Member ID";
            this.txt_editID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_14
            // 
            this.lbl_14.AutoSize = true;
            this.lbl_14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_14.Location = new System.Drawing.Point(12, 598);
            this.lbl_14.Name = "lbl_14";
            this.lbl_14.Size = new System.Drawing.Size(75, 19);
            this.lbl_14.TabIndex = 126;
            this.lbl_14.Text = "Nationality";
            this.lbl_14.UseStyleColors = true;
            // 
            // lbl_9
            // 
            this.lbl_9.AutoSize = true;
            this.lbl_9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_9.Location = new System.Drawing.Point(12, 383);
            this.lbl_9.Name = "lbl_9";
            this.lbl_9.Size = new System.Drawing.Size(86, 19);
            this.lbl_9.TabIndex = 125;
            this.lbl_9.Text = "eMail (Work)";
            this.lbl_9.UseStyleColors = true;
            // 
            // lbl_10
            // 
            this.lbl_10.AutoSize = true;
            this.lbl_10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_10.Location = new System.Drawing.Point(12, 425);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Size = new System.Drawing.Size(105, 19);
            this.lbl_10.TabIndex = 124;
            this.lbl_10.Text = "Mobile Number";
            this.lbl_10.UseStyleColors = true;
            // 
            // lbl_15
            // 
            this.lbl_15.AutoSize = true;
            this.lbl_15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_15.Location = new System.Drawing.Point(12, 467);
            this.lbl_15.Name = "lbl_15";
            this.lbl_15.Size = new System.Drawing.Size(149, 19);
            this.lbl_15.TabIndex = 123;
            this.lbl_15.Text = "Phone number (Home)";
            this.lbl_15.UseStyleColors = true;
            // 
            // lbl_12
            // 
            this.lbl_12.AutoSize = true;
            this.lbl_12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_12.Location = new System.Drawing.Point(12, 508);
            this.lbl_12.Name = "lbl_12";
            this.lbl_12.Size = new System.Drawing.Size(54, 19);
            this.lbl_12.TabIndex = 122;
            this.lbl_12.Text = "Gender";
            this.lbl_12.UseStyleColors = true;
            // 
            // lbl_13
            // 
            this.lbl_13.AutoSize = true;
            this.lbl_13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_13.Location = new System.Drawing.Point(12, 551);
            this.lbl_13.Name = "lbl_13";
            this.lbl_13.Size = new System.Drawing.Size(60, 19);
            this.lbl_13.TabIndex = 121;
            this.lbl_13.Text = "Birthday";
            this.lbl_13.UseStyleColors = true;
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_6.Location = new System.Drawing.Point(12, 249);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(33, 19);
            this.lbl_6.TabIndex = 120;
            this.lbl_6.Text = "City";
            this.lbl_6.UseStyleColors = true;
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_7.Location = new System.Drawing.Point(12, 293);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(81, 19);
            this.lbl_7.TabIndex = 119;
            this.lbl_7.Text = "Postal Code";
            this.lbl_7.UseStyleColors = true;
            // 
            // lbl_8
            // 
            this.lbl_8.AutoSize = true;
            this.lbl_8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_8.Location = new System.Drawing.Point(12, 337);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(105, 19);
            this.lbl_8.TabIndex = 118;
            this.lbl_8.Text = "eMail (Personal)";
            this.lbl_8.UseStyleColors = true;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_2.Location = new System.Drawing.Point(12, 79);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(75, 19);
            this.lbl_2.TabIndex = 117;
            this.lbl_2.Text = "First Name";
            this.lbl_2.UseStyleColors = true;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_3.Location = new System.Drawing.Point(12, 124);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(74, 19);
            this.lbl_3.TabIndex = 116;
            this.lbl_3.Text = "Last Name";
            this.lbl_3.UseStyleColors = true;
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_4.Location = new System.Drawing.Point(12, 164);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(95, 19);
            this.lbl_4.TabIndex = 115;
            this.lbl_4.Text = "Address line 1";
            this.lbl_4.UseStyleColors = true;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_5.Location = new System.Drawing.Point(12, 206);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(95, 19);
            this.lbl_5.TabIndex = 114;
            this.lbl_5.Text = "Address line 2";
            this.lbl_5.UseStyleColors = true;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_1.Location = new System.Drawing.Point(12, 43);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(23, 19);
            this.lbl_1.TabIndex = 113;
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
            this.txt_editNationality.Location = new System.Drawing.Point(177, 591);
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
            this.txt_editNationality.TabIndex = 112;
            this.txt_editNationality.UseSelectable = true;
            this.txt_editNationality.UseStyleColors = true;
            this.txt_editNationality.WaterMark = "Nationality";
            this.txt_editNationality.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editNationality.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dt_editBirthday
            // 
            this.dt_editBirthday.Location = new System.Drawing.Point(177, 545);
            this.dt_editBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_editBirthday.Name = "dt_editBirthday";
            this.dt_editBirthday.Size = new System.Drawing.Size(240, 29);
            this.dt_editBirthday.TabIndex = 111;
            this.dt_editBirthday.UseStyleColors = true;
            this.dt_editBirthday.ValueChanged += new System.EventHandler(this.dt_mmb_bdy_ValueChanged);
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
            this.txt_editPhoNumber.Location = new System.Drawing.Point(177, 461);
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
            this.txt_editPhoNumber.TabIndex = 108;
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
            this.txt_editMobNumber.Location = new System.Drawing.Point(177, 417);
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
            this.txt_editMobNumber.TabIndex = 107;
            this.txt_editMobNumber.UseSelectable = true;
            this.txt_editMobNumber.UseStyleColors = true;
            this.txt_editMobNumber.WaterMark = "Mobile phone number";
            this.txt_editMobNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editMobNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editWemail
            // 
            // 
            // 
            // 
            this.txt_editWemail.CustomButton.Image = null;
            this.txt_editWemail.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_editWemail.CustomButton.Name = "";
            this.txt_editWemail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editWemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editWemail.CustomButton.TabIndex = 1;
            this.txt_editWemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editWemail.CustomButton.UseSelectable = true;
            this.txt_editWemail.CustomButton.Visible = false;
            this.txt_editWemail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editWemail.Lines = new string[0];
            this.txt_editWemail.Location = new System.Drawing.Point(177, 374);
            this.txt_editWemail.MaxLength = 32767;
            this.txt_editWemail.Name = "txt_editWemail";
            this.txt_editWemail.PasswordChar = '\0';
            this.txt_editWemail.PromptText = "Work email";
            this.txt_editWemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editWemail.SelectedText = "";
            this.txt_editWemail.SelectionLength = 0;
            this.txt_editWemail.SelectionStart = 0;
            this.txt_editWemail.ShortcutsEnabled = true;
            this.txt_editWemail.Size = new System.Drawing.Size(240, 29);
            this.txt_editWemail.TabIndex = 106;
            this.txt_editWemail.UseSelectable = true;
            this.txt_editWemail.UseStyleColors = true;
            this.txt_editWemail.WaterMark = "Work email";
            this.txt_editWemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editWemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_editPemail.Location = new System.Drawing.Point(177, 329);
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
            this.txt_editPemail.TabIndex = 105;
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
            this.txt_editPcode.Location = new System.Drawing.Point(177, 284);
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
            this.txt_editPcode.TabIndex = 104;
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
            this.txt_editCity.Location = new System.Drawing.Point(177, 239);
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
            this.txt_editCity.TabIndex = 103;
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
            this.txt_editAdd2.Location = new System.Drawing.Point(177, 197);
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
            this.txt_editAdd2.TabIndex = 102;
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
            this.txt_editAdd1.Location = new System.Drawing.Point(177, 155);
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
            this.txt_editAdd1.TabIndex = 101;
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
            this.txt_editLname.Location = new System.Drawing.Point(177, 115);
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
            this.txt_editLname.TabIndex = 100;
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
            this.txt_editFname.Location = new System.Drawing.Point(177, 72);
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
            this.txt_editFname.TabIndex = 99;
            this.txt_editFname.UseSelectable = true;
            this.txt_editFname.UseStyleColors = true;
            this.txt_editFname.WaterMark = "First Name";
            this.txt_editFname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = null;
            this.btn_Close.Location = new System.Drawing.Point(492, 441);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(110, 33);
            this.btn_Close.TabIndex = 96;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseSelectable = true;
            this.btn_Close.UseStyleColors = true;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = null;
            this.btn_Update.Location = new System.Drawing.Point(492, 339);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 33);
            this.btn_Update.TabIndex = 97;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseSelectable = true;
            this.btn_Update.UseStyleColors = true;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // pb_editMember
            // 
            this.pb_editMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_editMember.Location = new System.Drawing.Point(438, 33);
            this.pb_editMember.Name = "pb_editMember";
            this.pb_editMember.Size = new System.Drawing.Size(210, 280);
            this.pb_editMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_editMember.TabIndex = 95;
            this.pb_editMember.TabStop = false;
            this.pb_editMember.Tag = "";
            this.pb_editMember.Click += new System.EventHandler(this.pb_editMember_Click);
            // 
            // MembersUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_updt);
            this.Controls.Add(this.pnl_vw);
            this.Controls.Add(this.gridview_Member);
            this.Controls.Add(this.lnk_mmbrs);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "MembersUi";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "MembersUi";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.pnl_vw.ResumeLayout(false);
            this.pnl_vw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_Member)).EndInit();
            this.pnl_updt.ResumeLayout(false);
            this.pnl_updt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnk_mmbrs;
        private MetroFramework.Controls.MetroPanel pnl_vw;
        private MetroFramework.Controls.MetroLabel lbl_memberNationality;
        private MetroFramework.Controls.MetroLabel lbl_memberEmail;
        private MetroFramework.Controls.MetroLabel lbl_memberPnumber;
        private MetroFramework.Controls.MetroLabel lbl_memberGender;
        private MetroFramework.Controls.MetroLabel lbl_memberAdd2;
        private MetroFramework.Controls.MetroLabel lbl_memberAdd1;
        private MetroFramework.Controls.MetroLabel lbl_memberDOB;
        private MetroFramework.Controls.MetroLabel lbl_memberID;
        private MetroFramework.Controls.MetroLabel lbl_memberCity;
        private MetroFramework.Controls.MetroLabel lbl_memberName;
        private System.Windows.Forms.PictureBox pb_viewMember;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_updateForm;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_mDelete;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_newMember;
        private MetroFramework.Controls.MetroGrid gridview_Member;
        private MetroFramework.Controls.MetroPanel pnl_updt;
        private MetroFramework.Controls.MetroLabel lbl_14;
        private MetroFramework.Controls.MetroLabel lbl_9;
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
        private MetroFramework.Controls.MetroTextBox txt_editWemail;
        private MetroFramework.Controls.MetroTextBox txt_editPemail;
        private MetroFramework.Controls.MetroTextBox txt_editPcode;
        private MetroFramework.Controls.MetroTextBox txt_editCity;
        private MetroFramework.Controls.MetroTextBox txt_editAdd2;
        private MetroFramework.Controls.MetroTextBox txt_editAdd1;
        private MetroFramework.Controls.MetroTextBox txt_editLname;
        private MetroFramework.Controls.MetroTextBox txt_editFname;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Close;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Update;
        private System.Windows.Forms.PictureBox pb_editMember;
        private MetroFramework.Controls.MetroTextBox txt_editID;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Delete;
        private MetroFramework.Controls.MetroComboBox cb_editGender;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Refresh;
    }
}