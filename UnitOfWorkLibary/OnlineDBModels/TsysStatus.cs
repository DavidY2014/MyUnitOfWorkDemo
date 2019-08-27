using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TsysStatus
    {
        public string TableName { get; set; }
        public string ColName { get; set; }
        public string CodeValue { get; set; }
        public string DisplayValue { get; set; }
        public string StatusNote { get; set; }
        public string DisplayValueEnglish { get; set; }
        public string Status { get; set; }
    }
}
