using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part42_OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open.Filter = "imagem png | *.png | Icone | *.ico";

            if (open.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = open.FileName;
              foreach (string item in open.FileNames)
                {
                    listBox1.Items.Add(item);
                }
            }
        }
    }
}
