using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtUsers
    {
        public DtUsers()
        {
            DtUserCode = new HashSet<DtUserCode>();
            DtUserLoginLog = new HashSet<DtUserLoginLog>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public string Avatar { get; set; }
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public string Qq { get; set; }
        public string Address { get; set; }
        public string SafeQuestion { get; set; }
        public string SafeAnswer { get; set; }
        public decimal? Amount { get; set; }
        public int? Point { get; set; }
        public int? Exp { get; set; }
        public byte? Status { get; set; }
        public DateTime? RegTime { get; set; }
        public string RegIp { get; set; }
        public byte? Isweixin { get; set; }
        public int? Wid { get; set; }
        public string WxOpenId { get; set; }
        public string WxName { get; set; }

        public virtual DtUserGroups Group { get; set; }
        public virtual ICollection<DtUserCode> DtUserCode { get; set; }
        public virtual ICollection<DtUserLoginLog> DtUserLoginLog { get; set; }
    }
}
