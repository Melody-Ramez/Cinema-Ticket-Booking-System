using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Hall
    {
        public int hallID { get; set; }
        public int cinemaID { get; set; }
        public string hallName { get; set; }
        public string hallType { get; set; }
        public int hallNum { get; set; }
        public int seatsNum { get; set; }

        [ForeignKey(nameof(cinemaID))] //cinema id foreign key of this navigation property
        public Cinema Cinema { get; set; }
        public ICollection<Seat> Seats { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}
