using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TprocessParameter
    {
        public int ParameterId { get; set; }
        public int ProcessId { get; set; }
        public string ParameterCode { get; set; }
        public string ParameterName { get; set; }
        public string ParameterDescription { get; set; }
        public string ParameterType { get; set; }
        public string DataType { get; set; }
        public string ParameterUsage { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
