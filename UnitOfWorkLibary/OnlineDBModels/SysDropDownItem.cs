using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysDropDownItem
    {
        public int SysNo { get; set; }
        public int DdsysNo { get; set; }
        public int ItemValue { get; set; }
        public string ItemName { get; set; }
        public int OrderList { get; set; }
        public string ItemDescribe { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
