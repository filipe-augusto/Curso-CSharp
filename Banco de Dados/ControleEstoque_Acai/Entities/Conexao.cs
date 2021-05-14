using ControleEstoque_Acai.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque_Acai.Entities
{
    class Conexao
    {
        Vendas vendas = new Vendas();
        Produto produto = new Produto();
        static string stringConection = @"Data Source=FILIPE-HPRPE60;Initial Catalog=acai;Integrated Security=True";
        SqlConnection cn = new SqlConnection(stringConection);
        private IDbConnection AbrirConexao()
        {
            return new SqlConnection(stringConection);
        }
        public DataTable selectProdutos()
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                string query = "SELECT idProduto as 'ID', nomeItem as 'Nome', pesoGramas as 'Quantidade', maximoQuantidade  as 'maximo' FROM  produtos";
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, stringConection);              
                adaptador.Fill(dados);
                return dados;
            }
        }

        public DataTable selectCardapio()
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                string query = "SELECT * from vw_Cardapio";
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, stringConection);
                adaptador.Fill(dados);
                return dados;
            }
        }


        public DataTable selectFaturamento (string inicio, string final)
        {
            try
            {
                using (var conexao = AbrirConexao())
                {
                    conexao.Open();
                    string query = " SELECT [codigo],[valorTotal], m.nome_modoDePagamento, [dataVenda], [nomeCliente]"
                        + " from vendas as v " +
                        "   inner join modoDePagamento as m on " +
                        "  v.modoDePagamento = m.id_modoDePagamento"
                        + $" where dataVenda >= '{inicio}' " +
                        $"   and dataVenda <= '{final}' ";

                    DataTable dados = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, stringConection);
                    adaptador.Fill(dados);
                    return dados;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void recarregarProduto(Produto p)
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = $"UPDATE produtos SET  pesoGramas = {p.Peso} WHERE idProduto = {p.ID}";
                    comando.ExecuteNonQuery();
                }
                conexao.Close();          
            }
        }
        public void adicionarProdutos(Produto p)
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = $"INSERT produtos values ('{p.Nome}',{p.Peso}, {p.PesoMaximo})";
                    comando.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        public DataTable selectFormaDePagamento()
        {
            try
            {
                using (var conexao = AbrirConexao())
                {
                    conexao.Open();
                    string query = "SELECT * FROM  tiposPagamento";
                    DataTable dt = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, stringConection);
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ;
            }
        }
        public DataTable selectAdicional()
        {
            try
            {
                using (var conexao = AbrirConexao())
                {
                    conexao.Open();
                    string query = "SELECT * FROM  produtos WHERE nomeItem NOT LIKE '%Açai%'";
                    DataTable dt = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, stringConection);
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void InsereVenda(Vendas venda, HashSet<ItensPedidos> itens)
        {
            try
            {
                int codigovenda = 0;
                using (var conexao = AbrirConexao())
                {
                    conexao.Open();
                    using (var comando = conexao.CreateCommand())
                    {
                        comando.CommandText = $"INSERT vendas values ({venda.ValorTotal},{venda.ModoDePagamento}," +
                            $" '{venda.DataVenda}', '{venda.NomeCliente}')";
                        comando.ExecuteNonQuery();
                    }
                    conexao.Close();
                    using (var C = AbrirConexao())
                    {
                        C.Open();
                        string query = $"SELECT TOP 1  codigo FROM " +
                            $" vendas WHERE  nomeCliente LIKE '{venda.NomeCliente}' and dataVenda = '{venda.DataVenda}'";
                        DataTable dt = new DataTable();
                        SqlDataAdapter adaptador = new SqlDataAdapter(query, stringConection);
                        adaptador.Fill(dt);
                        codigovenda = (int)dt.Rows[0][0];
                    }
                    insereItens(itens, codigovenda, venda.DataVenda.ToString());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("ERRO: " + e.Message);
            }


         
        }

        public void insereItens(HashSet<ItensPedidos> itens, int codVenda, string data)
        {

            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                using (var comando = conexao.CreateCommand())
                {

                    foreach (var item in itens)
                    {
                        comando.CommandText = $"INSERT itensPedidos values ({codVenda},{item.CodigoProdutoAcai}," +
                                              $" '{item.TamanhoAcai}', {item.CodigoProdutoAdicional1}," +
                                              $" {item.CodigoProdutoAdicional2}, {item.Valor}, '{data}')";
                        atualizaPesosDosItens(item.CodigoProdutoAcai, item.TamanhoAcai);
                        atualizaPesosDosItens(item.CodigoProdutoAdicional1, item.TamanhoAcai);
                        atualizaPesosDosItens(item.CodigoProdutoAdicional2, item.TamanhoAcai);
                        comando.ExecuteNonQuery();
                   
                    }
                }
                conexao.Close();
            }
        }
        public int retornaPesos(int idProduto, string tamanho)
            {
         
            if (idProduto > 3)
            {
                return 100;
            }
            else
            {
                if (tamanho.Equals("P"))
                {
                    return 250;
                } else if (tamanho.Equals("M"))
                {
                    return 450;
                } else if (tamanho.Equals("G"))
                {
                    return 750;
                }
                else
                {
                    return 0;
                }
            }
        }
            
        public void atualizaPesosDosItens(int idProduto, string tamanho)
        {
            try
            {
                using (var conexao = AbrirConexao())
                {
                    conexao.Open();
                    using (var comando = conexao.CreateCommand())
                    {
                        comando.CommandText = $"EXEC USP_ATUALIZA_PESOS {idProduto}, {retornaPesos(idProduto, tamanho)} ";
                        comando.ExecuteNonQuery();
                    }
                    conexao.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("ERRO: " + e.Message);
            }

        }


           
        }
    }
    




