using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ReservedPlaces
    {
        public  int Id { get; set; }
        public int FilmId { get; set; }
        public int CustomerId { get; set; }

        public Customers Customer;
        public Films Film;
    }
}
