using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioComTemporizador : Form
    {

        private List<String> lstMensagens;
        private int posicaoEnvio;

        public FrmEnvioComTemporizador()
        {
            InitializeComponent();
            lstMensagens = new List<string>();
            btnEnviar.Enabled = false;
        }

        private void InicializarTimerControle()
        {
            var minutos = Convert.ToInt32(txtTempo.Text.Trim());
            timerControle.Interval = 60 * 1000 * minutos;
            timerControle.Enabled = true;
            this.timerControle.Tick += new EventHandler(timerControle_Tick);
            this.BackColor = Color.Red;
        }
        private void PararTimerControle()
        {
            timerControle.Enabled = false;
            timerControle.Tick -= new EventHandler(timerControle_Tick);
            this.BackColor = SystemColors.Control;
            btnEnviar.Enabled = true;

        }

        private void AtualizarProgressoEnvio()
        {
            prbStatusEnvio.Value++;
            lblStatusEnvio.Text = string.Format("Enviado {0} de {1}...", posicaoEnvio, lstMensagens.Count);
            
        }


        private async void timerControle_Tick(object sernder, EventArgs e)
        {
            try
            {
                var telegrambot = new TelegramBotClient("1828957988:AAEEJzFdazsiXu1sb9DuWd0GBRdcMU00wIw");
                var mensagemAtual = lstMensagens[posicaoEnvio];
                mensagemAtual = EmojiConfig.Config(mensagemAtual);
                //https://emojipedia.org/people/
                //https://k3a.me/telegram-emoji-list-codes-descriptions/
                await telegrambot.SendTextMessageAsync(chatId: "-1001488109717", text: mensagemAtual, parseMode: ParseMode.Html);
                posicaoEnvio++;
                //atualizar o processo envio
                AtualizarProgressoEnvio();
                if (posicaoEnvio == lstMensagens.Count)
                {
                    PararTimerControle();
                }
            }
            catch (Exception ex)
            {
                PararTimerControle();
                MessageBox.Show("Erro ao enviar mensagem! "+ ex.Message, this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

            


        private void btnCarregarMensagens_Click(object sender, EventArgs e)
        {
            try
            {
                btnCarregarMensagens.Enabled = false;
                var arquivosMensagens = "Mensagens.txt";
                lstMensagens.Clear();
                lbMensagens.Items.Clear();
                using (StreamReader sr = new StreamReader(arquivosMensagens))
                {
                    var strLinha = string.Empty;
                    while ((strLinha = sr.ReadLine()) != null)//vai lendo até quando não ouver linha. ou seja for null
                    {
                        if (!strLinha.Trim().Equals(string.Empty))//se for diferente de vazio add as linhas
                        {
                            lstMensagens.Add(strLinha.Trim());
                            lbMensagens.Items.Add(strLinha.Trim());
                        }
                    }
                }
                if (lstMensagens.Count > 0)
                {
                    btnEnviar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                btnCarregarMensagens.Enabled = true;
                btnEnviar.Enabled = false;
                lstMensagens.Clear();
                lbMensagens.Items.Clear();
                MessageBox.Show("Erro ao carregar o arquivo. " + ex.Message, this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PrepararEnvio()
        {
            posicaoEnvio = 0;
            InicializarProgressBar();
            InicializarTimerControle();
        }
        private void InicializarProgressBar()
        {
            prbStatusEnvio.Value = 0;
            prbStatusEnvio.Maximum = lstMensagens.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTempo.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Voce deve informar o tempo do intervalo dos mensagens.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnEnviar.Enabled = false;
            //verificar se encontrou uma linha no arquivo de texto
            if (lstMensagens.Count == 0)
            {
                MessageBox.Show("Nenhuma mensagem carrega do arquivo.", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                PrepararEnvio();
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //https://web.fe.up.pt/~ee96100/projecto/Tabela%20ascii.htm
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)//verifica se é um  digito decimal
                e.Handled = true;
        } 
    }
}
