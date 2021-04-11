using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque_Acai.Modal
{
    class Cardapio
    {
        public string NomeItem { get; set; }
        public  int idProduto { get; set; }
        public double Valor { get; set; }
        public int LitrosAcai { get; set; }
        public string IdAdicional1 { get; set; }
        public string IdAdicional2 { get; set; }
        public string Tamanho { get; set; }
        public string NomeAdicional1 { get; set; }
        public string NomeAdicional2 { get; set; }

    }
}
