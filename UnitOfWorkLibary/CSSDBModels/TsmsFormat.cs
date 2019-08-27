using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TsmsFormat
    {
        public short SmsFormatId { get; set; }
        public string SmsFormatName { get; set; }
        public string SmsFormatCode { get; set; }
        public string Content { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
