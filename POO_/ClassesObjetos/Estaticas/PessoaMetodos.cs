using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    partial class Pessoa//é uma parte da classe
    {
        public void Apresentar()
        {
            Console.WriteLine("Hello! I am " + nome);
        }
        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
