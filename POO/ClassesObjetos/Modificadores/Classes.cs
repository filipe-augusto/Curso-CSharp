using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {
        private string nome;
        public string sobrenome;

        private void Metodo1()
        {

        }

        public void Executar()
        {

        }
    }

   class Humano
    {
        protected string nome; //é particular da classe e de quem herdar
        public string sobrenome; //é completamente privado da classe
        internal int idade;//restrito somente a aplicação
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 0;
        }
    }
}
