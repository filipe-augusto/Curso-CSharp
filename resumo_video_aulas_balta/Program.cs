using System;
namespace Aulas
{

    class Program
    {


        static void Main(String[] args)
        {
            // TipoObjeto();
            //  ValueType();
            ReferenceType();
            Console.ReadKey();
        }

        static void ReferenceType()
        {
            //tipo referência
            //armazena o endereço do objeto que contém os dados, e não armazena os dados em si
            // os reference types sao armazenados na memória heap
            //classes, objects arrays
            var arr = new string[2];
            arr[0] = "item 1";
            var arr2 = arr; // nao cria copia

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "item alterado"; //altera as duas listas
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);


        }

        static void ValueType()
        {
            //tipo valor
            int x = 25;
            int y = x;// y é uma cópia do x
            Console.WriteLine(x);
            Console.WriteLine(y);
            x = 32; // somente x for alterado
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        static void NumerosReais()
        {
            float salario = 2.500f; //sempre que for float colocar F
            decimal salarioAnual = 25.000m; //sempre que for decimal colocar m
            double salarioMensal = 8.500; //nao precisa colocar letra.
        }

        static void TipoObjeto()
        {

            //usando object 
            object idade;
            idade = 15;
            object nome = "filipe";

            Console.WriteLine($"nome {nome} - idade {idade}");
        }

        static void NullableTypes()
        {
            int? idade = null;
            if (idade is null)
            {
                Console.WriteLine("idade é nulla");
            }
        }

        static void ValoresPadroes()
        {
            int valorpadrao1 = 0;
            float valorpadrao2 = 0;
            decimal valorpadrao3 = 0;
            bool valorpadrao4 = false;
            char valorpadrao5;
            string valorpadrao6 = "";


        }

        static void ConversaoImplicita()
        {
            float valor = 25.8f;
            int outro = 25;
            valor = outro; //conversao implicita. os dados precisam ser compativeis

        }

        static void ConversaoExplicita()
        {
            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro;

        }

        static void usandoParse()
        {
            int inteiro = int.Parse("100");  // no caso do parse sempre será uma string
        }

        static void usandoConvert()
        {
            int inteiro = Convert.ToInt32("100");


        }
    }
}