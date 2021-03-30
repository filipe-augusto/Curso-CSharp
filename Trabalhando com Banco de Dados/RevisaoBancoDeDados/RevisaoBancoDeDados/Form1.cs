using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RevisaoBancoDeDados.Model;

namespace RevisaoBancoDeDados
{
    public partial class Form1 : Form
    {
        Pessoa pessoa = new Pessoa();

        public Form1()
        {
            InitializeComponent();
        }
        Pessoa p;

        static string strConection = @"Data Source=FILIPE-HPRPE60;Initial Catalog=PrimeiroBanco;Integrated Security=True";
        SqlConnection conexao = new SqlConnection(strConection);

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                string query = "SELECT * FROM pessoas";

                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, strConection);
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    listaGrid.Rows.Add(linha.ItemArray);//insere a linha na datagriw
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();



            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Formulario f = new Formulario();
            f.ShowDialog();
            //    Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Deseja sair?","Sair",MessageBoxButtons.YesNo) != DialogResult.No)
            //{
            //    this.Show();


            //}
        }

        private void listaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaGrid.Rows.Clear();
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                string query = "SELECT * FROM pessoas";

                if (txtProcurar.Text != "")
                {
                    query = "SELECT * FROM pessoas WHERE nome like '%" + txtProcurar.Text + "%'";
                }
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, strConection);
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    listaGrid.Rows.Add(linha.ItemArray);//insere a linha na datagriw
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
               // Form1_Load();
            }
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region SQL Server           

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                int id = (int)listaGrid.SelectedRows[0].Cells[0].Value;

                comando.CommandText = $"DELETE FROM pessoas WHERE id = {id}";
                comando.ExecuteNonQuery();             
                comando.Dispose();
                MessageBox.Show("Excluido","Registro excluido com sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            finally
            {
              
                conexao.Close();
            }
            #endregion
        }
    }
}

