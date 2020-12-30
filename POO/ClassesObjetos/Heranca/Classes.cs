using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("humano.Olhos");
        }
        public virtual void Cabelos()
        {
            Console.WriteLine("humano.Cabelos");
        }
    }
    class Pessoa : Humano
    {
        public sealed override void Olhos()//sealed lacrado
        {
            Console.WriteLine("pessoa.Olhos");
        }
        public override void Cabelos()
        {
            Console.WriteLine("pessoa.Cabelos");
        }
    }
    class Homem : Pessoa
    {
        //public override void Olhos()
        //{
        //    Console.WriteLine("homem.Olhos");
        //}
        public override void Cabelos()
        {
            Console.WriteLine("homem.Cabelos");
        }
    }


}
