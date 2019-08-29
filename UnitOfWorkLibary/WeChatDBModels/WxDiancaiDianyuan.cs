using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiDianyuan
    {
        public int Id { get; set; }
        public int? Shopid { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Bianhao { get; set; }
        public string DianyuanName { get; set; }
        public string DianyuanTel { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public int? UserStatus { get; set; }
        public string Fendian { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Remark { get; set; }
    }
}
