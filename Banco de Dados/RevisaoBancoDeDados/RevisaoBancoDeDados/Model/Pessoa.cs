using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoBancoDeDados.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }

        public TimeSpan Inicio { get; set; }
        public TimeSpan Termino { get; set; }
        public TimeSpan TempoTotal
        {
            get
            {
                return Termino.Subtract(Inicio);
            }
            set { }
        }
        public int Idade
        {
            get
            {
                return   DateTime.Now.Year - Nascimento.Year;
            }
        }
        public char Genero { get; set; }


    }
}
    