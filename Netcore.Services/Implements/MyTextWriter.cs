using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Netcore.Services.Implements
{
    public class MyTextWriter : TextWriter
    {
        public override Encoding Encoding => throw new NotImplementedException();
    }
}
