using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // pic.BackgroundImage = Image.FromFile("exit.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic.BackgroundImage = Image.FromFile("download.jpg");
        }
    }
}
