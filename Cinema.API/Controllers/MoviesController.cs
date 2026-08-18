using Cinema.Application.Services;
using Cinema.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieService movieService;

        public MoviesController(MovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var movies = movieService.GetAllMovies();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            var movie = movieService.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            movieService.AddMovie(movie);
            return Ok(movie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, Movie movie)
        {
            movieService.UpdateMovie(id, movie);
            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            movieService.DeleteMovie(id);
            return Ok();
        }
    }
}
