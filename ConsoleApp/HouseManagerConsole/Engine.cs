namespace HouseManagerConsole
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Seeder;
    using Services;
    using Services.Contracts;

    public class Engine
    {
        public void Run()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var servicePropvider = serviceCollection.BuildServiceProvider();

            var db = servicePropvider.GetService<HouseManagerDbContext>();

            db.Database.Migrate();

            var seeder = new Seeder(db);
            seeder.Seed();

            // var propertyService = servicePropvider.GetService<IPropertyService>();
            // var addressServise = new AddressService(db);
            // var feeService = new FeeService(db);
            // var userService = new UserService(db);
            // var dueAmountService = servicePropvider.GetService<IDueAmountService>();
            // var incomeService = new IncomeService(db);

            // задължения за текущ месец
            // for (int i = 1; i < 17; i++)
            // {
            //    var result = dueAmountService.GetPropertyMountDueAmount(i);
            //    var user = propertyService.GetAllResidents(i);
            //    if (result.RegularDueAmount > 0 || result.NotRegularDueAmount > 0)
            //    {
            //        Console.WriteLine($"Ап.{i}");
            //        foreach (var item in user)
            //        {
            //             Console.WriteLine(item);
            //        }
            // 
            //        Console.WriteLine();
            //        Console.WriteLine(result.RegularDueAmount);
            //        Console.WriteLine(result.NotRegularDueAmount);
            //        Console.WriteLine("---------------------------");
            //    }
            // }

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

        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            services.AddDbContext<HouseManagerDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<ApplicationUser>(options =>
            options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<HouseManagerDbContext>();

            services.AddTransient<IPropertyService, PropertyService>();
            services.AddTransient<IDueAmountService, DueAmountService>();
            // services.AddTransient<IAnswerService, AnswerServise>();
            // services.AddTransient<IUserAnswerService, UserAnswerService>();
        }
    }
}
