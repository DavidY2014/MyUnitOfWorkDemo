using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSysConfig
    {
        public int Id { get; set; }
        public string SysCode { get; set; }
        public string SysName { get; set; }
        public string SysValue { get; set; }
        public int? SysTypeId { get; set; }
        public string SysTypeName { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ParentId { get; set; }
        public string Remark { get; set; }
        public int? SortId { get; set; }
    }
}
