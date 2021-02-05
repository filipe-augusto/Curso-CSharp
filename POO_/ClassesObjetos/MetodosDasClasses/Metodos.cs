using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Metodos
    {
        //metodos simples
        public void Cumprimentar()//sem retorno e parametro
        {
            Console.WriteLine("Ola, seja bem vindo!");
        }
        //metodos com parametros
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }
        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("O meu nome  é " + nome + " e tenho " + idade + " anos");
        }

        //passagem de parametros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("valor final é(por valor): " + valor);
        }

        //passam de parametros por referencia
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("valor final é(por referencia): " + valor);//resultado no valor original da variavel
        }

        //metodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
      //      string nomeCompleto = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }
        public int CodigoChar(char caratere)
        {
            int codigo = (int)caratere;
            return codigo;
        }
        public double ValorPI()
        {
            return 3.1415;
        }

        //sobrecarga de metodos
        public void Cumprimentar(string nome)//o que define a assinatura do metodo é a passagem de parametros e nao o tipo
        {
            Console.WriteLine("Ola!"+nome);
        }
        public void Cumprimentar(string nome, int hora) {
            string mensagem = hora < 12 ? "bom dia " + nome : "boa tarde " + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }
        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }
    }
}
