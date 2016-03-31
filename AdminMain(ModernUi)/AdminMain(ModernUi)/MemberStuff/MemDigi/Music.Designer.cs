namespace AdminMain_ModernUi_.MemberStuff.Digi
{
    partial class Music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lnkbck = new MetroFramework.Controls.MetroLink();
            this.lnk_rvw = new MetroFramework.Controls.MetroLink();
            this.lnk_rsrv = new MetroFramework.Controls.MetroLink();
            this.pb_viewMusic = new System.Windows.Forms.PictureBox();
            this.gridview = new MetroFramework.Controls.MetroGrid();
            this.lnk_srch = new MetroFramework.Controls.MetroLink();
            this.txt_Search = new MetroFramework.Controls.MetroTextBox();
            this.cb_Search = new MetroFramework.Controls.MetroComboBox();
            this.txt_hide = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lnk_rvw);
            this.metroPanel1.Controls.Add(this.lnk_rsrv);
            this.metroPanel1.Controls.Add(this.pb_viewMusic);
            this.metroPanel1.Controls.Add(this.gridview);
            this.metroPanel1.Controls.Add(this.lnk_srch);
            this.metroPanel1.Controls.Add(this.txt_Search);
            this.metroPanel1.Controls.Add(this.cb_Search);
            this.metroPanel1.Controls.Add(this.txt_hide);
            this.metroPanel1.Controls.Add(this.lnkbck);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1160, 625);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lnkbck
            // 
            this.lnkbck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkbck.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkbck.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkbck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkbck.ImageSize = 32;
            this.lnkbck.Location = new System.Drawing.Point(3, 3);
            this.lnkbck.Name = "lnkbck";
            this.lnkbck.Size = new System.Drawing.Size(164, 37);
            this.lnkbck.TabIndex = 49;
            this.lnkbck.Text = "⬅  Music";
            this.lnkbck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkbck.UseSelectable = true;
            this.lnkbck.UseStyleColors = true;
            this.lnkbck.Click += new System.EventHandler(this.lnkbck_Click);
            // 
            // lnk_rvw
            // 
            this.lnk_rvw.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnk_rvw.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnk_rvw.Location = new System.Drawing.Point(998, 574);
            this.lnk_rvw.Name = "lnk_rvw";
            this.lnk_rvw.Size = new System.Drawing.Size(121, 30);
            this.lnk_rvw.TabIndex = 64;
            this.lnk_rvw.Text = "Write Review";
            this.lnk_rvw.UseSelectable = true;
            this.lnk_rvw.UseStyleColors = true;
            this.lnk_rvw.Click += new System.EventHandler(this.lnk_rvw_Click);
            // 
            // lnk_rsrv
            // 
            this.lnk_rsrv.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnk_rsrv.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnk_rsrv.Location = new System.Drawing.Point(819, 574);
            this.lnk_rsrv.Name = "lnk_rsrv";
            this.lnk_rsrv.Size = new System.Drawing.Size(121, 30);
            this.lnk_rsrv.TabIndex = 63;
            this.lnk_rsrv.Text = "Reserve Book";
            this.lnk_rsrv.UseSelectable = true;
            this.lnk_rsrv.UseStyleColors = true;
            this.lnk_rsrv.Click += new System.EventHandler(this.lnk_rsrv_Click);
            // 
            // pb_viewMusic
            // 
            this.pb_viewMusic.Image = global::AdminMain_ModernUi_.Properties.Resources.pics;
            this.pb_viewMusic.Location = new System.Drawing.Point(819, 167);
            this.pb_viewMusic.Name = "pb_viewMusic";
            this.pb_viewMusic.Size = new System.Drawing.Size(300, 400);
            this.pb_viewMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_viewMusic.TabIndex = 62;
            this.pb_viewMusic.TabStop = false;
            // 
            // gridview
            // 
            this.gridview.AllowUserToResizeRows = false;
            this.gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridview.EnableHeadersVisualStyles = false;
            this.gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview.Location = new System.Drawing.Point(66, 167);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(719, 455);
            this.gridview.TabIndex = 61;
            this.gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellContentClick);
            // 
            // lnk_srch
            // 
            this.lnk_srch.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnk_srch.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnk_srch.Image = global::AdminMain_ModernUi_.Properties.Resources.search;
            this.lnk_srch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnk_srch.Location = new System.Drawing.Point(928, 95);
            this.lnk_srch.Name = "lnk_srch";
            this.lnk_srch.Size = new System.Drawing.Size(117, 29);
            this.lnk_srch.TabIndex = 60;
            this.lnk_srch.Text = "Search";
            this.lnk_srch.UseSelectable = true;
            this.lnk_srch.UseStyleColors = true;
            // 
            // txt_Search
            // 
            // 
            // 
            // 
            this.txt_Search.CustomButton.Image = null;
            this.txt_Search.CustomButton.Location = new System.Drawing.Point(593, 1);
            this.txt_Search.CustomButton.Name = "";
            this.txt_Search.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Search.CustomButton.TabIndex = 1;
            this.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Search.CustomButton.UseSelectable = true;
            this.txt_Search.CustomButton.Visible = false;
            this.txt_Search.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Search.Lines = new string[0];
            this.txt_Search.Location = new System.Drawing.Point(280, 95);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PromptText = "Search for Book\'s by Category";
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(621, 29);
            this.txt_Search.TabIndex = 59;
            this.txt_Search.UseSelectable = true;
            this.txt_Search.WaterMark = "Search for Book\'s by Category";
            this.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cb_Search
            // 
            this.cb_Search.FormattingEnabled = true;
            this.cb_Search.ItemHeight = 23;
            this.cb_Search.Items.AddRange(new object[] {
            "By ID",
            "By Name",
            "By Genre",
            "By Publisher"});
            this.cb_Search.Location = new System.Drawing.Point(66, 95);
            this.cb_Search.Name = "cb_Search";
            this.cb_Search.Size = new System.Drawing.Size(180, 29);
            this.cb_Search.TabIndex = 58;
            this.cb_Search.UseSelectable = true;
            // 
            // txt_hide
            // 
            // 
            // 
            // 
            this.txt_hide.CustomButton.Image = null;
            this.txt_hide.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txt_hide.CustomButton.Name = "";
            this.txt_hide.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_hide.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_hide.CustomButton.TabIndex = 1;
            this.txt_hide.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_hide.CustomButton.UseSelectable = true;
            this.txt_hide.CustomButton.Visible = false;
            this.txt_hide.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_hide.Lines = new string[0];
            this.txt_hide.Location = new System.Drawing.Point(910, 325);
            this.txt_hide.MaxLength = 32767;
            this.txt_hide.Name = "txt_hide";
            this.txt_hide.PasswordChar = '\0';
            this.txt_hide.PromptText = "Search";
            this.txt_hide.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_hide.SelectedText = "";
            this.txt_hide.SelectionLength = 0;
            this.txt_hide.SelectionStart = 0;
            this.txt_hide.ShortcutsEnabled = true;
            this.txt_hide.Size = new System.Drawing.Size(123, 29);
            this.txt_hide.TabIndex = 65;
            this.txt_hide.UseSelectable = true;
            this.txt_hide.WaterMark = "Search";
            this.txt_hide.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_hide.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "Music";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Music";
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink lnkbck;
        private MetroFramework.Controls.MetroLink lnk_rvw;
        private MetroFramework.Controls.MetroLink lnk_rsrv;
        private System.Windows.Forms.PictureBox pb_viewMusic;
        private MetroFramework.Controls.MetroGrid gridview;
        private MetroFramework.Controls.MetroLink lnk_srch;
        private MetroFramework.Controls.MetroTextBox txt_Search;
        private MetroFramework.Controls.MetroComboBox cb_Search;
        private MetroFramework.Controls.MetroTextBox txt_hide;
    }
}