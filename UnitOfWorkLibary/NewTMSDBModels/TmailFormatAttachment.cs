using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TmailFormatAttachment
    {
        public int AttatchmentId { get; set; }
        public short MailFormatId { get; set; }
        public string FileName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
