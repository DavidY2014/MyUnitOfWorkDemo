using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TcontactPerson
    {
        public int ContactPersonId { get; set; }
        public string DistributeCenterId { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string FaxNo { get; set; }
        public string Remark { get; set; }
        public string ContactPersonType { get; set; }
        public string IsMaster { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
