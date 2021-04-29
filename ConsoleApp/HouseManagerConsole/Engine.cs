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
            var propertyService = new PropertyService(db);
            var addressServise = new AddressService(db);
            var feeService = new FeeService(db);
            var userService = new UserService(db);

            Console.WriteLine($"Постоянни разходи: {propertyService.GetDueAmount(1).RegularDueAmount}");
            Console.WriteLine($"Временни разходи: {propertyService.GetDueAmount(1).NotRegularDueAmount}");

        }
    }
}
