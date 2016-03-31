using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminMain_ModernUi_
{
    public partial class AccountsUi_New : MetroForm
    {
        // SqlConnection Conn = new SqlConnection("Data Source = ANUSHAN - PC; Initial Catalog = Curav2.1; Integrated Security = True");
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */

        // LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient();
        public AccountsUi_New()
        {
            InitializeComponent();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_sv_Click(object sender, EventArgs e)
        {
            string type = cb_typ.Text;
            string cat = cb_ctgry.Text;
            string des = txt_dscrptn.Text;
            string amt = txt_amnt.Text;
            int q = client.newtrans(type,cat,des,amt);
            if (q > 0)
            {
                MetroMessageBox.Show(this, "Transaction Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MetroMessageBox.Show(this, "Transaction Incomplete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
