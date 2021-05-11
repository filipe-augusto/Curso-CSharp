using RevisaoBancoDeDados.Model;
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
using System.Data.SqlClient;
namespace RevisaoBancoDeDados
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }
        Form1 f = new Form1();
         Pessoa p;
    
       static string strConection = @"Data Source=FILIPE-HPRPE60;Initial Catalog=PrimeiroBanco;Integrated Security=True";
        SqlConnection conexao = new SqlConnection(strConection);
     
       
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEmail.Text = "";
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            rardioM.Checked = true;
        }

        private void Formulario_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Email = txtEmail.Text;
            p.Nascimento = dateNascimento.Value;
            p.Inicio = TimeSpan.Parse(timeInicio.Text);
            p.Termino = TimeSpan.Parse(timeTermino.Text);
            char genero = rardioM.Checked ? 'M' :
                radioF.Checked ? 'F' : 'O';
            p.Genero = genero;
            if (MessageBox.Show( $"Confirma o cadastramento do {p.Nome}?", "Cadastramento", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                Insere(p);
            }        
        }

        private void Insere(Pessoa pessoa)
        {
            //MessageBox.Show("PAssar banco:    "+pessoa.Nome);
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = $"INSERT INTO pessoas VALUES ('{pessoa.Nome}', '{pessoa.Email}','{pessoa.Nascimento.Day}/{pessoa.Nascimento.Month}/{pessoa.Nascimento.Year}" +
                    $"' , '{pessoa.Inicio}'," +
                    $"'{pessoa.Termino}','{pessoa.TempoTotal}',{pessoa.Idade},'{pessoa.Genero}' )";
                comando.ExecuteNonQuery();
                MessageBox.Show($"Cadastramento realizado com sucesso!", "Castramento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
          
                txtEmail.Text = "";
                txtNome.Text = "";
                Close();

            }
        }

     
    }
}
