﻿using InterfaceHerdando.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHerdando.Model.Entities
{
   abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
