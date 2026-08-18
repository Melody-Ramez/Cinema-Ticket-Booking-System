using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Interfaces
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);

        Movie? GetMovieById(int movieId);

        List<Movie> GetAllMovies();

        void UpdateMovie(Movie movie);

        void DeleteMovie(Movie movie);

        void SaveChanges();
    }
}
