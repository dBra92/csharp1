using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Excecoes.Entities.Exceptions;

namespace Excecoes.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkout, DateTime checkin)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            this.RoomNumber = roomNumber;
            this.Checkout = checkout;
            this.Checkin = checkin;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException ("Reservations date for update must be future dates.");
            }

            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            Checkin = checkin;
            Checkout = checkout;

        }
        public override string ToString()
        {
            return "Room" + RoomNumber
                        + ","
                        + "Check-in:"
                        + Checkin.ToString("dd/MM/yyyy")
                        + ", "
                        + "Check-out:" + Checkout.ToString("dd/MM/yyyy")
                        + ", "
                        + Duration()
                        + " nights";
        }
    }
}