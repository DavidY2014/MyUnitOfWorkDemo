using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstLibraryDataAccess.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public bool IsCompleted { get; set; }

        public AirCraft Aircraft { get; set; }
    }
}
