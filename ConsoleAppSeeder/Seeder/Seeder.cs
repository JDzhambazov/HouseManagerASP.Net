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
            // SeedAddress();
            // SeedProperties();
        }

        private void SeedUsers()
        {
            UserService userService = new UserService(db);
            userService.AddNewUser("jamby", "Живко","Джамбазов", "jamby@mail.bg", "123456");
            userService.AddNewUser("lazur2", "Осман", "Сейдали", null, "123456");
            userService.AddNewUser("lazur3", "Кремена", "Миланова", null, "123456");
            userService.AddNewUser("lazur4", "Владимир", "Попов", null, "123456");
            userService.AddNewUser("lazur5", null, "Ганев", null, "123456");
            userService.AddNewUser("lazur6", null, "Ганева", null, "123456");
            userService.AddNewUser("lazur8", "Николай", "Кирилов", null, "123456");
            userService.AddNewUser("lazur9", "Симеон", "Ангелов", null, "123456");
            userService.AddNewUser("lazur10", "Албена", "Ангелова", null, "123456");
            userService.AddNewUser("lazur11", "Валентина",  "Дунгьова", null, "123456");
            userService.AddNewUser("lazur12", "------", "Дунгьов", null, "123456");
            userService.AddNewUser("lazur13", null, "Златеви", null, "123456");
            userService.AddNewUser("lazur14", "Калин", "Бошев", null, "123456");
            userService.AddNewUser("lazur15", "Рая", "Димова", null, "123456");
            userService.AddNewUser("lazur16", "----", "Овчарова", null, "123456");
            userService.AddNewUser("lazur17", null, "РДВР", null, "123456");
            userService.AddNewUser("lazur18", "Ирина", "Панайотова", null, "123456");
            userService.AddNewUser("lazur19", "Димо", "Лапчев", null, "123456");
            userService.AddNewUser("lazur20", "Мария", "Лапчева", null, "123456");
            userService.AddNewUser("lazur21", "Нана", "Милтиядова", null, "123456");
            userService.AddNewUser("lazur22", "Кина", "Шереметова", null, "123456");
            userService.AddNewUser("lazur23", "Атанас", "Бошев", null, "123456");
        }

        private void SeedAddress()
        {
            var addressService = new AddressService(db);
            addressService.CreateAddress("Бургас","Лазур", null, "88", "2", 16);
            addressService.SetAddressManager(1, "Атанас Бошев");
            addressService.SetAddressPaymaster(1, "Живко Джамбазов");
        }

        private void SeedProperties()
        {
            var propertyService = new PropertyService(db);

            propertyService.AddProperty("Aп.17", "Апартамент", 3, 1);
            propertyService.AddProperty("Aп.18", "Апартамент", 3, 1);
            propertyService.AddProperty("Aп.19", "Апартамент", 1, 1);
            propertyService.AddProperty("Aп.20", "Апартамент", 1, 1);
            propertyService.AddProperty("Aп.21", "Апартамент", 1, 1);
            propertyService.AddProperty("Aп.22", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.23", "Апартамент", 1, 1);
            propertyService.AddProperty("Aп.24", "Апартамент", 3, 1);
            propertyService.AddProperty("Aп.25", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.26", "Апартамент", 0, 1);
            propertyService.AddProperty("Aп.27", "Апартамент", 0, 1);
            propertyService.AddProperty("Aп.28", "Апартамент", 1, 1);
            propertyService.AddProperty("Aп.29", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.30", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.31", "Апартамент", 3, 1);
            propertyService.AddProperty("Aп.32", "Апартамент", 2, 1);
            
            //Users in properties
            propertyService.AddResidentToProperty("Aп.17", "jamby", "Живко", "Джамбазов", "jamby@mail.bg", "123456", 1);
            propertyService.AddResidentToProperty("Aп.17", "rumi", "Румяна", "Джамбазова", "rumiu@abv.bg", "123456", 1);
            propertyService.AddResidentToProperty("Aп.18", "Осман Сейдали");
            propertyService.AddResidentToProperty("Aп.19", "Владимир Попов");
            propertyService.AddResidentToProperty("Aп.20", "Кремена Миланова");
            propertyService.AddResidentToProperty("Aп.21", "Николай Кирилов");
            propertyService.AddResidentToProperty("Aп.22", "Ганев");
            propertyService.AddResidentToProperty("Aп.22", "Ганева");
            propertyService.AddResidentToProperty("Aп.23", "Валентина Дунгьова");
            propertyService.AddResidentToProperty("Aп.23", "------ Дунгьов");
            propertyService.AddResidentToProperty("Aп.24", "Симеон Ангелов");
            propertyService.AddResidentToProperty("Aп.24", "Албена Ангелова");
            propertyService.AddResidentToProperty("Aп.25", "Калин Бошев");
            propertyService.AddResidentToProperty("Aп.25", "Рая Димова");
            propertyService.AddResidentToProperty("Aп.26", "Златеви");
            propertyService.AddResidentToProperty("Aп.27", "РДВР");
            propertyService.AddResidentToProperty("Aп.28", "---- Овчарова");
            propertyService.AddResidentToProperty("Aп.29", "Димо Лапчев");
            propertyService.AddResidentToProperty("Aп.29", "Мария Лапчева");
            propertyService.AddResidentToProperty("Aп.30", "Ирина Панайотова");
            propertyService.AddResidentToProperty("Aп.31", "Кина Шереметова");
            propertyService.AddResidentToProperty("Aп.31", "Атанас Бошев");
            propertyService.AddResidentToProperty("Aп.32", "Нана Милтиядова");
        }
    }
}
