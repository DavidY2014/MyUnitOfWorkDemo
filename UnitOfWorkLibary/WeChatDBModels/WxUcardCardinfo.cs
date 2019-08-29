using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardCardinfo
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string CardName { get; set; }
        public string CardNameColor { get; set; }
        public string Logo { get; set; }
        public bool? IsLogoShow { get; set; }
        public int? BgTypeId { get; set; }
        public string BgTypeUrl { get; set; }
        public string BgUrl { get; set; }
        public string CardNoColor { get; set; }
        public string IndexTip { get; set; }
        public string NoticePic { get; set; }
        public string PrivilegesPic { get; set; }
        public string QiandaoPic { get; set; }
        public string ShopingPic { get; set; }
        public string PerinfoPic { get; set; }
        public string InstructionsPic { get; set; }
        public string ContactusPic { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SId { get; set; }
    }
}
