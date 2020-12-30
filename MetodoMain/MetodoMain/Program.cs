using System;

namespace MetodoMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = args[0];
            string senha = "123";

            if(senha != args[1])
            {
                Console.WriteLine("ACesso negado!!");
            }
            else
            {
            Console.WriteLine("ola "+nome);
            }
            Console.ReadKey();

        }
    }
}
