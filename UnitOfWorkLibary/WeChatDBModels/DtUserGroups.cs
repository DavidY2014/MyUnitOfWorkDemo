using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtUserGroups
    {
        public DtUserGroups()
        {
            DtUsers = new HashSet<DtUsers>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? Grade { get; set; }
        public int? UpgradeExp { get; set; }
        public decimal? Amount { get; set; }
        public int? Point { get; set; }
        public int? Discount { get; set; }
        public byte? IsDefault { get; set; }
        public byte? IsUpgrade { get; set; }
        public byte? IsLock { get; set; }

        public virtual ICollection<DtUsers> DtUsers { get; set; }
    }
}
