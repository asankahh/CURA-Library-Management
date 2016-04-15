namespace CuraGui
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.btn_strt = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_stp = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lbl_stts = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn_strt
            // 
            this.btn_strt.Image = null;
            this.btn_strt.Location = new System.Drawing.Point(23, 63);
            this.btn_strt.Name = "btn_strt";
            this.btn_strt.Size = new System.Drawing.Size(100, 50);
            this.btn_strt.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_strt.TabIndex = 0;
            this.btn_strt.Text = "Start";
            this.btn_strt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_strt.UseSelectable = true;
            this.btn_strt.UseVisualStyleBackColor = true;
            this.btn_strt.Click += new System.EventHandler(this.btn_strt_Click);
            // 
            // btn_stp
            // 
            this.btn_stp.Image = null;
            this.btn_stp.Location = new System.Drawing.Point(177, 63);
            this.btn_stp.Name = "btn_stp";
            this.btn_stp.Size = new System.Drawing.Size(100, 50);
            this.btn_stp.TabIndex = 0;
            this.btn_stp.Text = "Stop";
            this.btn_stp.UseSelectable = true;
            this.btn_stp.UseStyleColors = true;
            this.btn_stp.UseVisualStyleBackColor = true;
            this.btn_stp.Click += new System.EventHandler(this.btn_stp_Click);
            // 
            // lbl_stts
            // 
            this.lbl_stts.AutoSize = true;
            this.lbl_stts.Location = new System.Drawing.Point(23, 144);
            this.lbl_stts.Name = "lbl_stts";
            this.lbl_stts.Size = new System.Drawing.Size(12, 19);
            this.lbl_stts.Style = MetroFramework.MetroColorStyle.Orange;
            this.lbl_stts.TabIndex = 1;
            this.lbl_stts.Text = "l";
            this.lbl_stts.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_stts.UseStyleColors = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lbl_stts);
            this.Controls.Add(this.btn_stp);
            this.Controls.Add(this.btn_strt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Cura Server GUI";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_strt;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_stp;
        private MetroFramework.Controls.MetroLabel lbl_stts;
    }
}

