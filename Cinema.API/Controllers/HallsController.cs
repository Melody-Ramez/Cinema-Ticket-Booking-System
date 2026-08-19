using Cinema.Application.Services;
using Cinema.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HallsController : ControllerBase
    {
        private readonly HallService hallService;

        public HallsController(HallService hallService)
        {
            this.hallService = hallService;
        }

        [HttpGet]
        public IActionResult GetAllHalls()
        {
            var halls = hallService.GetAllHalls();

            return Ok(halls);
        }

        [HttpGet("{hallId}")]
        public IActionResult GetHallById([FromRoute]int hallId)
        {
            var hall = hallService.GetHallById(hallId);

            if (hall == null)
            {
                return NotFound();
            }

            return Ok(hall);
        }

        [HttpPost]
        public IActionResult AddHall([FromBody]Hall hall)
        {
            hallService.AddHall(hall);

            return Ok(hall);
        }


        [HttpPut("{hallId}")]
        public IActionResult UpdateHall([FromRoute]int hallId, [FromBody]Hall updatedHall)
        {
            var hall = hallService.GetHallById(hallId);

            if (hall == null)
            {
                return NotFound();
            }

            hallService.UpdateHall(hallId, updatedHall);

            return Ok();
        }

        [HttpDelete("{hallId}")]
        public IActionResult DeleteHall([FromRoute]int hallId)
        {
            var hall = hallService.GetHallById(hallId);

            if (hall == null)
            {
                return NotFound();
            }

            hallService.DeleteHall(hallId);

            return NoContent();
        }

        // GET: api/hall/5/seats
        [HttpGet("{hallId}/seats")]
        public IActionResult GetSeatsByHall([FromRoute] int hallId)
        {
            var hall = hallService.GetHallById(hallId);

            if (hall == null)
            {
                return NotFound();
            }

            var seats = hallService.GetSeatsByHall(hallId);

            return Ok(seats);
        }

        // POST: api/hall/5/seats
        [HttpPost("{hallId}/seats")]
        public IActionResult AddSeat([FromRoute]int hallId, [FromBody]Seat seat)
        {
            var hall = hallService.GetHallById(hallId);

            if (hall == null)
            {
                return NotFound();
            }

            hallService.AddSeat(hallId, seat);

            return Ok(seat);
        }

        // GET: api/hall/seats/10
        [HttpGet("seats/{seatId}")]
        public IActionResult GetSeatById(int seatId)
        {
            var seat = hallService.GetSeatById(seatId);

            if (seat == null)
            {
                return NotFound();
            }

            return Ok(seat);
        }

        // DELETE: api/hall/seats/10
        [HttpDelete("seats/{seatId}")]
        public IActionResult DeleteSeat(int seatId)
        {
            var seat = hallService.GetSeatById(seatId);

            if (seat == null)
            {
                return NotFound();
            }

            hallService.DeleteSeat(seatId);

            return NoContent();
        }

    }
}

