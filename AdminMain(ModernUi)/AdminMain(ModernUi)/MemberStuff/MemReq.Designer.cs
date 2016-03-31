namespace AdminMain_ModernUi_.MemberStuff
{
    partial class MemReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemReq));
            this.lnkcls = new MetroFramework.Controls.MetroLink();
            this.grd_rq = new MetroFramework.Controls.MetroGrid();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.txt_msg = new MetroFramework.Controls.MetroTextBox();
            this.btn_sbmt = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.ErrMReq = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_rq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMReq)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkcls
            // 
            this.lnkcls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkcls.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkcls.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkcls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkcls.ImageSize = 32;
            this.lnkcls.Location = new System.Drawing.Point(24, 34);
            this.lnkcls.Name = "lnkcls";
            this.lnkcls.Size = new System.Drawing.Size(227, 37);
            this.lnkcls.TabIndex = 5;
            this.lnkcls.Text = "⬅  Requests - Complains";
            this.lnkcls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkcls.UseSelectable = true;
            this.lnkcls.UseStyleColors = true;
            this.lnkcls.Click += new System.EventHandler(this.lnkcls_Click);
            // 
            // grd_rq
            // 
            this.grd_rq.AllowUserToResizeRows = false;
            this.grd_rq.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_rq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_rq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd_rq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_rq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_rq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_rq.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_rq.EnableHeadersVisualStyles = false;
            this.grd_rq.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_rq.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_rq.Location = new System.Drawing.Point(34, 105);
            this.grd_rq.Name = "grd_rq";
            this.grd_rq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_rq.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd_rq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_rq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_rq.Size = new System.Drawing.Size(670, 521);
            this.grd_rq.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(711, 105);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 19);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Message";
            // 
            // txt_msg
            // 
            // 
            // 
            // 
            this.txt_msg.CustomButton.Image = null;
            this.txt_msg.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.txt_msg.CustomButton.Name = "";
            this.txt_msg.CustomButton.Size = new System.Drawing.Size(133, 133);
            this.txt_msg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_msg.CustomButton.TabIndex = 1;
            this.txt_msg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_msg.CustomButton.UseSelectable = true;
            this.txt_msg.CustomButton.Visible = false;
            this.txt_msg.Lines = new string[0];
            this.txt_msg.Location = new System.Drawing.Point(790, 105);
            this.txt_msg.MaxLength = 500;
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.PasswordChar = '\0';
            this.txt_msg.PromptText = "Type here";
            this.txt_msg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_msg.SelectedText = "";
            this.txt_msg.SelectionLength = 0;
            this.txt_msg.SelectionStart = 0;
            this.txt_msg.ShortcutsEnabled = true;
            this.txt_msg.Size = new System.Drawing.Size(365, 138);
            this.txt_msg.TabIndex = 8;
            this.txt_msg.UseSelectable = true;
            this.txt_msg.WaterMark = "Type here";
            this.txt_msg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_msg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_sbmt
            // 
            this.btn_sbmt.Image = null;
            this.btn_sbmt.Location = new System.Drawing.Point(1045, 264);
            this.btn_sbmt.Name = "btn_sbmt";
            this.btn_sbmt.Size = new System.Drawing.Size(110, 29);
            this.btn_sbmt.TabIndex = 9;
            this.btn_sbmt.Text = "Submit";
            this.btn_sbmt.UseSelectable = true;
            this.btn_sbmt.UseVisualStyleBackColor = true;
            this.btn_sbmt.Click += new System.EventHandler(this.btn_sbmt_Click);
            // 
            // ErrMReq
            // 
            this.ErrMReq.ContainerControl = this;
            // 
            // MemReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sbmt);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.grd_rq);
            this.Controls.Add(this.lnkcls);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "MemReq";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MemReq";
            this.Load += new System.EventHandler(this.MemReq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_rq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkcls;
        private MetroFramework.Controls.MetroGrid grd_rq;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroTextBox txt_msg;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_sbmt;
        private System.Windows.Forms.ErrorProvider ErrMReq;
    }
}