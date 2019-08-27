using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TmailAttachment
    {
        public int AttachmentId { get; set; }
        public int MailId { get; set; }
        public string FileName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
