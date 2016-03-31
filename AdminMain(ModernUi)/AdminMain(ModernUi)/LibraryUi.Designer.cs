namespace AdminMain_ModernUi_
{
    partial class LibraryUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryUi));
            this.lnkLbrry = new MetroFramework.Controls.MetroLink();
            this.pnl_pb = new System.Windows.Forms.Panel();
            this.lnk_new = new MetroFramework.Controls.MetroLink();
            this.pb_dgtlarchv = new System.Windows.Forms.PictureBox();
            this.pb_thss = new System.Windows.Forms.PictureBox();
            this.pb_nwspprs = new System.Windows.Forms.PictureBox();
            this.pb_jrnls = new System.Windows.Forms.PictureBox();
            this.pb_mgzns = new System.Windows.Forms.PictureBox();
            this.pb_bks = new System.Windows.Forms.PictureBox();
            this.pnl_pb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgtlarchv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nwspprs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jrnls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mgzns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bks)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkLbrry
            // 
            this.lnkLbrry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkLbrry.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkLbrry.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkLbrry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLbrry.ImageSize = 32;
            this.lnkLbrry.Location = new System.Drawing.Point(24, 34);
            this.lnkLbrry.Name = "lnkLbrry";
            this.lnkLbrry.Size = new System.Drawing.Size(115, 37);
            this.lnkLbrry.TabIndex = 3;
            this.lnkLbrry.Text = "⬅  Library";
            this.lnkLbrry.UseSelectable = true;
            this.lnkLbrry.UseStyleColors = true;
            this.lnkLbrry.Click += new System.EventHandler(this.lnkLbrry_Click);
            // 
            // pnl_pb
            // 
            this.pnl_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_pb.Controls.Add(this.pb_dgtlarchv);
            this.pnl_pb.Controls.Add(this.pb_thss);
            this.pnl_pb.Controls.Add(this.pb_nwspprs);
            this.pnl_pb.Controls.Add(this.pb_jrnls);
            this.pnl_pb.Controls.Add(this.pb_mgzns);
            this.pnl_pb.Controls.Add(this.pb_bks);
            this.pnl_pb.Location = new System.Drawing.Point(185, 142);
            this.pnl_pb.Name = "pnl_pb";
            this.pnl_pb.Size = new System.Drawing.Size(830, 475);
            this.pnl_pb.TabIndex = 17;
            // 
            // lnk_new
            // 
            this.lnk_new.Image = global::AdminMain_ModernUi_.Properties.Resources.add_h;
            this.lnk_new.ImageSize = 60;
            this.lnk_new.Location = new System.Drawing.Point(934, 34);
            this.lnk_new.Name = "lnk_new";
            this.lnk_new.NoFocusImage = global::AdminMain_ModernUi_.Properties.Resources.add;
            this.lnk_new.Size = new System.Drawing.Size(61, 62);
            this.lnk_new.TabIndex = 19;
            this.lnk_new.UseSelectable = true;
            this.lnk_new.UseStyleColors = true;
            this.lnk_new.Click += new System.EventHandler(this.lnk_new_Click);
            // 
            // pb_dgtlarchv
            // 
            this.pb_dgtlarchv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_dgtlarchv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_dgtlarchv.Image = global::AdminMain_ModernUi_.Properties.Resources.Dgtl;
            this.pb_dgtlarchv.Location = new System.Drawing.Point(560, 275);
            this.pb_dgtlarchv.Name = "pb_dgtlarchv";
            this.pb_dgtlarchv.Size = new System.Drawing.Size(250, 125);
            this.pb_dgtlarchv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_dgtlarchv.TabIndex = 5;
            this.pb_dgtlarchv.TabStop = false;
            this.pb_dgtlarchv.Click += new System.EventHandler(this.pb_dgtlarchv_Click);
            this.pb_dgtlarchv.MouseLeave += new System.EventHandler(this.pb_dgtlarchv_MouseLeave);
            this.pb_dgtlarchv.MouseHover += new System.EventHandler(this.pb_dgtlarchv_MouseHover);
            // 
            // pb_thss
            // 
            this.pb_thss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_thss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_thss.Image = global::AdminMain_ModernUi_.Properties.Resources.Thss;
            this.pb_thss.Location = new System.Drawing.Point(20, 275);
            this.pb_thss.Name = "pb_thss";
            this.pb_thss.Size = new System.Drawing.Size(250, 125);
            this.pb_thss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_thss.TabIndex = 4;
            this.pb_thss.TabStop = false;
            this.pb_thss.Click += new System.EventHandler(this.pb_thss_Click);
            this.pb_thss.MouseLeave += new System.EventHandler(this.pb_thss_MouseLeave);
            this.pb_thss.MouseHover += new System.EventHandler(this.pb_thss_MouseHover);
            // 
            // pb_nwspprs
            // 
            this.pb_nwspprs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_nwspprs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_nwspprs.Image = global::AdminMain_ModernUi_.Properties.Resources.Nwspprs;
            this.pb_nwspprs.Location = new System.Drawing.Point(560, 75);
            this.pb_nwspprs.Name = "pb_nwspprs";
            this.pb_nwspprs.Size = new System.Drawing.Size(250, 125);
            this.pb_nwspprs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_nwspprs.TabIndex = 3;
            this.pb_nwspprs.TabStop = false;
            this.pb_nwspprs.Click += new System.EventHandler(this.pb_nwspprs_Click);
            this.pb_nwspprs.MouseLeave += new System.EventHandler(this.pb_nwspprs_MouseLeave);
            this.pb_nwspprs.MouseHover += new System.EventHandler(this.pb_nwspprs_MouseHover);
            // 
            // pb_jrnls
            // 
            this.pb_jrnls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_jrnls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_jrnls.Image = global::AdminMain_ModernUi_.Properties.Resources.Jrnls;
            this.pb_jrnls.Location = new System.Drawing.Point(290, 275);
            this.pb_jrnls.Name = "pb_jrnls";
            this.pb_jrnls.Size = new System.Drawing.Size(250, 125);
            this.pb_jrnls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_jrnls.TabIndex = 2;
            this.pb_jrnls.TabStop = false;
            this.pb_jrnls.Click += new System.EventHandler(this.pb_jrnls_Click);
            this.pb_jrnls.MouseLeave += new System.EventHandler(this.pb_jrnls_MouseLeave);
            this.pb_jrnls.MouseHover += new System.EventHandler(this.pb_jrnls_MouseHover);
            // 
            // pb_mgzns
            // 
            this.pb_mgzns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_mgzns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_mgzns.Image = global::AdminMain_ModernUi_.Properties.Resources.Mgzns;
            this.pb_mgzns.Location = new System.Drawing.Point(290, 75);
            this.pb_mgzns.Name = "pb_mgzns";
            this.pb_mgzns.Size = new System.Drawing.Size(250, 125);
            this.pb_mgzns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_mgzns.TabIndex = 1;
            this.pb_mgzns.TabStop = false;
            this.pb_mgzns.Click += new System.EventHandler(this.pb_mgzns_Click);
            this.pb_mgzns.MouseLeave += new System.EventHandler(this.pb_mgzns_MouseLeave);
            this.pb_mgzns.MouseHover += new System.EventHandler(this.pb_mgzns_MouseHover);
            // 
            // pb_bks
            // 
            this.pb_bks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_bks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_bks.Image = global::AdminMain_ModernUi_.Properties.Resources.Bks;
            this.pb_bks.Location = new System.Drawing.Point(20, 75);
            this.pb_bks.Name = "pb_bks";
            this.pb_bks.Size = new System.Drawing.Size(250, 125);
            this.pb_bks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_bks.TabIndex = 0;
            this.pb_bks.TabStop = false;
            this.pb_bks.Click += new System.EventHandler(this.pb_bks_Click);
            this.pb_bks.MouseLeave += new System.EventHandler(this.pb_bks_MouseLeave);
            this.pb_bks.MouseHover += new System.EventHandler(this.pb_bks_MouseHover);
            // 
            // LibraryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.lnk_new);
            this.Controls.Add(this.pnl_pb);
            this.Controls.Add(this.lnkLbrry);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "LibraryUi";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LibraryUi";
            this.pnl_pb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgtlarchv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nwspprs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jrnls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mgzns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkLbrry;
        private System.Windows.Forms.Panel pnl_pb;
        private System.Windows.Forms.PictureBox pb_dgtlarchv;
        private System.Windows.Forms.PictureBox pb_thss;
        private System.Windows.Forms.PictureBox pb_nwspprs;
        private System.Windows.Forms.PictureBox pb_jrnls;
        private System.Windows.Forms.PictureBox pb_mgzns;
        private System.Windows.Forms.PictureBox pb_bks;
        private MetroFramework.Controls.MetroLink lnk_new;
    }
}