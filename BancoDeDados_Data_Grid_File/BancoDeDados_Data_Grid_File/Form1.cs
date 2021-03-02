using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

        static string strConection = @"Data Source = 192.168.0.253; Initial Catalog = BOOKS;Timeout=9999;Persist Security Info=True;User ID=sa; password=m2y6bvMEkls;";
        // SqlConnection conexao = new SqlConnection(strConection);

        private void CarregarGrid()
        {
            try
            {
                dataGridViewLista.Rows.Clear();
                foreach (DataRow linha in selectBanco().Rows)
                {
                    var bytes = linha[4] as byte[];
                    if (bytes != null)
                    {
                        var arquivotemp = Path.GetFileName($"{linha[1]}{linha[5]}");
                        File.WriteAllBytes(arquivotemp, bytes);
                        FileInfo infoFile = new FileInfo(arquivotemp);
                        //  Image imagem = Image.FromFile(infoFile.FullName);
                        dataGridViewLista.Rows.Add(linha[0], linha[1], linha[2], linha[3], infoFile.Name, "Excluir");//insere a linha na datagriw
                                                                                                                                 //   }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }
        }
        private DataTable selectBanco()
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                string query = "select id, nome, datainclusao, descricao , foto, extencao  from imagens";
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, strConection);
                /////////////////
                adaptador.Fill(dados);
                return dados;
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
            }finally
            {
                txtDescricao.Text = "";
                txtImagem.Text = "";
               txtNome.Text = "";
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
            int id = Convert.ToInt32(dataGridViewLista.Rows[e.RowIndex].Cells["id"].Value.ToString());
            if (dataGridViewLista.Columns[e.ColumnIndex] == dataGridViewLista.Columns["linkImage"])
            {
                foreach (DataRow linha in selectBanco().Rows)
                {
                    if (Convert.ToInt32(linha[0]) == id)
                    {
                        FileInfo arquivo;
                        var bytes = linha[4] as byte[]; //pega o bytes
                        var arquivotemp = Path.GetFileName($"{linha[1]}{linha[5]}");

                        File.WriteAllBytes(arquivotemp, bytes); //escreve todos os bytes em no arquivo
                        arquivo = new FileInfo(arquivotemp);
                        Process.Start(arquivotemp);
                    }
                }

            }
            else if (dataGridViewLista.Columns[e.ColumnIndex] == dataGridViewLista.Columns["btnExcluir"])
            {
                if (MessageBox.Show($"Confirma a exclusão ?",
                                           "Excluir arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    excluirBanco(id);
                }
            }
        }
        private void excluirBanco(int id)
        {
            using (var conexao = AbrirConexao())
            {
                try
                {
                    using (var comando = conexao.CreateCommand())
                    {
                        conexao.Open();
                        comando.Connection = conexao;
                        comando.CommandText = $"DELETE FROM imagens WHERE id = {id}";
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                        MessageBox.Show("excluido com sucesso!", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir os arquivos: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                    CarregarGrid();
                }
            }
        }
            private void dataGridViewLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                MessageBox.Show("teste");
            }
        }
    }
