using Cinema.Application.Interfaces;
using Cinema.Domain.Entities;
using Cinema.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Infrastructure.Repositories
{
    public class HallRepository : IHallRepository
    {
        private readonly ApplicationDBContext context;

        public HallRepository(ApplicationDBContext context)
        {
            this.context = context;
        }

        public void AddHall(Hall hall)
        {
            context.Halls.Add(hall);
        }

        public Hall? GetHallById(int hallId)
        {
            return context.Halls.FirstOrDefault(hall => hall.hallID == hallId);
        }

        public List<Hall> GetAllHalls()
        {
            return context.Halls.ToList();
        }

        public void UpdateHall(Hall hall)
        {
            context.Halls.Update(hall);
        }

        public void DeleteHall(Hall hall)
        {
            context.Halls.Remove(hall);
        }

        public void AddSeat(Seat seat)
        {
            context.Seats.Add(seat);
        }

        public Seat? GetSeatById(int seatId)
        {
            return context.Seats.FirstOrDefault(seat => seat.seatID == seatId);
        }

        public List<Seat> GetSeatsByHall(int hallId)
        {
            return context.Seats.Where(seat => seat.hallID == hallId).ToList();
        }

        public void DeleteSeat(Seat seat)
        {
            context.Seats.Remove(seat);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

    }
}
