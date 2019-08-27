using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class Texpress
    {
        public int ExpressId { get; set; }
        public int InterfaceId { get; set; }
        public string ExpressCode { get; set; }
        public string ExpressName { get; set; }
        public string IsMultiPackage { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string IsDisplayOnWeb { get; set; }
    }
}
