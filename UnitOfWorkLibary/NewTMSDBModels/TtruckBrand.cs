using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TtruckBrand
    {
        public string BrandId { get; set; }
        public string BrandName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
    }
}
