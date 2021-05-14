using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemLocal : Form
    {
        public FrmEnvioImagemLocal()
        {
            InitializeComponent();
        }
        private Stream ToStream(Image imagem, ImageFormat formato )
        {
            var stream = new MemoryStream();
            imagem.Save(stream, formato);
            stream.Position = 0;
            return stream;

        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCaminhoImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Voce deve selecionar a imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegrambot = new TelegramBotClient("1828957988:AAEEJzFdazsiXu1sb9DuWd0GBRdcMU00wIw");
               
                using (var imgEnvio = Image.FromFile(txtCaminhoImagem.Text.Trim()))
                {
                    var stream = ToStream(imgEnvio, ImageFormat.Jpeg);
                    await telegrambot.SendPhotoAsync(chatId: "-1001488109717", photo: stream, caption: txtMensagem.Text.Trim(),
                           parseMode: ParseMode.Html);
                }
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
                txtCaminhoImagem.Text = string.Empty;
                txtMensagem.Text = string.Empty;
            }


        }

        private void btnBscImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "";
                ofd.Filter = " Imagens (* .jpg; *.jpeg; *.png)|* .jpg; *.jpeg; *.png ";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCaminhoImagem.Text = ofd.FileName;
                }

            }
        }
    }
}
