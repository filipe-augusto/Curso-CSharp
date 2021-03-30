using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_UsandoGrid.Entities
{
    class Conexao
    {
        static string strConection = @"Data Source=FILIPE-HPRPE60;Initial Catalog=eBook;Integrated Security=True";
        private IDbConnection AbrirConexao()
        {
            return new SqlConnection(strConection);
        }
        public DataTable selectBanco()
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                string query = "select cTitulo as 'Titulo'," +
                    " cSubtitulo as 'Subtitulo'," +
                    " nAno as 'Ano'," +
                    " nPeso as 'Peso' " +
                    " from tCADLivro";
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, strConection);
                /////////////////
                adaptador.Fill(dados);
                return dados;
            }
        }




    }
}
