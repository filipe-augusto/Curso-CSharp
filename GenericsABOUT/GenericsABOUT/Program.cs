using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsABOUT
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //list.Add("maria");
            //string name = list[0];

            PrintService<int>printService = new PrintService<int>();
            Console.WriteLine("how many values?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();

        }
    }
}
