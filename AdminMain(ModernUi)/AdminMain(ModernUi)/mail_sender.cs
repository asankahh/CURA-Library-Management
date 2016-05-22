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
using System.Net.Mail;
using System.Net;
using MetroFramework;

namespace AdminMain_ModernUi_
{
    public partial class Notifier : MetroForm
    {
        public Notifier()
        {
            InitializeComponent();
        }

        static string recievermail = BarrowelsReturns.email;
        static string recievername = BarrowelsReturns.name;
        string mailbody = "Mr. " + recievername + ". you haven't returned book yet. Please be kind to return it. thanks";

        private void Notifier_Load(object sender, EventArgs e)
        {
            txt_to.Text = recievermail;
            string name = recievername;            
            txt_msg.Text = mailbody;
        }

        private void btn_msndr_Click(object sender, EventArgs e)
        {
            MailSender();
            MetroMessageBox.Show(this, "Reminder sent to "+recievername+" successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void MailSender()
        {
            string host = "smtp.gmail.com";
            string sndr = "illuminati.nsbm@gmail.com";
            string pwrd = "aabkmilluminati";
            string rcvr = txt_to.Text;
            string body = txt_msg.Text;

            MailMessage msg = new MailMessage();
            msg.Subject = "Reminder From Library";
            msg.From = new MailAddress(sndr);
            msg.Body = body;
            msg.To.Add(new MailAddress(rcvr));
            SmtpClient smtp = new SmtpClient();
            smtp.Host = host;
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            NetworkCredential NC = new NetworkCredential(sndr, pwrd);
            smtp.Credentials = NC;
            smtp.Send(msg);
        }
    }
}
