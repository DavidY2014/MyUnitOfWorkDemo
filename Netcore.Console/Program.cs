using Netcore.Services.DelegateTransaction;
using Netcore.Services.FP;
using System;
using System.Collections.Generic;
using System.IO;
using TransactionControl;

namespace Netcore.ConsoleEntry
{
    class Program
    {

        static void Main(string[] args)
        {
            //bussiness 业务代码写成静态方法，保有一份，需要事务操作的方法扔进去就行，即插即用
            //var actions = new List<Action>();
            //actions.Add(()=> {
            //    Console.WriteLine("bussiness 1");
            //});
            //actions.Add(() =>
            //{
            //    Console.WriteLine("bussiness 2");
            //    throw new Exception();
            //});
            //actions.Add(() =>
            //{
            //    Console.WriteLine("bussiness 3");
            //});
            //TransactionEntry.NeedTransactionBussinessLogic(actions.ToArray(),false);


            //new PaymentTransaction().Bussiness();
            //Console.ReadKey();

            //var queue = new MessageQuene();
            //queue.Start();

            //queue.RegisterMessage(new Message() { Info = "message 1" });


            //queue._consumeMessage += (sender, e) =>
            //{
            //    var message = e as Message;
            //    Console.WriteLine(e.Info);
            //};



        }
    }


}
