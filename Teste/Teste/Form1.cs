using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{

    public partial class Form1 : Form
    {

      

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matematica.valor2 = 100;
            Matematica.valor1 = 2;
            listBox.Items.Add("Soma: " + Matematica.Somar());
            listBox.Items.Add("Subtrair: " + Matematica.Subtrair());
            listBox.Items.Add("Multiplicar: " + Matematica.Multiplicar());
            listBox.Items.Add("Dividir: " + Matematica.Dividir());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
