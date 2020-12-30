using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;
            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = outra;
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Filipe";
            p1.sobrenome = "chaves";
            p1.anoNascimento = 1993;

            Pessoa p2 = new Pessoa()
            { nome = "cassila",
                sobrenome = "Fonseca",
                anoNascimento = 1990
            };

            Console.WriteLine("Pessoa 1 " + p1.nome + " " + p1.sobrenome + ". " + p1.anoNascimento);
            Console.WriteLine("Pessoa 2 " + p2.nome + " " + p2.sobrenome + ". " + p2.anoNascimento);
            p1.Cumprimentar();
            p2.Cumprimentar();

            Console.ReadKey();
        }
    }
    class MinhaClasse
    {

    }

}
