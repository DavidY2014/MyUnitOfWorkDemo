using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstLibraryDataAccess.Models
{
    public class AirCraft
    {
        public int AircraftId { get; set; }
        public string Name { get; set; }
        public decimal Winspan { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }

        public List<Order> Orders { get; set; }
    }
}
