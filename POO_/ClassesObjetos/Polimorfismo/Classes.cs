using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
   public class Forma
    {
        public int x { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public int Raio { get; private set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area()
        {

        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um circulo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area do Circulo " + area);
        }
    }
    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um retangulo");
        }

        public override void Area()
        {
            double area = Altura * Largura;
            Console.WriteLine("Area do retangulo  " + area);
        }

    }
    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um Tringulo");
            base.Desenhar();
        }

        public override void Area()
        {
            double area = (Altura * Largura) / 2;
            Console.WriteLine("Area do Tringulo  " + area);
        }

    }

}
