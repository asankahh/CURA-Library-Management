namespace AdminMain_ModernUi_
{
    partial class Notifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifier));
            this.lbl_to = new MetroFramework.Controls.MetroLabel();
            this.lbl_msg = new MetroFramework.Controls.MetroLabel();
            this.txt_to = new MetroFramework.Controls.MetroTextBox();
            this.txt_msg = new MetroFramework.Controls.MetroTextBox();
            this.btn_msndr = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(54, 130);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(25, 19);
            this.lbl_to.TabIndex = 1;
            this.lbl_to.Text = "To:";
            this.lbl_to.UseStyleColors = true;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(54, 191);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(63, 19);
            this.lbl_msg.TabIndex = 6;
            this.lbl_msg.Text = "Message:";
            this.lbl_msg.UseStyleColors = true;
            // 
            // txt_to
            // 
            // 
            // 
            // 
            this.txt_to.CustomButton.Image = null;
            this.txt_to.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.txt_to.CustomButton.Name = "";
            this.txt_to.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_to.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_to.CustomButton.TabIndex = 1;
            this.txt_to.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_to.CustomButton.UseSelectable = true;
            this.txt_to.CustomButton.Visible = false;
            this.txt_to.Lines = new string[0];
            this.txt_to.Location = new System.Drawing.Point(111, 128);
            this.txt_to.MaxLength = 32767;
            this.txt_to.Name = "txt_to";
            this.txt_to.PasswordChar = '\0';
            this.txt_to.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_to.SelectedText = "";
            this.txt_to.SelectionLength = 0;
            this.txt_to.SelectionStart = 0;
            this.txt_to.ShortcutsEnabled = true;
            this.txt_to.Size = new System.Drawing.Size(271, 30);
            this.txt_to.TabIndex = 8;
            this.txt_to.UseSelectable = true;
            this.txt_to.UseStyleColors = true;
            this.txt_to.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_to.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_msg
            // 
            // 
            // 
            // 
            this.txt_msg.CustomButton.Image = null;
            this.txt_msg.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.txt_msg.CustomButton.Name = "";
            this.txt_msg.CustomButton.Size = new System.Drawing.Size(133, 133);
            this.txt_msg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_msg.CustomButton.TabIndex = 1;
            this.txt_msg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_msg.CustomButton.UseSelectable = true;
            this.txt_msg.CustomButton.Visible = false;
            this.txt_msg.Lines = new string[0];
            this.txt_msg.Location = new System.Drawing.Point(54, 228);
            this.txt_msg.MaxLength = 32767;
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.PasswordChar = '\0';
            this.txt_msg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_msg.SelectedText = "";
            this.txt_msg.SelectionLength = 0;
            this.txt_msg.SelectionStart = 0;
            this.txt_msg.ShortcutsEnabled = true;
            this.txt_msg.Size = new System.Drawing.Size(316, 138);
            this.txt_msg.TabIndex = 13;
            this.txt_msg.UseSelectable = true;
            this.txt_msg.UseStyleColors = true;
            this.txt_msg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_msg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_msndr
            // 
            this.btn_msndr.Image = null;
            this.btn_msndr.Location = new System.Drawing.Point(271, 411);
            this.btn_msndr.Name = "btn_msndr";
            this.btn_msndr.Size = new System.Drawing.Size(99, 36);
            this.btn_msndr.TabIndex = 15;
            this.btn_msndr.Text = "Send";
            this.btn_msndr.UseSelectable = true;
            this.btn_msndr.UseStyleColors = true;
            this.btn_msndr.UseVisualStyleBackColor = true;
            this.btn_msndr.Click += new System.EventHandler(this.btn_msndr_Click);
            // 
            // Notifier
            // 
            this.AcceptButton = this.btn_msndr;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 544);
            this.Controls.Add(this.btn_msndr);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lbl_to);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notifier";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Member Notifier";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Notifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lbl_to;
        private MetroFramework.Controls.MetroLabel lbl_msg;
        private MetroFramework.Controls.MetroTextBox txt_to;
        private MetroFramework.Controls.MetroTextBox txt_msg;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_msndr;
    }
}