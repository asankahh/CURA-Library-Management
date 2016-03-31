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
    public partial class AccountsUi : MetroForm
    {
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");/* use net.tcp for secure transmission */
        public AccountsUi()
        {
            InitializeComponent();
        }

        private void AccountsUi_Load(object sender, EventArgs e)
        {
            DataTable DTin = new DataTable();
            DTin = client.transldin();
            grd_incm.DataSource = DTin;
            grd_incm.Refresh();
            grd_incm.Update();

            DataTable DTex = new DataTable();
            DTex = client.transldex();
            grd_xpncs.DataSource = DTex;
            grd_xpncs.Refresh();
            grd_xpncs.Update();

            int sumIc = 0;
            for (int i = 0; i < grd_incm.Rows.Count; i++)
            {
                sumIc += Convert.ToInt32(grd_incm.Rows[i].Cells[1].Value);
            }
            lbl_ttlincmShow.Text = sumIc.ToString();

            int sumEx = 0;
            for (int i = 0; i < grd_xpncs.Rows.Count; i++)
            {
                sumEx += Convert.ToInt32(grd_xpncs.Rows[i].Cells[1].Value);
            }
            ttlxpncsShow.Text = sumEx.ToString();

            int a = sumIc;
            int b = sumEx;
            int sumBal = 0;

            sumBal = a - b;
            lbl_ttlshw.Text = sumBal.ToString();
        }

        private void lnkAccounts_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nw_Click(object sender, EventArgs e)
        {
            AccountsUi_New AUiN = new AccountsUi_New();
            StyleManager.Clone(AUiN);
            AUiN.ShowDialog();
        }

        private void btn_slct_Click(object sender, EventArgs e)
        {
            int mon = 0;
            string mnt = cb_mnth.Text;
            switch (mnt)
            {
                case "January":
                    mon = 01;
                    break;

                case "February":
                    mon = 02;
                    break;

                case "March":
                    mon = 03;
                    break;
                case "April":
                    mon = 04;
                    break;
                case "May":
                    mon = 05;
                    break;
                case "June":
                    mon = 06;
                    break;
                case "July":
                    mon = 07;
                    break;
                case "August":
                    mon = 08;
                    break;
                case "September":
                    mon = 09;
                    break;
                case "October":
                    mon = 10;
                    break;
                case "November":
                    mon = 11;
                    break;
                case "December":
                    mon = 12;
                    break;
            }
            BindingSource BSin = new BindingSource();
            BindingSource BSex = new BindingSource();

           // string qryex = "SELECT Date,Amount FROM Transactions WHERE DATEPART(MONTH,Date) ='" + mon.ToString() + "'AND Type = 'Expence'";

           // Conn.Open();

           // SqlCommand cmin = new SqlCommand(qryin, Conn);
           // SqlCommand cmex = new SqlCommand(qryex, Conn);

          //  SqlDataAdapter SDAin = new SqlDataAdapter(cmin);
          //  SqlDataAdapter SDAex = new SqlDataAdapter(cmex);

          //  SDAin.SelectCommand = cmin;
           // SDAex.SelectCommand = cmex;

            DataTable DTin = new DataTable();
            DataTable DTex = new DataTable();
            string pm = mon.ToString();
            DTin = client.Selectin(pm);
            DTex = client.Selectex(pm);
          //  SDAin.Fill(DTin);
           // SDAex.Fill(DTex);

            BSin.DataSource = DTin;
            BSex.DataSource = DTex;

            grd_incm.DataSource = BSin;
            grd_xpncs.DataSource = BSex;

           // Conn.Close();

            int sumIc = 0;
            for (int i = 0; i < grd_incm.Rows.Count; i++)
            {
                sumIc += Convert.ToInt32(grd_incm.Rows[i].Cells[1].Value);

            }
            lbl_ttlincmShow.Text = sumIc.ToString();



            int sumEx = 0;
            for (int i = 0; i < grd_xpncs.Rows.Count; i++)
            {
                sumEx += Convert.ToInt32(grd_xpncs.Rows[i].Cells[1].Value);

            }
            ttlxpncsShow.Text = sumEx.ToString();

            int a = sumIc;
            int b = sumEx;
            int sumBal = 0;

            sumBal = a - b;
            lbl_ttlshw.Text = sumBal.ToString();

        }
    }
    }

