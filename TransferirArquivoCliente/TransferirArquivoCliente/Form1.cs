﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTCliente.LabelMensagem = labelStatus;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void labelArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Enviar arquivo";
            if (dialog.ShowDialog() == DialogResult.OK) ;
            {
                txtArquivo.Text = dialog.FileName;
            }
        }

        private void btnEnviarArquivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIp.Text) || string.IsNullOrEmpty(txtPorta.Value.ToString()) ||
              txtArquivo.Text == "Clique para selecionar um arquivo") 
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "dados invalidos";
                return;
            }
            string enderecoIP = txtIp.Text;
            int porta = (int)txtPorta.Value;
            string nomeArquivo = txtArquivo.Text;

            FTCliente.EnderecoIP = enderecoIP;
            FTCliente.PortHost = porta;

            try
            {
                Task.Factory.StartNew(()=> {
                    FTCliente.EnviarArquivo(nomeArquivo);
                });
            }
            catch (Exception ex)
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Erro: \n "+ex.Message;
               
            }

        }
    }
}
