﻿using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkLibary.TestDBModels;

namespace Netcore.Services.DelegateTransaction
{
    public class TransactionEntry
    {
        public static void NeedTransactionBussinessLogic(Action[] actions)
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
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    context.Database.RollbackTransaction();
                }
            }

        }

    }
}