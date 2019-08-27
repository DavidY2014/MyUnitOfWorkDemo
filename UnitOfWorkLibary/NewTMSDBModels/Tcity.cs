using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class Tcity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public string AliasName { get; set; }
        public int ProvinceId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
