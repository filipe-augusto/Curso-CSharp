using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo Linq
            ////specify the data source
            //int[] numbers = new int[] { 2, 3, 4, 5 };
            ////define the query expression
            //var result = numbers
            //    .Where(x => x % 2 == 0)
            //    .Select(x => x * 10);

            ////execute the query
            //foreach (int x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Operações com Linq


            /* Filtering: Where, OfType - 
             * Sorting: OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse --ordenar
             * Set: Distinct, Except, Intersect, Union -- conjuntos
             * Quantification: All, Any, Contains -- testar todos, alguns ou se contem
             * Projection: Select, SelectMany 
             * Partition: Skip, Take
             * Join: Join, GroupJoin
             * Grouping: GroupBy
             * Generational: Empty
             * Equality: SequenceEquals
             * Element: ElementAt, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault
             * Conversions: AsEnumerable, AsQueryable
             * Concatenation: Concat
             * Aggregation: Aggregate, Average, Count, LongCount, Max, Min, Sum
             */
            #endregion
            Console.ReadKey();
        }
    }
}
