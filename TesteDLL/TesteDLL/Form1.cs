using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operacoes.Matematica.valor1 = 10;
            Operacoes.Matematica.valor2 = 2;

            label1.Text = ("Somar: " + Operacoes.Matematica.Somar() + " ");
            label1.Text += ("Subtrair: " + Operacoes.Matematica.Subtrair() + " ");
            label1.Text += ("Dividir: " + Operacoes.Matematica.Dividir() + " ");
            label1.Text += ("Multiplicar: " + Operacoes.Matematica.Multiplicar() + " ");
        }
    }
}
