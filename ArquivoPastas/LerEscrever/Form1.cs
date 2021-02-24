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

        byte[] buffer;
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

            txtConteudo.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = "";
            string path = @"c:\curso\file.txt";
            StreamReader reader = new StreamReader(path, Encoding.Default);

            //  string txt = reader.ReadToEnd();
            //txtConteudo.Text = txt;
            //string linha = reader.ReadLine();//apenas uma linha

            //while(linha != null)
            //{
            //    txtConteudo.Text += linha + "\n";
            //    linha = reader.ReadLine();
            //}
            //txtConteudo.Text = linha + "\n";
            while (!reader.EndOfStream)
            {                
                txtConteudo.Text += (char)reader.Read();
            }
     
            reader.Close();
        }

        private void btnLerBinario_Click(object sender, EventArgs e)
        {
            //txtConteudo.Text = "";
            string path = @"c:\curso\file.txt";
           FileStream file = File.OpenRead(path);
            BinaryReader reader = new BinaryReader(file);

            //while (reader.BaseStream.Position != reader.BaseStream.Length)
            //{
            //    byte b = reader.ReadByte();
            //    txtConteudo.Text += b + "";
            //}
            //         bufer = File.ReadAllBytes(path);
           byte[] buffer = reader.ReadBytes((int)reader.BaseStream.Length);

            //foreach (byte b in buffer)
            //{
            //    txtConteudo.Text += (char)b;
            //}

            reader.Close();
           // buffer = File.ReadAllBytes(path);
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            string path = @"c:\curso\file.txt";
            FileStream file = File.OpenWrite(path);
            BinaryWriter writer = new BinaryWriter(file);

            writer.Write(buffer);

            writer.Flush();
            writer.Dispose();
            writer.Close();

        }

        private void btnTEste_Click(object sender, EventArgs e)
        {
            // txtConteudo.Text = comboTeste.SelectedItem + "";
          //  string teste = "10/10/2020";
            MessageBox.Show("10/10/2020");
        }
    }
}
