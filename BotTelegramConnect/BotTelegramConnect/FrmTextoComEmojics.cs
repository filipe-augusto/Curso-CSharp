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
    public partial class FrmTextoComEmojics : Form
    {
        public FrmTextoComEmojics()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a mensagem para o envio!", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegrambot = new TelegramBotClient("1828957988:AAEEJzFdazsiXu1sb9DuWd0GBRdcMU00wIw");
                var strMensagem = txtMensagem.Text.Trim();

                strMensagem = EmojiConfig.Config(strMensagem);
                //https://emojipedia.org/people/
                //https://k3a.me/telegram-emoji-list-codes-descriptions/
                await telegrambot.SendTextMessageAsync(chatId: "-1001488109717", text: strMensagem,
                       parseMode: ParseMode.Html
                       );
                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
            }

        }
    }
}
