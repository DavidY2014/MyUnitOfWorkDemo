using Autofac;
using Netcore.Services.Implements;
using System;
using System.IO;

namespace Netcore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            var ret = Type.SO.ToString();
            var ret1 = (int)Type.SO;
        }
    }

    public enum Type
    {
        SO=1,
        DO=2
    }
}
