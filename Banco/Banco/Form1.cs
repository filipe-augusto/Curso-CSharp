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
          //  panelAdd.Visible = true;
            if (!panelAdd.Visible)
            {
                panelAdd.Visible = true;
            }
            else
            {
                panelAdd.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preencheComboBox();
            carregaGrid();
        }

        private void preencheComboBox()
        {
            cbProfissao.DisplayMember = "profissao";
            //  cbProfissao.DisplayMember = "vNomeProfissao";
            //cbProfissao.ValueMember = "iIdProfissao";
            cbProfissao.ValueMember = "id";
            cbProfissao.DataSource = conexao.selectProfissao();
            // conexao.selectProfissao();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                //MessageBox.Show("Campo vazio");
                return;
            }
            else
            {
            AdicionarFuncionario();
             limparCampos();
            carregaGrid();
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
            finally
            {
                carregaGrid();
                limparCampos();
            }
        }

        private void txtIdade_ValueChanged(object sender, EventArgs e)
        {

        }

       public void limparCampos()
        {
            txtNome.Text = "";
            txtNome.Focus(); 
            txtSalario.Text = "";
            txtIdade.Value = 16;
            cbProfissao.Text = "Selecione uma profissão";
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtNome.Text = dataView.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                txtSalario.Text = dataView.Rows[e.RowIndex].Cells["Salario"].Value.ToString();
                txtIdade.Value = Convert.ToInt32(dataView.Rows[e.RowIndex].Cells["Idade"].Value.ToString());
                panelAdd.Visible = true;

                int id = Convert.ToInt32(dataView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                if (dataView.Columns[e.ColumnIndex] == dataView.Columns["btnExcluir"])
                {

                    if (MessageBox.Show("Confirma a exclusão?", "atenção", MessageBoxButtons.YesNo)
                        == DialogResult.Yes)
                    {
                        conexao.excluirFuncionario(id);
                        MessageBox.Show("Excluido com sucesso");
                        carregaGrid();
                        limparCampos();
                    }
                    else if(dataView.Columns[e.ColumnIndex] == dataView.Columns["editar"])
                    {

                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("erro: " + ex.Message);
                return;
            }
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         //  txtBusca.Text = conexao.buscaFunciorario(txtBusca.Text);
        }

        private void dataView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //centralizar os dados das colunas
            dataView.Columns["Idade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataView.Columns["Salario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn coluna in dataView.Columns)
            {
                switch (coluna.Name)
                {
                    case "Nome":

                        coluna.Width = 180;
                        coluna.HeaderText = "Nome";
                        break;

                    case "Idade":
                        coluna.Width = 70;
                        coluna.HeaderText = "Idade";
                        break;

                    case "Salario":
                        coluna.Width = 140;
                        coluna.HeaderText = "Salario";
                        coluna.DefaultCellStyle.Format = "C2";
                        break;

                    //case "editar":
                    //    coluna.DisplayIndex = 6;
                    //    break;

                    //case "btnExluir":
                    //    coluna.DisplayIndex = 6;
                    //    break;



                }
            }
        }
    }

}
