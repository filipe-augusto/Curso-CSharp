using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
     Inicio:
            Console.Write("Digite o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());
           
            Console.Write("Digite o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());
     digitarOperador:
            Console.Write("Digite o operador: ");
            string op = Console.ReadLine();
            
            switch (op)
            {
                default:
                    goto digitarOperador;
                case "+":
                    Console.WriteLine(n1+ " + "+ n2 + " = "+(n1+n2));
                    
                    break;
                case "-":
                    Console.WriteLine(n1 + " - " + n2 + " = " + (n1 - n2));
                    break;
                case "*":
                    Console.WriteLine(n1 + " x " + n2 + " = " + (n1 * n2));
                    break;
                case "/":
                    Console.WriteLine(n1 + " / " + n2 + " = " + (n1 / n2));
                    break;
            }


            Console.WriteLine("--------------------------");
            goto Inicio;
            Console.ReadKey();
        }
    }
}
