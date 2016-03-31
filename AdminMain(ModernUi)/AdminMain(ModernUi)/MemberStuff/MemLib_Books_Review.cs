using MetroFramework;
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
    public partial class MemLib_Books_Review : MetroForm
    {
        public MemLib_Books_Review()
        {
            InitializeComponent();
        }

        private void btn_sbmt_Click(object sender, EventArgs e)
        {

            MetroMessageBox.Show(this, "Submitting a review", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            Close();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
