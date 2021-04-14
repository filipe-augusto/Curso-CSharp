using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque_Acai.Modal
{
    class ItensPedidos
    {
        public ItensPedidos()
        {
        }

        public ItensPedidos(int codigoProdutoAcai,  string tamanhoAcai, int codigoProduto1, int codigoProdutoAdicional2, double valor)
        {
            CodigoProdutoAcai = codigoProdutoAcai;
            TamanhoAcai = tamanhoAcai;
            CodigoProdutoAdicional1 = codigoProduto1;
            CodigoProdutoAdicional2 = codigoProdutoAdicional2;
            Valor = valor;
        }


        public int CodigoProdutoAcai { get; set; }
        public string TamanhoAcai { get; set; }
        public int CodigoProdutoAdicional1 { get; set; }
        public int CodigoProdutoAdicional2 { get; set; }
        public double Valor { get; set; }
    }
}
