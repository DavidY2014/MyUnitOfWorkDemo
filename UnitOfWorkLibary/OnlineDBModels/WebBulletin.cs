using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class WebBulletin
    {
        public int SysNo { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? OrderNum { get; set; }
        public int? Status { get; set; }
        public int? BulletinType { get; set; }
        public int IsScoll { get; set; }
        public int? ShowForums { get; set; }
        public int ProductSaleType { get; set; }
    }
}
