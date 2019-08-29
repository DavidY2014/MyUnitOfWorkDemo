using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxLogs
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string ModelName { get; set; }
        public string Remark { get; set; }
        public int? LogsType { get; set; }
        public string LogsTypeName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LogsContent { get; set; }
        public string LogsTitle { get; set; }
        public string FunName { get; set; }
        public string CreatePerson { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public string ExtStr3 { get; set; }
        public string Flg { get; set; }
        public string Flg2 { get; set; }
        public string Flg3 { get; set; }
        public int? FlgInt { get; set; }
        public DateTime? FlgDate { get; set; }
    }
}
