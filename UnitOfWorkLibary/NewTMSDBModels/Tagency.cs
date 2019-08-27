using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class Tagency
    {
        public int AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string Remark { get; set; }
        public int Authorizer { get; set; }
        public string IsMultiLevel { get; set; }
        public string IsAllowSubAuthorize { get; set; }
        public byte SubAuthorizeMaxLevel { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime ActualEndTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
