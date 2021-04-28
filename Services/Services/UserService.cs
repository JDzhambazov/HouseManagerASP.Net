﻿namespace Services
{
    using System;

    using Data;
    using Data.Models;
    using Services.Contracts;

    public class UserService : IUserService
    {
        private readonly HouseManagerDbContext db;

        public UserService(HouseManagerDbContext db)
        {
            this.db = db;
        }

        public void AddNewUser(string userName, string firstName, string lastName, string email, string password)
        {
            var fullname = string.Join(' ', firstName, lastName).Trim();

            this.db.Users.Add(new ApplicationUser
            {
                UserName = userName,
                FullName = fullname,
                NormalizedUserName = userName.ToUpper(),
                Email = email != null ? email : null,
                NormalizedEmail = email != null ? email.ToUpper() : null,
                CreatedOn = DateTime.Now,
                PasswordHash = password,
                EmailConfirmed = true,
            }); ;
            this.db.SaveChanges();
        }
    }
}
