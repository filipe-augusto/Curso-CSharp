using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            consulta();
        }
        
        public void consulta()
        {
            if (!string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                using (var ws = new WsCorreio.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCEP.Text.Trim());
                        txtCidade.Text = endereco.cidade;
                        txtRua.Text = endereco.end;
                        txtEstado.Text = endereco.uf;
                        txtBairro.Text = endereco.bairro;
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Erro: " + x.Message,
                            this.Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um cep valido!", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = string.Empty;
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtRua.Text = "";
            txtCEP.Focus();
        }

        private void txtCEP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                consulta();
            }
        }


    }
}
