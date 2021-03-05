using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EmissaoNFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                XmlTextWriter writer = new XmlTextWriter(@"c:\dados\filmes.xml", null);
                //inicia o documento xml
                writer.WriteStartDocument();
                //escreve o elmento raiz
                writer.WriteStartElement("filmes");
                //Escreve os sub-elementos
                writer.WriteElementString("titulo", "Cada & Companhia");
                writer.WriteElementString("titulo", "007 contra Godzila");
                writer.WriteElementString("titulo", "O segredo do Dr. Haus's");
                // encerra o elemento raiz
                writer.WriteEndElement();
                //Escreve o XML para o arquivo e fecha o objeto escritor
                writer.Close();
                MessageBox.Show("Arquivo XML gerado com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GeraXML()
        {
            XmlTextWriter writer = new XmlTextWriter(@"c:\dados\filmes2.xml", null);
            //inicia o documento xml
            writer.WriteStartDocument();
            //Usa a formatação
            writer.Formatting = Formatting.Indented;
            //Escreve o elemento raiz
            writer.WriteStartElement("filmes");
            //Inicia um elemento       
            writer.WriteStartElement("filmes");
            //e sub-elementos
            writer.WriteElementString("titulo", "Matrix");
                    writer.WriteElementString("formato", "DVD");
                    //encerra os elementos itens

            writer.WriteEndElement();
       
            // encerra o elemento raiz
            writer.WriteFullEndElement();
            //escreve o XML para o arquivo e fecha o escritor
            writer.Close();
        }

        private void btnLerXML_Click(object sender, EventArgs e)
        {
          
                DataSet ds = new DataSet();
                ds.ReadXml(txtPath.Text);
                dgvXML.DataSource = ds.Tables[0].DefaultView;

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    txtPath.Text = openFile.FileName;
                    lblSize.Text = System.IO.File.ReadAllBytes(txtPath.Text).Length + " bytes";
                    txtPath.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex.Message);
                }
            }
        }
    }
}
