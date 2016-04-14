using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminMain_ModernUi_.MemberStuff
{
    public partial class MemLib_Books_Reserve : MetroForm
    {
        public MemLib_Books_Reserve()
        {
            InitializeComponent();
        }

        private void lnk_rsrv_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
