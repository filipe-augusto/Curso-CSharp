using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While
            //int valor = 0;
            //while(valor < 10)
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //}
            #endregion
            #region Do While
            //int valor = 0;
            //do
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //} while (valor < 10);
            #endregion
            #region For
            //for (int i =0, j =10; i < 10; i++, j--)
            //{
            //    Console.WriteLine("I = "+i+ "| J = " + j);
            //}
            //Console.ReadKey();
            #endregion
            #region Foreach
            string[] frutas = { "uva", "maça", "laranja", "limao" };
            foreach(string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
