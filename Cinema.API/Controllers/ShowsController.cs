using Cinema.Application.Services;
using Cinema.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        private readonly ShowService showService;

        public ShowsController(ShowService showService)
        {
            this.showService = showService;
        }

        [HttpGet]
        public IActionResult GetAllShows()
        {
            var shows = showService.GetAllShows();

            return Ok(shows);
        }

        [HttpGet("{showId}")]
        public IActionResult GetShowById([FromRoute] int showId)
        {
            var show = showService.GetShowById(showId);

            if (show == null)
            {
                return NotFound();
            }

            return Ok(show);
        }

        [HttpPost]
        public IActionResult AddShow([FromBody] Show show)
        {
            showService.AddShow(show);

            return Ok(show);
        }

        [HttpPut("{showId}")]
        public IActionResult UpdateShow([FromRoute] int showId, [FromBody] Show updatedShow)
        {
            var show = showService.GetShowById(showId);

            if (show == null)
            {
                return NotFound();
            }

            showService.UpdateShow(showId, updatedShow);

            return Ok(updatedShow);
        }

        [HttpDelete("{showId}")]
        public IActionResult DeleteShow([FromRoute] int showId)
        {
            var show = showService.GetShowById(showId);

            if (show == null)
            {
                return NotFound();
            }

            showService.DeleteShow(showId);

            return NoContent();
        }

    }
}
