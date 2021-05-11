using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
namespace TaskAssincrona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //https://www.youtube.com/watch?v=P4ukz4FzMgE
        private void btnDownload_Click(object sender, EventArgs e)
        {

            var html = Task.Factory.StartNew(() => DonwloadHTML());
            html.Start();
            html.ContinueWith((x) =>
            {
                this.richTextBox1.Text = x.Result;
            }, TaskScheduler.FromCurrentSynchronizationContext());
                richTextBox1.Text = html.Result;
            //this.btnDownload.Enabled = false;
            //this.richTextBox1.Text = DonwloadHTML();
        }

        private string DonwloadHTML()
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            Thread.Sleep(5000);
            return wc.DownloadString("http://www.google.com");
        }
    }
}
