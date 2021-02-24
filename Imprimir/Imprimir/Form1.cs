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
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            #region Parte 1
            string texto = "trabalhando com impressão";
            Font letra = new Font("Arial",20,FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);
            Point pontoInicial = new Point(100, 50);
            //desenhar o documento para ser impresso
            e.Graphics.DrawString(texto, letra, pincel, pontoInicial);

            #endregion

        }
    }
}
