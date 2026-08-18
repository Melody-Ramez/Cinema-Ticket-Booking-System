using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Payment
    {
        public int paymentID { get; set; }
        public int bookingID { get; set; }
        public string method { get; set; }
        public string status { get; set; }
        public decimal amount { get; set; }
        public DateTime paymentDate { get; set; }
        public Booking Booking { get; set; }
    }
}
