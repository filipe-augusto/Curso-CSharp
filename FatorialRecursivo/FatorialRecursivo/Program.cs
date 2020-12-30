using System;

namespace FatorialRecursivo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(Fatorial(5));
            Console.ReadKey();
        }

        static int Fatorial(int num)
        {

            if(num <= 0)
            {
                return 1;
            }
            else
            {
            return num * Fatorial(num - 1);
            }

        }
    }
}



