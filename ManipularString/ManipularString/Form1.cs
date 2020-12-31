using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Contais / toString
            //    string texto = "este tipo de variavel é alfanumerica";
            //    string palavra = "tipo";             
            //    if (texto.Contains(palavra))
            //    {
            //        label1.Text = "Contém";
            //    }
            //    else
            //    {
            //        label1.Text = (" não contém");
            //    }

            //int num = 5400;
            //label1.Text = num.ToString();
            #endregion
            #region ToUpper e ToLower
            //string nome = "filipe";
            //label1.Text = nome.ToUpper() + nome.ToLower();
            #endregion
            #region indexOf LastIndexOf
            string nome = "Filipe augsto santos chaves";
            // int indice =   nome.IndexOf('a', 6,5);
            int indice = nome.LastIndexOf('e');
            label1.Text = "indice: " + indice;
            #endregion


        }

    }
}
