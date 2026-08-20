using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Interfaces
{
    public interface IHallRepository
    {
        public void AddHall(Hall hall);

        public Hall? GetHallById(int hallId);

        public List<Hall> GetAllHalls();

        public void UpdateHall(Hall updatedHall);

        public void DeleteHall(Hall hall);

        public void AddSeat(Seat seat);

        public Seat? GetSeatById(int seatId);

        public List<Seat> GetSeatsByHall(int hallId);

        public void DeleteSeat(Seat seat);

        void SaveChanges();



    }
}
