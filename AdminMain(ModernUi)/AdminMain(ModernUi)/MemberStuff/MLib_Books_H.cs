using AdminMain_ModernUi_.Properties;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminMain_ModernUi_.MemberStuff
{
    public partial class MLib_Books_H : MetroForm
    {
        /* Create a object of Service */
        LibraryService.CuraServiceClient client = new LibraryService.CuraServiceClient("NetTcpBinding_ICuraService");
        /* Database String */
        public static string dbstrng = "Data Source=ASA-LAPTOP-MSI;Initial Catalog=Cura_V3.5;Integrated Security=True";
        ///* create secondary database object */
        //SqlConnection conn = new SqlConnection(dbstrng);
        public MLib_Books_H()
        {
            InitializeComponent();
        }

        private void lnkbks_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnk_all_Click(object sender, EventArgs e)
        {
            MLib_Books MLB = new MLib_Books();
            StyleManager.Clone(MLB);
            MLB.ShowDialog();
        }

        private void MLib_Books_H_Load(object sender, EventArgs e)
        {
            rbk();            
        }

        private void rfsh_Click(object sender, EventArgs e)
        {
            rbk();
        }

        public void rbk()
        {
            DataTable grb = new DataTable();
            grb = client.randomBooks();

            string n0 = grb.Rows[0][0].ToString();
            string a0 = grb.Rows[0][1].ToString();
            byte[] i0 = null;
            if (!Convert.IsDBNull(grb.Rows[0][2]))
            {
                i0 = (byte[])grb.Rows[0][2];
            }

            string n1 = grb.Rows[1][0].ToString();
            string a1 = grb.Rows[1][1].ToString();
            byte[] i1 = null;
            if (!Convert.IsDBNull(grb.Rows[1][2]))
            {
                i1 = (byte[])grb.Rows[1][2];
            }

            string n2 = grb.Rows[2][0].ToString();
            string a2 = grb.Rows[2][1].ToString();
            byte[] i2 = null;
            if (!Convert.IsDBNull(grb.Rows[2][2]))
            {
                i2 = (byte[])grb.Rows[2][2];
            }

            string n3 = grb.Rows[3][0].ToString();
            string a3 = grb.Rows[3][1].ToString();
            byte[] i3 = null;
            if (!Convert.IsDBNull(grb.Rows[3][2]))
            {
                i3 = (byte[])grb.Rows[3][2];
            }

            string n4 = grb.Rows[4][0].ToString();
            string a4 = grb.Rows[4][1].ToString();
            byte[] i4 = null;
            if (!Convert.IsDBNull(grb.Rows[4][2]))
            {
                i4 = (byte[])grb.Rows[4][2];
            }

            string n5 = grb.Rows[5][0].ToString();
            string a5 = grb.Rows[5][1].ToString();
            byte[] i5 = null;
            if (!Convert.IsDBNull(grb.Rows[5][2]))
            {
                i5 = (byte[])grb.Rows[5][2];
            }

            string n6 = grb.Rows[6][0].ToString();
            string a6 = grb.Rows[6][1].ToString();
            byte[] i6 = null;
            if (!Convert.IsDBNull(grb.Rows[6][2]))
            {
                i6 = (byte[])grb.Rows[6][2];
            }

            string n7 = grb.Rows[7][0].ToString();
            string a7 = grb.Rows[7][1].ToString();
            byte[] i7 = null;
            if (!Convert.IsDBNull(grb.Rows[7][2]))
            {
                i7 = (byte[])grb.Rows[7][2];
            }


            bknm0.Text = n0;
            bka0.Text = a0;
            if (i0 != null)
            {
                pb0.Image = Image.FromStream(new MemoryStream(i0));
            }
            else
            {
                pb0.Image = Resources.ncvr;
            }

            bknm1.Text = n1;
            bka1.Text = a1;
            if (i1 != null)
            {
                pb1.Image = Image.FromStream(new MemoryStream(i1));
            }
            else
            {
                pb1.Image = Resources.ncvr;
            }

            bknm2.Text = n2;
            bka2.Text = a2;
            if (i2 != null)
            {
                pb2.Image = Image.FromStream(new MemoryStream(i2));
            }
            else
            {
                pb2.Image = Resources.ncvr;
            }

            bknm3.Text = n3;
            bka3.Text = a3;
            if (i3 != null)
            {
                pb3.Image = Image.FromStream(new MemoryStream(i3));
            }
            else
            {
                pb3.Image = Resources.ncvr;
            }

            bknm4.Text = n4;
            bka4.Text = a4;
            if (i4 != null)
            {
                pb4.Image = Image.FromStream(new MemoryStream(i4));
            }
            else
            {
                pb4.Image = Resources.ncvr;
            }

            bknm5.Text = n5;
            bka5.Text = a5;
            if (i5 != null)
            {
                pb5.Image = Image.FromStream(new MemoryStream(i5));
            }
            else
            {
                pb5.Image = Resources.ncvr;
            }

            bknm6.Text = n6;
            bka6.Text = a6;
            if (i6 != null)
            {
                pb6.Image = Image.FromStream(new MemoryStream(i6));
            }
            else
            {
                pb6.Image = Resources.ncvr;
            }

            bknm7.Text = n7;
            bka7.Text = a7;
            if (i7 != null)
            {
                pb7.Image = Image.FromStream(new MemoryStream(i7));
            }
            else
            {
                pb7.Image = Resources.ncvr;
            }
        }
    }
}

