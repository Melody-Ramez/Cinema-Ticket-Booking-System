using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Interfaces
{
    public interface IShowRepository
    {
        void AddShow(Show show);
        Show? GetShowById(int showId);
        List<Show> GetAllShows();
        void UpdateShow(Show show);
        void DeleteShow(Show show);
        void SaveChanges();
    }
}
