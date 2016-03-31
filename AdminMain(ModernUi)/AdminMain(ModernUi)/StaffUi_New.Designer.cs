namespace AdminMain_ModernUi_
{
    partial class StaffUi_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffUi_New));
            this.btn_Save = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_Close = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_Clear = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pb_insertStaff = new System.Windows.Forms.PictureBox();
            this.cb_Gender = new MetroFramework.Controls.MetroComboBox();
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
            this.txt_Nationality = new MetroFramework.Controls.MetroTextBox();
            this.dt_Birthday = new MetroFramework.Controls.MetroDateTime();
            this.txt_PhoNumber = new MetroFramework.Controls.MetroTextBox();
            this.txt_MobNumber = new MetroFramework.Controls.MetroTextBox();
            this.txt_Pemail = new MetroFramework.Controls.MetroTextBox();
            this.txt_Pcode = new MetroFramework.Controls.MetroTextBox();
            this.txt_City = new MetroFramework.Controls.MetroTextBox();
            this.txt_Add2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_Add1 = new MetroFramework.Controls.MetroTextBox();
            this.txt_Lname = new MetroFramework.Controls.MetroTextBox();
            this.txt_Fname = new MetroFramework.Controls.MetroTextBox();
            this.txt_ID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_Uname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_Pwrd = new MetroFramework.Controls.MetroTextBox();
            this.btn_pwgen = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cb_cat = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_ungen = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.print = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_insertStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Image = null;
            this.btn_Save.Location = new System.Drawing.Point(503, 340);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 29);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseSelectable = true;
            this.btn_Save.UseStyleColors = true;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = null;
            this.btn_Close.Location = new System.Drawing.Point(503, 440);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(110, 29);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseSelectable = true;
            this.btn_Close.UseStyleColors = true;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = null;
            this.btn_Clear.Location = new System.Drawing.Point(503, 390);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 29);
            this.btn_Clear.TabIndex = 31;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseSelectable = true;
            this.btn_Clear.UseStyleColors = true;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // pb_insertStaff
            // 
            this.pb_insertStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_insertStaff.Image = global::AdminMain_ModernUi_.Properties.Resources.picssss;
            this.pb_insertStaff.Location = new System.Drawing.Point(449, 34);
            this.pb_insertStaff.Name = "pb_insertStaff";
            this.pb_insertStaff.Size = new System.Drawing.Size(210, 280);
            this.pb_insertStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_insertStaff.TabIndex = 0;
            this.pb_insertStaff.TabStop = false;
            this.pb_insertStaff.Tag = "";
            this.pb_insertStaff.Click += new System.EventHandler(this.pb_stfusrimg_Click);
            // 
            // cb_Gender
            // 
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.ItemHeight = 23;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_Gender.Location = new System.Drawing.Point(183, 504);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(240, 29);
            this.cb_Gender.TabIndex = 182;
            this.cb_Gender.UseSelectable = true;
            this.cb_Gender.UseStyleColors = true;
            // 
            // lbl_14
            // 
            this.lbl_14.AutoSize = true;
            this.lbl_14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_14.Location = new System.Drawing.Point(18, 581);
            this.lbl_14.Name = "lbl_14";
            this.lbl_14.Size = new System.Drawing.Size(75, 19);
            this.lbl_14.TabIndex = 180;
            this.lbl_14.Text = "Nationality";
            this.lbl_14.UseStyleColors = true;
            // 
            // lbl_10
            // 
            this.lbl_10.AutoSize = true;
            this.lbl_10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_10.Location = new System.Drawing.Point(18, 437);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Size = new System.Drawing.Size(105, 19);
            this.lbl_10.TabIndex = 179;
            this.lbl_10.Text = "Mobile Number";
            this.lbl_10.UseStyleColors = true;
            // 
            // lbl_15
            // 
            this.lbl_15.AutoSize = true;
            this.lbl_15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_15.Location = new System.Drawing.Point(18, 473);
            this.lbl_15.Name = "lbl_15";
            this.lbl_15.Size = new System.Drawing.Size(149, 19);
            this.lbl_15.TabIndex = 178;
            this.lbl_15.Text = "Phone number (Home)";
            this.lbl_15.UseStyleColors = true;
            // 
            // lbl_12
            // 
            this.lbl_12.AutoSize = true;
            this.lbl_12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_12.Location = new System.Drawing.Point(18, 510);
            this.lbl_12.Name = "lbl_12";
            this.lbl_12.Size = new System.Drawing.Size(54, 19);
            this.lbl_12.TabIndex = 177;
            this.lbl_12.Text = "Gender";
            this.lbl_12.UseStyleColors = true;
            // 
            // lbl_13
            // 
            this.lbl_13.AutoSize = true;
            this.lbl_13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_13.Location = new System.Drawing.Point(18, 545);
            this.lbl_13.Name = "lbl_13";
            this.lbl_13.Size = new System.Drawing.Size(60, 19);
            this.lbl_13.TabIndex = 176;
            this.lbl_13.Text = "Birthday";
            this.lbl_13.UseStyleColors = true;
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_6.Location = new System.Drawing.Point(18, 323);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(33, 19);
            this.lbl_6.TabIndex = 175;
            this.lbl_6.Text = "City";
            this.lbl_6.UseStyleColors = true;
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_7.Location = new System.Drawing.Point(18, 361);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(81, 19);
            this.lbl_7.TabIndex = 174;
            this.lbl_7.Text = "Postal Code";
            this.lbl_7.UseStyleColors = true;
            // 
            // lbl_8
            // 
            this.lbl_8.AutoSize = true;
            this.lbl_8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_8.Location = new System.Drawing.Point(18, 398);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(105, 19);
            this.lbl_8.TabIndex = 173;
            this.lbl_8.Text = "eMail (Personal)";
            this.lbl_8.UseStyleColors = true;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_2.Location = new System.Drawing.Point(18, 76);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(75, 19);
            this.lbl_2.TabIndex = 172;
            this.lbl_2.Text = "First Name";
            this.lbl_2.UseStyleColors = true;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_3.Location = new System.Drawing.Point(18, 109);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(74, 19);
            this.lbl_3.TabIndex = 171;
            this.lbl_3.Text = "Last Name";
            this.lbl_3.UseStyleColors = true;
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_4.Location = new System.Drawing.Point(18, 251);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(95, 19);
            this.lbl_4.TabIndex = 170;
            this.lbl_4.Text = "Address line 1";
            this.lbl_4.UseStyleColors = true;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_5.Location = new System.Drawing.Point(18, 288);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(95, 19);
            this.lbl_5.TabIndex = 169;
            this.lbl_5.Text = "Address line 2";
            this.lbl_5.UseStyleColors = true;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_1.Location = new System.Drawing.Point(18, 43);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(23, 19);
            this.lbl_1.TabIndex = 168;
            this.lbl_1.Text = "ID";
            this.lbl_1.UseStyleColors = true;
            // 
            // txt_Nationality
            // 
            // 
            // 
            // 
            this.txt_Nationality.CustomButton.Image = null;
            this.txt_Nationality.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_Nationality.CustomButton.Name = "";
            this.txt_Nationality.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Nationality.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Nationality.CustomButton.TabIndex = 1;
            this.txt_Nationality.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Nationality.CustomButton.UseSelectable = true;
            this.txt_Nationality.CustomButton.Visible = false;
            this.txt_Nationality.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Nationality.Lines = new string[0];
            this.txt_Nationality.Location = new System.Drawing.Point(183, 576);
            this.txt_Nationality.MaxLength = 32767;
            this.txt_Nationality.Name = "txt_Nationality";
            this.txt_Nationality.PasswordChar = '\0';
            this.txt_Nationality.PromptText = "Nationality";
            this.txt_Nationality.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Nationality.SelectedText = "";
            this.txt_Nationality.SelectionLength = 0;
            this.txt_Nationality.SelectionStart = 0;
            this.txt_Nationality.ShortcutsEnabled = true;
            this.txt_Nationality.Size = new System.Drawing.Size(240, 29);
            this.txt_Nationality.TabIndex = 167;
            this.txt_Nationality.UseSelectable = true;
            this.txt_Nationality.UseStyleColors = true;
            this.txt_Nationality.WaterMark = "Nationality";
            this.txt_Nationality.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Nationality.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dt_Birthday
            // 
            this.dt_Birthday.Location = new System.Drawing.Point(183, 540);
            this.dt_Birthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_Birthday.Name = "dt_Birthday";
            this.dt_Birthday.Size = new System.Drawing.Size(240, 29);
            this.dt_Birthday.TabIndex = 166;
            this.dt_Birthday.UseStyleColors = true;
            // 
            // txt_PhoNumber
            // 
            // 
            // 
            // 
            this.txt_PhoNumber.CustomButton.Image = null;
            this.txt_PhoNumber.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_PhoNumber.CustomButton.Name = "";
            this.txt_PhoNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_PhoNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PhoNumber.CustomButton.TabIndex = 1;
            this.txt_PhoNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PhoNumber.CustomButton.UseSelectable = true;
            this.txt_PhoNumber.CustomButton.Visible = false;
            this.txt_PhoNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_PhoNumber.Lines = new string[0];
            this.txt_PhoNumber.Location = new System.Drawing.Point(183, 468);
            this.txt_PhoNumber.MaxLength = 10;
            this.txt_PhoNumber.Name = "txt_PhoNumber";
            this.txt_PhoNumber.PasswordChar = '\0';
            this.txt_PhoNumber.PromptText = "Home phone number";
            this.txt_PhoNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PhoNumber.SelectedText = "";
            this.txt_PhoNumber.SelectionLength = 0;
            this.txt_PhoNumber.SelectionStart = 0;
            this.txt_PhoNumber.ShortcutsEnabled = true;
            this.txt_PhoNumber.Size = new System.Drawing.Size(240, 29);
            this.txt_PhoNumber.TabIndex = 165;
            this.txt_PhoNumber.UseSelectable = true;
            this.txt_PhoNumber.UseStyleColors = true;
            this.txt_PhoNumber.WaterMark = "Home phone number";
            this.txt_PhoNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PhoNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_PhoNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PhoNumber_KeyPress);
            // 
            // txt_MobNumber
            // 
            // 
            // 
            // 
            this.txt_MobNumber.CustomButton.Image = null;
            this.txt_MobNumber.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_MobNumber.CustomButton.Name = "";
            this.txt_MobNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_MobNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_MobNumber.CustomButton.TabIndex = 1;
            this.txt_MobNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_MobNumber.CustomButton.UseSelectable = true;
            this.txt_MobNumber.CustomButton.Visible = false;
            this.txt_MobNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_MobNumber.Lines = new string[0];
            this.txt_MobNumber.Location = new System.Drawing.Point(183, 432);
            this.txt_MobNumber.MaxLength = 10;
            this.txt_MobNumber.Name = "txt_MobNumber";
            this.txt_MobNumber.PasswordChar = '\0';
            this.txt_MobNumber.PromptText = "Mobile phone number";
            this.txt_MobNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MobNumber.SelectedText = "";
            this.txt_MobNumber.SelectionLength = 0;
            this.txt_MobNumber.SelectionStart = 0;
            this.txt_MobNumber.ShortcutsEnabled = true;
            this.txt_MobNumber.Size = new System.Drawing.Size(240, 29);
            this.txt_MobNumber.TabIndex = 164;
            this.txt_MobNumber.UseSelectable = true;
            this.txt_MobNumber.UseStyleColors = true;
            this.txt_MobNumber.WaterMark = "Mobile phone number";
            this.txt_MobNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_MobNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_MobNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MobNumber_KeyPress);
            // 
            // txt_Pemail
            // 
            // 
            // 
            // 
            this.txt_Pemail.CustomButton.Image = null;
            this.txt_Pemail.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_Pemail.CustomButton.Name = "";
            this.txt_Pemail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Pemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Pemail.CustomButton.TabIndex = 1;
            this.txt_Pemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Pemail.CustomButton.UseSelectable = true;
            this.txt_Pemail.CustomButton.Visible = false;
            this.txt_Pemail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Pemail.Lines = new string[0];
            this.txt_Pemail.Location = new System.Drawing.Point(183, 394);
            this.txt_Pemail.MaxLength = 32767;
            this.txt_Pemail.Name = "txt_Pemail";
            this.txt_Pemail.PasswordChar = '\0';
            this.txt_Pemail.PromptText = "Personal email";
            this.txt_Pemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Pemail.SelectedText = "";
            this.txt_Pemail.SelectionLength = 0;
            this.txt_Pemail.SelectionStart = 0;
            this.txt_Pemail.ShortcutsEnabled = true;
            this.txt_Pemail.Size = new System.Drawing.Size(240, 29);
            this.txt_Pemail.TabIndex = 163;
            this.txt_Pemail.UseSelectable = true;
            this.txt_Pemail.UseStyleColors = true;
            this.txt_Pemail.WaterMark = "Personal email";
            this.txt_Pemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Pemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Pcode
            // 
            // 
            // 
            // 
            this.txt_Pcode.CustomButton.Image = null;
            this.txt_Pcode.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_Pcode.CustomButton.Name = "";
            this.txt_Pcode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Pcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Pcode.CustomButton.TabIndex = 1;
            this.txt_Pcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Pcode.CustomButton.UseSelectable = true;
            this.txt_Pcode.CustomButton.Visible = false;
            this.txt_Pcode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Pcode.Lines = new string[0];
            this.txt_Pcode.Location = new System.Drawing.Point(183, 357);
            this.txt_Pcode.MaxLength = 8;
            this.txt_Pcode.Name = "txt_Pcode";
            this.txt_Pcode.PasswordChar = '\0';
            this.txt_Pcode.PromptText = "Postal Code or ZIP";
            this.txt_Pcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Pcode.SelectedText = "";
            this.txt_Pcode.SelectionLength = 0;
            this.txt_Pcode.SelectionStart = 0;
            this.txt_Pcode.ShortcutsEnabled = true;
            this.txt_Pcode.Size = new System.Drawing.Size(240, 29);
            this.txt_Pcode.TabIndex = 162;
            this.txt_Pcode.UseSelectable = true;
            this.txt_Pcode.UseStyleColors = true;
            this.txt_Pcode.WaterMark = "Postal Code or ZIP";
            this.txt_Pcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Pcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_City
            // 
            // 
            // 
            // 
            this.txt_City.CustomButton.Image = null;
            this.txt_City.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_City.CustomButton.Name = "";
            this.txt_City.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_City.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_City.CustomButton.TabIndex = 1;
            this.txt_City.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_City.CustomButton.UseSelectable = true;
            this.txt_City.CustomButton.Visible = false;
            this.txt_City.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_City.Lines = new string[0];
            this.txt_City.Location = new System.Drawing.Point(183, 320);
            this.txt_City.MaxLength = 32767;
            this.txt_City.Name = "txt_City";
            this.txt_City.PasswordChar = '\0';
            this.txt_City.PromptText = "City";
            this.txt_City.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_City.SelectedText = "";
            this.txt_City.SelectionLength = 0;
            this.txt_City.SelectionStart = 0;
            this.txt_City.ShortcutsEnabled = true;
            this.txt_City.Size = new System.Drawing.Size(240, 29);
            this.txt_City.TabIndex = 161;
            this.txt_City.UseSelectable = true;
            this.txt_City.UseStyleColors = true;
            this.txt_City.WaterMark = "City";
            this.txt_City.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_City.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Add2
            // 
            // 
            // 
            // 
            this.txt_Add2.CustomButton.Image = null;
            this.txt_Add2.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_Add2.CustomButton.Name = "";
            this.txt_Add2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Add2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Add2.CustomButton.TabIndex = 1;
            this.txt_Add2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Add2.CustomButton.UseSelectable = true;
            this.txt_Add2.CustomButton.Visible = false;
            this.txt_Add2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Add2.Lines = new string[0];
            this.txt_Add2.Location = new System.Drawing.Point(183, 283);
            this.txt_Add2.MaxLength = 50;
            this.txt_Add2.Name = "txt_Add2";
            this.txt_Add2.PasswordChar = '\0';
            this.txt_Add2.PromptText = "Address line 2";
            this.txt_Add2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Add2.SelectedText = "";
            this.txt_Add2.SelectionLength = 0;
            this.txt_Add2.SelectionStart = 0;
            this.txt_Add2.ShortcutsEnabled = true;
            this.txt_Add2.Size = new System.Drawing.Size(240, 29);
            this.txt_Add2.TabIndex = 160;
            this.txt_Add2.UseSelectable = true;
            this.txt_Add2.UseStyleColors = true;
            this.txt_Add2.WaterMark = "Address line 2";
            this.txt_Add2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Add2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Add1
            // 
            // 
            // 
            // 
            this.txt_Add1.CustomButton.Image = null;
            this.txt_Add1.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_Add1.CustomButton.Name = "";
            this.txt_Add1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Add1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Add1.CustomButton.TabIndex = 1;
            this.txt_Add1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Add1.CustomButton.UseSelectable = true;
            this.txt_Add1.CustomButton.Visible = false;
            this.txt_Add1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Add1.Lines = new string[0];
            this.txt_Add1.Location = new System.Drawing.Point(183, 246);
            this.txt_Add1.MaxLength = 50;
            this.txt_Add1.Name = "txt_Add1";
            this.txt_Add1.PasswordChar = '\0';
            this.txt_Add1.PromptText = "Address line 1";
            this.txt_Add1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Add1.SelectedText = "";
            this.txt_Add1.SelectionLength = 0;
            this.txt_Add1.SelectionStart = 0;
            this.txt_Add1.ShortcutsEnabled = true;
            this.txt_Add1.Size = new System.Drawing.Size(240, 29);
            this.txt_Add1.TabIndex = 159;
            this.txt_Add1.UseSelectable = true;
            this.txt_Add1.UseStyleColors = true;
            this.txt_Add1.WaterMark = "Address line 1";
            this.txt_Add1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Add1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Lname
            // 
            // 
            // 
            // 
            this.txt_Lname.CustomButton.Image = null;
            this.txt_Lname.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_Lname.CustomButton.Name = "";
            this.txt_Lname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Lname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Lname.CustomButton.TabIndex = 1;
            this.txt_Lname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Lname.CustomButton.UseSelectable = true;
            this.txt_Lname.CustomButton.Visible = false;
            this.txt_Lname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Lname.Lines = new string[0];
            this.txt_Lname.Location = new System.Drawing.Point(183, 105);
            this.txt_Lname.MaxLength = 32767;
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.PasswordChar = '\0';
            this.txt_Lname.PromptText = "Last name or Surname";
            this.txt_Lname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Lname.SelectedText = "";
            this.txt_Lname.SelectionLength = 0;
            this.txt_Lname.SelectionStart = 0;
            this.txt_Lname.ShortcutsEnabled = true;
            this.txt_Lname.Size = new System.Drawing.Size(240, 29);
            this.txt_Lname.TabIndex = 158;
            this.txt_Lname.UseSelectable = true;
            this.txt_Lname.UseStyleColors = true;
            this.txt_Lname.WaterMark = "Last name or Surname";
            this.txt_Lname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Lname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Fname
            // 
            // 
            // 
            // 
            this.txt_Fname.CustomButton.Image = null;
            this.txt_Fname.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_Fname.CustomButton.Name = "";
            this.txt_Fname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Fname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Fname.CustomButton.TabIndex = 1;
            this.txt_Fname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Fname.CustomButton.UseSelectable = true;
            this.txt_Fname.CustomButton.Visible = false;
            this.txt_Fname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Fname.Lines = new string[0];
            this.txt_Fname.Location = new System.Drawing.Point(183, 70);
            this.txt_Fname.MaxLength = 32767;
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.PasswordChar = '\0';
            this.txt_Fname.PromptText = "First Name";
            this.txt_Fname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Fname.SelectedText = "";
            this.txt_Fname.SelectionLength = 0;
            this.txt_Fname.SelectionStart = 0;
            this.txt_Fname.ShortcutsEnabled = true;
            this.txt_Fname.Size = new System.Drawing.Size(240, 29);
            this.txt_Fname.TabIndex = 157;
            this.txt_Fname.UseSelectable = true;
            this.txt_Fname.UseStyleColors = true;
            this.txt_Fname.WaterMark = "First Name";
            this.txt_Fname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Fname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ID
            // 
            // 
            // 
            // 
            this.txt_ID.CustomButton.Image = null;
            this.txt_ID.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txt_ID.CustomButton.Name = "";
            this.txt_ID.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ID.CustomButton.TabIndex = 1;
            this.txt_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ID.CustomButton.UseSelectable = true;
            this.txt_ID.CustomButton.Visible = false;
            this.txt_ID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_ID.Lines = new string[0];
            this.txt_ID.Location = new System.Drawing.Point(183, 36);
            this.txt_ID.MaxLength = 32767;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PasswordChar = '\0';
            this.txt_ID.PromptText = "Staff Name";
            this.txt_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ID.SelectedText = "";
            this.txt_ID.SelectionLength = 0;
            this.txt_ID.SelectionStart = 0;
            this.txt_ID.ShortcutsEnabled = true;
            this.txt_ID.Size = new System.Drawing.Size(240, 29);
            this.txt_ID.TabIndex = 183;
            this.txt_ID.UseSelectable = true;
            this.txt_ID.UseStyleColors = true;
            this.txt_ID.WaterMark = "Staff Name";
            this.txt_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(18, 145);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 185;
            this.metroLabel1.Text = "User Name";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txt_Uname
            // 
            // 
            // 
            // 
            this.txt_Uname.CustomButton.Image = null;
            this.txt_Uname.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txt_Uname.CustomButton.Name = "";
            this.txt_Uname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Uname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Uname.CustomButton.TabIndex = 1;
            this.txt_Uname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Uname.CustomButton.UseSelectable = true;
            this.txt_Uname.CustomButton.Visible = false;
            this.txt_Uname.Enabled = false;
            this.txt_Uname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Uname.Lines = new string[0];
            this.txt_Uname.Location = new System.Drawing.Point(183, 141);
            this.txt_Uname.MaxLength = 32767;
            this.txt_Uname.Name = "txt_Uname";
            this.txt_Uname.PasswordChar = '\0';
            this.txt_Uname.PromptText = "Username";
            this.txt_Uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Uname.SelectedText = "";
            this.txt_Uname.SelectionLength = 0;
            this.txt_Uname.SelectionStart = 0;
            this.txt_Uname.ShortcutsEnabled = true;
            this.txt_Uname.Size = new System.Drawing.Size(157, 29);
            this.txt_Uname.TabIndex = 184;
            this.txt_Uname.UseSelectable = true;
            this.txt_Uname.UseStyleColors = true;
            this.txt_Uname.WaterMark = "Username";
            this.txt_Uname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Uname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(18, 180);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 187;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txt_Pwrd
            // 
            // 
            // 
            // 
            this.txt_Pwrd.CustomButton.Image = null;
            this.txt_Pwrd.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txt_Pwrd.CustomButton.Name = "";
            this.txt_Pwrd.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Pwrd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Pwrd.CustomButton.TabIndex = 1;
            this.txt_Pwrd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Pwrd.CustomButton.UseSelectable = true;
            this.txt_Pwrd.CustomButton.Visible = false;
            this.txt_Pwrd.Enabled = false;
            this.txt_Pwrd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Pwrd.Lines = new string[0];
            this.txt_Pwrd.Location = new System.Drawing.Point(183, 176);
            this.txt_Pwrd.MaxLength = 8;
            this.txt_Pwrd.Name = "txt_Pwrd";
            this.txt_Pwrd.PasswordChar = '\0';
            this.txt_Pwrd.PromptText = "Click on Generate";
            this.txt_Pwrd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Pwrd.SelectedText = "";
            this.txt_Pwrd.SelectionLength = 0;
            this.txt_Pwrd.SelectionStart = 0;
            this.txt_Pwrd.ShortcutsEnabled = true;
            this.txt_Pwrd.Size = new System.Drawing.Size(157, 29);
            this.txt_Pwrd.TabIndex = 186;
            this.txt_Pwrd.UseSelectable = true;
            this.txt_Pwrd.UseStyleColors = true;
            this.txt_Pwrd.WaterMark = "Click on Generate";
            this.txt_Pwrd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Pwrd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_pwgen
            // 
            this.btn_pwgen.Image = null;
            this.btn_pwgen.Location = new System.Drawing.Point(346, 176);
            this.btn_pwgen.Name = "btn_pwgen";
            this.btn_pwgen.Size = new System.Drawing.Size(77, 29);
            this.btn_pwgen.TabIndex = 188;
            this.btn_pwgen.Text = "Generate";
            this.btn_pwgen.UseSelectable = true;
            this.btn_pwgen.UseStyleColors = true;
            this.btn_pwgen.UseVisualStyleBackColor = true;
            this.btn_pwgen.Click += new System.EventHandler(this.btn_pwgen_Click);
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.ItemHeight = 23;
            this.cb_cat.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cb_cat.Location = new System.Drawing.Point(183, 211);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(240, 29);
            this.cb_cat.TabIndex = 190;
            this.cb_cat.UseSelectable = true;
            this.cb_cat.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(18, 217);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 189;
            this.metroLabel3.Text = "Category";
            this.metroLabel3.UseStyleColors = true;
            // 
            // btn_ungen
            // 
            this.btn_ungen.Image = null;
            this.btn_ungen.Location = new System.Drawing.Point(346, 140);
            this.btn_ungen.Name = "btn_ungen";
            this.btn_ungen.Size = new System.Drawing.Size(77, 29);
            this.btn_ungen.TabIndex = 191;
            this.btn_ungen.Text = "Generate";
            this.btn_ungen.UseSelectable = true;
            this.btn_ungen.UseStyleColors = true;
            this.btn_ungen.UseVisualStyleBackColor = true;
            this.btn_ungen.Click += new System.EventHandler(this.btn_ungen_Click);
            // 
            // print
            // 
            this.print.Image = null;
            this.print.Location = new System.Drawing.Point(523, 571);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(110, 29);
            this.print.TabIndex = 192;
            this.print.Text = "print";
            this.print.UseSelectable = true;
            this.print.UseStyleColors = true;
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // StaffUi_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 636);
            this.ControlBox = false;
            this.Controls.Add(this.print);
            this.Controls.Add(this.btn_ungen);
            this.Controls.Add(this.cb_cat);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btn_pwgen);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_Pwrd);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_Uname);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.lbl_14);
            this.Controls.Add(this.lbl_10);
            this.Controls.Add(this.lbl_15);
            this.Controls.Add(this.lbl_12);
            this.Controls.Add(this.lbl_13);
            this.Controls.Add(this.lbl_6);
            this.Controls.Add(this.lbl_7);
            this.Controls.Add(this.lbl_8);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.txt_Nationality);
            this.Controls.Add(this.dt_Birthday);
            this.Controls.Add(this.txt_PhoNumber);
            this.Controls.Add(this.txt_MobNumber);
            this.Controls.Add(this.txt_Pemail);
            this.Controls.Add(this.txt_Pcode);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Add2);
            this.Controls.Add(this.txt_Add1);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pb_insertStaff);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffUi_New";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StaffUi_New";
            ((System.ComponentModel.ISupportInitialize)(this.pb_insertStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_insertStaff;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Save;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Close;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Clear;
        private MetroFramework.Controls.MetroComboBox cb_Gender;
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
        private MetroFramework.Controls.MetroTextBox txt_Nationality;
        private MetroFramework.Controls.MetroDateTime dt_Birthday;
        private MetroFramework.Controls.MetroTextBox txt_PhoNumber;
        private MetroFramework.Controls.MetroTextBox txt_MobNumber;
        private MetroFramework.Controls.MetroTextBox txt_Pemail;
        private MetroFramework.Controls.MetroTextBox txt_Pcode;
        private MetroFramework.Controls.MetroTextBox txt_City;
        private MetroFramework.Controls.MetroTextBox txt_Add2;
        private MetroFramework.Controls.MetroTextBox txt_Add1;
        private MetroFramework.Controls.MetroTextBox txt_Lname;
        private MetroFramework.Controls.MetroTextBox txt_Fname;
        private MetroFramework.Controls.MetroTextBox txt_ID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_Uname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_Pwrd;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_pwgen;
        private MetroFramework.Controls.MetroComboBox cb_cat;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_ungen;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton print;
    }
}