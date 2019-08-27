using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TitemPictureRepl
    {
        public int PictureId { get; set; }
        public int ItemId { get; set; }
        public int DimentionValueId { get; set; }
        public string PictureFilePath { get; set; }
        public string PictureFileName { get; set; }
        public int ShowOrder { get; set; }
        public string IsDefault { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
