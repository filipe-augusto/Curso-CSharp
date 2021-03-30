using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Services
{
    interface ITaxService
    {
        double Tax(double amount);
    }
}
