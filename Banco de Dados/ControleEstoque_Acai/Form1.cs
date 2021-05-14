using ControleEstoque_Acai.Entities;
using ControleEstoque_Acai.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque_Acai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Produto produto = new Produto();
        Cardapio cardapio = new Cardapio();
        Conexao conexao = new Conexao();
        Vendas venda = new Vendas(); 
        private void tabVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

            //dataGridViewEstoque.Rows[e.RowIndex].Cells["id"].Value.ToString()
        }
        #region Estoque  
        #region Quando entra na tab Estoque carrega a grid
        private void tabEstoque_Enter(object sender, EventArgs e)
        {
            recarregaGrid();
        }
        #endregion
        #region  Mudar a cor da progressBar
        public void mudarCorProgressBar(int valor)
        {
            //if (valor < 25)
            //{
            //    progressProduto.Style.
            //}
            //else if (valor >= 25 && valor < 50)
            //{
            //    progressProduto.BackColor = Color.Orange;
            //}
            //else if (valor >= 50 && valor < 75)
            //{
            //    progressProduto.BackColor = Color.Orange;
            //}
            //else if (valor >= 75)
            //{
            //    progressProduto.BackColor = Color.Green;
            //}
        }
        #endregion
        #region  Carregando a grid
        private void recarregaGrid()
        {
            dataGridViewEstoque.DataSource = conexao.selectProdutos();
            dataGridViewEstoque.Columns[3].Visible = false;
            // txtSimulacao.Text = 0;
        }
        #endregion
        #region Clicando na linha da grid para recarregar o estoque
        private void dataGridViewEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProduto.Text = "";
            progressProduto.Value = 0;
            produto.ID = Convert.ToInt32(dataGridViewEstoque.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            produto.Nome = dataGridViewEstoque.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            produto.Peso = Convert.ToInt32(dataGridViewEstoque.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString());
            produto.PesoMaximo = Convert.ToInt32(dataGridViewEstoque.Rows[e.RowIndex].Cells["maximo"].Value.ToString());
            if (produto.ID > 0)
            {

                gBoxRecarregar.Visible = true;
                progressProduto.Value = (produto.Peso * 100) / produto.PesoMaximo;
                lblProduto.Text = produto.Nome;
                lblQuantidadeRecarregada.Text = produto.Peso.ToString();
                maximo.Text = produto.PesoMaximo.ToString();
                //mudarCorProgressBar(progressProduto.Value);
            }
            else
            {
                return;
            }
        }
        #endregion
        #region Simulando um valor para adicionar
        private void btnSimulacao_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSimulacao.Text))
            {
                MessageBox.Show("Digite um valor para continuar", "Atenção", MessageBoxButtons.OK);
                txtSimulacao.Focus();
                return;
            }
            if (Convert.ToInt32(lblQuantidadeRecarregada.Text) == produto.PesoMaximo)
            {
                MessageBox.Show("não é possivel adicoinar mais valores", "Atenção", MessageBoxButtons.OK);
                txtSimulacao.Text = "";

                return;
            }

            try
            {
                int total = Convert.ToInt32(lblQuantidadeRecarregada.Text) + Convert.ToInt32(txtSimulacao.Text);
                lblQuantidadeRecarregada.Text = total.ToString();
                int diferenca = produto.PesoMaximo - produto.Peso;
                if (total > Convert.ToInt32(produto.PesoMaximo))
                {
                    if (diferenca <= 0)
                    {
                        MessageBox.Show("Não é possivel mais registrar novas recargas enquanto o estoque estiver cheio.", "Atenção", MessageBoxButtons.OK);
                    }
                    MessageBox.Show($"Nao é possivel adicionar mais que o mais o maximo.Tente novamente com o valor da diferença" +
                        $" {diferenca}.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    total = total - Convert.ToInt32(txtSimulacao.Text);
                    txtSimulacao.Text = diferenca.ToString();
                }

                progressProduto.Value = (total * 100) / Convert.ToInt32(maximo.Text);
                // mudarCorProgressBar(progressProduto.Value);
                lblQuantidadeRecarregada.Text = total.ToString();
                txtSimulacao.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex);
                return;
            }
        }
        #endregion
        #region Recarregando o produto no estoque
        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblQuantidadeRecarregada.Text) == 0 || String.IsNullOrEmpty(lblQuantidadeRecarregada.Text))
            {
                MessageBox.Show("adicione um valor para acrescentar", "Atenção", MessageBoxButtons.OK);
                txtSimulacao.Focus();
                dataGridViewEstoque.Refresh();
                return;
            }
            produto.Peso = Convert.ToInt32(lblQuantidadeRecarregada.Text);
            if (MessageBox.Show($"Confirma a recarga do produto {produto.Nome }? o novo valor será de {produto.Peso}g?", "Alteração", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conexao.recarregarProduto(produto);
                txtSimulacao.Text = "";
            }
            recarregaGrid();
            tabEstoque.Refresh();
        }
        #endregion
        #region Adicionando um produto novo no estoque
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeProdutoNovo.Text) || String.IsNullOrEmpty(txtQuantidadeProdutoNovo.Text)
                    || string.IsNullOrEmpty(txtaMaximaNovo.Text))
                {
                    MessageBox.Show("");
                    return;
                }
                Produto produtoAdd = new Produto();
                produtoAdd.Nome = txtNomeProdutoNovo.Text;
                produtoAdd.Peso = Convert.ToInt32(txtQuantidadeProdutoNovo.Text);
                produtoAdd.PesoMaximo = Convert.ToInt32(txtaMaximaNovo.Text);
                if (MessageBox.Show($"Confirma o adição do novo produto? Nome: {produtoAdd.Nome} Quantidade em pesos: {produtoAdd.Peso}. ",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conexao.adicionarProdutos(produtoAdd);
                    MessageBox.Show($"Produto {produtoAdd.Nome} adicionado com sucesso.", "Atenção", MessageBoxButtons.OK);
                }

            }
            catch (Exception ek)
            {
                MessageBox.Show("Erro: " + ek.Message);
                throw;
            }
            recarregaGrid();
        }
        #endregion
        #region Pintado as linhas das colunas conforme a situação do estoque
        private void dataGridViewEstoque_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {

                int pesoAtual = Convert.ToInt32(dataGridViewEstoque.Rows[e.RowIndex].Cells[2].Value);
                int pesomaximo = Convert.ToInt32(dataGridViewEstoque.Rows[e.RowIndex].Cells["maximo"].Value);
                double porcentagem = (pesoAtual * 100) / pesomaximo;
                //   MessageBox.Show(" peso: " + pesoAtual + " maximo: "+ pesomaximo + "porcentagem: "+ porcentagem);
                if (porcentagem < 25)
                {
                    dataGridViewEstoque.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (porcentagem >= 25 && porcentagem < 50)
                {
                    dataGridViewEstoque.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Orange;
                }
                else if (porcentagem >= 50 && porcentagem < 75)
                {
                    dataGridViewEstoque.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Yellow;
                }
                else if (porcentagem >= 75)
                {
                    dataGridViewEstoque.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                }

            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #endregion


        #region Vendas
    
        #region Carrega Cardapio
        private void carregaGridCardapio()
        {
            dataGridViewCardapio.DataSource = conexao.selectCardapio();
            dataGridViewCardapio.Columns["IdAcai"].Visible = false;
            dataGridViewCardapio.Columns["mL"].Width = 80;
            dataGridViewCardapio.Columns["Valor"].Width = 100;
            a1.DisplayMember = "nomeitem";
            a1.ValueMember = "idProduto";
            a1.DataSource = conexao.selectAdicional();
            a2.DisplayMember = "nomeitem";
            a2.ValueMember = "idProduto";
            a2.DataSource = conexao.selectAdicional();
        }
        #endregion

        #region Preenche ComboBoxs Pagamento
        private void preencheComboBoxs()
        {
            comboBoxTiposDePagamento.DisplayMember = "nomePagamento";
            comboBoxTiposDePagamento.ValueMember = "id";
            comboBoxTiposDePagamento.DataSource = conexao.selectFormaDePagamento();

        }
        #endregion
        private void tabVendas_Enter(object sender, EventArgs e)
        {
            preencheComboBoxs();
            carregaGridCardapio();
        }

        #region Adicionando no carrinho
        private void dataGridViewCardapio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Convert.ToInt32(dataGridViewCardapio.Rows[e.RowIndex].Cells[0].Value) == 0 ||
               Convert.ToInt32(dataGridViewCardapio.Rows[e.RowIndex].Cells[1].Value) == 0)
            {
                return;
            }
            try
            {             
                cardapio.IdAcai = Convert.ToInt32(dataGridViewCardapio.Rows[e.RowIndex].Cells["IdAcai"].Value.ToString());
                cardapio.NomeItem = (dataGridViewCardapio.Rows[e.RowIndex].Cells["Nome"].Value.ToString());
                cardapio.Valor = Convert.ToInt32(dataGridViewCardapio.Rows[e.RowIndex].Cells["Valor"].Value.ToString());
                cardapio.Tamanho = dataGridViewCardapio.Rows[e.RowIndex].Cells["Tamanho"].Value.ToString();
                cardapio.LitrosAcai = Convert.ToInt32(dataGridViewCardapio.Rows[e.RowIndex].Cells["mL"].Value.ToString());
             
                cardapio.IdAdicional1 =  dataGridViewCardapio.Rows[e.RowIndex].Cells[0].Value.ToString();
                cardapio.IdAdicional2 =  dataGridViewCardapio.Rows[e.RowIndex].Cells[1].Value.ToString();
                cardapio.NomeAdicional1 = (dataGridViewCardapio.Rows[e.RowIndex].Cells["a1"] as DataGridViewComboBoxCell).FormattedValue.ToString();
                cardapio.NomeAdicional2 = (dataGridViewCardapio.Rows[e.RowIndex].Cells["a2"] as DataGridViewComboBoxCell).FormattedValue.ToString();
                if (string.IsNullOrEmpty(cardapio.NomeAdicional1) || string.IsNullOrEmpty(cardapio.NomeAdicional2))
                {
                    if (MessageBox.Show(" Deseja continuar sem os adicionais?", "Adicionar no carrinho ",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cardapio.NomeAdicional1 = "";
                        cardapio.NomeAdicional2 = "";
                        AddCarinho(cardapio);
                    }
                    else
                    {
                        return;
                    }
                }
                AddCarinho(cardapio);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }      
        private void AddCarinho(Cardapio c)
        {
            insereValorTotal(Convert.ToInt32(c.Valor));
            dataGridViewVendas.Rows.Add(c.IdAcai, c.NomeItem, c.Tamanho, c.Valor, c.NomeAdicional1, c.NomeAdicional2, c.IdAdicional1, c.IdAdicional2, "exluir");
        }
        #endregion
        #region Insere Valor Total  
        public void insereValorTotal(int valor)
        {
            double resultado =Convert.ToDouble(lblValorTotal.Text) + valor;
            lblValorTotal.Text = resultado.ToString();
            lblValorTotal2.Text = resultado.ToString();
        }
        private void dataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewVendas.Rows[e.RowIndex].Cells["idProduto"].Value.ToString());
                if (dataGridViewVendas.Columns[e.ColumnIndex] == dataGridViewVendas.Columns["excluir"])
                {
                    int valorretirado = Convert.ToInt32(dataGridViewVendas.Rows[e.RowIndex].Cells["valor"].Value.ToString());
                    insereValorTotal(-valorretirado);
                    dataGridViewVendas.Rows.RemoveAt(e.RowIndex); 
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion
        #region Limpar
        private void cleanFields()
        {
            dataGridViewVendas.Rows.Clear();
            txtNomeCliente.Text = "";
            comboBoxTiposDePagamento.SelectedIndex = 0;
            lblValorTotal.Text = "0";
            lblValorTotal2.Text = "0";

        }
        #endregion
        private void btnVenda_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNomeCliente.Text))
            {

                txtNomeCliente.Focus();
                return;
            }
            if (dataGridViewCardapio.Rows.Count == 0)
            {
                MessageBox.Show("Não há itens no carrinho.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridViewCardapio.Focus();
                return;
            }
            try
            {
                //dados vendas
                venda.NomeCliente = txtNomeCliente.Text;
                venda.ModoDePagamento = comboBoxTiposDePagamento.SelectedIndex +1;
                venda.DataVenda = DateTime.Now;
                venda.ValorTotal = Convert.ToDouble(lblValorTotal.Text);
                //dados itens 
                HashSet<ItensPedidos> itens = new HashSet<ItensPedidos>();
                if (MessageBox.Show($"Confirma a venda \n No valor de R${venda.ValorTotal}?", "Informativo", MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewVendas.Rows.Count; i++)
                    {
                        itens.Add(new ItensPedidos(Convert.ToInt32(dataGridViewVendas.Rows[i].Cells["idProduto"].Value),
                              dataGridViewVendas.Rows[i].Cells["tamanho"].Value.ToString(),
                                Convert.ToInt32(dataGridViewVendas.Rows[i].Cells["idAdicional1"].Value),
                                 Convert.ToInt32(dataGridViewVendas.Rows[i].Cells["idAdicional2"].Value),
                              Convert.ToDouble(dataGridViewVendas.Rows[i].Cells["valor"].Value)
                              ));
                    }
                    conexao.InsereVenda(venda, itens);
                    MessageBox.Show("VENDA REALIZADA");
                     cleanFields();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        #endregion
        private void tabFaturamento_Enter(object sender, EventArgs e)
        {
            carregagridFaturamento();
        }

        private void carregagridFaturamento()
        {
            try
            {
                string dataInicio = dateTimePicker_INICIO.Value.ToString();
                string dataFinal = dateTimePicker_FIM.Value.ToString();
                dataGridView_vendas.DataSource = conexao.selectFaturamento(dataInicio,dataFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex);
               // throw;
            }
        }

        private void dateTimePicker_INICIO_ValueChanged(object sender, EventArgs e)
        {
            carregagridFaturamento();
        }

        private void dateTimePicker_FIM_ValueChanged(object sender, EventArgs e)
        {
            carregagridFaturamento();
        }

        //private void dataGridViewEstoque_Enter(object sender, EventArgs e)
        //{
        //  
        //}
    }
}
