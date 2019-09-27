using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionControl
{
    public class Message:EventArgs
    {
        public string Info { get; set; }
    }
}
