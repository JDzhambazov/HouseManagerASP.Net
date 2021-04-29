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
            var dueAmountService = new DueAmountService(db);

            // var properies = addressServise.GetAllProperyies(1);

            // foreach (var item in properies)
            // {
            //     Console.WriteLine(item.Name);
            //     Console.WriteLine($"Постоянни разходи: {propertyService.GetDueAmount(item.Id).RegularDueAmount}");
            //     Console.WriteLine($"Временни разходи: {propertyService.GetDueAmount(item.Id).NotRegularDueAmount}");
            // }
        }
    }
}
