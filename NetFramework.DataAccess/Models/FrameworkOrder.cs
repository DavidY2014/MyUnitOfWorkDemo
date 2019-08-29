using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetFramework.Models
{
    public class FrameworkOrder
    {
        [Key]
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public bool IsCompleted { get; set; }

        public FrameworkAirCraft Aircraft { get; set; }
    }
}
