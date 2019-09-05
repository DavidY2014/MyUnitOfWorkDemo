using CodeFirstLibraryDataAccess.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace EFCodeFirstDemo
{
    /// <summary>
    /// webhost https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/web-host?view=aspnetcore-2.2
    /// The host is responsible for app startup and lifetime management.
    /// At a minimum, the host configures a server and a request processing pipeline. 
    /// The host can also set up logging, dependency injection, and configuration.
    /// </summary>
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
