using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TapplicationUpgrade
    {
        public int UpgradeId { get; set; }
        public string ApplicationId { get; set; }
        public string ApplicationVersion { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
