using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SautinSoft;

namespace ConvertPDFInWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nomeArquivo;
        string caminho;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
                lblConversao.Text = "";
                lblCaminho.Text = "";
            try
            {

                SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
                 caminho = @escolherArquivo();
                f.OpenPdf(@caminho);
                //string caminho = (Environment.GetFolderPath caminho);

                if (f.PageCount > 0)
                {
                    string destino = @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() + @"\Conversao"
                    + nomeArquivo.Replace(".","") + ".docx";
                    f.WordOptions.Format = SautinSoft.PdfFocus.CWordOptions.eWordDocument.Docx;
                    f.ToWord(destino);

                    lblConversao.ForeColor = Color.Green;
                    lblConversao.Text = destino;

                }
            }
            catch (Exception ex)
            {
                lblConversao.ForeColor = Color.Red;
                lblConversao.Text = "Erro:  "+ ex.Message;
               
            }
            this.Cursor = Cursors.Default;
        }

        public string escolherArquivo()
        {
            var retorno = string.Empty;               
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    retorno = dialog.FileName;
                    lblCaminho.Text = retorno;
                    FileInfo info = new FileInfo(retorno);
                    nomeArquivo = info.Name;
                }
            }
            return retorno;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblConversao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var diretorio = Path.GetDirectoryName(lblConversao.Text);
                var nomearquivo = Path.GetFileName(lblConversao.Text);
                var arquivo = new FileInfo(lblConversao.Text);
                lblConversao.Text = diretorio +@"\"+ nomearquivo;
                Process.Start(lblConversao.Text);

            }
            catch (Exception ex)
            {
                lblConversao.ForeColor = Color.Red;
                lblConversao.Text = "Erro:  " + ex.Message + "\n" ;
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para converter, apenas clique no botão, escolhea o arquivo e automaticamente ele será " +
                "convertido para word.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicação desenvolvida por Filipe Augusto.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
