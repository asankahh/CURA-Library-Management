namespace AdminMain_ModernUi_
{
    partial class SplashScreen
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
            this.mpb = new MetroFramework.Controls.MetroProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_ldng = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mpb
            // 
            this.mpb.Location = new System.Drawing.Point(0, 310);
            this.mpb.Name = "mpb";
            this.mpb.Size = new System.Drawing.Size(600, 7);
            this.mpb.Style = MetroFramework.MetroColorStyle.Blue;
            this.mpb.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_ldng
            // 
            this.lbl_ldng.AutoSize = true;
            this.lbl_ldng.Location = new System.Drawing.Point(334, 288);
            this.lbl_ldng.Name = "lbl_ldng";
            this.lbl_ldng.Size = new System.Drawing.Size(0, 0);
            this.lbl_ldng.TabIndex = 1;
            this.lbl_ldng.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdminMain_ModernUi_.Properties.Resources.SplashScreen;
            this.ClientSize = new System.Drawing.Size(600, 338);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_ldng);
            this.Controls.Add(this.mpb);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar mpb;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel lbl_ldng;
    }
}