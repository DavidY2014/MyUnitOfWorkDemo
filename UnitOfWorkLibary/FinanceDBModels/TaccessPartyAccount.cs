using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TaccessPartyAccount
    {
        public int AccessPartyId { get; set; }
        public string AccessPartyName { get; set; }
        public string AccessPartyAccountNum { get; set; }
        public string AccessPartySecret { get; set; }
        public string AccessPartyCallUrl { get; set; }
        public string AccessPartyRemark { get; set; }
        public string Standby1 { get; set; }
        public string Standby2 { get; set; }
        public string Status { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
