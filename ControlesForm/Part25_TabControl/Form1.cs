using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part25_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://" + url_1.Text);
            tP1.Text = url_1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://" + url_2.Text);
            tP2.Text = url_2.Text;
        }
    }
}
