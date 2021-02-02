using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDetalhes
{
    public partial class FormSecond : Form
    {
        public string Mensagem { get; set; }
        public FormSecond()
        {
            InitializeComponent();
        }

        public FormSecond(string mensagem)
        {
            InitializeComponent();
            this.Mensagem = mensagem;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormMain()));
            t.Start();
        }

        private void FormSecond_Load(object sender, EventArgs e)
        {
            txtMensagem.Text = Mensagem;
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            if(txtMensagem.Text == "" || txtMensagem.Text == null)
            {
                Mensagem = null;
            }
            else
            {
                Mensagem = txtMensagem.Text;
            }
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Mensagem = null;
            Close();
        }
    }
}
