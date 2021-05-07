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
            var incomeService = new IncomeService(db);

            // задължения за текущ месец
            for (int i = 1; i < 17; i++)
            {
               var result = dueAmountService.GetPropertyMountDueAmount(i);
               var user = propertyService.GetAllResidents(i);
               if (result.RegularDueAmount > 0 || result.NotRegularDueAmount > 0)
               {
                   Console.WriteLine($"Ап.{i}");
                   Console.WriteLine(user.FirstOrDefault());
                   Console.WriteLine(result.RegularDueAmount);
                   Console.WriteLine(result.NotRegularDueAmount);
                   Console.WriteLine("---------------------------");
               }
            }

            // for (int i = 1; i <= 16; i++)
            // {
            //    var incomes = incomeService.GetAllIncomeForPropery(i, true);
            //    Console.WriteLine($"Ap. {i}");
            //    foreach (var item in incomes)
            //    {
            //        Console.WriteLine($"Price: {item.Price} -> date: {item.Date.ToString("dd.MM.yyyy")} User -> {item.Resident.FullName}");
            //    }
            //    Console.WriteLine();
            // }
        }
    }
}
