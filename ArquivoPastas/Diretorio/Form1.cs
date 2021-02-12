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

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            string path = @"c:\curso\";
            bool res = Directory.Exists(path + "");
            // lista.Items.Add(res);
            //if(!res) //se nao existe ele cria
            //{
            //Directory.CreateDirectory(path + "logan");
            //}

            //if (res) //se existe ele deleta
            //{
            //    Directory.Delete(path + "logan");
            //}

            //if (true)// se existe ele move
            //{
            //    Directory.Move(path + "logan", path + @"destino\logan");
            //}

            //string[] dirs = Directory.GetDirectories(path);

            //foreach(string d in dirs) // pega os diretorios
            //{
            //    lista.Items.Add(d);
            //}

            //string[] files = Directory.GetDirectories(path);
            //foreach (string f in files) // pega os as pastas
            //{
            //    lista.Items.Add(f);
            //}

            //string root =Directory.GetDirectoryRoot(path);
            //lista.Items.Add(root);

            //string[] drives = Directory.GetLogicalDrives(); //todas as pastas raizes
            //lista.Items.AddRange(drives);

           //DirectoryInfo info =  Directory.GetParent(path);
           // lista.Items.Add(info.FullName);
          //string dir =  Directory.GetCurrentDirectory();
          //  lista.Items.Add(dir);

        }
    }
}
