using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace EFCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateWebHostBuilder(args);
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>();
    }
}
