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
    public partial class login : Form
    {
        /* Create a object of Service */
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */

        public static string chkusr;
        public static int wcfck;
        public static int dbck;

        public login()
        {
            InitializeComponent();                      
        }

        private void login_Load(object sender, EventArgs e)
        {
            chkcons();
        }        

        private void btn_ext_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_lgn_Click(object sender, EventArgs e)
        {
            AcceptButton = btn_lgn;
            loginmethod();
        }

        

        private void chkcons()
        {
            bool wcfchk = false;
            bool dbchk = false;
            try
            {
                wcfchk = client.wcf();
                if (wcfchk == true)
                {
                    wcfck = 1;
                    dbchk = client.db();
                    if (dbchk == true)
                    {
                        dbck = 1;
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There are some errors with connecting to database. if you having this message frequently please contact Technical Addministrator", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "There are some errors with connecting to Server. if you having this message frequently please contact Technical Addministrator. Technical Details : " + ex, "Server Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginmethod()
        {
            
            chkusr = txt_un.Text; /*assign textbox to string to pass server*/
            int avl = client.login_chkusr(chkusr);/* Pass string to server and get return value then assign it to var */
            if (avl == 1)
            {
                string pass = client.login_chkpw(chkusr);
                if (pass == txt_pw.Text)
                {
                    string status = client.login_chksts(chkusr);
                    if (status == "Admin")
                    {
                        this.Hide();
                        MAdminUi AUi = new MAdminUi();
                        AUi.ShowDialog();
                        this.Close();
                    }
                    else if (status == "Staff")
                    {
                        this.Hide();
                        MStaffUi MSUi = new MStaffUi();
                        MSUi.ShowDialog();
                        this.Close();
                    }
                    else if (status == "Member")
                    {
                        this.Hide();
                        MMemberUi MMUi = new MMemberUi();
                        MMUi.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Contact System Adminstrator", "Authentication Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Check Password again", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Check UserName again", "Wrong User Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
