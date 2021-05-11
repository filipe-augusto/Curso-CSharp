using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioTexto : Form
    {
        public FrmEnvioTexto()
        {
            InitializeComponent();
        }

   

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Infome a mensagem para envio.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //errorProvider1.SetError(txtMensagem, "campo vazio")
                return;
            }
            try
            {
                TelegramBotClient telegrambot = new TelegramBotClient("1828957988:AAEEJzFdazsiXu1sb9DuWd0GBRdcMU00wIw");
                await telegrambot.SendTextMessageAsync(chatId: "-1001488109717",
                       txtMensagem.Text.Trim(),
                       parseMode: ParseMode.Html
                       );
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
            }
        }
    }
}
