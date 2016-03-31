using AdminMain_ModernUi_.Properties;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminMain_ModernUi_.LibCat
{
    public partial class LibShw : MetroForm
    {

        /* Create a object of Service */
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");

        public LibShw()
        {
            InitializeComponent();
        }

        public static string bk_id;
        

        private void LibShw_Load(object sender, EventArgs e)
        {
            int source = LibraryBooks.frm;
            
            if(source==1)
            {
                bk_id = LibraryBooks.bid;
            }
            else 
            {
                bk_id = MemberStuff.MLib_Books.bid;
            }
            
            DataTable DT = new DataTable();
            DT = client.getbkdata(bk_id);
            string bnm = null;
            string atr = null;
            string et = null;
            string isbn = null;
            string pbl = null;
            string yr = null;
            string dsc = null;
            byte[] bc = null;
            if (DT!=null)
            {
                bnm = DT.Rows[0][1].ToString();
                atr = DT.Rows[0][3].ToString();
                et = DT.Rows[0][4].ToString();
                isbn = DT.Rows[0][5].ToString();
                yr = DT.Rows[0][6].ToString();
                pbl = DT.Rows[0][7].ToString();
                dsc = DT.Rows[0][11].ToString();
                if(!Convert.IsDBNull(DT.Rows[0][16]))
                {
                    bc = (byte[])DT.Rows[0][16];
                }
                else
                {
                    pb_vwbk.Image = Resources.ncvr; 
                }
                
            }
            l_bnm.Text = bnm;
            l_at.Text = "By " + atr;
            if(et=="1")
            {
                l_ed.Text = et + " st Edition";
            }else if(et=="2")
            {
                l_ed.Text = et + " nd Edition";
            }else if(et=="3")
            {
                l_ed.Text = et + " rd Edition";
            }else
            {
                l_ed.Text = et + " th Edition";
            }
            l_ed.Text = et + " th Edition";
            l_isbn.Text = "ISBN - " + isbn;
            l_pb.Text = "by " + pbl;
            l_yr.Text = "Published on " + yr;
            l_dsc.Text = dsc;
            if (bc != null)
            {
                pb_vwbk.Image = Image.FromStream(new MemoryStream(bc));
            }
                
        }

        private void l_dsc_Click(object sender, EventArgs e)
        {

        }
    }
}
