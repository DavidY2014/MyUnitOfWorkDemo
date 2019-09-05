﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public string ClassList { get; set; }
        public int? ClassLayer { get; set; }
        public int? SortId { get; set; }
        public string LinkUrl { get; set; }
        public string ImgUrl { get; set; }
        public string ClassContent { get; set; }
        public string Remark { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public int? Wid { get; set; }
        public string IcoUrl { get; set; }
    }
}