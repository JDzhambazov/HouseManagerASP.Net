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
            //SeedUsers();
            SeedAddress();
        }

        private void SeedUsers()
        {
            UserService userService = new UserService(db);
            userService.AddNewUser("Живко Джамбазов", "jamby@mail.bg", "123456");
            userService.AddNewUser("Осман Сейдали", null, "123456");
            userService.AddNewUser("Кремена Миланова", null, "123456");
            userService.AddNewUser("Владимир Попов", null, "123456");
            userService.AddNewUser("Ганев", null, "123456");
            userService.AddNewUser("Николай Кирилов", null, "123456");
            userService.AddNewUser("Симеон Ангелов", null, "123456");
            userService.AddNewUser("Дунгьова", null, "123456");
            userService.AddNewUser("Златеви", null, "123456");
            userService.AddNewUser("Калин Бошев", null, "123456");
            userService.AddNewUser("Рая Димова", null, "123456");
            userService.AddNewUser("Овчарова", null, "123456");
            userService.AddNewUser("РДВР", null, "123456");
            userService.AddNewUser("Панайотова", null, "123456");
            userService.AddNewUser("Димо Лапчев", null, "123456");
            userService.AddNewUser("Нана Милтиядова", null, "123456");
            userService.AddNewUser("Кина Шереметова", null, "123456");
            userService.AddNewUser("Атанас Бошев", null, "123456");
        }

        private void SeedAddress()
        {

        }
    }
}
