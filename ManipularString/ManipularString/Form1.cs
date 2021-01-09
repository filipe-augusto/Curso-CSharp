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
            //string nome = "Filipe augsto santos chaves";
            //// int indice =   nome.IndexOf('a', 6,5);
            //int indice = nome.LastIndexOf('e');
            //label1.Text = "indice: " + indice;
            #endregion
            #region inser e replace
            //string nome = "Filipe Chaves";
            ////string nomeFinal = nome.Insert(6, " Augusto");
            //string nomeFinal = nome.Replace("Chaves", "Augusto");
            //// nomeFinal = nome.Replace('p', '9').Replace('i', '1').Replace('e', '3');
            //label1.Text = nomeFinal;
            #endregion
            #region length - substring
            //string nome = "Filipe Augusto Santos Chaves";
            //int tam =   nome.Length;
            //// string parte = nome.Substring(0, 7);
            ////string parte = nome.Substring(7);
            //string parte = nome.Substring(nome.LastIndexOf(" "));//PEGANDO O SOBRENOME
            //label1.Text = parte.ToString();
            #endregion
            #region Split
            //string nome = "Filipe Augusto Cassila Joel Pedro Maria Ana";                  
            //string[] nomes = nome.Split(' ');
            //foreach (string n in nomes ) {
            //    label1.Text += n + "\n";
            //}
            #endregion
            #region startWith EndsWith
            //string nome = "Filipe";
            //bool verdade = nome.StartsWith("Feli");//começa com. case sensitive 
            //bool verdade2 = nome.EndsWith("pe");// termina com
            //label1.Text = verdade+" " +verdade2;
            #endregion
            #region trim  - trimstart - trimend
            //string mensagem = "ola filipe           "; //remove os espaços
            //label1.Text = ">" + mensagem.Trim().TrimEnd() + "<";
            #endregion
            #region compareTo - Equals
            //string nome = "filipe";
            //string res = nome.Equals("filipe") ? "positivo" : "negativo";
            //int res2 = nome.CompareTo("felipe");

            //label1.Text = res2.ToString();
            #endregion
            #region format
            decimal valor = 19.95m;
            int temp = 32;
            // string s = String.Format("O valor do produto é {0:} é a temperatura é {1}", valor, temp);
            //string s = String.Format("hoje é {0:D} e são {0:T}", DateTime.Now);
            // string s = $"O valor do produto é {valor:C4} é a temperatura é {temp}";
            string s = $"Data {DateTime.Now:D} e hora {DateTime.Now:T}";
            label1.Text = s;
            #endregion
        }
    }
}




