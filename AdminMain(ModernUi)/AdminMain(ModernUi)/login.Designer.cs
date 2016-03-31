namespace AdminMain_ModernUi_
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lbl_lgn = new MetroFramework.Controls.MetroLabel();
            this.lbl_usrnm = new MetroFramework.Controls.MetroLabel();
            this.txt_un = new MetroFramework.Controls.MetroTextBox();
            this.lbl_pw = new MetroFramework.Controls.MetroLabel();
            this.txt_pw = new MetroFramework.Controls.MetroTextBox();
            this.btn_lgn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_ext = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbl_lgn
            // 
            this.lbl_lgn.AutoSize = true;
            this.lbl_lgn.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_lgn.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_lgn.Location = new System.Drawing.Point(252, 57);
            this.lbl_lgn.Name = "lbl_lgn";
            this.lbl_lgn.Size = new System.Drawing.Size(71, 25);
            this.lbl_lgn.TabIndex = 0;
            this.lbl_lgn.Text = "Sign In";
            this.lbl_lgn.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_usrnm
            // 
            this.lbl_usrnm.AutoSize = true;
            this.lbl_usrnm.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_usrnm.Location = new System.Drawing.Point(165, 131);
            this.lbl_usrnm.Name = "lbl_usrnm";
            this.lbl_usrnm.Size = new System.Drawing.Size(97, 25);
            this.lbl_usrnm.TabIndex = 1;
            this.lbl_usrnm.Text = "User Name";
            this.lbl_usrnm.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_un
            // 
            // 
            // 
            // 
            this.txt_un.CustomButton.Image = null;
            this.txt_un.CustomButton.Location = new System.Drawing.Point(211, 2);
            this.txt_un.CustomButton.Name = "";
            this.txt_un.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_un.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_un.CustomButton.TabIndex = 1;
            this.txt_un.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_un.CustomButton.UseSelectable = true;
            this.txt_un.CustomButton.Visible = false;
            this.txt_un.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_un.Lines = new string[0];
            this.txt_un.Location = new System.Drawing.Point(320, 126);
            this.txt_un.MaxLength = 32767;
            this.txt_un.Name = "txt_un";
            this.txt_un.PasswordChar = '\0';
            this.txt_un.PromptText = "Type given Username";
            this.txt_un.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_un.SelectedText = "";
            this.txt_un.SelectionLength = 0;
            this.txt_un.SelectionStart = 0;
            this.txt_un.ShortcutsEnabled = true;
            this.txt_un.Size = new System.Drawing.Size(239, 30);
            this.txt_un.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_un.TabIndex = 2;
            this.txt_un.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_un.UseSelectable = true;
            this.txt_un.WaterMark = "Type given Username";
            this.txt_un.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_un.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_pw.Location = new System.Drawing.Point(165, 174);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(82, 25);
            this.lbl_pw.TabIndex = 3;
            this.lbl_pw.Text = "Password";
            this.lbl_pw.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_pw
            // 
            // 
            // 
            // 
            this.txt_pw.CustomButton.Image = null;
            this.txt_pw.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.txt_pw.CustomButton.Name = "";
            this.txt_pw.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pw.CustomButton.TabIndex = 1;
            this.txt_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pw.CustomButton.UseSelectable = true;
            this.txt_pw.CustomButton.Visible = false;
            this.txt_pw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_pw.Lines = new string[0];
            this.txt_pw.Location = new System.Drawing.Point(320, 174);
            this.txt_pw.MaxLength = 32767;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '●';
            this.txt_pw.PromptText = "Type your password";
            this.txt_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pw.SelectedText = "";
            this.txt_pw.SelectionLength = 0;
            this.txt_pw.SelectionStart = 0;
            this.txt_pw.ShortcutsEnabled = true;
            this.txt_pw.Size = new System.Drawing.Size(238, 30);
            this.txt_pw.TabIndex = 4;
            this.txt_pw.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_pw.UseSelectable = true;
            this.txt_pw.WaterMark = "Type your password";
            this.txt_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_lgn
            // 
            this.btn_lgn.Image = null;
            this.btn_lgn.Location = new System.Drawing.Point(483, 267);
            this.btn_lgn.Name = "btn_lgn";
            this.btn_lgn.Size = new System.Drawing.Size(75, 29);
            this.btn_lgn.TabIndex = 7;
            this.btn_lgn.Text = "Login";
            this.btn_lgn.UseSelectable = true;
            this.btn_lgn.UseVisualStyleBackColor = true;
            this.btn_lgn.Click += new System.EventHandler(this.btn_lgn_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.Image = null;
            this.btn_ext.Location = new System.Drawing.Point(320, 267);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(75, 29);
            this.btn_ext.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_ext.TabIndex = 8;
            this.btn_ext.Text = "Exit";
            this.btn_ext.UseSelectable = true;
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(320, 225);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 0);
            this.lbl1.TabIndex = 9;
            // 
            // login
            // 
            this.BackgroundImage = global::AdminMain_ModernUi_.Properties.Resources.Login;
            this.ClientSize = new System.Drawing.Size(600, 338);
            this.ControlBox = false;
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.btn_lgn);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.txt_un);
            this.Controls.Add(this.lbl_usrnm);
            this.Controls.Add(this.lbl_lgn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_usrnm;
        private MetroFramework.Controls.MetroTextBox txt_un;
        private MetroFramework.Controls.MetroLabel lbl_pw;
        private MetroFramework.Controls.MetroTextBox txt_pw;
        private MetroFramework.Controls.MetroLabel lbl_lgn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_lgn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_ext;
        private MetroFramework.Controls.MetroLabel lbl1;
    }
}