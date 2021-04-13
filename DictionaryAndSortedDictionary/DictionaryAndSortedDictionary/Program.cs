using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();


            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";
            Console.WriteLine(cookies["phone"]);
            Console.ReadKey();

            cookies.Remove("email");
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }else
            {
                Console.WriteLine("there is no 'email' key");
            }
            Console.WriteLine("size: "+ cookies.Count);
            Console.WriteLine("ALL COOKIES");
              foreach (KeyValuePair<string, string> item in cookies)
         //   foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": "+ item.Value);
            }
        }
    }
}
