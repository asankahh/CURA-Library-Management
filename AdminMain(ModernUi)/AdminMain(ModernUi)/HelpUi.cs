using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminMain_ModernUi_
{
    public partial class HelpUi : MetroForm
    {
        public HelpUi()
        {
            InitializeComponent();
        }

        private void lnkhlp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnk_hlp_Common_Click(object sender, EventArgs e)
        {
            
            //MetroMessageBox.Show(this, "Under Construction", "We are sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
