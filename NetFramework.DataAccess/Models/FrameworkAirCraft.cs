using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetFramework.Models
{
    public class FrameworkAirCraft
    {
        [Key]
        public int AircraftId { get; set; }
        public string Name { get; set; }
        public decimal Winspan { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }

        public List<FrameworkOrder> Orders { get; set; }
    }
}
