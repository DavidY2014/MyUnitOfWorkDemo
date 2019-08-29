using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtChannelCategory
    {
        public DtChannelCategory()
        {
            DtChannel = new HashSet<DtChannel>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string BuildPath { get; set; }
        public string TempletPath { get; set; }
        public string Domain { get; set; }
        public byte? IsDefault { get; set; }
        public int? SortId { get; set; }
        public int? Wid { get; set; }

        public virtual ICollection<DtChannel> DtChannel { get; set; }
    }
}
