using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceHerdando.Model.Entities;
using InterfaceHerdando.Model.Enums;

namespace InterfaceHerdando.Model.Entities
{
  abstract  class AbstractShape : IShape
    {
  
        public Color Color { get; set; }
        abstract public double Area();
       
    }
}
