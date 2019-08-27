using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SpecialPriceDiscount
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Discount { get; set; }
        public int ChannelType { get; set; }
    }
}
