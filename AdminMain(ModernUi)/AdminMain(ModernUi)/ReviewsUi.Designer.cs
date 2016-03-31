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
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_usrnm = new MetroFramework.Controls.MetroLabel();
            this.txt_mmbrnm = new MetroFramework.Controls.MetroTextBox();
            this.lbl_msg = new MetroFramework.Controls.MetroLabel();
            this.txt_msg = new MetroFramework.Controls.MetroTextBox();
            this.lbl_rply = new MetroFramework.Controls.MetroLabel();
            this.txt_rply = new MetroFramework.Controls.MetroTextBox();
            this.lbl_mmbrID = new MetroFramework.Controls.MetroLabel();
            this.txt_mmbrID = new MetroFramework.Controls.MetroTextBox();
            this.btn_rply = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
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
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Message,
            this.respond});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(38, 78);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(649, 574);
            this.metroGrid1.TabIndex = 2;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            // 
            // respond
            // 
            this.respond.HeaderText = "Respond";
            this.respond.Name = "respond";
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
            this.lbl_msg.Location = new System.Drawing.Point(719, 196);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(60, 19);
            this.lbl_msg.TabIndex = 5;
            this.lbl_msg.Text = "Message";
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
            this.txt_msg.Location = new System.Drawing.Point(831, 196);
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
            // lbl_rply
            // 
            this.lbl_rply.AutoSize = true;
            this.lbl_rply.Location = new System.Drawing.Point(719, 401);
            this.lbl_rply.Name = "lbl_rply";
            this.lbl_rply.Size = new System.Drawing.Size(41, 19);
            this.lbl_rply.TabIndex = 7;
            this.lbl_rply.Text = "Reply";
            // 
            // txt_rply
            // 
            // 
            // 
            // 
            this.txt_rply.CustomButton.Image = null;
            this.txt_rply.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.txt_rply.CustomButton.Name = "";
            this.txt_rply.CustomButton.Size = new System.Drawing.Size(175, 175);
            this.txt_rply.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_rply.CustomButton.TabIndex = 1;
            this.txt_rply.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_rply.CustomButton.UseSelectable = true;
            this.txt_rply.CustomButton.Visible = false;
            this.txt_rply.Lines = new string[0];
            this.txt_rply.Location = new System.Drawing.Point(831, 401);
            this.txt_rply.MaxLength = 32767;
            this.txt_rply.Multiline = true;
            this.txt_rply.Name = "txt_rply";
            this.txt_rply.PasswordChar = '\0';
            this.txt_rply.PromptText = "reply";
            this.txt_rply.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_rply.SelectedText = "";
            this.txt_rply.SelectionLength = 0;
            this.txt_rply.SelectionStart = 0;
            this.txt_rply.ShortcutsEnabled = true;
            this.txt_rply.ShowClearButton = true;
            this.txt_rply.Size = new System.Drawing.Size(295, 180);
            this.txt_rply.TabIndex = 8;
            this.txt_rply.UseSelectable = true;
            this.txt_rply.WaterMark = "reply";
            this.txt_rply.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_rply.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // btn_rply
            // 
            this.btn_rply.Image = null;
            this.btn_rply.Location = new System.Drawing.Point(1015, 610);
            this.btn_rply.Name = "btn_rply";
            this.btn_rply.Size = new System.Drawing.Size(110, 29);
            this.btn_rply.TabIndex = 12;
            this.btn_rply.Text = "Reply";
            this.btn_rply.UseSelectable = true;
            this.btn_rply.UseVisualStyleBackColor = true;
            this.btn_rply.Click += new System.EventHandler(this.btn_rply_Click);
            // 
            // ReviewsUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.btn_rply);
            this.Controls.Add(this.txt_mmbrID);
            this.Controls.Add(this.lbl_mmbrID);
            this.Controls.Add(this.txt_rply);
            this.Controls.Add(this.lbl_rply);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.txt_mmbrnm);
            this.Controls.Add(this.lbl_usrnm);
            this.Controls.Add(this.metroGrid1);
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
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkRvws;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn respond;
        private MetroFramework.Controls.MetroLabel lbl_usrnm;
        private MetroFramework.Controls.MetroTextBox txt_mmbrnm;
        private MetroFramework.Controls.MetroLabel lbl_msg;
        private MetroFramework.Controls.MetroTextBox txt_msg;
        private MetroFramework.Controls.MetroLabel lbl_rply;
        private MetroFramework.Controls.MetroTextBox txt_rply;
        private MetroFramework.Controls.MetroLabel lbl_mmbrID;
        private MetroFramework.Controls.MetroTextBox txt_mmbrID;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_rply;
    }
}