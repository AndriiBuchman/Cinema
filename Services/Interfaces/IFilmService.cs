using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IFilmService
    {
        public Task<IEnumerable<Films>> GetFilmsList();

        public void BuyTicket(int filmId, int customerId);
        public Task<IEnumerable<ReservedPlaces>> GetReservedPlaces();
        public Task<IEnumerable<Customers>> GetCustomers();
    }
}
