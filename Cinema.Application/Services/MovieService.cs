using Cinema.Application.Interfaces;
using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Services
{
    public class MovieService
    {
        private readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public void AddMovie(Movie movie)
        {
            movieRepository.AddMovie(movie);
            movieRepository.SaveChanges();

        }
        public Movie? GetMovieById(int movieId)
        {
            return movieRepository.GetMovieById(movieId);
        }

        public List<Movie> GetAllMovies()
        {
            return movieRepository.GetAllMovies();
        }

        public void UpdateMovie(int movieId, Movie updatedMovie)
        {
            updatedMovie.movieID = movieId;

            movieRepository.UpdateMovie(updatedMovie);
            movieRepository.SaveChanges();
        }

        public void DeleteMovie(int movieId)
        {
            Movie? movie = movieRepository.GetMovieById(movieId);

            if (movie != null)
            {
                movieRepository.DeleteMovie(movie);
                movieRepository.SaveChanges();
            }
        }

    }
}
