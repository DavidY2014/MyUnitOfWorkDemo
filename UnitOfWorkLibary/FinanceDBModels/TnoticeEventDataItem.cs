using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TnoticeEventDataItem
    {
        public string EventId { get; set; }
        public string DataItemName { get; set; }
        public string DataItemDescription { get; set; }
        public string Status { get; set; }
    }
}
