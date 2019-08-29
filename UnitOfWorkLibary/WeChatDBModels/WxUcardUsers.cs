using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardUsers
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public int? Sid { get; set; }
        public string Openid { get; set; }
        public string CardNo { get; set; }
        public string Pwd { get; set; }
        public int? DegreeId { get; set; }
        public int? Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string WxName { get; set; }
        public string RealName { get; set; }
        public int? Age { get; set; }
        public string Qq { get; set; }
        public DateTime? RegTime { get; set; }
        public string RegIp { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Addr { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TtScore { get; set; }
        public int? QdScore { get; set; }
        public int? ConsumeScore { get; set; }
        public double? ConsumeMoney { get; set; }
    }
}
