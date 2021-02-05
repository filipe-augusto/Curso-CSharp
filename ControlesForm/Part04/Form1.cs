using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            lista.Items.Add(txtNome.Text);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            object item = lista.SelectedItem;
            lista.Items.Remove(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            lista.Items.RemoveAt(indice);
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
           string nome = lista.SelectedItem.ToString();
            txtNome.Text = nome;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quantidadeDeItens = lista.Items.Count;
            MessageBox.Show("Quanitade de itens na lista: " + quantidadeDeItens);
        }
    }
}
