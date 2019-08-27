using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TlogisticParcel
    {
        public int ParcelId { get; set; }
        public int ParcelTypeId { get; set; }
        public int ExpressId { get; set; }
        public int InterfaceId { get; set; }
        public string DistributeCenterId { get; set; }
        public string ExpressParcelCode { get; set; }
        public string VoucherNo { get; set; }
        public string CustomerCode { get; set; }
        public DateTime DeliveryTime { get; set; }
        public decimal ParcelAmount { get; set; }
        public string Receiver { get; set; }
        public int ProvinceId { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverMobile { get; set; }
        public string DataType { get; set; }
        public string Signer { get; set; }
        public DateTime? SignTime { get; set; }
        public string Courier { get; set; }
        public string CourierMobile { get; set; }
        public string IsConfirmed { get; set; }
        public int ConfirmUserId { get; set; }
        public DateTime? ConfirmTime { get; set; }
        public DateTime? InterfaceUpdateTime { get; set; }
        public string InterfaceStatus { get; set; }
        public string InterfaceErrorMessage { get; set; }
        public DateTime NextInterfaceTime { get; set; }
        public int ErrorCount { get; set; }
        public int ExportUserId { get; set; }
        public int ExportCount { get; set; }
        public DateTime? ExportTime { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public byte[] Tmstamp { get; set; }
    }
}
