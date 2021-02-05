using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma a = new Forma();
            Forma b = new Triangulo();
            Forma c = new Circulo();
            Forma d = new Retangulo();
            Console.WriteLine("Froma");
            a.Desenhar();
            Console.WriteLine("triangulo");
            b.Desenhar();
            Console.WriteLine("circulo");
            c.Desenhar();
            Console.WriteLine("retangulo");
            d.Desenhar();

            Console.ReadKey();

        }
    }
}
