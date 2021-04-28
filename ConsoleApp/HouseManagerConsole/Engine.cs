namespace HouseManagerConsole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Seeder;
    using Services;

    public class Engine
    {
        public void Run()
        {
            var db = new HouseManagerDbContext();

            db.Database.Migrate();

            //var seeder = new Seeder(db);
            //seeder.Seed();

            // var res = db.Properties.Where(x => x.Id == 1)
            //    .Select(x => new
            //    {
            //        name= x.MonthFees.Sum(x => x.Cost),
            //    })
            //    .ToList();
            // foreach (var item in res)
            // {
            //    Console.WriteLine($"{item.name} -> ");
            // }
        }
    }
}
