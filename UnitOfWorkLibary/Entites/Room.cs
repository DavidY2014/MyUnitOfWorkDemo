using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UnitOfWorkLibary.Entites
{
    [Table("Room")]
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string type { get; set; }

        public int studentid { get; set; }
    }
}
