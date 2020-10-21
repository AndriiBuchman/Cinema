using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public List<ReservedPlaces> ReservedPlaces;
    }
}
