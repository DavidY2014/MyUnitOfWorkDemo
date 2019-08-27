using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TsysMaxNumber
    {
        public string ColName { get; set; }
        public string TableName { get; set; }
        public string ColNote { get; set; }
        public int BaseValue { get; set; }
        public int StepValue { get; set; }
        public int CurrentValue { get; set; }
    }
}
