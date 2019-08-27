using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdvertisingContentTd
    {
        public int SysNo { get; set; }
        public string AdTitle { get; set; }
        public int Status { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string AdTag { get; set; }
        public string AdTextContent { get; set; }
        public string AdPic { get; set; }
        public string AdSmallPic { get; set; }
        public string AdLinkPageAddress { get; set; }
        public int AdLinkTarget { get; set; }
        public int OrderNum { get; set; }
        public int AdvertisingPositionSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int IsSynced { get; set; }
        public string ImgAlt { get; set; }
    }
}
