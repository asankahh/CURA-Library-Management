namespace AdminMain_ModernUi_.LibCat
{
    partial class LibraryBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryBooks));
            this.btn_mDelete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cb_Search = new MetroFramework.Controls.MetroComboBox();
            this.txt_Search = new MetroFramework.Controls.MetroTextBox();
            this.gridview = new MetroFramework.Controls.MetroGrid();
            this.btn_updateForm = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lnkBks = new MetroFramework.Controls.MetroLink();
            this.pb_viewBook = new System.Windows.Forms.PictureBox();
            this.pnl_edtbk = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_editDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_editAdvisor = new MetroFramework.Controls.MetroTextBox();
            this.btn_Delete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txt_editID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl5 = new MetroFramework.Controls.MetroLabel();
            this.txt_editGener = new MetroFramework.Controls.MetroTextBox();
            this.lbl3 = new MetroFramework.Controls.MetroLabel();
            this.txt_editQuantity = new MetroFramework.Controls.MetroTextBox();
            this.lbl2 = new MetroFramework.Controls.MetroLabel();
            this.txt_editNoOfPage = new MetroFramework.Controls.MetroTextBox();
            this.btn_Update = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_Close = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.cb_editCatagory = new MetroFramework.Controls.MetroComboBox();
            this.lbl_year = new MetroFramework.Controls.MetroLabel();
            this.cb_editYear = new MetroFramework.Controls.MetroComboBox();
            this.lbl_pblshr = new MetroFramework.Controls.MetroLabel();
            this.lbl_edtn = new MetroFramework.Controls.MetroLabel();
            this.txt_editPublisher = new MetroFramework.Controls.MetroTextBox();
            this.txt_editEdition = new MetroFramework.Controls.MetroTextBox();
            this.txt_editName = new MetroFramework.Controls.MetroTextBox();
            this.lbl_isbn = new MetroFramework.Controls.MetroLabel();
            this.txt_editISBN = new MetroFramework.Controls.MetroTextBox();
            this.lbl_athr = new MetroFramework.Controls.MetroLabel();
            this.lbl_nm = new MetroFramework.Controls.MetroLabel();
            this.txt_editAuthor = new MetroFramework.Controls.MetroTextBox();
            this.pb_editBook = new System.Windows.Forms.PictureBox();
            this.lbl_bknm = new MetroFramework.Controls.MetroLabel();
            this.by = new MetroFramework.Controls.MetroLabel();
            this.lbl_bkathr = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewBook)).BeginInit();
            this.pnl_edtbk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mDelete
            // 
            this.btn_mDelete.Image = null;
            this.btn_mDelete.Location = new System.Drawing.Point(70, 600);
            this.btn_mDelete.Name = "btn_mDelete";
            this.btn_mDelete.Size = new System.Drawing.Size(86, 29);
            this.btn_mDelete.TabIndex = 22;
            this.btn_mDelete.Text = "Remove";
            this.btn_mDelete.UseSelectable = true;
            this.btn_mDelete.UseStyleColors = true;
            this.btn_mDelete.UseVisualStyleBackColor = true;
            this.btn_mDelete.Click += new System.EventHandler(this.btn_rmv_Click);
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
            this.cb_Search.Location = new System.Drawing.Point(70, 108);
            this.cb_Search.Name = "cb_Search";
            this.cb_Search.Size = new System.Drawing.Size(240, 29);
            this.cb_Search.TabIndex = 17;
            this.cb_Search.UseSelectable = true;
            this.cb_Search.UseStyleColors = true;
            // 
            // txt_Search
            // 
            // 
            // 
            // 
            this.txt_Search.CustomButton.Image = null;
            this.txt_Search.CustomButton.Location = new System.Drawing.Point(833, 2);
            this.txt_Search.CustomButton.Name = "";
            this.txt_Search.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Search.CustomButton.TabIndex = 1;
            this.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Search.CustomButton.UseSelectable = true;
            this.txt_Search.CustomButton.Visible = false;
            this.txt_Search.DisplayIcon = true;
            this.txt_Search.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Search.Lines = new string[0];
            this.txt_Search.Location = new System.Drawing.Point(321, 107);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PromptText = "Search for Book\'s by Category";
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.ShowClearButton = true;
            this.txt_Search.Size = new System.Drawing.Size(861, 30);
            this.txt_Search.TabIndex = 16;
            this.txt_Search.UseSelectable = true;
            this.txt_Search.UseStyleColors = true;
            this.txt_Search.WaterMark = "Search for Book\'s by Category";
            this.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_bookSearch_TextChanged);
            this.txt_Search.Click += new System.EventHandler(this.txt_Search_Click);
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
            this.gridview.Location = new System.Drawing.Point(337, 178);
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
            this.gridview.Size = new System.Drawing.Size(845, 439);
            this.gridview.TabIndex = 15;
            this.gridview.UseStyleColors = true;
            this.gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewBooks_CellContentClick);
            this.gridview.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridview_RowHeaderMouseDoubleClick);
            // 
            // btn_updateForm
            // 
            this.btn_updateForm.Image = null;
            this.btn_updateForm.Location = new System.Drawing.Point(224, 600);
            this.btn_updateForm.Name = "btn_updateForm";
            this.btn_updateForm.Size = new System.Drawing.Size(86, 29);
            this.btn_updateForm.TabIndex = 23;
            this.btn_updateForm.Text = "Update";
            this.btn_updateForm.UseSelectable = true;
            this.btn_updateForm.UseStyleColors = true;
            this.btn_updateForm.UseVisualStyleBackColor = true;
            this.btn_updateForm.Click += new System.EventHandler(this.btn_updt_Click);
            // 
            // lnkBks
            // 
            this.lnkBks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkBks.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkBks.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkBks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkBks.ImageSize = 32;
            this.lnkBks.Location = new System.Drawing.Point(24, 34);
            this.lnkBks.Name = "lnkBks";
            this.lnkBks.Size = new System.Drawing.Size(90, 37);
            this.lnkBks.TabIndex = 24;
            this.lnkBks.Text = "⬅  Books";
            this.lnkBks.UseSelectable = true;
            this.lnkBks.UseStyleColors = true;
            this.lnkBks.Click += new System.EventHandler(this.lnkBks_Click);
            // 
            // pb_viewBook
            // 
            this.pb_viewBook.Image = global::AdminMain_ModernUi_.Properties.Resources.pics;
            this.pb_viewBook.Location = new System.Drawing.Point(70, 178);
            this.pb_viewBook.Name = "pb_viewBook";
            this.pb_viewBook.Size = new System.Drawing.Size(240, 320);
            this.pb_viewBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_viewBook.TabIndex = 21;
            this.pb_viewBook.TabStop = false;
            // 
            // pnl_edtbk
            // 
            this.pnl_edtbk.Controls.Add(this.metroLabel2);
            this.pnl_edtbk.Controls.Add(this.txt_editDescription);
            this.pnl_edtbk.Controls.Add(this.metroLabel3);
            this.pnl_edtbk.Controls.Add(this.txt_editAdvisor);
            this.pnl_edtbk.Controls.Add(this.btn_Delete);
            this.pnl_edtbk.Controls.Add(this.txt_editID);
            this.pnl_edtbk.Controls.Add(this.metroLabel1);
            this.pnl_edtbk.Controls.Add(this.lbl5);
            this.pnl_edtbk.Controls.Add(this.txt_editGener);
            this.pnl_edtbk.Controls.Add(this.lbl3);
            this.pnl_edtbk.Controls.Add(this.txt_editQuantity);
            this.pnl_edtbk.Controls.Add(this.lbl2);
            this.pnl_edtbk.Controls.Add(this.txt_editNoOfPage);
            this.pnl_edtbk.Controls.Add(this.btn_Update);
            this.pnl_edtbk.Controls.Add(this.btn_Close);
            this.pnl_edtbk.Controls.Add(this.lbl1);
            this.pnl_edtbk.Controls.Add(this.cb_editCatagory);
            this.pnl_edtbk.Controls.Add(this.lbl_year);
            this.pnl_edtbk.Controls.Add(this.cb_editYear);
            this.pnl_edtbk.Controls.Add(this.lbl_pblshr);
            this.pnl_edtbk.Controls.Add(this.lbl_edtn);
            this.pnl_edtbk.Controls.Add(this.txt_editPublisher);
            this.pnl_edtbk.Controls.Add(this.txt_editEdition);
            this.pnl_edtbk.Controls.Add(this.txt_editName);
            this.pnl_edtbk.Controls.Add(this.lbl_isbn);
            this.pnl_edtbk.Controls.Add(this.txt_editISBN);
            this.pnl_edtbk.Controls.Add(this.lbl_athr);
            this.pnl_edtbk.Controls.Add(this.lbl_nm);
            this.pnl_edtbk.Controls.Add(this.txt_editAuthor);
            this.pnl_edtbk.Controls.Add(this.pb_editBook);
            this.pnl_edtbk.HorizontalScrollbarBarColor = true;
            this.pnl_edtbk.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_edtbk.HorizontalScrollbarSize = 10;
            this.pnl_edtbk.Location = new System.Drawing.Point(356, 34);
            this.pnl_edtbk.Name = "pnl_edtbk";
            this.pnl_edtbk.Size = new System.Drawing.Size(632, 606);
            this.pnl_edtbk.TabIndex = 26;
            this.pnl_edtbk.UseStyleColors = true;
            this.pnl_edtbk.VerticalScrollbarBarColor = true;
            this.pnl_edtbk.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_edtbk.VerticalScrollbarSize = 10;
            this.pnl_edtbk.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 511);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 39;
            this.metroLabel2.Text = "Description";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txt_editDescription
            // 
            // 
            // 
            // 
            this.txt_editDescription.CustomButton.Image = null;
            this.txt_editDescription.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editDescription.CustomButton.Name = "";
            this.txt_editDescription.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editDescription.CustomButton.TabIndex = 1;
            this.txt_editDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editDescription.CustomButton.UseSelectable = true;
            this.txt_editDescription.CustomButton.Visible = false;
            this.txt_editDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editDescription.Lines = new string[0];
            this.txt_editDescription.Location = new System.Drawing.Point(108, 504);
            this.txt_editDescription.MaxLength = 32767;
            this.txt_editDescription.Name = "txt_editDescription";
            this.txt_editDescription.PasswordChar = '\0';
            this.txt_editDescription.PromptText = "Book Description";
            this.txt_editDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editDescription.SelectedText = "";
            this.txt_editDescription.SelectionLength = 0;
            this.txt_editDescription.SelectionStart = 0;
            this.txt_editDescription.ShortcutsEnabled = true;
            this.txt_editDescription.Size = new System.Drawing.Size(247, 29);
            this.txt_editDescription.TabIndex = 38;
            this.txt_editDescription.UseSelectable = true;
            this.txt_editDescription.UseStyleColors = true;
            this.txt_editDescription.WaterMark = "Book Description";
            this.txt_editDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 470);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 37;
            this.metroLabel3.Text = "Advisor";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txt_editAdvisor
            // 
            // 
            // 
            // 
            this.txt_editAdvisor.CustomButton.Image = null;
            this.txt_editAdvisor.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editAdvisor.CustomButton.Name = "";
            this.txt_editAdvisor.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editAdvisor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editAdvisor.CustomButton.TabIndex = 1;
            this.txt_editAdvisor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editAdvisor.CustomButton.UseSelectable = true;
            this.txt_editAdvisor.CustomButton.Visible = false;
            this.txt_editAdvisor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editAdvisor.Lines = new string[0];
            this.txt_editAdvisor.Location = new System.Drawing.Point(108, 465);
            this.txt_editAdvisor.MaxLength = 32767;
            this.txt_editAdvisor.Name = "txt_editAdvisor";
            this.txt_editAdvisor.PasswordChar = '\0';
            this.txt_editAdvisor.PromptText = "Advisor";
            this.txt_editAdvisor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editAdvisor.SelectedText = "";
            this.txt_editAdvisor.SelectionLength = 0;
            this.txt_editAdvisor.SelectionStart = 0;
            this.txt_editAdvisor.ShortcutsEnabled = true;
            this.txt_editAdvisor.Size = new System.Drawing.Size(247, 29);
            this.txt_editAdvisor.TabIndex = 36;
            this.txt_editAdvisor.UseSelectable = true;
            this.txt_editAdvisor.UseStyleColors = true;
            this.txt_editAdvisor.WaterMark = "Advisor";
            this.txt_editAdvisor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editAdvisor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = null;
            this.btn_Delete.Location = new System.Drawing.Point(442, 447);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 33);
            this.btn_Delete.TabIndex = 35;
            this.btn_Delete.Text = "Remove";
            this.btn_Delete.UseSelectable = true;
            this.btn_Delete.UseStyleColors = true;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_bookDelete_Click);
            // 
            // txt_editID
            // 
            // 
            // 
            // 
            this.txt_editID.CustomButton.Image = null;
            this.txt_editID.CustomButton.Location = new System.Drawing.Point(219, 1);
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
            this.txt_editID.Location = new System.Drawing.Point(108, 53);
            this.txt_editID.MaxLength = 32767;
            this.txt_editID.Name = "txt_editID";
            this.txt_editID.PasswordChar = '\0';
            this.txt_editID.PromptText = "Book ID";
            this.txt_editID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editID.SelectedText = "";
            this.txt_editID.SelectionLength = 0;
            this.txt_editID.SelectionStart = 0;
            this.txt_editID.ShortcutsEnabled = true;
            this.txt_editID.Size = new System.Drawing.Size(247, 29);
            this.txt_editID.TabIndex = 34;
            this.txt_editID.UseSelectable = true;
            this.txt_editID.UseStyleColors = true;
            this.txt_editID.WaterMark = "Book ID";
            this.txt_editID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_editID.Click += new System.EventHandler(this.txt_edit_bookId_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "ID";
            this.metroLabel1.UseStyleColors = true;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(11, 435);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(44, 19);
            this.lbl5.TabIndex = 32;
            this.lbl5.Text = "Gener";
            this.lbl5.UseStyleColors = true;
            // 
            // txt_editGener
            // 
            // 
            // 
            // 
            this.txt_editGener.CustomButton.Image = null;
            this.txt_editGener.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editGener.CustomButton.Name = "";
            this.txt_editGener.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editGener.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editGener.CustomButton.TabIndex = 1;
            this.txt_editGener.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editGener.CustomButton.UseSelectable = true;
            this.txt_editGener.CustomButton.Visible = false;
            this.txt_editGener.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editGener.Lines = new string[0];
            this.txt_editGener.Location = new System.Drawing.Point(108, 428);
            this.txt_editGener.MaxLength = 32767;
            this.txt_editGener.Name = "txt_editGener";
            this.txt_editGener.PasswordChar = '\0';
            this.txt_editGener.PromptText = "Use tags";
            this.txt_editGener.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editGener.SelectedText = "";
            this.txt_editGener.SelectionLength = 0;
            this.txt_editGener.SelectionStart = 0;
            this.txt_editGener.ShortcutsEnabled = true;
            this.txt_editGener.Size = new System.Drawing.Size(247, 29);
            this.txt_editGener.TabIndex = 31;
            this.txt_editGener.UseSelectable = true;
            this.txt_editGener.UseStyleColors = true;
            this.txt_editGener.WaterMark = "Use tags";
            this.txt_editGener.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editGener.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(11, 394);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(58, 19);
            this.lbl3.TabIndex = 30;
            this.lbl3.Text = "Quantity";
            this.lbl3.UseStyleColors = true;
            // 
            // txt_editQuantity
            // 
            // 
            // 
            // 
            this.txt_editQuantity.CustomButton.Image = null;
            this.txt_editQuantity.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editQuantity.CustomButton.Name = "";
            this.txt_editQuantity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editQuantity.CustomButton.TabIndex = 1;
            this.txt_editQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editQuantity.CustomButton.UseSelectable = true;
            this.txt_editQuantity.CustomButton.Visible = false;
            this.txt_editQuantity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editQuantity.Lines = new string[0];
            this.txt_editQuantity.Location = new System.Drawing.Point(108, 389);
            this.txt_editQuantity.MaxLength = 32767;
            this.txt_editQuantity.Name = "txt_editQuantity";
            this.txt_editQuantity.PasswordChar = '\0';
            this.txt_editQuantity.PromptText = "Quantity";
            this.txt_editQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editQuantity.SelectedText = "";
            this.txt_editQuantity.SelectionLength = 0;
            this.txt_editQuantity.SelectionStart = 0;
            this.txt_editQuantity.ShortcutsEnabled = true;
            this.txt_editQuantity.Size = new System.Drawing.Size(247, 29);
            this.txt_editQuantity.TabIndex = 29;
            this.txt_editQuantity.UseSelectable = true;
            this.txt_editQuantity.UseStyleColors = true;
            this.txt_editQuantity.WaterMark = "Quantity";
            this.txt_editQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(11, 351);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(84, 19);
            this.lbl2.TabIndex = 28;
            this.lbl2.Text = "No. of Pages";
            this.lbl2.UseStyleColors = true;
            // 
            // txt_editNoOfPage
            // 
            // 
            // 
            // 
            this.txt_editNoOfPage.CustomButton.Image = null;
            this.txt_editNoOfPage.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editNoOfPage.CustomButton.Name = "";
            this.txt_editNoOfPage.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editNoOfPage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editNoOfPage.CustomButton.TabIndex = 1;
            this.txt_editNoOfPage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editNoOfPage.CustomButton.UseSelectable = true;
            this.txt_editNoOfPage.CustomButton.Visible = false;
            this.txt_editNoOfPage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editNoOfPage.Lines = new string[0];
            this.txt_editNoOfPage.Location = new System.Drawing.Point(108, 351);
            this.txt_editNoOfPage.MaxLength = 32767;
            this.txt_editNoOfPage.Name = "txt_editNoOfPage";
            this.txt_editNoOfPage.PasswordChar = '\0';
            this.txt_editNoOfPage.PromptText = "Page count";
            this.txt_editNoOfPage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editNoOfPage.SelectedText = "";
            this.txt_editNoOfPage.SelectionLength = 0;
            this.txt_editNoOfPage.SelectionStart = 0;
            this.txt_editNoOfPage.ShortcutsEnabled = true;
            this.txt_editNoOfPage.Size = new System.Drawing.Size(247, 29);
            this.txt_editNoOfPage.TabIndex = 27;
            this.txt_editNoOfPage.UseSelectable = true;
            this.txt_editNoOfPage.UseStyleColors = true;
            this.txt_editNoOfPage.WaterMark = "Page count";
            this.txt_editNoOfPage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editNoOfPage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = null;
            this.btn_Update.Location = new System.Drawing.Point(442, 395);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 33);
            this.btn_Update.TabIndex = 26;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseSelectable = true;
            this.btn_Update.UseStyleColors = true;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_bookUpdate_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = null;
            this.btn_Close.Location = new System.Drawing.Point(442, 499);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(110, 33);
            this.btn_Close.TabIndex = 25;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseSelectable = true;
            this.btn_Close.UseStyleColors = true;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_clse_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(11, 275);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 19);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "Catagory";
            this.lbl1.UseStyleColors = true;
            // 
            // cb_editCatagory
            // 
            this.cb_editCatagory.FormattingEnabled = true;
            this.cb_editCatagory.ItemHeight = 23;
            this.cb_editCatagory.Items.AddRange(new object[] {
            "",
            "Book",
            "Magazines",
            "Newspaper",
            "Thesis",
            "Journal Articles",
            "Digital Archive"});
            this.cb_editCatagory.Location = new System.Drawing.Point(108, 270);
            this.cb_editCatagory.Name = "cb_editCatagory";
            this.cb_editCatagory.Size = new System.Drawing.Size(247, 29);
            this.cb_editCatagory.TabIndex = 23;
            this.cb_editCatagory.UseSelectable = true;
            this.cb_editCatagory.UseStyleColors = true;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(11, 315);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(34, 19);
            this.lbl_year.TabIndex = 22;
            this.lbl_year.Text = "Year";
            this.lbl_year.UseStyleColors = true;
            // 
            // cb_editYear
            // 
            this.cb_editYear.FormattingEnabled = true;
            this.cb_editYear.ItemHeight = 23;
            this.cb_editYear.Items.AddRange(new object[] {
            "",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "-----",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "-----",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "-----",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "-----"});
            this.cb_editYear.Location = new System.Drawing.Point(108, 309);
            this.cb_editYear.Name = "cb_editYear";
            this.cb_editYear.Size = new System.Drawing.Size(82, 29);
            this.cb_editYear.TabIndex = 21;
            this.cb_editYear.UseSelectable = true;
            this.cb_editYear.UseStyleColors = true;
            // 
            // lbl_pblshr
            // 
            this.lbl_pblshr.AutoSize = true;
            this.lbl_pblshr.Location = new System.Drawing.Point(11, 238);
            this.lbl_pblshr.Name = "lbl_pblshr";
            this.lbl_pblshr.Size = new System.Drawing.Size(62, 19);
            this.lbl_pblshr.TabIndex = 20;
            this.lbl_pblshr.Text = "Publisher";
            this.lbl_pblshr.UseStyleColors = true;
            // 
            // lbl_edtn
            // 
            this.lbl_edtn.AutoSize = true;
            this.lbl_edtn.Location = new System.Drawing.Point(11, 198);
            this.lbl_edtn.Name = "lbl_edtn";
            this.lbl_edtn.Size = new System.Drawing.Size(49, 19);
            this.lbl_edtn.TabIndex = 19;
            this.lbl_edtn.Text = "Edition";
            this.lbl_edtn.UseStyleColors = true;
            // 
            // txt_editPublisher
            // 
            // 
            // 
            // 
            this.txt_editPublisher.CustomButton.Image = null;
            this.txt_editPublisher.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editPublisher.CustomButton.Name = "";
            this.txt_editPublisher.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editPublisher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editPublisher.CustomButton.TabIndex = 1;
            this.txt_editPublisher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editPublisher.CustomButton.UseSelectable = true;
            this.txt_editPublisher.CustomButton.Visible = false;
            this.txt_editPublisher.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editPublisher.Lines = new string[0];
            this.txt_editPublisher.Location = new System.Drawing.Point(108, 232);
            this.txt_editPublisher.MaxLength = 32767;
            this.txt_editPublisher.Name = "txt_editPublisher";
            this.txt_editPublisher.PasswordChar = '\0';
            this.txt_editPublisher.PromptText = "Publisher";
            this.txt_editPublisher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editPublisher.SelectedText = "";
            this.txt_editPublisher.SelectionLength = 0;
            this.txt_editPublisher.SelectionStart = 0;
            this.txt_editPublisher.ShortcutsEnabled = true;
            this.txt_editPublisher.Size = new System.Drawing.Size(247, 29);
            this.txt_editPublisher.TabIndex = 18;
            this.txt_editPublisher.UseSelectable = true;
            this.txt_editPublisher.UseStyleColors = true;
            this.txt_editPublisher.WaterMark = "Publisher";
            this.txt_editPublisher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editPublisher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editEdition
            // 
            // 
            // 
            // 
            this.txt_editEdition.CustomButton.Image = null;
            this.txt_editEdition.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editEdition.CustomButton.Name = "";
            this.txt_editEdition.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editEdition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editEdition.CustomButton.TabIndex = 1;
            this.txt_editEdition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editEdition.CustomButton.UseSelectable = true;
            this.txt_editEdition.CustomButton.Visible = false;
            this.txt_editEdition.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editEdition.Lines = new string[0];
            this.txt_editEdition.Location = new System.Drawing.Point(108, 195);
            this.txt_editEdition.MaxLength = 32767;
            this.txt_editEdition.Name = "txt_editEdition";
            this.txt_editEdition.PasswordChar = '\0';
            this.txt_editEdition.PromptText = "Book Edition";
            this.txt_editEdition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editEdition.SelectedText = "";
            this.txt_editEdition.SelectionLength = 0;
            this.txt_editEdition.SelectionStart = 0;
            this.txt_editEdition.ShortcutsEnabled = true;
            this.txt_editEdition.Size = new System.Drawing.Size(247, 29);
            this.txt_editEdition.TabIndex = 17;
            this.txt_editEdition.UseSelectable = true;
            this.txt_editEdition.UseStyleColors = true;
            this.txt_editEdition.WaterMark = "Book Edition";
            this.txt_editEdition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editEdition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_editName
            // 
            // 
            // 
            // 
            this.txt_editName.CustomButton.Image = null;
            this.txt_editName.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editName.CustomButton.Name = "";
            this.txt_editName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editName.CustomButton.TabIndex = 1;
            this.txt_editName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editName.CustomButton.UseSelectable = true;
            this.txt_editName.CustomButton.Visible = false;
            this.txt_editName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editName.Lines = new string[0];
            this.txt_editName.Location = new System.Drawing.Point(108, 88);
            this.txt_editName.MaxLength = 32767;
            this.txt_editName.Name = "txt_editName";
            this.txt_editName.PasswordChar = '\0';
            this.txt_editName.PromptText = "Book Name";
            this.txt_editName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editName.SelectedText = "";
            this.txt_editName.SelectionLength = 0;
            this.txt_editName.SelectionStart = 0;
            this.txt_editName.ShortcutsEnabled = true;
            this.txt_editName.Size = new System.Drawing.Size(247, 29);
            this.txt_editName.TabIndex = 16;
            this.txt_editName.UseSelectable = true;
            this.txt_editName.UseStyleColors = true;
            this.txt_editName.WaterMark = "Book Name";
            this.txt_editName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.Location = new System.Drawing.Point(11, 92);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(79, 19);
            this.lbl_isbn.TabIndex = 15;
            this.lbl_isbn.Text = "Book Name";
            this.lbl_isbn.UseStyleColors = true;
            // 
            // txt_editISBN
            // 
            // 
            // 
            // 
            this.txt_editISBN.CustomButton.Image = null;
            this.txt_editISBN.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editISBN.CustomButton.Name = "";
            this.txt_editISBN.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editISBN.CustomButton.TabIndex = 1;
            this.txt_editISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editISBN.CustomButton.UseSelectable = true;
            this.txt_editISBN.CustomButton.Visible = false;
            this.txt_editISBN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editISBN.Lines = new string[0];
            this.txt_editISBN.Location = new System.Drawing.Point(108, 159);
            this.txt_editISBN.MaxLength = 32767;
            this.txt_editISBN.Name = "txt_editISBN";
            this.txt_editISBN.PasswordChar = '\0';
            this.txt_editISBN.PromptText = "ISBN";
            this.txt_editISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editISBN.SelectedText = "";
            this.txt_editISBN.SelectionLength = 0;
            this.txt_editISBN.SelectionStart = 0;
            this.txt_editISBN.ShortcutsEnabled = true;
            this.txt_editISBN.Size = new System.Drawing.Size(247, 29);
            this.txt_editISBN.TabIndex = 14;
            this.txt_editISBN.UseSelectable = true;
            this.txt_editISBN.UseStyleColors = true;
            this.txt_editISBN.WaterMark = "ISBN";
            this.txt_editISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_athr
            // 
            this.lbl_athr.AutoSize = true;
            this.lbl_athr.Location = new System.Drawing.Point(11, 163);
            this.lbl_athr.Name = "lbl_athr";
            this.lbl_athr.Size = new System.Drawing.Size(37, 19);
            this.lbl_athr.TabIndex = 13;
            this.lbl_athr.Text = "ISBN";
            this.lbl_athr.UseStyleColors = true;
            // 
            // lbl_nm
            // 
            this.lbl_nm.AutoSize = true;
            this.lbl_nm.Location = new System.Drawing.Point(11, 128);
            this.lbl_nm.Name = "lbl_nm";
            this.lbl_nm.Size = new System.Drawing.Size(49, 19);
            this.lbl_nm.TabIndex = 12;
            this.lbl_nm.Text = "Author";
            this.lbl_nm.UseStyleColors = true;
            // 
            // txt_editAuthor
            // 
            // 
            // 
            // 
            this.txt_editAuthor.CustomButton.Image = null;
            this.txt_editAuthor.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt_editAuthor.CustomButton.Name = "";
            this.txt_editAuthor.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_editAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_editAuthor.CustomButton.TabIndex = 1;
            this.txt_editAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_editAuthor.CustomButton.UseSelectable = true;
            this.txt_editAuthor.CustomButton.Visible = false;
            this.txt_editAuthor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_editAuthor.Lines = new string[0];
            this.txt_editAuthor.Location = new System.Drawing.Point(108, 124);
            this.txt_editAuthor.MaxLength = 32767;
            this.txt_editAuthor.Name = "txt_editAuthor";
            this.txt_editAuthor.PasswordChar = '\0';
            this.txt_editAuthor.PromptText = "Author\'s Name";
            this.txt_editAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_editAuthor.SelectedText = "";
            this.txt_editAuthor.SelectionLength = 0;
            this.txt_editAuthor.SelectionStart = 0;
            this.txt_editAuthor.ShortcutsEnabled = true;
            this.txt_editAuthor.Size = new System.Drawing.Size(247, 29);
            this.txt_editAuthor.TabIndex = 11;
            this.txt_editAuthor.UseSelectable = true;
            this.txt_editAuthor.UseStyleColors = true;
            this.txt_editAuthor.WaterMark = "Author\'s Name";
            this.txt_editAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_editAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pb_editBook
            // 
            this.pb_editBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_editBook.Image = global::AdminMain_ModernUi_.Properties.Resources.picssss;
            this.pb_editBook.Location = new System.Drawing.Point(371, 53);
            this.pb_editBook.Name = "pb_editBook";
            this.pb_editBook.Size = new System.Drawing.Size(242, 327);
            this.pb_editBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_editBook.TabIndex = 10;
            this.pb_editBook.TabStop = false;
            this.pb_editBook.Tag = "";
            this.pb_editBook.Click += new System.EventHandler(this.pb_editBook_Click);
            // 
            // lbl_bknm
            // 
            this.lbl_bknm.AutoSize = true;
            this.lbl_bknm.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_bknm.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_bknm.Location = new System.Drawing.Point(70, 515);
            this.lbl_bknm.Name = "lbl_bknm";
            this.lbl_bknm.Size = new System.Drawing.Size(105, 25);
            this.lbl_bknm.TabIndex = 27;
            this.lbl_bknm.Text = "Book Name";
            this.lbl_bknm.UseStyleColors = true;
            // 
            // by
            // 
            this.by.AutoSize = true;
            this.by.Location = new System.Drawing.Point(70, 547);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(23, 19);
            this.by.TabIndex = 28;
            this.by.Text = "By";
            // 
            // lbl_bkathr
            // 
            this.lbl_bkathr.AutoSize = true;
            this.lbl_bkathr.Location = new System.Drawing.Point(99, 547);
            this.lbl_bkathr.Name = "lbl_bkathr";
            this.lbl_bkathr.Size = new System.Drawing.Size(49, 19);
            this.lbl_bkathr.TabIndex = 29;
            this.lbl_bkathr.Text = "Author";
            // 
            // LibraryBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_bkathr);
            this.Controls.Add(this.by);
            this.Controls.Add(this.lbl_bknm);
            this.Controls.Add(this.pnl_edtbk);
            this.Controls.Add(this.lnkBks);
            this.Controls.Add(this.btn_updateForm);
            this.Controls.Add(this.btn_mDelete);
            this.Controls.Add(this.pb_viewBook);
            this.Controls.Add(this.cb_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.gridview);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "LibraryBooks";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "LibraryBooks";
            this.Load += new System.EventHandler(this.LibraryBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_viewBook)).EndInit();
            this.pnl_edtbk.ResumeLayout(false);
            this.pnl_edtbk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_mDelete;
        private System.Windows.Forms.PictureBox pb_viewBook;
        private MetroFramework.Controls.MetroComboBox cb_Search;
        private MetroFramework.Controls.MetroTextBox txt_Search;
        private MetroFramework.Controls.MetroGrid gridview;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_updateForm;
        private MetroFramework.Controls.MetroLink lnkBks;
        private MetroFramework.Controls.MetroPanel pnl_edtbk;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Delete;
        private MetroFramework.Controls.MetroTextBox txt_editID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl5;
        private MetroFramework.Controls.MetroTextBox txt_editGener;
        private MetroFramework.Controls.MetroLabel lbl3;
        private MetroFramework.Controls.MetroTextBox txt_editQuantity;
        private MetroFramework.Controls.MetroLabel lbl2;
        private MetroFramework.Controls.MetroTextBox txt_editNoOfPage;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Update;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_Close;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroComboBox cb_editCatagory;
        private MetroFramework.Controls.MetroLabel lbl_year;
        private MetroFramework.Controls.MetroComboBox cb_editYear;
        private MetroFramework.Controls.MetroLabel lbl_pblshr;
        private MetroFramework.Controls.MetroLabel lbl_edtn;
        private MetroFramework.Controls.MetroTextBox txt_editPublisher;
        private MetroFramework.Controls.MetroTextBox txt_editEdition;
        private MetroFramework.Controls.MetroTextBox txt_editName;
        private MetroFramework.Controls.MetroLabel lbl_isbn;
        private MetroFramework.Controls.MetroTextBox txt_editISBN;
        private MetroFramework.Controls.MetroLabel lbl_athr;
        private MetroFramework.Controls.MetroLabel lbl_nm;
        private MetroFramework.Controls.MetroTextBox txt_editAuthor;
        private System.Windows.Forms.PictureBox pb_editBook;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_editDescription;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_editAdvisor;
        private MetroFramework.Controls.MetroLabel lbl_bknm;
        private MetroFramework.Controls.MetroLabel by;
        private MetroFramework.Controls.MetroLabel lbl_bkathr;
    }
}