using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    class Program
    {
        delegate void Operacao(int n1,int n2); //delagate armazena referencias de metodos
        static void Main(string[] args)
        {
            Matematica m = new Matematica();
            Operacao conta = null;

            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Divdir;
            conta += m.Multiplicar;
            conta(10, 2);

            Console.ReadKey();
        }
    }
}
