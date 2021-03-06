﻿using System;
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
        // string stringConectJob = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=treino;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string stringConectJob = @"Data Source=TI-2021\SQLEXPRESS; Initial Catalog=treino; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // SqlConnection conexao = new SqlConnection(strConection);

        private SqlConnection AbrirConexao()
        {
            return new SqlConnection(strConection);
        }
        public DataTable selectProfissao()
        {
            try
            {
                using (var conexao = AbrirConexao())
                {
                    conexao.Open();
                    string query = "SELECT * FROM  tblprofissao";
                    SqlCommand cmd = new SqlCommand(query, conexao);
                    SqlDataReader dados = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    return dt;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable selectFuncionario()
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                string query = "SELECT * FROM  VW_DADOS_FUNCIONARIO";
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, strConection);
                adaptador.Fill(dados);
                return dados;
            }
        }
        public void addFuncionario(string nome, int idade, double salario, double profissao)
        {
            try
            {
                using (var conexao = AbrirConexao())
                {
                    conexao.Open();
                    using (var comando = conexao.CreateCommand())
                    {
                        comando.CommandText = "INSERT INTO tblfuncionario (vNomeFuncionario,iIdade, dSalario, iProfissao) values" +
                            $"('{nome}',{idade},{salario},{profissao})";
                        // ConfigurarParametros(comando, arquivo);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // throw;
                
            }
        }

        public void excluirFuncionario(int idFuncionario)
        {
            using (var conexao = AbrirConexao())
            {
                try
                {
                    using (var comando = conexao.CreateCommand())
                    {
                        conexao.Open();
                        comando.Connection = conexao;
                        comando.CommandText = $"DELETE FROM tblfuncionario WHERE iIdFuncionario = {idFuncionario}";
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir os arquivos: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        //public string buscaFunciorario( string nome)
        //{
        //    using (var conexao = AbrirConexao())
        //    {
        //        conexao.Open();
        //        string query = $"SELECT top 1 Nome  FROM  VW_DADOS_FUNCIONARIO where Nome like " +
        //            $"'%{nome}%'";
        //        DataTable dados = new DataTable();
        //        SqlDataAdapter adaptador = new SqlDataAdapter(query, strConection);
        //        adaptador.Fill(dados);
        //    //    return dados.Columns['']
        //    }
        //}


    }




}
