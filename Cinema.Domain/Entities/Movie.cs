using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Movie
    {
        public int movieID { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string rating { get; set; }
        public string director { get; set; }
        public string description { get; set; }
        public string language { get; set; }
        public DateOnly releaseDate { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}
