using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LerEscrever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscrever_Click(object sender, EventArgs e)
        {
            string path = @"c:\curso\file.txt";
            StreamWriter writer = new StreamWriter(path, true,Encoding.UTF8);
            //writer.WriteLine(txtConteudo.Text);

            string txt = txtConteudo.Text;
            writer.Write(txt);
            //writer.Flush();
            //writer.Dispose();
            writer.Close();

        }
    }
}
