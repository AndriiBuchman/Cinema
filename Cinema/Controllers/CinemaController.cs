using Microsoft.AspNetCore.Mvc;
using Models;
using Services.DTOs;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {

        private readonly IFilmService _filmService;

        public CinemaController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpGet]
        [Route("GetFilms")]
        public Task<IEnumerable<Films>> GetFilms()
        {
            var result = _filmService.GetFilmsList();
            return result;
        }

        [HttpGet]
        [Route("GetReservation")]
        public Task<IEnumerable<ReservedPlaces>> GetReservations()
        {
            var result = _filmService.GetReservedPlaces();
            return result;
        }

        [HttpGet]
        [Route("GetCustomers")]
        public Task<IEnumerable<Customers>> GetCustomers()
        {
             var film = _filmService.GetCustomers();
             return film;
        }

        [HttpPost]
        [Route("AddReservation")]
        public ActionResult AddReservation([FromBody] ReservationDto reservationDto)
        {
            try
            {
                _filmService.BuyTicket(reservationDto.FilmId, reservationDto.CustomerId);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(new { dto = reservationDto, message = ex.Message });
            }
        }
    }
}
