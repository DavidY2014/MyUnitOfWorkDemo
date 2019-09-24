using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.TestDBModels;

namespace Netcore.Services.DelegateTransaction
{
    public class TransactionEntry
    {
        /// <summary>
        /// FP 函数 High order function
        /// </summary>
        /// <param name="actions"></param>
        public static void NeedTransactionBussinessLogic(Action[] actions,bool isSubmit)
        {
            using (var context = new TestDBContext())
            {
                try
                {
                    foreach (var action in actions)
                    {
                        if (action != null)
                        {
                            action();
                        }
                    }
                    if(isSubmit)
                        context.SaveChanges(true);
                }
                catch (Exception ex)
                {
                    context.Database.RollbackTransaction();
                }
                finally
                {
                    context.Dispose();
                }
            }

        }

    }
}
