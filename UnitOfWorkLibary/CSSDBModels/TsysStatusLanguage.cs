using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TsysStatusLanguage
    {
        public string TableName { get; set; }
        public string ColName { get; set; }
        public string CodeValue { get; set; }
        public string DisplayValue { get; set; }
        public string StatusNote { get; set; }
        public string DisplayValueEnglish { get; set; }
        public string LanguageId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
