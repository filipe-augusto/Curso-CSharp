using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquivoInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(@"c:\curso\teste.txt");
            if (info.Exists) { 

            lista.Items.Clear();
            lista.Items.Add(info.FullName);
            lista.Items.Add(info.Name);
            lista.Items.Add(info.Extension);
            lista.Items.Add(info.Directory.FullName);
            lista.Items.Add(info.FullName);
            lista.Items.Add(info.DirectoryName);
            lista.Items.Add(info.CreationTime);
     
            lista.Items.Add(info.LastAccessTime);
            lista.Items.Add(info.LastWriteTime);
            }
            else
            {
                lista.Items.Add("ARQUIVO NAO EXISTE!");
            }
        }
    }
}
