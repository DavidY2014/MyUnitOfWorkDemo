using Netcore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netcore.Services.Implements
{
    public class MyService : IService
    {
        INotifier _notifier;

        public MyService(INotifier notifier)
        {
            _notifier = notifier;
        }
        public void GetInfo()
        {
            _notifier.NotifierToMem();
        }
    }
}
