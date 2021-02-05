using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
   sealed class Bicicleta : Veiculo //não pode ser herdada
    {    
        public void Pedalar()
        {
            Console.WriteLine("pedalando!");
        }

        public override void Acelerar()//herdou uma classe abstrato
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a bicicleta!");
        }
    }
}
