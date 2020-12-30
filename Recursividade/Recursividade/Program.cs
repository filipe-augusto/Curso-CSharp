using System;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursiva r = new Recursiva();
            // r.Executar("Ola mundo", 5);
            r.ExecutarRecursivo("Ola mundo!", 5);
            Console.ReadKey();
        }
       
    }
}
