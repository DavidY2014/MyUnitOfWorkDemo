using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class Tdistrict
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public string AliasName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
