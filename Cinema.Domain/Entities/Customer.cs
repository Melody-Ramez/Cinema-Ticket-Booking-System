using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Customer
    {
        public int customerID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string phoneNum { get; set; }
        public string email { get; set; }
        public ICollection<Booking> Bookings { get; set; }

    }
}
