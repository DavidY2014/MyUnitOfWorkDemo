using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopUserAddr
    {
        public int Id { get; set; }
        public int Wid { get; set; }
        public string Openid { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string AddrDetail { get; set; }
        public string Tel { get; set; }
        public string Jiedao { get; set; }
        public string ContractPerson { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? IsDefault { get; set; }
    }
}
