using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace AdminMain_ModernUi_
{
    class printcls
    {
        public void prnt()
        {
            PrintDialog PDlg = new PrintDialog();
            PrintDocument PDoc = new PrintDocument();
            PDlg.Document = PDoc;

            PDoc.PrintPage += new PrintPageEventHandler(CreateDoc);
            DialogResult DRs = PDlg.ShowDialog();
            if (DRs == DialogResult.OK)
            {
                PDoc.Print();
            }
        }

        public void CreateDoc(object sender, PrintPageEventArgs e)
        {
            string fn = StaffUi_New.fn;
            string ln = StaffUi_New.ln;
            string un = StaffUi_New.un;
            string pw = StaffUi_New.pw;
            string tp = StaffUi_New.tp;

            Graphics grphcs = e.Graphics;
            Font fnthdr = new Font("neon pixel-7", 24);
            SolidBrush clrhdr = new SolidBrush(Color.MidnightBlue);
            Font fnt = new Font("Anonymous Pro", 12);
            SolidBrush fntclr = new SolidBrush(Color.Black);
            int startX = 70;
            int startY = 50;
            int offset = 40;
            string hdr = "Library Staff Card";/* For Print */
            string sprtr = "________________________________________________";/* For Print */
            string nme = "Name".PadRight(15) + ":".PadRight(5) + fn + "".PadRight(1) + ln; /* For Print */
            string unme = "User Name".PadRight(15) + ":".PadRight(5) + un; /* For Print */
            string pwd = "Password".PadRight(15) + ":".PadRight(5) + pw;/* For Print */
            string tpe = "Authorization".PadRight(15) + ":".PadRight(5) + tp; /* For Print */

            /*header*/
            grphcs.DrawString(hdr, fnthdr, clrhdr, startX, startY + offset);
            offset = offset +  20;
            startX = 30;

            /*Seperator*/
            grphcs.DrawString(sprtr, fnt, fntclr, startX, startY + offset);
            offset = offset + 20;
            startX = 80;

            /*Name*/
            grphcs.DrawString(nme, fnt, fntclr, startX, startY + offset);
            offset = offset + 20;

            /*UserName*/
            grphcs.DrawString(unme, fnt, fntclr, startX, startY + offset);
            offset = offset + 20;

            /*Password*/
            grphcs.DrawString(pwd, fnt, fntclr, startX, startY + offset);
            offset = offset + 20;

            /*Type*/
            grphcs.DrawString(tpe, fnt, fntclr, startX, startY + offset);
            offset = offset + 20;
            startX = 30;

            /*Seperator*/
            grphcs.DrawString(sprtr, fnt, fntclr, startX, startY + offset);
            offset = offset + 20;

        }
    }
}
