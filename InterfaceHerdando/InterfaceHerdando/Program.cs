using InterfaceHerdando.Model.Entities;
using InterfaceHerdando.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHerdando
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2,Color = Color.White };
            IShape s2 = new Rectangle { Width = 10, Height = 10, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }


    }
}
