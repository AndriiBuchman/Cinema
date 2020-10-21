using System;
using System.Collections.Generic;

namespace Models
{
    public class Films
    {
        public int Id { get; set; }
        public string FilmName { get; set; }
        public DateTime StartTime { get; set; }
        
        public List<ReservedPlaces> ReservedPlaces;

    }
}
