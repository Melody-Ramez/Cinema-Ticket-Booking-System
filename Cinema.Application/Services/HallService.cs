using Cinema.Application.Interfaces;
using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Services
{
    public class HallService
    {
        private readonly IHallRepository hallRepository;

        public HallService(IHallRepository hallRepository)
        {
            this.hallRepository = hallRepository;
        }

        public void AddHall(Hall hall)
        {
            hallRepository.AddHall(hall);
            hallRepository.SaveChanges();
        }

        public Hall? GetHallById(int hallId)
        {
            return hallRepository.GetHallById(hallId);
        }

        public List<Hall> GetAllHalls()
        {
            return hallRepository.GetAllHalls();
        }

        public void UpdateHall(int hallId, Hall updatedHall)
        {
            Hall? hall = hallRepository.GetHallById(hallId);

            if (hall != null)
            {
                hallRepository.UpdateHall(hall);
                hallRepository.SaveChanges();
            }
        }

        public void DeleteHall(int hallId)
        {
            Hall? hall = hallRepository.GetHallById(hallId);

            if (hall != null)
            {
                hallRepository.DeleteHall(hall);
                hallRepository.SaveChanges();
            }
        }


        public void AddSeat(int hallId, Seat seat)
        {
            Hall? hall = hallRepository.GetHallById(hallId);

            if (hall != null)
            {
                seat.hallID = hallId;

                hallRepository.AddSeat(seat);
                hallRepository.SaveChanges();
            }
        }

        public Seat? GetSeatById(int seatId)
        {
            return hallRepository.GetSeatById(seatId);
        }

        public List<Seat> GetSeatsByHall(int hallId)
        {
            return hallRepository.GetSeatsByHall(hallId);
        }

        public void DeleteSeat(int seatId)
        {
            Seat? seat = hallRepository.GetSeatById(seatId);

            if (seat != null)
            {
                hallRepository.DeleteSeat(seat);
                hallRepository.SaveChanges();
            }
        }

    }
}
