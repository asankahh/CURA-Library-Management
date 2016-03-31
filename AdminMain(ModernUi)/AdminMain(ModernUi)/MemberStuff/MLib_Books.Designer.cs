namespace AdminMain_ModernUi_.MemberStuff
{
    partial class MLib_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MLib_Books));
            this.lnkbks = new MetroFramework.Controls.MetroLink();
            this.cb_Search = new MetroFramework.Controls.MetroComboBox();
            this.txt_Search = new MetroFramework.Controls.MetroTextBox();
            this.lnk_srch = new MetroFramework.Controls.MetroLink();
            this.gridview_Book = new MetroFramework.Controls.MetroGrid();
            this.pb_viewBook = new System.Windows.Forms.PictureBox();
            this.lnk_rsrv = new MetroFramework.Controls.MetroLink();
            this.lnk_rvw = new MetroFramework.Controls.MetroLink();
            this.txt_hide = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkbks
            // 
            this.lnkbks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkbks.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkbks.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkbks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkbks.ImageSize = 32;
            this.lnkbks.Location = new System.Drawing.Point(24, 34);
            this.lnkbks.Name = "lnkbks";
            this.lnkbks.Size = new System.Drawing.Size(94, 37);
            this.lnkbks.TabIndex = 4;
            this.lnkbks.Text = "⬅  Books";
            this.lnkbks.UseSelectable = true;
            this.lnkbks.UseStyleColors = true;
            this.lnkbks.Click += new System.EventHandler(this.lnkbks_Click);
            // 
            // cb_Search
            // 
            this.cb_Search.FormattingEnabled = true;
            this.cb_Search.ItemHeight = 23;
            this.cb_Search.Items.AddRange(new object[] {
            "By ID",
            "By Name",
            "By Author",
            "By Genre",
            "By Publisher"});
            this.cb_Search.Location = new System.Drawing.Point(87, 122);
            this.cb_Search.Name = "cb_Search";
            this.cb_Search.Size = new System.Drawing.Size(180, 29);
            this.cb_Search.TabIndex = 5;
            this.cb_Search.UseSelectable = true;
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
            this.txt_Search.Location = new System.Drawing.Point(301, 122);
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
            this.txt_Search.TabIndex = 6;
            this.txt_Search.UseSelectable = true;
            this.txt_Search.WaterMark = "Search for Book\'s by Category";
            this.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lnk_srch
            // 
            this.lnk_srch.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnk_srch.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnk_srch.Image = global::AdminMain_ModernUi_.Properties.Resources.search;
            this.lnk_srch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnk_srch.Location = new System.Drawing.Point(949, 122);
            this.lnk_srch.Name = "lnk_srch";
            this.lnk_srch.Size = new System.Drawing.Size(117, 29);
            this.lnk_srch.TabIndex = 7;
            this.lnk_srch.Text = "Search";
            this.lnk_srch.UseSelectable = true;
            this.lnk_srch.UseStyleColors = true;
            // 
            // gridview_Book
            // 
            this.gridview_Book.AllowUserToResizeRows = false;
            this.gridview_Book.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview_Book.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_Book.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridview_Book.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_Book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_Book.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_Book.EnableHeadersVisualStyles = false;
            this.gridview_Book.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridview_Book.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview_Book.Location = new System.Drawing.Point(87, 194);
            this.gridview_Book.Name = "gridview_Book";
            this.gridview_Book.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_Book.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_Book.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_Book.Size = new System.Drawing.Size(719, 458);
            this.gridview_Book.TabIndex = 8;
            this.gridview_Book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_Book_CellContentClick);
            this.gridview_Book.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridview_Book_RowHeaderMouseDoubleClick);
            // 
            // pb_viewBook
            // 
            this.pb_viewBook.Location = new System.Drawing.Point(840, 194);
            this.pb_viewBook.Name = "pb_viewBook";
            this.pb_viewBook.Size = new System.Drawing.Size(300, 400);
            this.pb_viewBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_viewBook.TabIndex = 9;
            this.pb_viewBook.TabStop = false;
            // 
            // lnk_rsrv
            // 
            this.lnk_rsrv.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnk_rsrv.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnk_rsrv.Location = new System.Drawing.Point(840, 601);
            this.lnk_rsrv.Name = "lnk_rsrv";
            this.lnk_rsrv.Size = new System.Drawing.Size(121, 30);
            this.lnk_rsrv.TabIndex = 10;
            this.lnk_rsrv.Text = "Reserve Book";
            this.lnk_rsrv.UseSelectable = true;
            this.lnk_rsrv.UseStyleColors = true;
            this.lnk_rsrv.Click += new System.EventHandler(this.lnk_rsrv_Click);
            // 
            // lnk_rvw
            // 
            this.lnk_rvw.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnk_rvw.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnk_rvw.Location = new System.Drawing.Point(1019, 601);
            this.lnk_rvw.Name = "lnk_rvw";
            this.lnk_rvw.Size = new System.Drawing.Size(121, 30);
            this.lnk_rvw.TabIndex = 11;
            this.lnk_rvw.Text = "Write Review";
            this.lnk_rvw.UseSelectable = true;
            this.lnk_rvw.UseStyleColors = true;
            this.lnk_rvw.Click += new System.EventHandler(this.lnk_rvw_Click);
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
            this.txt_hide.Location = new System.Drawing.Point(931, 352);
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
            this.txt_hide.TabIndex = 12;
            this.txt_hide.UseSelectable = true;
            this.txt_hide.WaterMark = "Search";
            this.txt_hide.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_hide.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MLib_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.lnk_rvw);
            this.Controls.Add(this.lnk_rsrv);
            this.Controls.Add(this.pb_viewBook);
            this.Controls.Add(this.gridview_Book);
            this.Controls.Add(this.lnk_srch);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cb_Search);
            this.Controls.Add(this.lnkbks);
            this.Controls.Add(this.txt_hide);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "MLib_Books";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "MemberLibrary_Books";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.gridview_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkbks;
        private MetroFramework.Controls.MetroComboBox cb_Search;
        private MetroFramework.Controls.MetroTextBox txt_Search;
        private MetroFramework.Controls.MetroLink lnk_srch;
        private MetroFramework.Controls.MetroGrid gridview_Book;
        private System.Windows.Forms.PictureBox pb_viewBook;
        private MetroFramework.Controls.MetroLink lnk_rsrv;
        private MetroFramework.Controls.MetroLink lnk_rvw;
        private MetroFramework.Controls.MetroTextBox txt_hide;
    }
}