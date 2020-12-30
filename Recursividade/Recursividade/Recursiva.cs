using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividade
{
    class Recursiva
    {

        //metodo nao recursivo
        public void Executar(string mensagem, int n)
        {
            for(int i = 0; i< n; i++)
            {
                Console.WriteLine(mensagem);
            }
        }
        //metodo recursivo
        public void ExecutarRecursivo (string mensagem, int n)
        {
            if(n >0)
            {
                Console.WriteLine(mensagem);
                ExecutarRecursivo(mensagem, n - 1);
            }          
        }
    }
}
