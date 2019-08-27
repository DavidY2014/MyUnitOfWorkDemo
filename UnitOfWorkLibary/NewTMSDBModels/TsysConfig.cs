using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TsysConfig
    {
        public string ConfigClass { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
        public string ConfigStatus { get; set; }
        public string ConfigNote { get; set; }
        public string ConfigDescription { get; set; }
        public string ValidateRegExpress { get; set; }
        public string IsReserved { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
