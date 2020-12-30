using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        enum Notas
        {
        Minimo = 10, Media=20, Maxima=30
        }
        struct Pessoa 
        {
            public string nome;
            public int idade;
            public double altura;

        }

        static void Main(string[] args)
        {
            #region Numericas Integrais
            ////integral assinado
            //sbyte num1 = 10;  //de -128 a 127
            //short num2 = 20; // de -32.768 a 32.767
            //int num3 = 30; //de -2,147 x 10^10
            //long num4 = 40L; //de -9,223x 10^18 a  9,223x 10^18

            ////integral sem sinal
            //byte num5 = 10; //0 a 255
            //ushort num6 = 20; //de  0 a 65.535
            //uint num7 = 30; //de 0 a 4.29 x 10^9
            //ulong num8 = 40L; // de 0 a 1,8. z 10^18
            #endregion

            #region Numeros Reais
            //float real1 = 100.75f;//de 1,5 x 10^-45 a 3,4 x 10^38
            //double real2 = 500.754f; // de 5,0 x 10-324 a 1,7 x 10^308
            //decimal real3 = 752538.453m;
            #endregion

            #region Caractere
            //char letra = '\u0061';
            //char escape = '\n';
            //char literal = 'C';
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String
            string texto = @"Filipe Augusto \n Santos Chaves"; //@ ignora todos os caracateres de escape
            #endregion
            
            #region Var (tipo implicito)
            var valor = 140.6; //nao pode mais alterar o valor
            valor = 20;
            #endregion

            #region Objeto (base para todos os tipos)
            object obj = false;
            obj = 200;
            obj = "gabriel";
            #endregion

            #region Constantes
            const double pi = 3.1415;
            const string nome = "nome";
            #endregion

           
            #region Struct
           Pessoa p1 = new Pessoa();
            p1.altura = 1.75;
            p1.nome = "Filipe";
            p1.idade = 27;

            Pessoa p2 = new Pessoa(){
            nome = "Cassila",
            idade =30,
            altura = 1.65
            };
            Console.WriteLine( "\nNome: "+ p1.nome + "\nIdade: " + p1.idade + "\nAltura: "+p1.altura); 
            Console.WriteLine( "\nNome: "+ p2.nome + "\nIdade: " + p2.idade + "\nAltura: "+p2.altura);
            #endregion



            Console.WriteLine();
            Console.ReadKey();

            


        }
    }
}