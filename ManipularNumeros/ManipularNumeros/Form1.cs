using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region TryParse
            // //tryParse - tenta convertar 
            // int num;
            //// bool res = int.TryParse("1985ano", out num);

            // if (int.TryParse("1985ano", out num))
            // {
            //     label.Text = num.ToString();
            // }
            // else
            // {
            //     label.Text = "Erro na conversão";
            // }
            #endregion
            #region To string 
            // int num = 11;
            // label.Text = num.ToString("#.00");
            //  label.Text = num.ToString("(11)00000.0000");
            //label.Text = num.ToString("x");//hexadecimal
            //label.Text = num.ToString("D");//decimal
            // label.Text = num.ToString("C");//valor
            //label.Text = num.ToString("(00)0000-0000");//valor
            // label.Text = num.ToString("0000-000");//valor
            // label.Text = Convert.ToString(num, 16);
            #endregion
            #region  Mth
            double pi = Math.PI;
            double E = Math.E;
            double seno = Math.Sin(3);
            double cosseno = Math.Cos(3);
            double potencia = Math.Pow(5,2);
            double raiz = Math.Sqrt(49);
            Math.Round(158.75);//retorna
            double floor = Math.Floor(52.75);//arredondar para baixo
            double ceil = Math.Ceiling(2.52); //arredondar para cima
            label.Text = pi.ToString("#.00");
            #endregion
        }
    }
}

