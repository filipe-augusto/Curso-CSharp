using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region heranca
            Carro c = new Carro();
            //c.Cor = "preto";
            //c.Marca = "Fiat";
            //c.VelocidadeMAxima = 200;
            //c.Acelerar();
            //c.Parar();
            Bicicleta b = new Bicicleta();
            //b.Cor = "veiculo";
            //b.Marca = "caloi";
            //b.VelocidadeMAxima = 50;
            //b.Acelerar();
            //b.Parar();
            #endregion
            #region abstract
            //Veiculo v = new Veiculo(); classe abstrata, apenas classe base. N  ao pode ser instanciada para um obj
            c.Acelerar();
            c.Parar();
            b.Acelerar();
            b.Parar();
            #endregion
            #region sealed
            //classe sealed nao pode ser herdada, apneas para instancia objetos
            #endregion
            #region membros sealed

            Humano a = new Humano();
            Pessoa p = new Pessoa();
            Homem h = new Homem();

            Console.WriteLine("\nHumano");
            a.Olhos();
            a.Cabelos();
            Console.WriteLine("\nPessoa");
            p.Olhos();
            p.Cabelos();
            Console.WriteLine("\nHomem");
            h.Olhos();
            h.Cabelos();
            #endregion

            Console.ReadKey();
        }
    }
}
