using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDetalhes
{
    public partial class FormMain : Form
    {
     
        public FormMain()
        {
            InitializeComponent();
        }
     

        private void btnSecond_Click(object sender, EventArgs e)
        {
            Hide();
            FormSecond f = new FormSecond("Bem vindo");
            f.Mensagem = "Filipe Augusto";
            // f.Show();
            f.ShowDialog(); // mostrar e bloquear a principal
                if(f.Mensagem != null)
            {
                lblTitulo.Text = f.Mensagem;
            }
            this.Show();
        }

        private void btnSecondFormWithThread_Click(object sender, EventArgs e)
        {
            Close();     
            Thread t = new Thread(() => Application.Run(new FormSecond("Filipe")));
         
           
            t.Start();
        }

        private void sobtrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mFilNovo_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start();

        }

        private void mFileAbrir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSecond f = new FormSecond();
            f.ShowDialog();
            Show();
        }

        private void mfileSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mHelpDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filpe Augusto");
        }

        private void mHelpVesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão: 1.0");
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboMenu.SelectedIndex == 0)
            {
                menuHelp.Text = "Help";
                menuFile.Text = "File";
            }
            else if(comboMenu.SelectedIndex == 1)
            {
                menuHelp.Text = "Ajuda";
                menuFile.Text = "Arquivo";
            }
        }

        private void btnPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                lblTitulo.Text = mPesquisar.Text;
                mPesquisar.Text = "";
            }
        }
    }
}
