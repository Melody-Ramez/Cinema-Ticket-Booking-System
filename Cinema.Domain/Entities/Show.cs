using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Show
    {
        public int showID { get; set; }
        public int movieID { get; set; }
        public int hallID { get; set; }
        public DateTime showDateTime { get; set; }
        public decimal price { get; set; }
        public Movie Movie { get; set; }
        public Hall Hall { get; set; }
    }
}
