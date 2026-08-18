using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Ticket
    {
        public int ticketID { get; set; }
        public int bookingID { get; set; }
        public int seatID { get; set; }
        public Booking Booking { get; set; }
        public Seat Seat { get; set; }
    }
}
