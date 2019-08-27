using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Category1
    {
        public Category1()
        {
            Category2 = new HashSet<Category2>();
        }

        public int SysNo { get; set; }
        public string C1id { get; set; }
        public string C1name { get; set; }
        public int Status { get; set; }
        public string Seotitle { get; set; }
        public string Seokeyword { get; set; }
        public string Seodescription { get; set; }
        public int BorderList { get; set; }
        public int Bstatus { get; set; }
        public int Gstatus { get; set; }
        public string SearchKeyWord { get; set; }
        public string ChannelShowType { get; set; }
        public string BrandSearchKeyWord { get; set; }
        public string NameEn { get; set; }
        public int? IsVisable { get; set; }
        public decimal? IntegralCoefficient { get; set; }
        public decimal? IntegralMultiples { get; set; }
        public string IntegralName { get; set; }

        public virtual ICollection<Category2> Category2 { get; set; }
    }
}
