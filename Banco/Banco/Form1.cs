using Banco.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {

        Conexao conexao = new Conexao();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            //if (!panelAdd.Visible)
            //{
            //panelAdd.Visible = true;
            //}
            //else
            //{
            //    panelAdd.Visible = false;
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preencheComboBox();
            carregaGrid();
        }

        private void preencheComboBox()
        {
            cbProfissao.DisplayMember = "vNomeProfissao";
            cbProfissao.ValueMember = "iIdProfissao";
            cbProfissao.DataSource = conexao.selectProfissao();
            // conexao.selectProfissao();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
        
            }
            else
            {
                
            }

           
        }

        public void carregaGrid()
        {
            dataView.DataSource = conexao.selectFuncionario();
        }

        public void AdicionarFuncionario()
        {
            try
            {
                conexao.addFuncionario(txtNome.Text.Trim(),
                                     (int)txtIdade.Value,
                                     Convert.ToDouble(txtSalario.Text.Trim()),
                                     cbProfissao.SelectedIndex);
                MessageBox.Show("Adicionado com sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("erro!" + e.Message);
            }
        }

        private void txtIdade_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
