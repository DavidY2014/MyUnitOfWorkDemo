using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ArticleThemeTd
    {
        public int SysNo { get; set; }
        public int? CategoryType { get; set; }
        public int? StyleType { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Status { get; set; }
        public int? ThemeType { get; set; }
        public int? OrderNum { get; set; }
    }
}
