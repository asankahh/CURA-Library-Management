namespace AdminMain_ModernUi_.MemberStuff
{
    partial class MemLib_Books_Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemLib_Books_Review));
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.lbl2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_bknm = new MetroFramework.Controls.MetroLabel();
            this.txt_rev = new MetroFramework.Controls.MetroTextBox();
            this.lbl_3 = new MetroFramework.Controls.MetroLabel();
            this.btn_sbmt = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_cls = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lbl_4 = new MetroFramework.Controls.MetroLabel();
            this.r5 = new System.Windows.Forms.PictureBox();
            this.r4 = new System.Windows.Forms.PictureBox();
            this.r3 = new System.Windows.Forms.PictureBox();
            this.r2 = new System.Windows.Forms.PictureBox();
            this.r1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.r5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.AutoSize = true;
            this.lbl1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl1.Location = new System.Drawing.Point(205, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Review";
            this.lbl1.UseStyleColors = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(51, 56);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(83, 19);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Book name :";
            // 
            // lbl_bknm
            // 
            this.lbl_bknm.AutoSize = true;
            this.lbl_bknm.Location = new System.Drawing.Point(153, 55);
            this.lbl_bknm.Name = "lbl_bknm";
            this.lbl_bknm.Size = new System.Drawing.Size(87, 19);
            this.lbl_bknm.TabIndex = 2;
            this.lbl_bknm.Text = "[Book Name]";
            // 
            // txt_rev
            // 
            // 
            // 
            // 
            this.txt_rev.CustomButton.Image = null;
            this.txt_rev.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txt_rev.CustomButton.Name = "";
            this.txt_rev.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txt_rev.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_rev.CustomButton.TabIndex = 1;
            this.txt_rev.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_rev.CustomButton.UseSelectable = true;
            this.txt_rev.CustomButton.Visible = false;
            this.txt_rev.Lines = new string[0];
            this.txt_rev.Location = new System.Drawing.Point(150, 100);
            this.txt_rev.MaxLength = 500;
            this.txt_rev.Multiline = true;
            this.txt_rev.Name = "txt_rev";
            this.txt_rev.PasswordChar = '\0';
            this.txt_rev.PromptText = "Write Review";
            this.txt_rev.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_rev.SelectedText = "";
            this.txt_rev.SelectionLength = 0;
            this.txt_rev.SelectionStart = 0;
            this.txt_rev.ShortcutsEnabled = true;
            this.txt_rev.ShowClearButton = true;
            this.txt_rev.Size = new System.Drawing.Size(300, 100);
            this.txt_rev.TabIndex = 3;
            this.txt_rev.UseSelectable = true;
            this.txt_rev.WaterMark = "Write Review";
            this.txt_rev.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_rev.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(51, 100);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(56, 19);
            this.lbl_3.TabIndex = 4;
            this.lbl_3.Text = "Review :";
            // 
            // btn_sbmt
            // 
            this.btn_sbmt.Image = null;
            this.btn_sbmt.Location = new System.Drawing.Point(340, 285);
            this.btn_sbmt.Name = "btn_sbmt";
            this.btn_sbmt.Size = new System.Drawing.Size(110, 29);
            this.btn_sbmt.TabIndex = 5;
            this.btn_sbmt.Text = "Submit";
            this.btn_sbmt.UseSelectable = true;
            this.btn_sbmt.UseStyleColors = true;
            this.btn_sbmt.UseVisualStyleBackColor = true;
            this.btn_sbmt.Click += new System.EventHandler(this.btn_sbmt_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Image = null;
            this.btn_cls.Location = new System.Drawing.Point(150, 285);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(110, 29);
            this.btn_cls.TabIndex = 6;
            this.btn_cls.Text = "Close";
            this.btn_cls.UseSelectable = true;
            this.btn_cls.UseStyleColors = true;
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Location = new System.Drawing.Point(51, 226);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(53, 19);
            this.lbl_4.TabIndex = 4;
            this.lbl_4.Text = "Rating :";
            // 
            // r5
            // 
            this.r5.Image = global::AdminMain_ModernUi_.Properties.Resources.star_def;
            this.r5.Location = new System.Drawing.Point(410, 220);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(40, 40);
            this.r5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r5.TabIndex = 11;
            this.r5.TabStop = false;
            this.r5.Click += new System.EventHandler(this.r5_Click);
            this.r5.MouseLeave += new System.EventHandler(this.r5_MouseLeave);
            this.r5.MouseHover += new System.EventHandler(this.r5_MouseHover);
            // 
            // r4
            // 
            this.r4.Image = global::AdminMain_ModernUi_.Properties.Resources.star_def;
            this.r4.Location = new System.Drawing.Point(345, 220);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(40, 40);
            this.r4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r4.TabIndex = 10;
            this.r4.TabStop = false;
            this.r4.Click += new System.EventHandler(this.r4_Click);
            this.r4.MouseLeave += new System.EventHandler(this.r4_MouseLeave);
            this.r4.MouseHover += new System.EventHandler(this.r4_MouseHover);
            // 
            // r3
            // 
            this.r3.Image = global::AdminMain_ModernUi_.Properties.Resources.star_def;
            this.r3.Location = new System.Drawing.Point(280, 220);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(40, 40);
            this.r3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r3.TabIndex = 9;
            this.r3.TabStop = false;
            this.r3.Click += new System.EventHandler(this.r3_Click);
            this.r3.MouseLeave += new System.EventHandler(this.r3_MouseLeave);
            this.r3.MouseHover += new System.EventHandler(this.r3_MouseHover);
            // 
            // r2
            // 
            this.r2.Image = global::AdminMain_ModernUi_.Properties.Resources.star_def;
            this.r2.Location = new System.Drawing.Point(215, 220);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(40, 40);
            this.r2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r2.TabIndex = 8;
            this.r2.TabStop = false;
            this.r2.Click += new System.EventHandler(this.r2_Click);
            this.r2.MouseLeave += new System.EventHandler(this.r2_MouseLeave);
            this.r2.MouseHover += new System.EventHandler(this.r2_MouseHover);
            // 
            // r1
            // 
            this.r1.Image = global::AdminMain_ModernUi_.Properties.Resources.star_def;
            this.r1.Location = new System.Drawing.Point(150, 220);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(40, 40);
            this.r1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r1.TabIndex = 7;
            this.r1.TabStop = false;
            this.r1.Click += new System.EventHandler(this.r1_Click);
            this.r1.MouseLeave += new System.EventHandler(this.r1_MouseLeave);
            this.r1.MouseHover += new System.EventHandler(this.r1_MouseHover);
            // 
            // MemLib_Books_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 337);
            this.ControlBox = false;
            this.Controls.Add(this.r5);
            this.Controls.Add(this.r4);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_sbmt);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.txt_rev);
            this.Controls.Add(this.lbl_bknm);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "MemLib_Books_Review";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MemLib_Books_Review";
            this.Load += new System.EventHandler(this.MemLib_Books_Review_Load);
            ((System.ComponentModel.ISupportInitialize)(this.r5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroLabel lbl2;
        private MetroFramework.Controls.MetroLabel lbl_bknm;
        private MetroFramework.Controls.MetroTextBox txt_rev;
        private MetroFramework.Controls.MetroLabel lbl_3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_sbmt;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_cls;
        private MetroFramework.Controls.MetroLabel lbl_4;
        private System.Windows.Forms.PictureBox r1;
        private System.Windows.Forms.PictureBox r2;
        private System.Windows.Forms.PictureBox r3;
        private System.Windows.Forms.PictureBox r4;
        private System.Windows.Forms.PictureBox r5;
    }
}