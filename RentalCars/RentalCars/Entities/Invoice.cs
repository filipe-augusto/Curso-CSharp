using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}" +
                $"\nTax: {Tax.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} " +
                $"\nTotal payment: {TotalPayment.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}";
        }
    }
}
