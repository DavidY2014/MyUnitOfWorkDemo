using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiFormControl
    {
        public int Id { get; set; }
        public int? ShopinfoId { get; set; }
        public string CName { get; set; }
        public string CType { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsBiTian { get; set; }
        public int? Seq { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Remark { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr { get; set; }
        public bool? IsSys { get; set; }
        public string SysControlerType { get; set; }
    }
}
