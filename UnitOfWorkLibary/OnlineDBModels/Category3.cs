using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Category3
    {
        public Category3()
        {
            Category3ReviewItemTd = new HashSet<Category3ReviewItemTd>();
            CategoryAttribute1Td = new HashSet<CategoryAttribute1Td>();
        }

        public int SysNo { get; set; }
        public int? C2sysNo { get; set; }
        public string C3id { get; set; }
        public string C3name { get; set; }
        public int Status { get; set; }
        public int? Online { get; set; }
        public int? C3inventoryCycleTime { get; set; }
        public decimal? C3dmsweight { get; set; }
        public int? C3type { get; set; }
        public int? MustHasInvoice { get; set; }
        public int? MaxSafeQty { get; set; }
        public int? MinSafeQty { get; set; }
        public int CanSumInvoice { get; set; }
        public string Seotitle { get; set; }
        public string Seokeyword { get; set; }
        public string Seodescription { get; set; }
        public int? OrderList { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? MinPrice { get; set; }
        public int? IsThePlan { get; set; }
        public int IsGonlineShow { get; set; }
        public int Bstatus { get; set; }
        public int Gstatus { get; set; }
        public string Description { get; set; }
        public string ChannelShowType { get; set; }
        public string BrandSearchKeyWord { get; set; }
        public string NameEn { get; set; }
        public int? IsVisable { get; set; }
        public decimal? IntegralCoefficient { get; set; }
        public decimal? IntegralMultiples { get; set; }
        public string IntegralName { get; set; }

        public virtual Category2 C2sysNoNavigation { get; set; }
        public virtual ICollection<Category3ReviewItemTd> Category3ReviewItemTd { get; set; }
        public virtual ICollection<CategoryAttribute1Td> CategoryAttribute1Td { get; set; }
    }
}
