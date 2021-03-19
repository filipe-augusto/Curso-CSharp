using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Servicos
{
    class Conexao
    {
        static string strConection = @"Data Source=FILIPE-HPRPE60;Initial Catalog=PrimeiroBanco;Integrated Security=True";
        // SqlConnection conexao = new SqlConnection(strConection);

        private IDbConnection AbrirConexao()
        {
            return new SqlConnection(strConection);
        }
        public DataTable selectProfissao()
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                string query = "SELECT * FROM  tblprofissao";
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, strConection);
                adaptador.Fill(dados);
                return dados;
            }
        }

    }




}
