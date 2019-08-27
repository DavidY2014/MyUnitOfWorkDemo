using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class Tpower
    {
        public short PowerId { get; set; }
        public string PowerName { get; set; }
        public string PowerCode { get; set; }
        public string PowerType { get; set; }
        public string ApplicationId { get; set; }
        public string ObjectName { get; set; }
        public string MenuIcon { get; set; }
        public short ParentPowerId { get; set; }
        public byte PowerLevelId { get; set; }
        public string IsLastLevel { get; set; }
        public int ShowOrder { get; set; }
        public string IsUseSsl { get; set; }
        public string HasSplitLine { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
