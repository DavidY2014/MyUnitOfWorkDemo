using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Netcore.Services.Implements
{
    public class MemNotifier : INotifier
    {
        TextWriter _writer;
        public MemNotifier(TextWriter writer)
        {
            _writer = writer;
        }

        public void NotifierToMem()
        {
            _writer.WriteLine("dadsadadada");
        }
    }
}
