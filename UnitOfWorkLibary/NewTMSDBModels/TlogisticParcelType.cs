using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TlogisticParcelType
    {
        public int ParcelTypeId { get; set; }
        public string ParcelTypeCode { get; set; }
        public string ParcelTypeName { get; set; }
        public string IsNeedConfirmn { get; set; }
        public string DataType { get; set; }
        public int InterfaceIntervalHour { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
