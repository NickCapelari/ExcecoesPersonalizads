using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcecoesPesonalisadas.Entities.Exceptions;

namespace ExcecoesPesonalisadas.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Erro na reserva Check Out menor que Check In");
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

        public void UpdateDates (DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (now > checkIn || now > checkOut)
            {
                throw new DomainException ("Error in reservation: Reservation Dates for update must be future datas");
            }
           if (checkOut <= checkIn)
            {
                throw new DomainException ("Erro na reserva Check Out menor que Check In");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            
        }
        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
