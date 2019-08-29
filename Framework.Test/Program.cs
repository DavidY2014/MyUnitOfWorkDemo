using NetFramework.DataAccess;
using NetFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertAircraft();
        }

        static void InsertAircraft()
        {
            var aircraft = new FrameworkAirCraft
            {
                Name = "F-16",
                Winspan = 9.96m,
                Description = "The General Dynamics F-16 Fighting Falcon " +
                "is a single-engine multirole fighter aircraft"
            };
            using (var context = new DotnetFrameworkAirCraftContext())
            {
                context.Aircrafts.Add(aircraft);
                context.SaveChanges();
            }
        }
    }
}
