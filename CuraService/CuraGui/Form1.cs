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
using System.ServiceModel;

namespace CuraGui
{
    public partial class GUI : MetroForm
    {
        private ServiceHost host;
        public GUI()
        {
            InitializeComponent();
            host = new ServiceHost(typeof(CuraService.CuraService));
            host.Open();
            btn_strt.Enabled = false;
            btn_stp.Enabled = true;
            lbl_stts.Text = "Service Started";
        }

        //private void GUI_Load(object sender, EventArgs e)
        //{
        //    host.Close();
        //    btn_strt.Enabled = true;
        //    btn_stp.Enabled = false;
        //}

        private void btn_strt_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(CuraService.CuraService));
            host.Open();
            btn_strt.Enabled = false;
            btn_stp.Enabled = true;
            lbl_stts.Text = "Service Started";
        }

        private void btn_stp_Click(object sender, EventArgs e)
        {
            host.Close();
            btn_strt.Enabled = true;
            btn_stp.Enabled = false;
            lbl_stts.Text = "Service Stopped";
        }

        private void GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            host.Close();
            btn_strt.Enabled = true;
            btn_stp.Enabled = false;            
        }
    }
}
