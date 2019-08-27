using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.Models
{
    public partial class Room
    {
        public int RoomId { get; set; }
        public string Type { get; set; }
        public int? Studentid { get; set; }
    }
}
