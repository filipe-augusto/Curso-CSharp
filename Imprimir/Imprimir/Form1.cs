using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprimir
{
    public partial class Form1 : Form
    {

        int x;
        int y;
        int largura;
        int altura;
        int num_linhas;
        int pagina;
        int num_paginas;
        public Form1()
        {
            InitializeComponent();
            pagina = 0;
            num_paginas = 0;  

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            #region Parte 1
            //string texto = "trabalhando com impressão";
            //Font letra = new Font("Arial",20,FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Black);
            //Point pontoInicial = new Point(100, 50);
            ////desenhar o documento para ser impresso
            //e.Graphics.DrawString(texto, letra, pincel, pontoInicial);
            //e.Graphics.DrawString("Filipe Augusto", letra, Brushes.Red, new Point(100, 150));
            //e.Graphics.FillRectangle(Brushes.Green, new Rectangle(100, 220, 400, 100));
            #endregion
            #region Parte 2 

            //int x = printDocument1.DefaultPageSettings.Bounds.X;
            //int y = printDocument1.DefaultPageSettings.Bounds.Y;
            //int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            //int altura = printDocument1.DefaultPageSettings.Bounds.Height;

            //string titulo = "Lorem Ipsum.";
            //Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincelTitulo = new SolidBrush(Color.Black);
            //Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, 100);
            //StringFormat formatoTitulo = new StringFormat();
            //formatoTitulo.Alignment = StringAlignment.Center;
            //formatoTitulo.LineAlignment = StringAlignment.Center;

            //string texto = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
            //    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
            //    "when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
            //    " It has survived not only five centuries, but also the leap into electronic typesetting," +
            //    " remaining essentially unchanged. " +
            //    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages," +
            //    " and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            //Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Black);
            //Rectangle areaTexto = new Rectangle(x +50, y + 200, largura -100, altura -400);
            ////desenhar o documento para ser impresso
            //e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo);
            //e.Graphics.DrawString(texto, letra, pincel, areaTexto);
            //e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);

            #endregion
            #region Parte 3
            List<string> linhas = new List<string>()
            {
                "1.teste teste teste teste teste teste teste teste",
                 "2.teste teste teste teste teste teste teste teste",
                  "3.teste teste teste teste teste teste teste teste",
                   "4.teste teste teste teste teste teste teste teste",
                    "5.teste teste teste teste teste teste teste teste",
                     "6.teste teste teste teste teste teste teste teste",
                      "7.teste teste teste teste teste teste teste teste",
                       "8.teste teste teste teste teste teste teste teste",
                       "9.teste teste teste teste teste teste teste teste",
        
                 "2.teste teste teste teste teste teste teste teste",
                  "3.teste teste teste teste teste teste teste teste",
                   "4.teste teste teste teste teste teste teste teste",
                    "5.teste teste teste teste teste teste teste teste",
                     "6.teste teste teste teste teste teste teste teste",
                      "7.teste teste teste teste teste teste teste teste",
                       "8.teste teste teste teste teste teste teste teste",
                       "9.teste teste teste teste teste teste teste teste",
                     "10.teste teste teste teste teste teste teste teste",
                          "1.teste teste teste teste teste teste teste teste",
                 "2.teste teste teste teste teste teste teste teste",
                  "3.teste teste teste teste teste teste teste teste",
                   "4.teste teste teste teste teste teste teste teste",
                    "5.teste teste teste teste teste teste teste teste",
                     "6.teste teste teste teste teste teste teste teste",
                      "7.teste teste teste teste teste teste teste teste",
                       "8.teste teste teste teste teste teste teste teste",
                       "9.teste teste teste teste teste teste teste teste",
                     "10.teste teste teste teste teste teste teste teste",
                          "1.teste teste teste teste teste teste teste teste",
                 "2.teste teste teste teste teste teste teste teste",
                  "3.teste teste teste teste teste teste teste teste",
                   "4.teste teste teste teste teste teste teste teste",
                    "5.teste teste teste teste teste teste teste teste",
                     "6.teste teste teste teste teste teste teste teste",
                      "7.teste teste teste teste teste teste teste teste",
                       "8.teste teste teste teste teste teste teste teste",
                       "9.teste teste teste teste teste teste teste teste",
                     "10.teste teste teste teste teste teste teste teste",
                     "11.teste teste teste teste teste teste teste teste"
            };

            string titulo = "Lorem Ipsum.";
            Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincelTitulo = new SolidBrush(Color.Black);
            Rectangle areaTitulo = new Rectangle(x , y, largura - 100, 100);
            StringFormat formatoTitulo = new StringFormat();
            formatoTitulo.Alignment = StringAlignment.Center;
            formatoTitulo.LineAlignment = StringAlignment.Center;
           

            Font letra = new Font("Verdana", 24, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);
            while (num_linhas < linhas.Count)
            {

                if (num_linhas==0)
                {
                    e.Graphics.DrawString(titulo, letraTitulo, pincel, areaTitulo);
                    y += 150;
                }
                e.Graphics.DrawString(linhas[num_linhas], letra, pincel, new Point(x, y));
                y += 30;
                num_linhas++;
                if (y >= altura - 50)
                {
                    y += 50;
                    e.HasMorePages = true;
                    num_paginas++;
                    break;
                }
            }



            #endregion

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printDocument1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                printPreviewControl1.StartPage = --pagina;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pagina < num_paginas)
            {
                printPreviewControl1.StartPage = ++pagina;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;


            printPreviewControl1.Document = printDocument1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
