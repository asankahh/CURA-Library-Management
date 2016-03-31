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

namespace AdminMain_ModernUi_
{
    public partial class Notifier : MetroForm
    {
        public Notifier()
        {
            InitializeComponent();
        }

        private void btn_snd_Click(object sender, EventArgs e)
        {
            string smtp = "smtp-mail.outlook.com";
            string email = "cura_illuminati@hotmail.com";
            string psw = "aabkmilluminati5";
            MailMessage mail = new MailMessage(txt_frm.Text,txt_to.Text,txt_sub.Text,txt_msg.Text);
            SmtpClient client = new SmtpClient(smtp);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(email,psw);
            client.Send(mail);
            MessageBox.Show("Notified","Success",MessageBoxButtons.OK);
        }

        private void Notifier_Load(object sender, EventArgs e)
        {
            txt_to.Text = BarrowelsReturns.email;
            string name = BarrowelsReturns.name;
            string msg = "jkajflahglihnlsakhgk"+name+"aghakfgabkjhgjk";
            txt_msg.Text = msg;
        }
    }
}
