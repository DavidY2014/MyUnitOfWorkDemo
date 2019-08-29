using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSjbBisai
    {
        public int Id { get; set; }
        public string BsPic { get; set; }
        public string BsRemark { get; set; }
        public int? RcId { get; set; }
        public int? Qd1Id { get; set; }
        public int? Qd2Id { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? JcBeginDate { get; set; }
        public DateTime? JcEndDate { get; set; }
        public int? ResultType { get; set; }
        public int? RType1Times { get; set; }
        public int? RType2Times { get; set; }
        public int? RType3Times { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
