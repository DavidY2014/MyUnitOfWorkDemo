﻿using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtArticleAlbums
    {
        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public string ThumbPath { get; set; }
        public string OriginalPath { get; set; }
        public string Remark { get; set; }
        public DateTime? AddTime { get; set; }
        public int? Wid { get; set; }
    }
}