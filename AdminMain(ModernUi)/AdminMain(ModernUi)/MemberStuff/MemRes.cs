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
    public partial class MemRes : MetroForm
    {
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */

        public MemRes()
        {
            InitializeComponent();
        }

        private void lnkcls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MemRes_Load(object sender, EventArgs e)
        {            
            grd_res.DataSource = client.mRes();
            grd_res.Refresh();
            grd_res.Update();
        }
    }
}
