using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class ProdutoUsandoEncapsulamento
    {
        private string _nome { set; get; }
        private double _preco { set; get; }
        private int _quantidade { set; get; }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome (string nome)
        {
            _nome = nome;
        }

        public ProdutoUsandoEncapsulamento()
        {
            _quantidade = 0;
        }
        //constutor
        public ProdutoUsandoEncapsulamento(string nome, double preco, int quantidade)
        {
            _nome = nome; _preco = preco; _quantidade = quantidade;
        }
        //SOBRECARGA - MODIFICAR METODOS
        public ProdutoUsandoEncapsulamento(string nome, double preco) : this()  //USANDO O THIS -- PARA NAO TER QUE FICAR REPETINDO CODIGO
        {
            _nome = nome; _preco = preco; _quantidade = 0;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _preco = _preco + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _preco = _preco - quantidade;
        }
        public override string ToString()
        {
            return $"{_nome}, R${_preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" Quantidade: {_quantidade}, Total: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InstalledUICulture)}";
        }
    }
}
