using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conversão implicita
            //byte num1 = 255;
            //ushort num2;
            //num2 = num1;
            //float num3 = 1250.45f;
            //double num4 = num3;
            //int numero = 'C';
            #endregion
            #region Conversão Explicita
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500f;
            //int num4 = (int)num3;

            //char letra = (char)97;

            #endregion
            #region Parse
            //string txtNumero = "1985";
            //int numero = int.Parse(txtNumero);
            //byte num1 = byte.Parse("120");
            //double num2 = double.Parse("125623,56");
            //float num3 = float.Parse("125,33");
            //
            #endregion
            #region treino 1
            //Console.WriteLine("digite um numero:");
            //string idade = Console.ReadLine();
            // int idadeCasamento = int.Parse(idade) + 10;
            // Console.WriteLine("Voce casará em "+idadeCasamento);
            #endregion

            #region Convert
            string texto = Convert.ToString(2500);
            double num1 = Convert.ToDouble(false);
            int num2 = Convert.ToInt32('c');
            Console.WriteLine(num2);
            Console.ReadLine();
            #endregion



        }
    }
}


