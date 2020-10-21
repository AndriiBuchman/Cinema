using Cinema.Context;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public class FilmService : IFilmService
    {
        private readonly CinemaContext _cinemaContext;

        public FilmService(CinemaContext cinemaContext)
        {
            _cinemaContext = cinemaContext;
        }

        public void BuyTicket(int filmId, int customerId)
        {
            var film =  _cinemaContext.Films.Find(filmId);

            var customer = _cinemaContext.Customers.Find(customerId);
            if (film != null && customer != null)
            {
                var reserve = new ReservedPlaces() { CustomerId = customerId, FilmId = filmId };
                _cinemaContext.Add(reserve);

                _cinemaContext.SaveChanges();
            }
            else throw new Exception("Bad parameters");
            
        }

        public async Task<IEnumerable<Customers>> GetCustomers()
        {
            var customers = await _cinemaContext.Customers.ToListAsync();

            return customers;
        }

        public async Task<IEnumerable<Films>> GetFilmsList()
        {
            var films = await _cinemaContext.Films.ToListAsync();

            return films;

        }

        public async Task<IEnumerable<ReservedPlaces>> GetReservedPlaces()
        {
            var reservations = await _cinemaContext.ReservedPlaces.ToListAsync();
            return reservations;
        }
    }
}
