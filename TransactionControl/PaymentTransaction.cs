using Microsoft.EntityFrameworkCore.Storage;
using NetCore.SmallUnit.EFModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TransactionControl
{
    /// <summary>
    /// https://mp.weixin.qq.com/s/DTJB9Z3mkWxIYdMlv8X30w
    /// </summary>
    public class PaymentTransaction
    {
        public void Bussiness()
        {

            PayforCompany();
            ComsumeMessageAndUpdateDetail();
        }


        public void PayforCompany()
        {
            var bank = new Bank();
            using (var dbContext = new TestDBContext())
            {
                using (IDbContextTransaction transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        bank.transferCompleteCallback += (sender, args) => {
                            var message = args as Message;
                            Console.WriteLine(message.Info);
                            dbContext.Students.Add(new Students() { Name = "message" + DateTime.Now.Second });//call back save message information;
                        };
                        bank.StartTransfer();
                        dbContext.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error occurred.");
                    }
                }
            }
        }

        public void ComsumeMessageAndUpdateDetail()
        {
            using (var dbContext = new TestDBContext())
            {
                var message = dbContext.Students.Find(1);
                if (message == null)
                {
                    throw new Exception("未获取到支付消息凭证");
                }

                using (IDbContextTransaction transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        dbContext.UserLogin.Add(new UserLogin() { UserName="明细"+DateTime.Now});//更新明细表
                        dbContext.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error occurred.");
                    }
                }
            }
        }

    }
}
