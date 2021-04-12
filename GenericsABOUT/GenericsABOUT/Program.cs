using GenericsABOUT.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            #region Generics Parte 1
            //PrintService<int>printService = new PrintService<int>();
            //Console.WriteLine("how many values?");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    printService.AddValue(x);
            //}
            //printService.Print();
            #endregion
            #region Exemplo
            //List<int> list = new List<int>();
            //Console.Write("enter N: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    list.Add(x);
            //}

            //CalculationService calculationService = new CalculationService();
            //int max = calculationService.Max(list);
            //Console.WriteLine("Max: ");
            //Console.WriteLine(max);
            //Console.ReadLine();
            #endregion
            List<Product> list = new List<Product>();
            Console.Write("enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
              
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
           Product max = calculationService.Max(list);
            Console.WriteLine("Max: ");
            Console.WriteLine(max);
            Console.ReadLine();




        }
    }
}
