using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Cinema
    {
        public int cinemaID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }

        public ICollection<Hall> Halls { get; set; }


    }
}
