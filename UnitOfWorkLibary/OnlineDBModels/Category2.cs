using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Category2
    {
        public Category2()
        {
            Category3 = new HashSet<Category3>();
        }

        public int SysNo { get; set; }
        public int C1sysNo { get; set; }
        public string C2id { get; set; }
        public string C2name { get; set; }
        public int Status { get; set; }
        public string Seotitle { get; set; }
        public string Seokeyword { get; set; }
        public string Seodescription { get; set; }
        public int Bstatus { get; set; }
        public int Gstatus { get; set; }
        public int OrderList { get; set; }
        public string ChannelShowType { get; set; }
        public string CategorySameKeyWord { get; set; }
        public string NameEn { get; set; }
        public int? IsVisable { get; set; }
        public decimal? IntegralCoefficient { get; set; }
        public decimal? IntegralMultiples { get; set; }
        public string IntegralName { get; set; }

        public virtual Category1 C1sysNoNavigation { get; set; }
        public virtual ICollection<Category3> Category3 { get; set; }
    }
}
