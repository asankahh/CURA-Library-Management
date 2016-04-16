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

namespace AdminMain_ModernUi_
{
    public partial class GoogleBooks : MetroForm
    {
        public GoogleBooks()
        {
            InitializeComponent();
        }

        private void lnk_bck_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
