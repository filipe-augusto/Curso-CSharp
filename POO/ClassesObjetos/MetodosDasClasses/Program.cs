using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            #region metodos simples
            //
            //m.Cumprimentar();
            //m.Somar(10,5);
            //m.Apresentar("Filipe", 27);
            #endregion
            #region metodos com parametros
            //int valor1 = 100;
            //int valor2 = 100;
            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);
            #endregion
            #region passagem de parametros por valor e por referencia
            //Console.WriteLine("valor 1: " + valor1);//não altera a valor da variavel
            //Console.WriteLine("valor 2: " + valor2);//altera o valor da variavel passada por referencia
            #endregion
            #region metodos com retorno
            //int codigoChar = m.CodigoChar('a');
            //string nomeCompleto = m.MontaNome("Filipe", "Chaves");
            //double pi = m.ValorPI();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);
            #endregion
            #region sobrecarga de metodos
            //m.Cumprimentar();
            //m.Cumprimentar("Filipe");
            //m.Cumprimentar("Filipe", 00);
            //bool res1 = m.Comparar(10, 50 * 2);
            //bool res2 = m.Comparar("Cassila", "cassila");
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            #endregion

            Console.ReadKey();
        }
    }
}
