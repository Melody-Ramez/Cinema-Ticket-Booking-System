using Cinema.Application.Interfaces;
using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Services
{
    public class ShowService
    {
        private readonly IShowRepository showRepository;

        public ShowService(IShowRepository showRepository)
        {
            this.showRepository = showRepository;
        }

        public void AddShow(Show show)
        {
            showRepository.AddShow(show);
            showRepository.SaveChanges();
        }

        public Show? GetShowById(int showId)
        {
            return showRepository.GetShowById(showId);
        }

        public List<Show> GetAllShows()
        {
            return showRepository.GetAllShows();
        }

        public void UpdateShow(int showId, Show updatedShow)
        {
            updatedShow.showID = showId;

            showRepository.UpdateShow(updatedShow);
            showRepository.SaveChanges();
        }

        public void DeleteShow(int showId)
        {
            Show? show = showRepository.GetShowById(showId);

            if (show != null)
            {
                showRepository.DeleteShow(show);
                showRepository.SaveChanges();
            }
        }
    }
}
