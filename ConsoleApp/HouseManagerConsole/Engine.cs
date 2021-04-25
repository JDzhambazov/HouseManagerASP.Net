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

    public class Engine
    {
        public void Run()
        {
            var db = new HouseManagerDbContext();
            // db.Database.Migrate();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            // var user = db.Users.FirstOrDefault();
            // Console.WriteLine(user.Id);
            // db.Users.Add(new ApplicationUser
            // {
            //    Id = Guid.NewGuid().ToString(),
            //    CreatedOn = DateTime.Now,
            //    UserName = "Ivan",
            //    IsDeleted = false,
            //    EmailConfirmed = true,
            //    PhoneNumberConfirmed = false,
            //    TwoFactorEnabled = false,
            //    LockoutEnabled = false,
            //    AccessFailedCount = 2,
            // });
            // db.SaveChanges();
        }
    }
}
