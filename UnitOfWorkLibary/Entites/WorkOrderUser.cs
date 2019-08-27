using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UnitOfWorkLibary.Entites
{
    [Table("TWorkOrderUser")]
    public class WorkOrderUser
    {
        [Key]
        public int WorkOrderId { get; set; }

        public int UserID { get; set; }
        public string ReferType { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
