using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class Form1 : Form
    {

        //trata o nome do usuario
        private string NomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;
        //necessario para atualizar o formulario com mensagens da outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        //necessario para definir o formulario para o estado disconnected de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool Conectado;


        public Form1()
        {
            //na saida da aplicação  : desconectar
            Application.ApplicationExit += new EventHandler(OnAplicationExit);
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviaMensagem();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //se nao esta conectando aguarda a conexão
            if (!Conectado)
            {
                InicializaConexao();
            }
            else
            {
                FechaConexao("Desconectado a pedido do usuario.");
            }
        }


        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se pressionou a tecla enter
            if (e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }
        private void InicializaConexao()
        {
            try
            {
                //trata o endereço ip informado em um objeto ipadress
                enderecoIP = IPAddress.Parse(txtServidorIp.Text);
                //trata o numero da porta do host 
                portaHost = (int)numPortaHost.Value;
                //inicia uma nova conexão TCP com o servidor chat
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, portaHost);
                //ajuda a verificar se estamos conectados ou não 
                Conectado = true;

                //preparar o formulario
                NomeUsuario = txtUsuario.Text;
                //desabilitar e habilitar os campos apropriados
                txtServidorIp.Enabled = false;
                numPortaHost.Enabled = false;
                txtUsuario.Enabled = false;
                txtMensagem.Enabled = true;
                btnConectar.ForeColor = Color.Red;
                btnConectar.Text = "Desconectar";

                //envia o nome do usuario ao servidor
                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(txtUsuario.Text);
                stwEnviador.Flush();
                //inicia  a thread para receber mensagens e nova comunicação
                mensagemThread = new Thread(new ThreadStart(RecebeMensagens));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();
                labelStatus.Invoke(new Action(() =>
                {
                    labelStatus.ForeColor = Color.Green;
                    labelStatus.Text = $"Conectado ao servidor de chat{enderecoIP}:{portaHost}";
                }));


            }
            catch (Exception ex)
            {
                labelStatus.Invoke(new Action(() =>
                {
                    labelStatus.ForeColor = Color.Red;
                    labelStatus.Text = "Erro na conexão com o servidor :\n" + ex.Message;
                }));
            }
        }
        private void RecebeMensagens()
        {
            //recebe a resposta do servidor
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();
            //se o primeiro formulario para informar que esta conectado
            if (ConResposta[0] == '1')
            {
                //atualiza o formulario para informar que esta conectado
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[]
                {"conectado com sucesso!"
                });
            }
            else
            {
                //se o primeiro caractere não for 1 a conexão falhou
                string Motivo = "não conectado: ";
                //extrai o motivo da mensagem resposta, o moitvo começa no 3 caractere
                Motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                //atualiza o formulario com o motivo da falha de conexão
                this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] { Motivo });
                // sai do metodo
                return;
            }

            //enquanto estiver conectado le as linhas que estaõ chegando do servidor
            while (Conectado)
            {
                this.Invoke(new FechaConexaoCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });
            }

        }
        private void AtualizaLog(string strMensagem)
        {
            //anexa texto ao final de cada linha
            txtLog.AppendText(strMensagem + "\r\n");

        }
        private void EnviaMensagem()
        {
            //envia a mensagem para o servidor
            if (txtMensagem.Lines.Length >=1)
            {
                stwEnviador.WriteLine(txtMensagem.Text);
                stwEnviador.Flush();
                txtMensagem.Lines = null;
            }
            txtMensagem.Text = "";
        }
        private void FechaConexao(string Motivo)
        {
            //fecha a conexão com o servidor

            //mostra o motivo proque a conexão encerrou
            txtLog.AppendText(Motivo + "\r\n");
            //habilita e desabilita os contrles apropriados no formulario
            txtServidorIp.Enabled = true;
            numPortaHost.Enabled = true;
            txtUsuario.Enabled = true;
            txtMensagem.Enabled = false;
            btnEnviar.Enabled = false;
            btnConectar.ForeColor = Color.Green;
            btnConectar.Text = "conectado";

            //fecha objetos
            Conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();
            labelStatus.Invoke(new Action(() =>
            {
                labelStatus.ForeColor = Color.Green;
                labelStatus.Text = $"Desconectadoo do servidor de chat{enderecoIP} {portaHost} ";
            }));

        }
        //o tratador  de evento para a saida da aplicação
        public void OnAplicationExit(object Sender, EventArgs e)
        {
            if (Conectado)
            {
                //fecha as conexoes, streams etc
                Conectado = false;
                stwEnviador.Close();
                strReceptor.Close();
                tcpServidor.Close();
                labelStatus.Invoke(new Action(() =>
                {
                    labelStatus.ForeColor = Color.Green;
                    labelStatus.Text = $"Desconectadoo do servidor de chat{enderecoIP} {portaHost} ";
                }));
            }
        }
    }
}
