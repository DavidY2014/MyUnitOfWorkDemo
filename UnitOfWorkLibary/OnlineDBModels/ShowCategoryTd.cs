using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ShowCategoryTd
    {
        public int SysNo { get; set; }
        public int? ChannelType { get; set; }
        public string ShowCategoryName { get; set; }
        public int? OrderNo { get; set; }
        public int? AdPositionSysNo { get; set; }
        public int? Status { get; set; }
        public string NameEn { get; set; }
    }
}
