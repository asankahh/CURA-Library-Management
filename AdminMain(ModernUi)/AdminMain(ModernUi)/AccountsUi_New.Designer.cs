namespace AdminMain_ModernUi_
{
    partial class AccountsUi_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsUi_New));
            this.btn_cls = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_sv = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cb_typ = new MetroFramework.Controls.MetroComboBox();
            this.cb_ctgry = new MetroFramework.Controls.MetroComboBox();
            this.txt_dscrptn = new MetroFramework.Controls.MetroTextBox();
            this.txt_amnt = new MetroFramework.Controls.MetroTextBox();
            this.lbl_2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_3 = new MetroFramework.Controls.MetroLabel();
            this.lbl_4 = new MetroFramework.Controls.MetroLabel();
            this.lbl_5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn_cls
            // 
            this.btn_cls.Image = null;
            this.btn_cls.Location = new System.Drawing.Point(385, 560);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(110, 29);
            this.btn_cls.TabIndex = 15;
            this.btn_cls.Text = "Close";
            this.btn_cls.UseSelectable = true;
            this.btn_cls.UseStyleColors = true;
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_sv
            // 
            this.btn_sv.Image = null;
            this.btn_sv.Location = new System.Drawing.Point(520, 560);
            this.btn_sv.Name = "btn_sv";
            this.btn_sv.Size = new System.Drawing.Size(110, 29);
            this.btn_sv.TabIndex = 16;
            this.btn_sv.Text = "Save";
            this.btn_sv.UseSelectable = true;
            this.btn_sv.UseStyleColors = true;
            this.btn_sv.UseVisualStyleBackColor = true;
            this.btn_sv.Click += new System.EventHandler(this.btn_sv_Click);
            // 
            // cb_typ
            // 
            this.cb_typ.FormattingEnabled = true;
            this.cb_typ.ItemHeight = 23;
            this.cb_typ.Items.AddRange(new object[] {
            "Income",
            "Expence"});
            this.cb_typ.Location = new System.Drawing.Point(229, 88);
            this.cb_typ.Name = "cb_typ";
            this.cb_typ.Size = new System.Drawing.Size(200, 29);
            this.cb_typ.TabIndex = 18;
            this.cb_typ.UseSelectable = true;
            this.cb_typ.UseStyleColors = true;
            // 
            // cb_ctgry
            // 
            this.cb_ctgry.FormattingEnabled = true;
            this.cb_ctgry.ItemHeight = 23;
            this.cb_ctgry.Items.AddRange(new object[] {
            "Fine",
            "Member Fee",
            "Donation",
            "Photocopy ",
            "-------------------",
            "Maintenance",
            "Purchases",
            "Repairs"});
            this.cb_ctgry.Location = new System.Drawing.Point(229, 143);
            this.cb_ctgry.Name = "cb_ctgry";
            this.cb_ctgry.Size = new System.Drawing.Size(200, 29);
            this.cb_ctgry.TabIndex = 19;
            this.cb_ctgry.UseSelectable = true;
            this.cb_ctgry.UseStyleColors = true;
            // 
            // txt_dscrptn
            // 
            // 
            // 
            // 
            this.txt_dscrptn.CustomButton.Image = null;
            this.txt_dscrptn.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txt_dscrptn.CustomButton.Name = "";
            this.txt_dscrptn.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.txt_dscrptn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dscrptn.CustomButton.TabIndex = 1;
            this.txt_dscrptn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dscrptn.CustomButton.UseSelectable = true;
            this.txt_dscrptn.CustomButton.Visible = false;
            this.txt_dscrptn.Lines = new string[0];
            this.txt_dscrptn.Location = new System.Drawing.Point(229, 200);
            this.txt_dscrptn.MaxLength = 32767;
            this.txt_dscrptn.Multiline = true;
            this.txt_dscrptn.Name = "txt_dscrptn";
            this.txt_dscrptn.PasswordChar = '\0';
            this.txt_dscrptn.PromptText = "Description";
            this.txt_dscrptn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dscrptn.SelectedText = "";
            this.txt_dscrptn.SelectionLength = 0;
            this.txt_dscrptn.SelectionStart = 0;
            this.txt_dscrptn.ShortcutsEnabled = true;
            this.txt_dscrptn.Size = new System.Drawing.Size(200, 67);
            this.txt_dscrptn.TabIndex = 20;
            this.txt_dscrptn.UseSelectable = true;
            this.txt_dscrptn.WaterMark = "Description";
            this.txt_dscrptn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dscrptn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_amnt
            // 
            // 
            // 
            // 
            this.txt_amnt.CustomButton.Image = null;
            this.txt_amnt.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_amnt.CustomButton.Name = "";
            this.txt_amnt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_amnt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amnt.CustomButton.TabIndex = 1;
            this.txt_amnt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amnt.CustomButton.UseSelectable = true;
            this.txt_amnt.CustomButton.Visible = false;
            this.txt_amnt.Lines = new string[0];
            this.txt_amnt.Location = new System.Drawing.Point(229, 298);
            this.txt_amnt.MaxLength = 32767;
            this.txt_amnt.Name = "txt_amnt";
            this.txt_amnt.PasswordChar = '\0';
            this.txt_amnt.PromptText = "Format 89.00";
            this.txt_amnt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amnt.SelectedText = "";
            this.txt_amnt.SelectionLength = 0;
            this.txt_amnt.SelectionStart = 0;
            this.txt_amnt.ShortcutsEnabled = true;
            this.txt_amnt.Size = new System.Drawing.Size(200, 29);
            this.txt_amnt.TabIndex = 21;
            this.txt_amnt.UseSelectable = true;
            this.txt_amnt.WaterMark = "Format 89.00";
            this.txt_amnt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amnt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(76, 88);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(36, 19);
            this.lbl_2.TabIndex = 23;
            this.lbl_2.Text = "Type";
            this.lbl_2.UseStyleColors = true;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(76, 143);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(64, 19);
            this.lbl_3.TabIndex = 24;
            this.lbl_3.Text = "Category";
            this.lbl_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_3.UseStyleColors = true;
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Location = new System.Drawing.Point(76, 200);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(74, 19);
            this.lbl_4.TabIndex = 25;
            this.lbl_4.Text = "Description";
            this.lbl_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_4.UseStyleColors = true;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Location = new System.Drawing.Point(76, 298);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(56, 19);
            this.lbl_5.TabIndex = 26;
            this.lbl_5.Text = "Amount";
            this.lbl_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_5.UseStyleColors = true;
            // 
            // AccountsUi_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 675);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.txt_amnt);
            this.Controls.Add(this.txt_dscrptn);
            this.Controls.Add(this.cb_ctgry);
            this.Controls.Add(this.cb_typ);
            this.Controls.Add(this.btn_sv);
            this.Controls.Add(this.btn_cls);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "AccountsUi_New";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AccountsUi_New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_cls;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_sv;
        private MetroFramework.Controls.MetroComboBox cb_typ;
        private MetroFramework.Controls.MetroComboBox cb_ctgry;
        private MetroFramework.Controls.MetroTextBox txt_dscrptn;
        private MetroFramework.Controls.MetroTextBox txt_amnt;
        private MetroFramework.Controls.MetroLabel lbl_2;
        private MetroFramework.Controls.MetroLabel lbl_3;
        private MetroFramework.Controls.MetroLabel lbl_4;
        private MetroFramework.Controls.MetroLabel lbl_5;
    }
}