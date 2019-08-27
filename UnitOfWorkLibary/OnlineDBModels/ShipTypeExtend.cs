using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ShipTypeExtend
    {
        public int ShipTypeSysNo { get; set; }
        public string CustomerCode { get; set; }
        public string ReciverLoanAccount { get; set; }
        public string AccountName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string PostCode { get; set; }
        public string Fax { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ReceiveProvince { get; set; }
        public string ReceiveCity { get; set; }
        public string ReceiveDistrict { get; set; }
        public string ReceiveAddress { get; set; }
        public string IdentityFlag { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
        public string IsRunning { get; set; }
        public string Extend1 { get; set; }
        public string Extend2 { get; set; }
        public string Extend3 { get; set; }
    }
}
