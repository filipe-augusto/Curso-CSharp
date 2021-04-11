using GetHashCodeAndEquals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeAndEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Equals
            //string a = "Maria";
            //string b = "Jose";
            //Console.WriteLine(a.Equals(b));
            #endregion
            #region GetHashCode
            //string a = "Cassila";
            //string b = "Filipe";
            //Console.WriteLine(a.GetHashCode());//gerou numero inteiro(usa um numero pseudo aleatorio)
         //   Console.WriteLine(b.GetHashCode());//gerou numero inteiro
            #endregion
            Client ca = new Client { Name = "Cassila", Email = "Cassila@gmail.com" };
            Client cb = new Client { Name = "Filipe", Email = "Filipea@gmail.com" };

            Console.WriteLine(ca.Equals(cb));
            Console.WriteLine(ca == cb);
            Console.WriteLine(ca.GetHashCode());
            Console.WriteLine(cb.GetHashCode());
            Console.ReadKey(); 
        }
    }
}
