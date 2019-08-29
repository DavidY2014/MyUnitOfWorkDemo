using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiShopinfo
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string HotelName { get; set; }
        public string HotelLogo { get; set; }
        public DateTime? HoteltimeBegin { get; set; }
        public DateTime? HoteltimeEnd { get; set; }
        public bool? LimiteOrder { get; set; }
        public string DcRename { get; set; }
        public double? SendPrice { get; set; }
        public double? SendCost { get; set; }
        public int? FreeSendcost { get; set; }
        public string Radius { get; set; }
        public string SendArea { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public int? PersonLimite { get; set; }
        public string Notice { get; set; }
        public string Hotelintroduction { get; set; }
        public string Email { get; set; }
        public string Emailpwd { get; set; }
        public string Stmp { get; set; }
        public string Css { get; set; }
        public DateTime? CreateDate { get; set; }
        public string KcType { get; set; }
        public string Miaoshu { get; set; }
        public double? Xplace { get; set; }
        public double? Yplace { get; set; }
        public DateTime? HoteltimeBegin1 { get; set; }
        public DateTime? HoteltimeEnd1 { get; set; }
        public DateTime? HoteltimeBegin2 { get; set; }
        public DateTime? HoteltimeEnd2 { get; set; }
    }
}
