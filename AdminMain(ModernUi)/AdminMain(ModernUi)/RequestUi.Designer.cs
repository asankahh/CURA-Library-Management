namespace AdminMain_ModernUi_
{
    partial class RequestUi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestUi));
            this.lnkRqsts = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_rply = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cb_Reply = new MetroFramework.Controls.MetroComboBox();
            this.txt_mmbrID = new MetroFramework.Controls.MetroTextBox();
            this.lbl_mmbrID = new MetroFramework.Controls.MetroLabel();
            this.lbl_rply = new MetroFramework.Controls.MetroLabel();
            this.txt_msg = new MetroFramework.Controls.MetroTextBox();
            this.lbl_msg = new MetroFramework.Controls.MetroLabel();
            this.txt_mmbrnm = new MetroFramework.Controls.MetroTextBox();
            this.lbl_usrnm = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ErrRMN = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrRMID = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrRMSG = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRMN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRMID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRMSG)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkRqsts
            // 
            this.lnkRqsts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRqsts.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkRqsts.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkRqsts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkRqsts.ImageSize = 32;
            this.lnkRqsts.Location = new System.Drawing.Point(24, 34);
            this.lnkRqsts.Name = "lnkRqsts";
            this.lnkRqsts.Size = new System.Drawing.Size(115, 37);
            this.lnkRqsts.TabIndex = 2;
            this.lnkRqsts.Text = "⬅  Requests";
            this.lnkRqsts.UseSelectable = true;
            this.lnkRqsts.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_rply);
            this.metroPanel1.Controls.Add(this.cb_Reply);
            this.metroPanel1.Controls.Add(this.txt_mmbrID);
            this.metroPanel1.Controls.Add(this.lbl_mmbrID);
            this.metroPanel1.Controls.Add(this.lbl_rply);
            this.metroPanel1.Controls.Add(this.txt_msg);
            this.metroPanel1.Controls.Add(this.lbl_msg);
            this.metroPanel1.Controls.Add(this.txt_mmbrnm);
            this.metroPanel1.Controls.Add(this.lbl_usrnm);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(623, 112);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(546, 485);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_rply
            // 
            this.btn_rply.Image = null;
            this.btn_rply.Location = new System.Drawing.Point(331, 319);
            this.btn_rply.Name = "btn_rply";
            this.btn_rply.Size = new System.Drawing.Size(110, 29);
            this.btn_rply.TabIndex = 22;
            this.btn_rply.Text = "Reply";
            this.btn_rply.UseSelectable = true;
            this.btn_rply.UseVisualStyleBackColor = true;
            this.btn_rply.Click += new System.EventHandler(this.btn_rply_Click);
            // 
            // cb_Reply
            // 
            this.cb_Reply.FormattingEnabled = true;
            this.cb_Reply.ItemHeight = 23;
            this.cb_Reply.Items.AddRange(new object[] {
            "Read - Not interested",
            "Read - Interested"});
            this.cb_Reply.Location = new System.Drawing.Point(147, 229);
            this.cb_Reply.Name = "cb_Reply";
            this.cb_Reply.Size = new System.Drawing.Size(294, 29);
            this.cb_Reply.TabIndex = 21;
            this.cb_Reply.UseSelectable = true;
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
            this.txt_mmbrID.Location = new System.Drawing.Point(147, 59);
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
            this.txt_mmbrID.TabIndex = 20;
            this.txt_mmbrID.UseSelectable = true;
            this.txt_mmbrID.WaterMark = "Member\'s ID";
            this.txt_mmbrID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mmbrID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_mmbrID.Click += new System.EventHandler(this.txt_mmbrID_Click);
            // 
            // lbl_mmbrID
            // 
            this.lbl_mmbrID.AutoSize = true;
            this.lbl_mmbrID.Location = new System.Drawing.Point(35, 59);
            this.lbl_mmbrID.Name = "lbl_mmbrID";
            this.lbl_mmbrID.Size = new System.Drawing.Size(76, 19);
            this.lbl_mmbrID.TabIndex = 19;
            this.lbl_mmbrID.Text = "Member ID";
            // 
            // lbl_rply
            // 
            this.lbl_rply.AutoSize = true;
            this.lbl_rply.Location = new System.Drawing.Point(35, 229);
            this.lbl_rply.Name = "lbl_rply";
            this.lbl_rply.Size = new System.Drawing.Size(41, 19);
            this.lbl_rply.TabIndex = 16;
            this.lbl_rply.Text = "Reply";
            // 
            // txt_msg
            // 
            // 
            // 
            // 
            this.txt_msg.CustomButton.Image = null;
            this.txt_msg.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txt_msg.CustomButton.Name = "";
            this.txt_msg.CustomButton.Size = new System.Drawing.Size(97, 97);
            this.txt_msg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_msg.CustomButton.TabIndex = 1;
            this.txt_msg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_msg.CustomButton.UseSelectable = true;
            this.txt_msg.CustomButton.Visible = false;
            this.txt_msg.Enabled = false;
            this.txt_msg.Lines = new string[0];
            this.txt_msg.Location = new System.Drawing.Point(147, 101);
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
            this.txt_msg.Size = new System.Drawing.Size(295, 99);
            this.txt_msg.TabIndex = 15;
            this.txt_msg.UseSelectable = true;
            this.txt_msg.WaterMark = "Message";
            this.txt_msg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_msg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_msg.Click += new System.EventHandler(this.txt_msg_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(35, 101);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(55, 19);
            this.lbl_msg.TabIndex = 14;
            this.lbl_msg.Text = "Request";
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
            this.txt_mmbrnm.Location = new System.Drawing.Point(147, 17);
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
            this.txt_mmbrnm.TabIndex = 13;
            this.txt_mmbrnm.UseSelectable = true;
            this.txt_mmbrnm.WaterMark = "Member\'s Name";
            this.txt_mmbrnm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mmbrnm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_mmbrnm.Click += new System.EventHandler(this.txt_mmbrnm_Click);
            // 
            // lbl_usrnm
            // 
            this.lbl_usrnm.AutoSize = true;
            this.lbl_usrnm.Location = new System.Drawing.Point(35, 17);
            this.lbl_usrnm.Name = "lbl_usrnm";
            this.lbl_usrnm.Size = new System.Drawing.Size(60, 19);
            this.lbl_usrnm.TabIndex = 12;
            this.lbl_usrnm.Text = "Member";
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
            this.metroGrid1.Location = new System.Drawing.Point(24, 112);
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
            this.metroGrid1.Size = new System.Drawing.Size(571, 485);
            this.metroGrid1.TabIndex = 4;
            this.metroGrid1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.metroGrid1_MouseDoubleClick);
            // 
            // ErrRMN
            // 
            this.ErrRMN.ContainerControl = this;
            // 
            // ErrRMID
            // 
            this.ErrRMID.ContainerControl = this;
            // 
            // ErrRMSG
            // 
            this.ErrRMSG.ContainerControl = this;
            // 
            // RequestUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lnkRqsts);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "RequestUi";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "RequestUi";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.RequestUi_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRMN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRMID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRMSG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkRqsts;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel lbl_usrnm;
        private MetroFramework.Controls.MetroTextBox txt_mmbrnm;
        private MetroFramework.Controls.MetroLabel lbl_msg;
        private MetroFramework.Controls.MetroTextBox txt_msg;
        private MetroFramework.Controls.MetroLabel lbl_rply;
        private MetroFramework.Controls.MetroLabel lbl_mmbrID;
        private MetroFramework.Controls.MetroTextBox txt_mmbrID;
        private MetroFramework.Controls.MetroComboBox cb_Reply;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_rply;
        private System.Windows.Forms.ErrorProvider ErrRMN;
        private System.Windows.Forms.ErrorProvider ErrRMID;
        private System.Windows.Forms.ErrorProvider ErrRMSG;
    }
}