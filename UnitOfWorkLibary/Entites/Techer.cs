using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UnitOfWorkLibary.Entites
{
    [Table("Techer")]
    public class Techer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
