using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemWeb : Form
    {
        public FrmEnvioImagemWeb()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtURL.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Infome a URL da imagem para envio.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //errorProvider1.SetError(txtMensagem, "campo vazio")
                return;
            }
            try
            {
                TelegramBotClient telegrambot = new TelegramBotClient("1828957988:AAEEJzFdazsiXu1sb9DuWd0GBRdcMU00wIw");
                var imagemRequest = WebRequest.Create(txtURL.Text.Trim());
                using (var  imagemResponse = imagemRequest.GetResponse())
                {
                    var stream = imagemResponse.GetResponseStream();
                    await telegrambot.SendPhotoAsync(chatId: "-1001488109717", photo: stream, caption: txtMensagem.Text.Trim(),          
                           parseMode: ParseMode.Html);
                }
                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
                txtURL.Text = string.Empty;
            }
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
