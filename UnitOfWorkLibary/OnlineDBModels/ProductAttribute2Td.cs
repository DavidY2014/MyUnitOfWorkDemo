using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductAttribute2Td
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Attribute2SysNo { get; set; }
        public int Attribute2OptionSysNo { get; set; }
        public string Attribute2Value { get; set; }
        public int IsShow { get; set; }

        public virtual Product ProductSysNoNavigation { get; set; }
    }
}
