using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    class Teste
    {
        //definição de um campo
        private string _nome;
        public string _sobrenome { get; } = "Chaves"; //definindo valor padrão
        private int _idade;


        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if(value < 18)
                {
                    Console.WriteLine("idade não pode ser menor que 18 anos");
                }
                else { 
                _idade = value;
                }
            }
        }
       


        public void Apresentar()
        {
            if(_nome != "")
            {
                Console.WriteLine("Bem vindo " + _nome);
            }
        }

    }
}
