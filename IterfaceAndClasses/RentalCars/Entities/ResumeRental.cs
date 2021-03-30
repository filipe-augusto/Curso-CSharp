using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalCars.Services;

namespace RentalCars.Entities
{
    class ResumeRental : CarRental
    {
        public ResumeRental( DateTime start, DateTime finish, Vehicle vehicle) : base(start, finish, vehicle)
        {
            Invoice = null;
        }     
        public Invoice Invoice { get; set; }
       

    }
}
