using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class Tuser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public string CompanyPhoneNo { get; set; }
        public string HomePhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string IsRestrictIp { get; set; }
        public DateTime PwdExpireTime { get; set; }
        public string IsFromAd { get; set; }
        public string LoginId { get; set; }
        public string Memo { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
