using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class CaixaEletronico : IConta
    {
        //não é considerada uma Classe e sim uma Entidade.
        //Não possui implementação, apenas assinatura, ou seja, apenas a definição dos seus métodos sem o corpo
        //  Todos os métodos são abstratos.
        //Seus métodos são implicitamente Públicos e Abstratos.
        // Não há como fazer uma instância de uma Interface e nem como criar um Construtor.
        public string Usuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Depositar()
        {
            throw new NotImplementedException();
        }

        public void Sacar()
        {
            throw new NotImplementedException();
        }

        public void Saldo()
        {
            throw new NotImplementedException();
        }

        public void SolicitarEmpresimo() { }
    }

    interface IConta
    {
        String Usuario { get; set; }

        void Depositar();
        void Saldo();
        void Sacar();
    }
}
