namespace AdminMain_ModernUi_
{
    partial class ReviewsUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewsUi));
            this.lnkRvws = new MetroFramework.Controls.MetroLink();
            this.grd = new MetroFramework.Controls.MetroGrid();
            this.lbl_usrnm = new MetroFramework.Controls.MetroLabel();
            this.txt_mmbrnm = new MetroFramework.Controls.MetroTextBox();
            this.lbl_msg = new MetroFramework.Controls.MetroLabel();
            this.txt_msg = new MetroFramework.Controls.MetroTextBox();
            this.lbl_mmbrID = new MetroFramework.Controls.MetroLabel();
            this.txt_mmbrID = new MetroFramework.Controls.MetroTextBox();
            this.btn_dlt = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.r5 = new System.Windows.Forms.PictureBox();
            this.r4 = new System.Windows.Forms.PictureBox();
            this.r3 = new System.Windows.Forms.PictureBox();
            this.r2 = new System.Windows.Forms.PictureBox();
            this.r1 = new System.Windows.Forms.PictureBox();
            this.lbl_4 = new MetroFramework.Controls.MetroLabel();
            this.txt_bknm = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkRvws
            // 
            this.lnkRvws.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRvws.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkRvws.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkRvws.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkRvws.ImageSize = 32;
            this.lnkRvws.Location = new System.Drawing.Point(24, 34);
            this.lnkRvws.Name = "lnkRvws";
            this.lnkRvws.Size = new System.Drawing.Size(105, 37);
            this.lnkRvws.TabIndex = 1;
            this.lnkRvws.Text = "⬅  Reviews";
            this.lnkRvws.UseSelectable = true;
            this.lnkRvws.UseStyleColors = true;
            this.lnkRvws.Click += new System.EventHandler(this.lnkRvws_Click);
            // 
            // grd
            // 
            this.grd.AllowUserToResizeRows = false;
            this.grd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd.EnableHeadersVisualStyles = false;
            this.grd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd.Location = new System.Drawing.Point(38, 78);
            this.grd.Name = "grd";
            this.grd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(649, 574);
            this.grd.TabIndex = 2;
            this.grd.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grd_RowHeaderMouseClick);
            // 
            // lbl_usrnm
            // 
            this.lbl_usrnm.AutoSize = true;
            this.lbl_usrnm.Location = new System.Drawing.Point(719, 112);
            this.lbl_usrnm.Name = "lbl_usrnm";
            this.lbl_usrnm.Size = new System.Drawing.Size(60, 19);
            this.lbl_usrnm.TabIndex = 3;
            this.lbl_usrnm.Text = "Member";
            // 
            // txt_mmbrnm
            // 
            // 
            // 
            // 
            this.txt_mmbrnm.CustomButton.Image = null;
            this.txt_mmbrnm.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.txt_mmbrnm.CustomButton.Name = "";
            this.txt_mmbrnm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_mmbrnm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mmbrnm.CustomButton.TabIndex = 1;
            this.txt_mmbrnm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mmbrnm.CustomButton.UseSelectable = true;
            this.txt_mmbrnm.CustomButton.Visible = false;
            this.txt_mmbrnm.Enabled = false;
            this.txt_mmbrnm.Lines = new string[0];
            this.txt_mmbrnm.Location = new System.Drawing.Point(831, 112);
            this.txt_mmbrnm.MaxLength = 32767;
            this.txt_mmbrnm.Name = "txt_mmbrnm";
            this.txt_mmbrnm.PasswordChar = '\0';
            this.txt_mmbrnm.PromptText = "Member\'s Name";
            this.txt_mmbrnm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mmbrnm.SelectedText = "";
            this.txt_mmbrnm.SelectionLength = 0;
            this.txt_mmbrnm.SelectionStart = 0;
            this.txt_mmbrnm.ShortcutsEnabled = true;
            this.txt_mmbrnm.Size = new System.Drawing.Size(295, 23);
            this.txt_mmbrnm.TabIndex = 4;
            this.txt_mmbrnm.UseSelectable = true;
            this.txt_mmbrnm.WaterMark = "Member\'s Name";
            this.txt_mmbrnm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mmbrnm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(719, 248);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(49, 19);
            this.lbl_msg.TabIndex = 5;
            this.lbl_msg.Text = "Review";
            // 
            // txt_msg
            // 
            // 
            // 
            // 
            this.txt_msg.CustomButton.Image = null;
            this.txt_msg.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txt_msg.CustomButton.Name = "";
            this.txt_msg.CustomButton.Size = new System.Drawing.Size(181, 181);
            this.txt_msg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_msg.CustomButton.TabIndex = 1;
            this.txt_msg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_msg.CustomButton.UseSelectable = true;
            this.txt_msg.CustomButton.Visible = false;
            this.txt_msg.Enabled = false;
            this.txt_msg.Lines = new string[0];
            this.txt_msg.Location = new System.Drawing.Point(831, 248);
            this.txt_msg.MaxLength = 32767;
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.PasswordChar = '\0';
            this.txt_msg.PromptText = "Message";
            this.txt_msg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_msg.SelectedText = "";
            this.txt_msg.SelectionLength = 0;
            this.txt_msg.SelectionStart = 0;
            this.txt_msg.ShortcutsEnabled = true;
            this.txt_msg.Size = new System.Drawing.Size(295, 183);
            this.txt_msg.TabIndex = 6;
            this.txt_msg.UseSelectable = true;
            this.txt_msg.WaterMark = "Message";
            this.txt_msg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_msg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_mmbrID
            // 
            this.lbl_mmbrID.AutoSize = true;
            this.lbl_mmbrID.Location = new System.Drawing.Point(719, 154);
            this.lbl_mmbrID.Name = "lbl_mmbrID";
            this.lbl_mmbrID.Size = new System.Drawing.Size(76, 19);
            this.lbl_mmbrID.TabIndex = 10;
            this.lbl_mmbrID.Text = "Member ID";
            // 
            // txt_mmbrID
            // 
            // 
            // 
            // 
            this.txt_mmbrID.CustomButton.Image = null;
            this.txt_mmbrID.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.txt_mmbrID.CustomButton.Name = "";
            this.txt_mmbrID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_mmbrID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mmbrID.CustomButton.TabIndex = 1;
            this.txt_mmbrID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mmbrID.CustomButton.UseSelectable = true;
            this.txt_mmbrID.CustomButton.Visible = false;
            this.txt_mmbrID.Enabled = false;
            this.txt_mmbrID.Lines = new string[0];
            this.txt_mmbrID.Location = new System.Drawing.Point(831, 154);
            this.txt_mmbrID.MaxLength = 32767;
            this.txt_mmbrID.Name = "txt_mmbrID";
            this.txt_mmbrID.PasswordChar = '\0';
            this.txt_mmbrID.PromptText = "Member\'s ID";
            this.txt_mmbrID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mmbrID.SelectedText = "";
            this.txt_mmbrID.SelectionLength = 0;
            this.txt_mmbrID.SelectionStart = 0;
            this.txt_mmbrID.ShortcutsEnabled = true;
            this.txt_mmbrID.Size = new System.Drawing.Size(294, 23);
            this.txt_mmbrID.TabIndex = 11;
            this.txt_mmbrID.UseSelectable = true;
            this.txt_mmbrID.WaterMark = "Member\'s ID";
            this.txt_mmbrID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mmbrID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_dlt
            // 
            this.btn_dlt.Image = null;
            this.btn_dlt.Location = new System.Drawing.Point(1015, 610);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(110, 29);
            this.btn_dlt.TabIndex = 12;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseSelectable = true;
            this.btn_dlt.UseVisualStyleBackColor = true;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // r5
            // 
            this.r5.Location = new System.Drawing.Point(1085, 453);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(40, 40);
            this.r5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r5.TabIndex = 18;
            this.r5.TabStop = false;
            // 
            // r4
            // 
            this.r4.Location = new System.Drawing.Point(1015, 453);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(40, 40);
            this.r4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r4.TabIndex = 17;
            this.r4.TabStop = false;
            // 
            // r3
            // 
            this.r3.Location = new System.Drawing.Point(950, 453);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(40, 40);
            this.r3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r3.TabIndex = 16;
            this.r3.TabStop = false;
            // 
            // r2
            // 
            this.r2.Location = new System.Drawing.Point(891, 453);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(40, 40);
            this.r2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r2.TabIndex = 15;
            this.r2.TabStop = false;
            // 
            // r1
            // 
            this.r1.Location = new System.Drawing.Point(831, 453);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(40, 40);
            this.r1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r1.TabIndex = 14;
            this.r1.TabStop = false;
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Location = new System.Drawing.Point(719, 459);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(53, 19);
            this.lbl_4.TabIndex = 13;
            this.lbl_4.Text = "Rating :";
            // 
            // txt_bknm
            // 
            // 
            // 
            // 
            this.txt_bknm.CustomButton.Image = null;
            this.txt_bknm.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.txt_bknm.CustomButton.Name = "";
            this.txt_bknm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_bknm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bknm.CustomButton.TabIndex = 1;
            this.txt_bknm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bknm.CustomButton.UseSelectable = true;
            this.txt_bknm.CustomButton.Visible = false;
            this.txt_bknm.Enabled = false;
            this.txt_bknm.Lines = new string[0];
            this.txt_bknm.Location = new System.Drawing.Point(831, 197);
            this.txt_bknm.MaxLength = 32767;
            this.txt_bknm.Name = "txt_bknm";
            this.txt_bknm.PasswordChar = '\0';
            this.txt_bknm.PromptText = "Member\'s ID";
            this.txt_bknm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bknm.SelectedText = "";
            this.txt_bknm.SelectionLength = 0;
            this.txt_bknm.SelectionStart = 0;
            this.txt_bknm.ShortcutsEnabled = true;
            this.txt_bknm.Size = new System.Drawing.Size(294, 23);
            this.txt_bknm.TabIndex = 20;
            this.txt_bknm.UseSelectable = true;
            this.txt_bknm.WaterMark = "Member\'s ID";
            this.txt_bknm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_bknm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(719, 197);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Book name";
            // 
            // ReviewsUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.txt_bknm);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.r5);
            this.Controls.Add(this.r4);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.txt_mmbrID);
            this.Controls.Add(this.lbl_mmbrID);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.txt_mmbrnm);
            this.Controls.Add(this.lbl_usrnm);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.lnkRvws);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "ReviewsUi";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "ReviewsUi";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.ReviewsUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkRvws;
        private MetroFramework.Controls.MetroGrid grd;
        private MetroFramework.Controls.MetroLabel lbl_usrnm;
        private MetroFramework.Controls.MetroTextBox txt_mmbrnm;
        private MetroFramework.Controls.MetroLabel lbl_msg;
        private MetroFramework.Controls.MetroTextBox txt_msg;
        private MetroFramework.Controls.MetroLabel lbl_mmbrID;
        private MetroFramework.Controls.MetroTextBox txt_mmbrID;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_dlt;
        private System.Windows.Forms.PictureBox r5;
        private System.Windows.Forms.PictureBox r4;
        private System.Windows.Forms.PictureBox r3;
        private System.Windows.Forms.PictureBox r2;
        private System.Windows.Forms.PictureBox r1;
        private MetroFramework.Controls.MetroLabel lbl_4;
        private MetroFramework.Controls.MetroTextBox txt_bknm;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}