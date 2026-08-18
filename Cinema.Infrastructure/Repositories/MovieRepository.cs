using Cinema.Application.Interfaces;
using Cinema.Domain.Entities;
using Cinema.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDBContext context;

        public MovieRepository(ApplicationDBContext context)
        {
            this.context = context;
        }

        public void AddMovie(Movie movie)
        {
            context.Movies.Add(movie);
        }

        public Movie? GetMovieById(int movieId)
        {
            return context.Movies
                .FirstOrDefault(movie => movie.movieID == movieId);
        }

        public List<Movie> GetAllMovies()
        {
            return context.Movies.ToList();
        }

        public void UpdateMovie(Movie movie)
        {
            context.Movies.Update(movie);
        }

        public void DeleteMovie(Movie movie)
        {
            context.Movies.Remove(movie);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

    }
}
