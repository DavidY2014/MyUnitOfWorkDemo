using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TdataPublisherParameter
    {
        public string DataPublisherId { get; set; }
        public string ParameterCode { get; set; }
        public string ParameterName { get; set; }
        public string DataType { get; set; }
        public string DefaultValue { get; set; }
        public string MinValue { get; set; }
        public string MaxValue { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
