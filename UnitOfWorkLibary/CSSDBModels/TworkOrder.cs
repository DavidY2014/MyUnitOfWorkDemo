using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrder
    {
        public int WorkOrderId { get; set; }
        public int CustomerId { get; set; }
        public int SoId { get; set; }
        public string SoCode { get; set; }
        public int DoId { get; set; }
        public string DoCode { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Address { get; set; }
        public string Postalcode { get; set; }
        public string ContactName { get; set; }
        public string ContactMobileNo { get; set; }
        public string ContactPhoneNo { get; set; }
        public string ContactMail { get; set; }
        public int ClassId1 { get; set; }
        public int ClassId2 { get; set; }
        public int ClassId3 { get; set; }
        public string WorkOrderTypeId { get; set; }
        public int TimeLimitId { get; set; }
        public string SourceType { get; set; }
        public string Priority { get; set; }
        public string Content { get; set; }
        public string Remark { get; set; }
        public string NewSoId { get; set; }
        public string NewDeliveryId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string ResponsibleParty { get; set; }
        public string ExpenseParty { get; set; }
        public int ApplyUserId { get; set; }
    }
}
