using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;


namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int idLinha;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            #region Sql Server CE
            string baseDados = Application.StartupPath + @"\db\dbSqlServer.sdf";
            string strConection = @"DataSource=" + baseDados + "; Password =''";
            SqlCeEngine db = new SqlCeEngine(strConection);

            if (!File.Exists(baseDados))// se nao existir
            {
                db.CreateDatabase();//ele cria
            }
            db.Dispose();//liberar recursos

            SqlCeConnection conexao = new SqlCeConnection(strConection);//cria a conexão
            //  conexao.ConnectionString = strConection;

            try
            {
                conexao.Open();
                lblResultado.Text = "Conectado Sql Server CE";

            }
            catch (Exception ex)
            {
                lblResultado.Text = "Erro ao Conectado Sql Server CE\n" + ex;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
            #region SQLite
            //      string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //      string strConection = @"Data Source=" + baseDados + "; Version =3";


            //      if (!File.Exists(baseDados))// se nao existir
            //      {
            //          SQLiteConnection.CreateFile(baseDados);
            //      }

            //SQLiteConnection conexao = new SQLiteConnection(strConection);//cria a conexão
            //      //  conexao.ConnectionString = strConection;

            //      try
            //      {
            //          conexao.Open();
            //          lblResultado.Text = "Conectado SQLite";

            //      }
            //      catch (Exception ex)
            //      {
            //          lblResultado.Text = "Erro ao Conectado SQLite\n" + ex;
            //      }
            //      finally
            //      {
            //          conexao.Close();
            //      }

            #endregion
            #region Mysql

            //...
            #endregion
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            #region Sql Server
            string baseDados = Application.StartupPath + @"\db\dbSqlServer.sdf";
            string strConection = @"DataSource=" + baseDados + "; Password =''";

            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE pessoas (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                comando.ExecuteNonQuery();
                lblResultado.Text = "Tabela criada sql server Ce";
                comando.Dispose();

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion

            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + "; Version =3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);


            //try
            //{
            //    conexao.Open();
            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE TABLE pessoas (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();
            //    lblResultado.Text = "Tabela criada SQLite";
            //    comando.Dispose();

            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySql

            //--
            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region SQL Server           
            string baseDados = Application.StartupPath + @"\db\dbSqlServer.sdf";
            string strConection = @"DataSource=" + baseDados + "; Password =''";
            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = $"INSERT INTO pessoas VALUES ({id}, '{nome}', '{email}')";
                comando.ExecuteNonQuery();
                lblResultado.Text = "Dados inseridos na  tabela ";
                comando.Dispose();

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + "; Version =3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            //try
            //{
            //    conexao.Open();
            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;
            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";
            //    comando.ExecuteNonQuery();
            //    lblResultado.Text = "Registro inserido SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
            #region Mysql

            #endregion
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            listaResultado.Rows.Clear();
            #region SQL Server

            string baseDados = Application.StartupPath + @"\db\dbSqlServer.sdf";
            string strConection = @"DataSource=" + baseDados + "; Password =''";
            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                string query = "SELECT * FROM pessoas";
                conexao.Open();
                if (txtNome.Text != "")
                {
                    query = "SELECT * FROM pessoas WHERE nome like '%" + txtNome.Text + "%'";
                }
                DataTable dados = new DataTable();
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConection);
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    listaResultado.Rows.Add(linha.ItemArray);//insere a linha na datagriw
                }


            }
            catch (Exception ex)
            {
                listaResultado.Rows.Clear();
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + "; Version =3";
            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            //try
            //{
            //    string query = "SELECT * FROM pessoas";
            //    conexao.Open();
            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome like '%" + txtNome.Text + "%'";
            //    }
            //    DataTable dados = new DataTable();
            //    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);
            //    adaptador.Fill(dados);
            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        listaResultado.Rows.Add(linha.ItemArray);//insere a linha na datagriw
            //    }
            //}
            //catch (Exception ex)
            //{
            //    listaResultado.Rows.Clear();
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
            #region Mysql

            #endregion
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region SQL Server           
            string baseDados = Application.StartupPath + @"\db\dbSqlServer.sdf";
            string strConection = @"DataSource=" + baseDados + "; Password =''";
            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                int id = (int)listaResultado.SelectedRows[0].Cells[0].Value;

                comando.CommandText = $"DELETE FROM pessoas WHERE id = {id}";
                comando.ExecuteNonQuery();
                lblResultado.Text = "Registro excluido SQl Server ";
                comando.Dispose();

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + "; Version =3";
            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            //try
            //{
            //    conexao.Open();
            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;
            //    int id = (int)listaResultado.SelectedRows[0].Cells[0].Value;
            //    comando.CommandText = $"DELETE FROM pessoas WHERE id = {id}";
            //    comando.ExecuteNonQuery();
            //    lblResultado.Text = "registro excluido SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
            #region Mysql

            #endregion

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region SQL Server           
            string baseDados = Application.StartupPath + @"\db\dbSqlServer.sdf";
            string strConection = @"DataSource=" + baseDados + "; Password =''";
            SqlCeConnection conexao = new SqlCeConnection(strConection);
            try
            {
                conexao.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                int id = (int)listaResultado.SelectedRows[0].Cells[0].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string query = $"UPDATE pessoas SET nome ='{nome}', email= '{email}' WHERE id LIKE '{id}'";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                lblResultado.Text = "Registro alteado SQl Server ";
                comando.Dispose();

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
            #region SQLite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + "; Version =3";
            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            //try
            //{
            //    conexao.Open();
            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;
            //    int id = (int)listaResultado.SelectedRows[0].Cells[0].Value;
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;
            //    string query = $"UPDATE pessoas SET nome ='{nome}', email= '{email}' WHERE id LIKE '{id}'";
            //    comando.CommandText = query;
            //    comando.ExecuteNonQuery();
            //    lblResultado.Text = "Registro alteado SQl Server ";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
            #region Mysql

            #endregion
        }

        private void listaResultado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            listaResultado.Rows[e.RowIndex].Cells["acao"].ToolTipText = "Clique aqui";
        }

        private void listaResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                idLinha = Convert.ToInt32(listaResultado.Rows[e.RowIndex].Cells["id"].Value.ToString());
               // MessageBox.Show("teste" + idLinha);
                //verifica a coluna que foi clicada
                if (listaResultado.Columns[e.ColumnIndex] == listaResultado.Columns["acao"])
                {
                    MessageBox.Show(listaResultado.Columns["nome"].ToString());
                }
            }
            catch (Exception)
            {
              
            }
           
        }
    }
}
