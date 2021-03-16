using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHerdando.Model.Entities
{
    //class Rectangle :
          class Rectangle : AbstractShape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return     "Rectangle color = "
                + Color
                + ", width = "
                + Width
                + ", height = "
                + Height
                + ", area ="
                + Area().ToString("F2");

        }
       
    }
}
