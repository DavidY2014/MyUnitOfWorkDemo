using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderHasten
    {
        public int HastenId { get; set; }
        public int WorkOrderId { get; set; }
        public string HastenContent { get; set; }
        public string HastenName { get; set; }
        public string FromSource { get; set; }
        public string Urgent { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
