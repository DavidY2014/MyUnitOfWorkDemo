using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class PreCommonDistrict
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public int? Upid { get; set; }
    }
}
