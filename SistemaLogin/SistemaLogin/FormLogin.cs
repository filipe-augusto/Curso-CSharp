using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

   

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (CadastrarUsuario.Login(nome, senha)) {
                Close();
            }
            else {
                MessageBox.Show("Acesso Negado!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                _ = txtUsuario.Focus();
                Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
