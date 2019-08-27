using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TsysColsList
    {
        public string ColName { get; set; }
        public string TableName { get; set; }
        public byte ColId { get; set; }
        public string ColDescription { get; set; }
        public string DefaultValue { get; set; }
        public string DataType { get; set; }
        public string ValueType { get; set; }
        public short MinLength { get; set; }
        public short MaxLength { get; set; }
        public string ColNote { get; set; }
        public string IsNeedLanguage { get; set; }
        public string MaxValue { get; set; }
        public string ClassPropertyName { get; set; }
        public string MinValue { get; set; }
        public string IsGetByParent { get; set; }
        public string ClassName { get; set; }
        public string IsRequired { get; set; }
        public string IsBool { get; set; }
        public string ParentGetMethodName { get; set; }
        public string IsDefaultSetByUser { get; set; }
        public string UserDefaultValue { get; set; }
        public string RegExpression { get; set; }
    }
}
