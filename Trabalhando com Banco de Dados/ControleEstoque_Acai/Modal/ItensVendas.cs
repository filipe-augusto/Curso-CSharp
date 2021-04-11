using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque_Acai.Modal
{
    class ItensVendas
    {
        public Cardapio Item { get; set; }
        public double ValorTotal { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public string Observacao { get; set; }
        public int ModoDePagamento { get; set; }
    }
}
