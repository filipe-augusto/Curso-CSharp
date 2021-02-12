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

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //  File

            string pasta = @"c:\curso\";
            string arquivo = "teste.txt";
            //bool res = File.Exists(pasta + arquivo);
            //if (res)
            //{
            //    MessageBox.Show("Existe!");
            //}
            //DELETAR
            //File.Delete(pasta + arquivo);

            //CRIAR-para nao deletar e criar outro
            //if (!File.Exists(pasta + arquivo))//se nao existir, 
            //{
            //    File.Create(pasta + arquivo).Close();//criar e fechar
            //    label1.Text = "Arquivo criado!";
            //}
            //else
            //{
            //    label1.Text = "Arquivo ja existe!";
            //}
            //COPIAR 
            //if (File.Exists(pasta+arquivo))
            //{
            //    File.Copy(pasta + arquivo, pasta + "copia.txt", true); //true permite sobrescrever
            //    label1.Text = "Copiado";
            //}
            //else
            //{
            //    label1.Text = "Arquivo não existe";
            //}

            //MOVE
            //if(File.Exists(pasta + arquivo))
            //{
            //    File.Move(pasta + arquivo, pasta + "destino\\" + arquivo);
            //    label1.Text = "Arquivo movido!";
            //}
            //else if(File.Exists(pasta + "destino\\" + arquivo) && !File.Exists(pasta + arquivo))
            //{
            //    label1.Text = "Arquivo já foi movido!";
            //    label1.ForeColor = Color.Red;
            //}
            //else
            //{
            //    label1.Text = "Arquivo não existe";
            //}

            //File.WriteAllText(pasta + arquivo, "teste de escrita de arquivo novo", Encoding.Default);//escrever
            //label1.Text = File.ReadAllText(pasta + arquivo, Encoding.Default); //ler

            label1.Text = "Criado em: "+ File.GetCreationTime(pasta + arquivo).ToString();
            label1.Text += "ultima data de acesso : " + File.GetLastAccessTime(pasta + arquivo).ToString();
           File.SetCreationTime(pasta + arquivo,DateTime.Now);
            label1.Text += "mudando a data de criado para: " + File.GetCreationTime(pasta + arquivo).ToString();
        }
    }
}
