﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDiancaiCaipinCategory
    {
        public int Id { get; set; }
        public int? Shopid { get; set; }
        public int? Sortid { get; set; }
        public string CategoryName { get; set; }
        public string Miaoshu { get; set; }
        public bool? IsStart { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}