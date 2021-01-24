using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Israel.Models
{
    public class Livros
    {
        public int IdLivro { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public Autores Autores { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }
        public int QuantidadePaginas{ get; set; }
        public int Classificacao { get; set; }


    }
}