using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RecommendedBrand
    {
        public int SysNo { get; set; }
        public string BrandName { get; set; }
        public int? ParamType { get; set; }
        public int? ParamSysNo { get; set; }
        public int? IsHighlight { get; set; }
        public int? Validity { get; set; }
        public int? ShowOrder { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateSysNo { get; set; }
    }
}
