using Banco_UsandoGrid.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_UsandoGrid
{
    public partial class A : Form
    {
        public A()
        {
            InitializeComponent();
        }
        Conexao conexao = new Conexao();

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();      
            dataGridView_Livros.DataSource = conexao.selectBanco();
        }
    }
}
