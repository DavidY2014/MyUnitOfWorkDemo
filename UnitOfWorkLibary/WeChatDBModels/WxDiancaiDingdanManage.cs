using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiDingdanManage
    {
        public int Id { get; set; }
        public int? Shopinfoid { get; set; }
        public string Openid { get; set; }
        public int? Wid { get; set; }
        public string OrderNumber { get; set; }
        public string DeskNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTel { get; set; }
        public string Address { get; set; }
        public DateTime? OderTime { get; set; }
        public string OderRemark { get; set; }
        public double? PayAmount { get; set; }
        public int? PayStatus { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
