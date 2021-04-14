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
                        $" vendas WHERE  nomeCliente LIKE '{venda.NomeCliente}' and dataVenda = {venda.DataVenda}";
                    DataTable dt = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, stringConection);
                    adaptador.Fill(dt);
                    codigovenda = (int)dt.Rows[0][0];
                }
                insereItens(itens, codigovenda);
            }
        }

        public void insereItens(HashSet<ItensPedidos> itens, int codVenda)
        {

            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                using (var comando = conexao.CreateCommand())
                {

                    foreach (var item in itens)
                    {
                        comando.CommandText = $"INSERT itensPedidos values ({codVenda},{item.CodigoProdutoAcai},'{item.TipoAcai}'," +
                                              $" '{item.TamanhoAcai}', {item.CodigoProdutoAdicional1}," +
                                              $" {item.CodigoProdutoAdicional2}, {item.Valor})";
                        comando.ExecuteNonQuery();

                    }
                  
                }
                conexao.Close();
            }



           
        }
    }
    }




