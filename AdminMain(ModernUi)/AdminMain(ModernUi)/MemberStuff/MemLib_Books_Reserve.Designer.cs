namespace AdminMain_ModernUi_.MemberStuff
{
    partial class MemLib_Books_Reserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemLib_Books_Reserve));
            this.lnk_rsrv = new MetroFramework.Controls.MetroLink();
            this.dt_pick = new MetroFramework.Controls.MetroDateTime();
            this.pb_cvr = new System.Windows.Forms.PictureBox();
            this.lbl_bknm = new MetroFramework.Controls.MetroLabel();
            this.lbl_athr = new MetroFramework.Controls.MetroLabel();
            this.Date = new MetroFramework.Controls.MetroLabel();
            this.Notes = new MetroFramework.Controls.MetroLabel();
            this.txt_nt = new MetroFramework.Controls.MetroTextBox();
            this.btn_dn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cvr)).BeginInit();
            this.SuspendLayout();
            // 
            // lnk_rsrv
            // 
            this.lnk_rsrv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk_rsrv.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnk_rsrv.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnk_rsrv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnk_rsrv.ImageSize = 32;
            this.lnk_rsrv.Location = new System.Drawing.Point(36, 24);
            this.lnk_rsrv.Name = "lnk_rsrv";
            this.lnk_rsrv.Size = new System.Drawing.Size(147, 37);
            this.lnk_rsrv.TabIndex = 5;
            this.lnk_rsrv.Text = "⬅  Book Reserve";
            this.lnk_rsrv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnk_rsrv.UseSelectable = true;
            this.lnk_rsrv.UseStyleColors = true;
            this.lnk_rsrv.Click += new System.EventHandler(this.lnk_rsrv_Click);
            // 
            // dt_pick
            // 
            this.dt_pick.Location = new System.Drawing.Point(154, 315);
            this.dt_pick.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_pick.Name = "dt_pick";
            this.dt_pick.Size = new System.Drawing.Size(242, 29);
            this.dt_pick.TabIndex = 7;
            this.dt_pick.UseStyleColors = true;
            // 
            // pb_cvr
            // 
            this.pb_cvr.Location = new System.Drawing.Point(36, 90);
            this.pb_cvr.Name = "pb_cvr";
            this.pb_cvr.Size = new System.Drawing.Size(150, 200);
            this.pb_cvr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cvr.TabIndex = 6;
            this.pb_cvr.TabStop = false;
            // 
            // lbl_bknm
            // 
            this.lbl_bknm.AutoSize = true;
            this.lbl_bknm.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_bknm.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_bknm.Location = new System.Drawing.Point(206, 90);
            this.lbl_bknm.Name = "lbl_bknm";
            this.lbl_bknm.Size = new System.Drawing.Size(102, 25);
            this.lbl_bknm.TabIndex = 8;
            this.lbl_bknm.Text = "Book name";
            this.lbl_bknm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_bknm.UseStyleColors = true;
            // 
            // lbl_athr
            // 
            this.lbl_athr.AutoSize = true;
            this.lbl_athr.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_athr.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_athr.Location = new System.Drawing.Point(206, 147);
            this.lbl_athr.Name = "lbl_athr";
            this.lbl_athr.Size = new System.Drawing.Size(113, 25);
            this.lbl_athr.TabIndex = 9;
            this.lbl_athr.Text = "Book Author";
            this.lbl_athr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_athr.UseStyleColors = true;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(42, 321);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 19);
            this.Date.TabIndex = 10;
            this.Date.Text = "Date";
            this.Date.UseStyleColors = true;
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(42, 378);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(88, 19);
            this.Notes.TabIndex = 11;
            this.Notes.Text = "Special Notes";
            this.Notes.UseStyleColors = true;
            // 
            // txt_nt
            // 
            // 
            // 
            // 
            this.txt_nt.CustomButton.Image = null;
            this.txt_nt.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txt_nt.CustomButton.Name = "";
            this.txt_nt.CustomButton.Size = new System.Drawing.Size(73, 73);
            this.txt_nt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nt.CustomButton.TabIndex = 1;
            this.txt_nt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nt.CustomButton.UseSelectable = true;
            this.txt_nt.CustomButton.Visible = false;
            this.txt_nt.Lines = new string[0];
            this.txt_nt.Location = new System.Drawing.Point(154, 373);
            this.txt_nt.MaxLength = 32767;
            this.txt_nt.Multiline = true;
            this.txt_nt.Name = "txt_nt";
            this.txt_nt.PasswordChar = '\0';
            this.txt_nt.PromptText = "Reason or special note";
            this.txt_nt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nt.SelectedText = "";
            this.txt_nt.SelectionLength = 0;
            this.txt_nt.SelectionStart = 0;
            this.txt_nt.ShortcutsEnabled = true;
            this.txt_nt.Size = new System.Drawing.Size(242, 75);
            this.txt_nt.TabIndex = 12;
            this.txt_nt.UseSelectable = true;
            this.txt_nt.UseStyleColors = true;
            this.txt_nt.WaterMark = "Reason or special note";
            this.txt_nt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_dn
            // 
            this.btn_dn.Image = null;
            this.btn_dn.Location = new System.Drawing.Point(169, 499);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(75, 23);
            this.btn_dn.TabIndex = 13;
            this.btn_dn.Text = "Done";
            this.btn_dn.UseSelectable = true;
            this.btn_dn.UseStyleColors = true;
            this.btn_dn.UseVisualStyleBackColor = true;
            this.btn_dn.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // MemLib_Books_Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 556);
            this.Controls.Add(this.btn_dn);
            this.Controls.Add(this.txt_nt);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.lbl_athr);
            this.Controls.Add(this.lbl_bknm);
            this.Controls.Add(this.dt_pick);
            this.Controls.Add(this.pb_cvr);
            this.Controls.Add(this.lnk_rsrv);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "MemLib_Books_Reserve";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "MemLib_Books_Reserve";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MemLib_Books_Reserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cvr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnk_rsrv;
        private System.Windows.Forms.PictureBox pb_cvr;
        private MetroFramework.Controls.MetroDateTime dt_pick;
        private MetroFramework.Controls.MetroLabel lbl_bknm;
        private MetroFramework.Controls.MetroLabel lbl_athr;
        private MetroFramework.Controls.MetroLabel Date;
        private MetroFramework.Controls.MetroLabel Notes;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_dn;
        private MetroFramework.Controls.MetroTextBox txt_nt;
    }
}