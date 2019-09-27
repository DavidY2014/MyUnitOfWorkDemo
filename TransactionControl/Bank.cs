using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TransactionControl
{
    public class Bank
    {
        public int moneny { get; set; }
        public event EventHandler transferCompleteCallback;

        public void StartTransfer()
        {
            moneny = 100;
            Thread.Sleep(5000);
            if (transferCompleteCallback !=null)
            {
                transferCompleteCallback(this,new Message() { Info="moneny is"+moneny});
            }
        }





    }

}
