using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtSmsTemplate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CallIndex { get; set; }
        public string Content { get; set; }
        public byte? IsSys { get; set; }
    }
}
