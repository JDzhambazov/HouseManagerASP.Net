namespace Seeder
{
    using System;

    using Data;
    using Data.Models;

    using Services;

    public class Seeder
    {
        private readonly HouseManagerDbContext db;

        public Seeder(HouseManagerDbContext dbContext)
        {
            this.db = dbContext;
        }

        public void Seed()
        {
            // SeedUsers();
            SeedAddress();
        }

        private void SeedUsers()
        {
            UserService userService = new UserService(db);
            userService.AddNewUser("jamby", "Живко","Джамбазов", "jamby@mail.bg", "123456");
            userService.AddNewUser("lazur2", "Осман", "Сейдали", null, "123456");
            userService.AddNewUser("lazur3", "Кремена", "Миланова", null, "123456");
            userService.AddNewUser("lazur4", "Владимир ", "Попов", null, "123456");
            userService.AddNewUser("lazur5", null, "Ганев", null, "123456");
            userService.AddNewUser("lazur6", "Николай", "Кирилов", null, "123456");
            userService.AddNewUser("lazur7", "Симеон", "Ангелов", null, "123456");
            userService.AddNewUser("lazur8", null,  "Дунгьова", null, "123456");
            userService.AddNewUser("lazur9", null, "Златеви", null, "123456");
            userService.AddNewUser("lazur10", "Калин", "Бошев", null, "123456");
            userService.AddNewUser("lazur11", "Рая", "Димова", null, "123456");
            userService.AddNewUser("lazur12", null, "Овчарова", null, "123456");
            userService.AddNewUser("lazur13", null, "РДВР", null, "123456");
            userService.AddNewUser("lazur14", "Ирина", "Панайотова", null, "123456");
            userService.AddNewUser("lazur15", "Димо", "Лапчев", null, "123456");
            userService.AddNewUser("lazur16", "Нана", "Милтиядова", null, "123456");
            userService.AddNewUser("lazur17", "Кина", "Шереметова", null, "123456");
            userService.AddNewUser("lazur18", "Атанас", "Бошев", null, "123456");
        }

        private void SeedAddress()
        {

        }
    }
}
