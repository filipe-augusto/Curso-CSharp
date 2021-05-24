using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_1
{
    class Program
    {
        const int mil = 1000;
        static async Task Main(string[] args)
        {
            #region Thread simples - threadsegundaria
            //Thread t = new Thread(threadsegundaria);
            //t.Start();
            //for (int i = 0; i < mil; i++)
            //{
            //    Console.Write(".");
            //}
            //  Console.ReadKey();
            #endregion
            #region Task await - Aguardar
            // Console.WriteLine("Tecle algo para  iniciar...");
            // Console.ReadLine();
            //await  Aguardar(5);
            // Console.WriteLine("ja passou 5 segundos....");
            // Console.WriteLine("fim");
            // Console.ReadLine();
            #endregion

            Console.WriteLine("informe o ID do cliente");
            var criterio = Console.ReadLine().ToUpper();
            OrderService.
               }
        static void threadsegundaria()
        {
            for (int i = 0; i < mil; i++)
            {
                Console.Write("0");
            }
        }
        static async Task Aguardar(int tempo)
        {
            Console.WriteLine("iniciado espera...");
          await  Task.Delay(TimeSpan.FromSeconds(tempo));
            Console.WriteLine("Fim");
        }
    }
}
