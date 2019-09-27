using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TransactionControl
{
    public class MessageQuene
    {

        public event EventHandler<Message> _consumeMessage;

        public static List<Message> _queue = new List<Message>();

        private MessageQuene _messageQueue;

        public MessageQuene GetInstance()
        {
            if (_messageQueue == null)
            {
                _messageQueue = new MessageQuene();
            }
            return _messageQueue;
        }

        public void Start()
        {
            Console.WriteLine("server is running");
            var thread1 = new Thread(()=> {
                //check if _queue is emputy or not 
                while (true)
                {
                    if (_queue.Count > 0)
                    {
                        if (_consumeMessage != null)
                        {
                            _consumeMessage(this, _queue[0]);
                        }
                    }
                }
            });

            thread1.Start();

        }

        public void RegisterMessage(Message m)
        {
            _queue.Add(m);
        }

        public void UnregisterMessage(Message m)
        {
            _queue.Remove(m);
        }

         
    }

}
