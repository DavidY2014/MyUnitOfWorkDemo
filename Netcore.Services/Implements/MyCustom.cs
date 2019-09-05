using Netcore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netcore.Services.Implements
{
    public class MyCustom : ICustom
    {
        public int age { get => 20; set => throw new NotImplementedException();}
        public string name { get => "jack"; set => throw new NotImplementedException(); }
    }
}
