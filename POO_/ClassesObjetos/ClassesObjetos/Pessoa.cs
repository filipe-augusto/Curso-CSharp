using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Pessoa
    {

        //atributos ou campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        //metodo simples
        public void Cumprimentar()
        {
            Console.WriteLine("Ola eu sou " + nome + " " + sobrenome);
        }

    }
}
