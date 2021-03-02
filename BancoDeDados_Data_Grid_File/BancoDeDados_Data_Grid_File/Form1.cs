using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados_Data_Grid_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarGrid();
        }
        static string strConection = @"Data Source=FILIPE-HPRPE60;Initial Catalog=PrimeiroBanco;Integrated Security=True";
        // SqlConnection conexao = new SqlConnection(strConection);

        private void CarregarGrid()
        {
            try
            {
                using (var conexao = AbrirConexao())
                {
                    conexao.Open();
                    string query = "select id, nome, datainclusao , descricao from imagens";
                    DataTable dados = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, strConection);
                    /////////////////
                    adaptador.Fill(dados);
                    foreach (DataRow linha in dados.Rows)
                    {
                        dataGridViewLista.Rows.Add(linha.ItemArray);//insere a linha na datagriw
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro");
            }

        }
        private IDbConnection AbrirConexao()
        {
            return new SqlConnection(strConection);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var arquivo = EscolherArquivo();
                if (!string.IsNullOrWhiteSpace(arquivo))
                {
                    SalvarAquivo(arquivo);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string EscolherArquivo()
        {
            var retorno = string.Empty;
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    retorno = dialog.FileName;
                    txtImagem.Text = retorno;

                }

            }
            return retorno;
        }
        private void SalvarAquivo(string arquivo)
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO imagens (nome,datainclusao, descricao, foto, extencao) values" +
                        $"(@Nome,@DataInclusao, @Descricao,@Foto,@Extecao)";
                    ConfigurarParametros(comando, arquivo);
                    comando.ExecuteNonQuery();
                    CarregarGrid();
                }
            }
        }

        private void ConfigurarParametros(IDbCommand comm, string arquivo)
        {
            comm.Parameters.Add(new SqlParameter("Nome", txtNome.Text));
            comm.Parameters.Add(new SqlParameter("DataInclusao", DateTime.Now));
            comm.Parameters.Add(new SqlParameter("Descricao", txtDescricao.Text));
            comm.Parameters.Add(new SqlParameter("Foto", File.ReadAllBytes(arquivo)));
            comm.Parameters.Add(new SqlParameter("Extecao", Path.GetExtension(arquivo)));
        }

        private void dataGridViewLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("teste");
        }

        private void dataGridViewLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("teste");
        }
    }
}
