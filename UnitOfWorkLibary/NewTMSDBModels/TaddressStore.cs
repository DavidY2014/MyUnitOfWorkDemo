using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TaddressStore
    {
        public int AddressStoreId { get; set; }
        public string OriginalAddress { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Address { get; set; }
        public string Source { get; set; }
        public int Confidence { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public int ConfirmedUserId { get; set; }
        public DateTime? ConfirmTime { get; set; }
    }
}
