using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxOrderTemp
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string Openid { get; set; }
        public string UName { get; set; }
        public int? PersonNum { get; set; }
        public int? StadId { get; set; }
        public string StadName { get; set; }
        public int? RoomId { get; set; }
        public string RoomName { get; set; }
        public int? RtimesId { get; set; }
        public DateTime? YdBeginDate { get; set; }
        public DateTime? YdEndDate { get; set; }
        public string OutTradeNo { get; set; }
        public string Ordersubject { get; set; }
        public double? OrderMoney { get; set; }
        public int? OrderStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ComplateDate { get; set; }
        public string Phone { get; set; }
        public int? ExtInt { get; set; }
        public double? ExtFloat { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public double? TtPrice { get; set; }
    }
}
