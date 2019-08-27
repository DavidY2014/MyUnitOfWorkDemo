using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class EmailTemplatesTt
    {
        public int SysNo { get; set; }
        public string Title { get; set; }
        public int EmailType { get; set; }
        public string EmailBody { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDefault { get; set; }
        public int Status { get; set; }
    }
}
