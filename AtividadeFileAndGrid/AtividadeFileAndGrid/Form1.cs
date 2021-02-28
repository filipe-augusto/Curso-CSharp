using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeFileAndGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.Filter = "Imagem png | *.png | Pdf | *.pdf";
            if (open.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = open.FileName;
            }

          ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
                lista.Rows.Add(label1.Text, "a", "a");
            label1.Text = "";
        }
    }
}

