using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class Tprovince
    {
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceCode { get; set; }
        public string AliasName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
