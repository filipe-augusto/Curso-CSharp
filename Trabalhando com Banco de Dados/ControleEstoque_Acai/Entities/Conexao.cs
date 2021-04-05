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


    }

}


