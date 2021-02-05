using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Matematicos
            //int num1 = 10;
            //int num2 = 2;

            //Console.WriteLine(num1 +num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.ReadKey();
            #endregion
            #region Precedencia de Operadores
            // prioridade de calculo. 1: (); 2: * e /; 3: + e -

            //int num1 = 100;
            //int num2 = 10;
            //int num3 = 5;
            //double result = num1 * (num1 + num2) / num3;
            //Console.WriteLine(result);    
            //Console.ReadKey();
            #endregion
            #region Incremento e decremento
            //int num1 = 10;
            //num1++;
            //++num1;
            //--num1;
            //num1--;
            #endregion
            #region Variavel de concatenação
            //string nome = "Filipe " + "Augusto";
            //string sobrenome = " Chaves "+1993;
            //Console.WriteLine(nome +sobrenome);
            #endregion
            #region Operadores de atribuição
            //float num1 = 10;
            //num1 += 20;         
            //num1 *= 2;
            //num1 /= 5;
            //num1 -= 2;
            //num1 %= 2; //resto
            //string nome = "filipe";
            //nome += " Augusto";
            #endregion
            #region Igualdade / comparação 
            //bool resu = 100+50 == 10*15; //igual ==
            //bool resu2 = 200 / 2 != 150;//diferente !=
            //string nome = "filipe";
            //bool resu3 = nome == "Filipe";
            //bool resu4 = nome != "augusto"; 
            //Console.WriteLine(resu + " " + resu2 + " " + resu3 + " "+resu4);
            #endregion
            #region Relacionais
            //bool res = 100 < 50 * 2;
            //bool res2 = 199 > 20;
            //bool res3 = 100 <= 200;
            //bool res4 = 20 >= 25;
            //Console.WriteLine(res);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            //Console.WriteLine(res4);
            #endregion
            #region Operadores Logicos
            //bool res1 = 100 > 50;
            //bool res2 = 120 == 120;
            //bool final = res1 && res2; //e
            //bool final2 = res1 || res2; //ou
            #endregion
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
