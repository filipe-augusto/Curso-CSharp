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
            //string b = "Alex";
            ////Console.WriteLine(a.Equals(b));
            //string c = (String)b.Clone();
            //Console.WriteLine(c);
            //Console.ReadLine();
            #endregion
            #region GetHashCode
            string a = "Maria";
            string b = "alex";
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            #endregion
        }
    }
}
