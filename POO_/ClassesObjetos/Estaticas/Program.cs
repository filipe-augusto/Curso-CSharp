using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region classe estatica
            //// não podem ser instanciadas
            //// Elas são caracterizadas por não poderem ser herdadas, já que são seladas.
            //Matematica.taxa = 10;
            //int valor1 = Matematica.Adicionar(200);
            //int valor2 = Matematica.Diminuir(200);
            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            #endregion
            #region Membros Estáticos
            Pessoa.maioridade = 18;
            Pessoa p1 = new Pessoa();
            p1.nome = "Filipe";
            p1.idade = Pessoa.CalcularIdade(1993);
            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maioridade);
            #endregion
            #region Classes Parciais

            #endregion

            Console.ReadLine();
        }
    }
}
