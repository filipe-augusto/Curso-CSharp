using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection(@"data source=FILIPE-HPRPE60 ; Integrated Security=SSPI ; Initial Catalog=PrimeiroBanco");
            conexao.Open();

            //UPDATE
            //string strQueryUpdate = "update cadastronome set nome = 'Filipe' where id= 1";
            //SqlCommand cmdComandoUpdate = new SqlCommand(strQueryUpdate, conexao);
            //cmdComandoUpdate.ExecuteNonQuery();

            //DELETE 
            // string strQueryDelete = "Delete from  cadastronome  where id= 1";
            //  SqlCommand cmdComandoDelete = new SqlCommand(strQueryDelete, conexao);
            // cmdComandoDelete.ExecuteNonQuery();

            //INSERT Insert

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            string strQueryInsert = string.Format("INSERT INTO cadastronome values ('{0}')",nome);
              SqlCommand cmdComandoInsert = new SqlCommand(strQueryInsert, conexao);
            cmdComandoInsert.ExecuteNonQuery();

            //SELECT
            string strQuerySelect = "SELECT * FROM cadastronome";
            SqlCommand cmdComandoSelect = new SqlCommand(strQuerySelect, conexao);
            SqlDataReader dados = cmdComandoSelect.ExecuteReader();

            while (dados.Read())
            {
                 Console.WriteLine("id:{0}, nome: {1}",dados["id"], dados["nome"]);
               // Console.WriteLine('a');

            }
            Console.ReadKey();
        }
    }
}
