using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso:   ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("IMC: " + imc);
            

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if ((imc >= 20) && (imc <= 25))
            {
                Console.WriteLine("Normal");
            }
            else if((imc >= 26) && (imc <=29))
            {
                Console.WriteLine("Acima do peso");
            }
            else if((imc >= 30) && (imc <= 34))
            {
                Console.WriteLine("Obeso");
            }
            else
            {
                Console.WriteLine("Muito obeso");
            }
            Console.ReadLine();
        }
    }
}
