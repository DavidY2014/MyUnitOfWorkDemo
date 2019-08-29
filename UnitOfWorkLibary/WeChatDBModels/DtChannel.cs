using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtChannel
    {
        public DtChannel()
        {
            DtChannelField = new HashSet<DtChannelField>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public byte? IsAlbums { get; set; }
        public byte? IsAttach { get; set; }
        public byte? IsGroupPrice { get; set; }
        public int? PageSize { get; set; }
        public int? SortId { get; set; }
        public int? Wid { get; set; }

        public virtual DtChannelCategory Category { get; set; }
        public virtual ICollection<DtChannelField> DtChannelField { get; set; }
    }
}
