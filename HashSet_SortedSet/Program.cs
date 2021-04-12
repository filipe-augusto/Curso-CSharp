using Course.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HashSet
            //hashSet
            // armazenamento em tabela hash
            //extremamente rapido: inserção, remoção e busca
            //a ordem dos  não é garantido
            //HashSet<string> set = new HashSet<string>();
            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");
            //Console.WriteLine(set.Contains("Notebook"));
            //Console.WriteLine(set.Contains("Computer"));

            //foreach (string p in set)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion
            #region Sortedset
            //sortedset
            //armazenamento em arvore
            //rapido: inserção, remoção e busca
            //os elmentos são armazenados ordenamento conforme implementação
            //Comparer <T>
            //SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            //SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            ////union
            //SortedSet<int> c = new SortedSet<int>(a);
            //Console.WriteLine("UnionWith");
            //c.UnionWith(b);

            //PrintCollection(c);
            ////intersection
            //SortedSet<int> d = new SortedSet<int>(a);
            //d.IntersectWith(b);
            //Console.WriteLine("IntersectWith");
            //PrintCollection(d);

            ////difference
            //SortedSet<int> e = new SortedSet<int>(a);
            //e.ExceptWith(b);
            //Console.WriteLine("ExceptWith");
            //  PrintCollection(e);
            #endregion
            #region Hash comparam igualdade
            //HashSet<string> set = new HashSet<string>();
            //set.Add("Cassila");
            //set.Add("Filipe");
            //Console.WriteLine(set.Contains("Filipe"));

            #endregion

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV",900.0));
            a.Add(new Product("Notebook", 1200.0));
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));
            Product prod = new Product("Notebook",1200.0);
            Console.WriteLine(a.Contains(prod));
            Console.ReadKey();

        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
