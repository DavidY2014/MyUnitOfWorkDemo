using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtOrders
    {
        public DtOrders()
        {
            DtOrderGoods = new HashSet<DtOrderGoods>();
        }

        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string TradeNo { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? PaymentId { get; set; }
        public decimal? PaymentFee { get; set; }
        public byte? PaymentStatus { get; set; }
        public DateTime? PaymentTime { get; set; }
        public int? ExpressId { get; set; }
        public string ExpressNo { get; set; }
        public decimal? ExpressFee { get; set; }
        public byte? ExpressStatus { get; set; }
        public DateTime? ExpressTime { get; set; }
        public string AcceptName { get; set; }
        public string PostCode { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Message { get; set; }
        public string Remark { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? RealAmount { get; set; }
        public decimal? OrderAmount { get; set; }
        public int? Point { get; set; }
        public byte? Status { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? ConfirmTime { get; set; }
        public DateTime? CompleteTime { get; set; }
        public int? Wid { get; set; }
        public string Openid { get; set; }
        public string ModelName { get; set; }
        public string ModelCode { get; set; }
        public string ModelActionName { get; set; }
        public int? ModelActionId { get; set; }
        public string OrderSubject { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string NotifyId { get; set; }
        public string PayInfo { get; set; }
        public bool? IsSubscribe { get; set; }
        public string FahuoCode { get; set; }
        public string FahuoMsg { get; set; }

        public virtual ICollection<DtOrderGoods> DtOrderGoods { get; set; }
    }
}
