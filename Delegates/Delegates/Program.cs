using Delegates.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates.Entities;
using System.Linq;
namespace Delegates
{
    class Program
    {

        //  delegate double BinaryNumericOperation(double n1, double n2);
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            #region Delegates
            // double a = 10;
            // double b = 20;
            // //BinaryNumericOperation op = CalculationService.Sum;
            // //BinaryNumericOperation op1 = new BinaryNumericOperation(CalculationService.Max);          
            // //multicast delegates
            // BinaryNumericOperation op = CalculationService.ShowSum;
            // op += CalculationService.ShowMax;
            // op.Invoke(a, b);
            //   //  double result = op(a, b);
            //  //  double result1 = op.Invoke(a, b); 
            // //double result = CalculationService.Sum(a, b);
            //// Console.WriteLine(result);

            #endregion
            #region Predicate
            //List<Product> list = new List<Product>();
            //list.Add(new Product("TV", 900.00));
            //list.Add(new Product("Mouse", 80.00));
            //list.Add(new Product("Tablet", 120.00));
            //list.Add(new Product("HD Case", 50.00));

            //list.RemoveAll(p => p.Price >= 100);
            //list.RemoveAll(ProductTest);

            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion
            #region Action
            //List<Product> list = new List<Product>();
            //list.Add(new Product("TV", 900.00));
            //list.Add(new Product("Mouse", 80.00));
            //list.Add(new Product("Tablet", 120.00));
            //list.Add(new Product("HD Case", 80.00));

            //// 1 FORMA
            ////  list.ForEach(UpatePrice);
            //// 2 FORMA 
            ////Action<Product> act = UpatePrice;
            ////list.ForEach(act);
            //// 3 FORMA
            //// Action<Product> act = p => { p.Price += p.Price * 0.1; };
            //// 4 FORMA
            //list.ForEach(p => { p.Price += p.Price * 0.1; });

            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion
            #region Func
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 80.00));
            list.Add(new Product("Tablet", 120.00));
            list.Add(new Product("HD Case", 80.00));

            //METODO 1
            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();
            //METODO 2
            // List<string> result = list.Select(NameUpper).ToList();
            //METODO 3
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();
            //METODO 4
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string  s in result)
            {
                Console.WriteLine(s);
            }

            #endregion

            Console.ReadKey();
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        static void UpatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
