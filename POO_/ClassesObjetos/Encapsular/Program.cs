using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    class Program
    {
        static void Main(string[] args)
        {
            //encapsular = separar o programa em partes mais isoladas possiveis. é o processo de ocultar ou esconder uma classe do 
            //acesso exterior

            Conta c1 = new Conta();
            c1.Cliente = "Filipe";
           // c1.Saldo = 1600;

            //============ operação deposito ====================
            double valor = 100;
            c1.Depositar(valor);

            //==========operação de saque ===================
            double valor2 = 50;
            c1.Depositar(valor2);

            Console.WriteLine("Cliente: "+ c1.Cliente);
            Console.WriteLine("Saldo: "+ c1.Saldo);
            Console.ReadKey();
        }
    }
}
