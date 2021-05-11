using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotTelegramConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is MdiClient)
                {
                    controle.BackgroundImage = Properties.Resources.telegram_bot_with_aws_lambda;
                    break;
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void envioMensagemSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioTexto();
            frm.MdiParent = this;
            frm.Show();
            frm.Show();
        }
    }
}
