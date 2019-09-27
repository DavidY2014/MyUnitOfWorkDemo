using System;
using System.Collections.Generic;
using System.Text;

namespace MessageQueneServer
{
    public class MSqueen
    {
        public static Dictionary<int, string> _messageQueue = new Dictionary<int, string>();

        public event EventHandler _messageComing;

        public MSqueen()
        {
            
        }

        public void start()
        {
        }
    }
}
