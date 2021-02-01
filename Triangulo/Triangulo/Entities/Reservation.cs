using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangulo.Entities.Exceptions;
namespace Triangulo
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn{get; set;}
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check Out date must be after che-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if(checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must...");
            }
            if(checkOut <= checkIn)
            {
                throw new DomainException("Check Out date must be after che-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return $"Room {RoomNumber}, check-In: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}," +
                $"{Duration()}, nights";
        }

    }
}
