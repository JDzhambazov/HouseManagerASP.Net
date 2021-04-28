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

            var seeder = new Seeder(db);
            seeder.Seed();

            var propperyService = new PropertyService(db);
            for (int i = 1; i < 17; i++)
            {
                var user = propperyService.GetAllResidents(i);

                foreach (var item in user)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
