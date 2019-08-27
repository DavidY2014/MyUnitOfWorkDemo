using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ArticleThemeGroup
    {
        public int SysNo { get; set; }
        public int? ThemeSysNo { get; set; }
        public string GroupName { get; set; }
        public string Note { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? OrderNum { get; set; }
        public int? Status { get; set; }
        public int? HelpEnum { get; set; }
        public string NameEn { get; set; }
    }
}
