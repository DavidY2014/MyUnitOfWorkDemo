using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TparameterSetDetail
    {
        public int SetId { get; set; }
        public string ParameterName { get; set; }
        public short SeqId { get; set; }
        public string DataType { get; set; }
        public string ValueType { get; set; }
        public string ParameterValue { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
