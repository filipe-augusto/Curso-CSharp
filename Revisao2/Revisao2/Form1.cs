using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao2
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (Pessoa count in pessoas)
            {
                if (count.Nome == txtNomeCliente.Text)//para nao der cadastro com o mesmo nome
                {
                    index = pessoas.IndexOf(count);
                }
            }
            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("Preencha o campo cliente");
                txtNomeCliente.Focus();
                return;
            } 
         
            Pessoa p = new Pessoa();
            p.Nome = txtNomeCliente.Text;
            p.DataMorte = txtData.Text;
            p.DataNascimento = txtNascimento.Text;
            p.Morto = checkMorto.Checked;

            if (index < 0)
            {
                pessoas.Add(p); //recebeu novo
            }
            else
            {
                pessoas[index] = p; //existe um igual
            }
            btnLimpar_Click(btnLimpar, EventArgs.Empty);
            Listar();

        }





        private void Listar()
        {
            int id = 0;
            string vivo;
            lista.Items.Clear(); //limmpa todo o item box
            foreach (Pessoa p in pessoas)
            {
                id++;
                vivo = p.Morto ? "morto"+ " | " + p.DataMorte : "vivo";

                lista.Items.Add(id+" | "+p.Nome +"| " +" | "+p.DataNascimento+" | " +vivo  );
            
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
            checkMorto.Checked = false;
            txtNascimento.Text = "";
            txtNomeCliente.Focus();
        }
    }


}



