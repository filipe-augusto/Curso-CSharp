using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Condição simples e encadeada
            int valor = 10;
            if (valor ==5)
            {
                Console.WriteLine("Condição alternativa 0");
            }
            else if(valor == 10 && valor >=10)
            {
                Console.WriteLine("Condição alternativa 1");
            }
            else
            {
                Console.WriteLine("Condição falsa");
            }
            #endregion
            #region Condições alinhadas
            //int numero = 10;
            //if(numero> 5)
            //{
            //    Console.Write("O numero é maior que 5");
            //    if(numero %2 == 0)
            //    {
            //        Console.WriteLine("e também é par");
            //    }
            //    else
            //    {
            //        Console.WriteLine("mas não é par");
            //    }
            //}
            #endregion
            #region Operador ternario
            int numero = 10;
            string mensagem = numero > 5 ? "Maior que 5" : "Menos que 5";


            //condição ? true : false
            // mensagem = numero > 5 ? "Maior que 5" : "Menos que 5";

         //   Console.WriteLine(mensagem);
            Console.WriteLine(numero > 5 ? "Maior que 5" : "Menos que 5");
            Console.ReadKey();
            #endregion
        }
    }
}
