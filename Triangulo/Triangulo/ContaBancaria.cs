using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class ContaBancaria
    {
        public string Nome { private set; get; }
        public int NumeroConta { private set; get; }
        public bool DepositoInicial { private set; get; }
        public double ValorEmConta { private set; get; }

        public ContaBancaria()
        {
            DepositoInicial = false;
            ValorEmConta = 0;
        }

        public ContaBancaria(string nome, int numeroDaConta, double valorDepositoInicial) 
        {
            Nome = nome;
            NumeroConta = numeroDaConta;
            DepositoInicial = true;
            ValorEmConta = valorDepositoInicial;
        }
        public ContaBancaria(string nome, int numeroDaConta) : this()
        {
            Nome = nome;
            NumeroConta = numeroDaConta;
            DepositoInicial = false;
            ValorEmConta = 0;
        }

        public string dadosDaConta()
        {
            string deposito = DepositoInicial ? "Com deposito inicial" : "Sem depositoinicial";
            return $" \nDados Atualizados :\nConta: {NumeroConta} - Titular: {Nome} - {deposito} - Saldo: R${ValorEmConta}";
        }

        public string deposito(double valor)
        {
             ValorEmConta += valor;
            return $"\nDados Atualizados :\nConta: {NumeroConta} - Titular: {Nome} - Saldo: R${ValorEmConta}.";
        }
        public string saque(double valor)
        {
            ValorEmConta -= valor +5;
            return $"\nDados Atualizados : \nConta: {NumeroConta} - Titular: {Nome}  - Saldo: R${ValorEmConta}.";
        }
        



    }
}
