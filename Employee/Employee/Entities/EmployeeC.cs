using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Entities
{
    class EmployeeC
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public EmployeeC( )
        {

        }
        public EmployeeC (string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual  double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
