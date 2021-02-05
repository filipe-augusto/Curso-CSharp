using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro : Veiculo
    {
   
        public void LigarMotor()
        {
            Console.WriteLine("O carro ligou o motor");
        }
        public override void Acelerar()//herdou uma classe abstrato, é necessario implementa-la
        {
            Console.WriteLine("Acelerou o carro!");
        }

        public override void Parar()// 
        {
            Console.WriteLine("Parou o carro!");
        }

    }
}
