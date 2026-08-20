using Cinema.Application.Interfaces;
using Cinema.Domain.Entities;
using Cinema.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Infrastructure.Repositories
{
    public class ShowRepository : IShowRepository
    {
        private readonly ApplicationDBContext context;

        public ShowRepository(ApplicationDBContext context)
        {
            this.context = context;
        }

        public void AddShow(Show show)
        {
            context.Shows.Add(show);
        }

        public Show? GetShowById(int showId)
        {
            return context.Shows
                .FirstOrDefault(show => show.showID == showId);
        }

        public List<Show> GetAllShows()
        {
            return context.Shows.ToList();
        }

        public void UpdateShow(Show show)
        {
            context.Shows.Update(show);
        }

        public void DeleteShow(Show show)
        {
            context.Shows.Remove(show);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
