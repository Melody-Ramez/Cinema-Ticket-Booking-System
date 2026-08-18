using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Seat
    {
        public int seatID { get; set; }
        public int hallID { get; set; }
        public Hall Hall { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
