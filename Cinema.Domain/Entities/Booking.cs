using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Booking
    {
        public int bookingID { get; set; }
        public int CustomerID { get; set; }
        public decimal totalprice { get; set; }
        public DateTime bookingDate { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

    }
}
