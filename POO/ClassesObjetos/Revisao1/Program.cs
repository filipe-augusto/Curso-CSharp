using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao1
{
    class Program
    {
        static void Main(string[] args)
        {
            //REVISAO
            Heroi draven = new Heroi("Draven", 'm', "França", 80, 170, 0);
            Heroi sivir = new Heroi("Sivir", 'f', "França", 40, 200, 0);

            int count = 0;
             inicio:
            if (draven.vida >= 0 && sivir.vida >= 0)
            {
                count++;
                Console.WriteLine("Round: " + count);
                Console.WriteLine(draven.nome + " = " + draven.vida);
                Console.WriteLine(sivir.nome + " = " + sivir.vida);
                draven.Luta(sivir.forca,ref draven.vida);
                sivir.Luta(draven.forca, ref sivir.vida);
                goto inicio;
            }
            else
            {
                Console.WriteLine("fim da luta");
                Console.WriteLine(draven.nome + " = " + draven.vida);
                Console.WriteLine(sivir.nome + " = " + sivir.vida);
            }

            Console.ReadKey();
        }
    }
}



  
          


         
     
      



