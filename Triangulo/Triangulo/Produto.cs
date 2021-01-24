using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Triangulo
{
    class Produto
    {
        public string Nome { set; get; }
        public double Preco { set; get; }
        public int Quantidade { set; get;}


        public Produto() {
            Quantidade = 0;
        }

      
        //constutor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome; Preco = preco; Quantidade = quantidade;
        }
        //SOBRECARGA - MODIFICAR METODOS
        public Produto (string nome, double preco) : this()  //USANDO O THIS -- PARA NAO TER QUE FICAR REPETINDO CODIGO
        {
            Nome = nome; Preco = preco; 
        }
        //USANDO O THIS
        //public Produto(string Nome, double Preco)
        //{
        //    this.Nome = Nome; this.Preco = Preco; this.Quantidade = 0;
        //}


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString()
        {
            return $"{Nome}, R${Preco.ToString("F2",CultureInfo.InvariantCulture)}," +
                $" Quantidade: {Quantidade}, Total: {ValorTotalEmEstoque().ToString("F2",CultureInfo.InstalledUICulture)}";
        }
    }


}
