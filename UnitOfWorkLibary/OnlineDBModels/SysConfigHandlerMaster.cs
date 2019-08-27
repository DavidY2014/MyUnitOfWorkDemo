using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysConfigHandlerMaster
    {
        public SysConfigHandlerMaster()
        {
            SysConfigHandlerPath = new HashSet<SysConfigHandlerPath>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public string ApplicationId { get; set; }
        public string CommunicationUserId { get; set; }
        public string CommunicationKey { get; set; }
        public bool LogAdd { get; set; }
        public bool DataTurn { get; set; }
        public int Timeout { get; set; }

        public virtual ICollection<SysConfigHandlerPath> SysConfigHandlerPath { get; set; }
    }
}
