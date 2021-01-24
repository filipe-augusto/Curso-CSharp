using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class ProdutoUsandoPropriedades
    {
        private string _nome { set; get; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public string Nome //propriedades normais
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //public double Preco
        //{
        //    get{ return _preco; }
        //}
        //public int Quantidade
        //{
        //    get { return _quantidade; }
        //}

        public ProdutoUsandoPropriedades()
        {
            Quantidade = 0;
        }
        
      
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Preco = Preco + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Preco = Preco - quantidade;
        }
        public override string ToString()
        {
            return $"{_nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" Quantidade: {Quantidade}, Total: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InstalledUICulture)}";
        }
    }
}

