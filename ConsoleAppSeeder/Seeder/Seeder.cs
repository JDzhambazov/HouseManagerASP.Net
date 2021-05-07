namespace Seeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Services;

    public class Seeder
    {
        private readonly HouseManagerDbContext db;
        private PropertyService propertyService;
        private AddressService addressService;
        private FeeService feeService;
        private UserService userService;
        private DueAmountService amountService;
        private IncomeService incomeService;

        public Seeder(HouseManagerDbContext dbContext)
        {
            this.db = dbContext;
            this.propertyService = new PropertyService(db);
            this.addressService = new AddressService(db);
            this.feeService = new FeeService(db);
            this.userService = new UserService(db);
            this.amountService = new DueAmountService(db);
            this.incomeService = new IncomeService(db);
        }

        public void Seed()
        {
            // SeedUsers();
            // SeedAddress();
            // SeedProperties();
            // SeedFees();
            // SeedDueAmounts();
            // SeedIncome();
        }

        private void SeedUsers()
        {
            userService.AddNewUser("jamby", "Живко", "Джамбазов", "jamby@mail.bg", "123456");
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
            addressService.CreateAddress("Бургас","Лазур", null, "88", "2", 16);
            addressService.SetAddressManager(1, "Атанас Бошев");
            addressService.SetAddressPaymaster(1, "Живко Джамбазов");
        }

        private void SeedProperties()
        {
            propertyService.AddProperty("Aп.17", "Апартамент", 3, 1);
            propertyService.AddProperty("Aп.18", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.19", "Апартамент", 1, 1);
            propertyService.AddProperty("Aп.20", "Апартамент", 1, 1);
            propertyService.AddProperty("Aп.21", "Апартамент", 1, 1);
            propertyService.AddProperty("Aп.22", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.23", "Апартамент", 1, 1);
            propertyService.AddProperty("Aп.24", "Апартамент", 3, 1);
            propertyService.AddProperty("Aп.25", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.26", "Апартамент", 0, 1);
            propertyService.AddProperty("Aп.27", "Апартамент", 0, 1);
            propertyService.AddProperty("Aп.28", "Апартамент", 3, 1);
            propertyService.AddProperty("Aп.29", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.30", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.31", "Апартамент", 2, 1);
            propertyService.AddProperty("Aп.32", "Апартамент", 2, 1);
            
            //Users in properties
            propertyService.AddResidentToProperty("Aп.17", "jamby", "Живко", "Джамбазов", "jamby@mail.bg", "123456", 1);
            propertyService.AddResidentToProperty("Aп.17", "rumi", "Румяна", "Джамбазова", "rumiu@abv.bg", "123456", 1);
            propertyService.AddResidentToProperty("Aп.18", "burgas", "Община", "Бургас", "obshtina@burgas.bg", "123456", 1);
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

        private void SeedFees() 
        {
            feeService.AddFeeToAddress(1, "Общи части", 3, true, true);
            feeService.AddFeeToAddress(1, "Асансьор", 3.50m, true, true);
            feeService.AddFeeToAddress(1, "Ремонт вход", 0, false, false);

            var propertyList = new List<int>();
            var address = db.Addresses
                .Include(x => x.Properties)
                .FirstOrDefault(x => x.Id == 1);

            foreach (var item in address.Properties)
            {
                propertyList.Add(item.Id);
            }

            feeService.AddFeeToProperty(propertyList, "Общи части");
            feeService.AddFeeToProperty(propertyList, "Ремонт вход");

            var lift = new List<int>() { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            feeService.AddFeeToProperty(lift, "Асансьор");
        }

        private void SeedDueAmounts()
        {

            // задължения от предходна година
            amountService.AddStartDueAmount(3, 12, 2019, 6, true);
            amountService.AddStartDueAmount(4, 12, 2019, 6, true);
            amountService.AddStartDueAmount(5, 12, 2019, 13, true);
            amountService.AddStartDueAmount(7, 12, 2019, 13, true);

            // 2020 year
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 16; j++)
                {
                    amountService.AddMounthDueAmountInProperies(j, i, 2020);
                }
            }

            // добавяне разходи за ремонт
            feeService.EditAddresFee(1, "Ремонт вход", 20);
            // промяна брой обитатели ап.24
            propertyService.ChangeResidentsCount(8, 4);

            for (int i = 5; i <= 8; i++)
            {
                for (int j = 1; j <= 16; j++)
                {
                    amountService.AddMounthDueAmountInProperies(j, i, 2020);
                }
            }

            // промяна брой обитатели ап.28
            propertyService.ChangeResidentsCount(12, 1);

            for (int j = 1; j <= 16; j++)
            {
                amountService.AddMounthDueAmountInProperies(j, 9, 2020);
            }

            // промяна брой обитатели ап.24
            propertyService.ChangeResidentsCount(8, 3);
            for (int i = 10; i <= 12; i++)
            {
                for (int j = 1; j <= 16; j++)
                {
                    amountService.AddMounthDueAmountInProperies(j, i, 2020);
                }
            }

            // 2021 year
            // промяна брой обитатели ап.18 ап.24 и ап.31
            propertyService.ChangeResidentsCount(2, 3);
            propertyService.ChangeResidentsCount(15, 3);
            propertyService.ChangeResidentsCount(8, 4);

            for (int j = 1; j <= 16; j++)
            {
                amountService.AddMounthDueAmountInProperies(j, 1, 2021);
            }

            // промяна на таксите за входа
            // промяна брой обитатели ап.24
            propertyService.ChangeResidentsCount(8, 3);
            feeService.EditAddresFee(1, "Общи части", 4);
            feeService.EditAddresFee(1, "Асансьор", 5);


            for (int i = 2; i <= 4; i++)
            {
                for (int j = 1; j <= 16; j++)
                {
                    amountService.AddMounthDueAmountInProperies(j, i, 2021);
                }
            }
        }

        private void SeedIncome()
        {
            ApplicationUser user;
            //налична сума от предходна година
            incomeService.AddIncome(null, 244.20m, new DateTime(2019, 12, 31), null, 1, true);
            user = db.Users.FirstOrDefault(x => x.FullName == "Живко Джамбазов");
            // общи части
            for (int i = 1; i < 8; i++)
            {
                incomeService.AddIncome(1, 9, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(1, 18, new DateTime(2020, 8, 10), user, 1, true); 
            incomeService.AddIncome(1, 27, new DateTime(2020, 10, 10), user, 1, true);
            incomeService.AddIncome(1, 30.40m, new DateTime(2021, 1, 12), user, 1, true);
            incomeService.AddIncome(1, 76.80m, new DateTime(2021, 2, 15), user, 1, true);

            // за ремонт
            incomeService.AddIncome(1, 20, new DateTime(2020, 5, 10), user, 1, false);
            incomeService.AddIncome(1, 20, new DateTime(2020, 6, 10), user, 1, false);
            incomeService.AddIncome(1, 20, new DateTime(2020, 7, 10), user, 1, false);
            incomeService.AddIncome(1, 40, new DateTime(2020, 8, 10), user, 1, false);
            incomeService.AddIncome(1, 300, new DateTime(2020, 10, 10), user, 1, false);

            ///////////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Осман Сейдали");
            // общи части
            for (int i = 1; i < 7; i++)
            {
                incomeService.AddIncome(2, 6, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(2, 12, new DateTime(2020, 8, 10), user, 1, true);
            incomeService.AddIncome(2, 24, new DateTime(2020, 10, 10), user, 1, true);
            incomeService.AddIncome(2, 9, new DateTime(2021, 1, 12), user, 1, true);
            incomeService.AddIncome(2, 12, new DateTime(2021, 2, 15), user, 1, true);
            incomeService.AddIncome(2, 24, new DateTime(2021, 4, 15), user, 1, true);

            ////////////////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Община Бургас");
            // за ремонт
            incomeService.AddIncome(2, 151, new DateTime(2020, 11, 10), user, 1, false);

            ////////////////////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Владимир Попов");
            // общи части
            incomeService.AddIncome(3, 9, new DateTime(2020, 1, 10), user, 1, true);
            incomeService.AddIncome(3, 3, new DateTime(2020, 2, 10), user, 1, true);
            incomeService.AddIncome(3, 12, new DateTime(2020, 5, 10), user, 1, true);
            incomeService.AddIncome(3, 6, new DateTime(2020, 8, 10), user, 1, true);
            incomeService.AddIncome(3, 3, new DateTime(2020, 9, 10), user, 1, true);
            incomeService.AddIncome(3, 3, new DateTime(2020, 10, 10), user, 1, true);
            incomeService.AddIncome(3, 12, new DateTime(2021, 2, 9), user, 1, true);
            incomeService.AddIncome(3, 5, new DateTime(2021, 3, 7), user, 1, true);

            // за ремонт
            incomeService.AddIncome(3, 40, new DateTime(2020, 5, 10), user, 1, false);
            incomeService.AddIncome(3, 40, new DateTime(2020, 6, 10), user, 1, false);
            incomeService.AddIncome(3, 80, new DateTime(2020, 7, 10), user, 1, false);
            incomeService.AddIncome(3, 40, new DateTime(2021, 2, 9), user, 1, false);
            incomeService.AddIncome(3, 20, new DateTime(2021, 3, 7), user, 1, false);

            //////////////////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Кремена Миланова");
            // общи части
            incomeService.AddIncome(4, 3, new DateTime(2020, 1, 10), user, 1, true);
            incomeService.AddIncome(4, 9, new DateTime(2020, 2, 10), user, 1, true);
            incomeService.AddIncome(4, 5.3m, new DateTime(2020, 4, 10), user, 1, true);
            incomeService.AddIncome(4, 6.7m, new DateTime(2020, 6, 10), user, 1, true);
            incomeService.AddIncome(4, 6, new DateTime(2020, 8, 10), user, 1, true);
            incomeService.AddIncome(4, 6, new DateTime(2020, 10, 10), user, 1, true);
            incomeService.AddIncome(4, 6, new DateTime(2020, 12, 9), user, 1, true);
            incomeService.AddIncome(4, 11, new DateTime(2021, 3, 25), user, 1, true);

            // за ремонт
            incomeService.AddIncome(4, 20, new DateTime(2020, 6, 10), user, 1, false);
            incomeService.AddIncome(4, 60, new DateTime(2020, 8, 10), user, 1, false);
            incomeService.AddIncome(4, 40, new DateTime(2020, 10, 10), user, 1, false);
            incomeService.AddIncome(4, 40, new DateTime(2020, 12, 9), user, 1, false);
            incomeService.AddIncome(4, 60, new DateTime(2021, 3, 25), user, 1, false);

            //////////////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Николай Кирилов");
            // общи части
            incomeService.AddIncome(5, 71.5m, new DateTime(2020, 9, 10), user, 1, true);
            incomeService.AddIncome(5, 20, new DateTime(2020, 11, 10), user, 1, true);
            incomeService.AddIncome(5, 33, new DateTime(2021, 4, 22), user, 1, true);

            // за ремонт
            incomeService.AddIncome(5, 150, new DateTime(2020, 9, 10), user, 1, false);
            incomeService.AddIncome(5, 10, new DateTime(2020, 11, 10), user, 1, false);
            incomeService.AddIncome(5, 80, new DateTime(2021, 4, 22), user, 1, false);

            //////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Ганев");
            // общи части
            incomeService.AddIncome(6, 39, new DateTime(2020, 1, 10), user, 1, true);
            incomeService.AddIncome(6, 13, new DateTime(2020, 4, 10), user, 1, true);
            incomeService.AddIncome(6, 13, new DateTime(2020, 5, 10), user, 1, true);
            incomeService.AddIncome(6, 26, new DateTime(2020, 7, 10), user, 1, true);
            incomeService.AddIncome(6, 13, new DateTime(2020, 8, 10), user, 1, true);
            incomeService.AddIncome(6, 13, new DateTime(2020, 9, 10), user, 1, true);
            incomeService.AddIncome(6, 39, new DateTime(2020, 11, 10), user, 1, true);
            incomeService.AddIncome(6, 13, new DateTime(2021, 1, 10), user, 1, true);
            incomeService.AddIncome(6, 20, new DateTime(2021, 2, 21), user, 1, true);
            incomeService.AddIncome(6, 34, new DateTime(2021, 4, 28), user, 1, true);

            // за ремонт
            incomeService.AddIncome(6, 20, new DateTime(2020, 5, 10), user, 1, false);
            incomeService.AddIncome(6, 40, new DateTime(2020, 7, 10), user, 1, false);
            incomeService.AddIncome(6, 20, new DateTime(2020, 8, 10), user, 1, false);
            incomeService.AddIncome(6, 300, new DateTime(2020, 10, 10), user, 1, false);

            ////////////////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Валентина Дунгьова");
            // общи части
            incomeService.AddIncome(7, 26, new DateTime(2020, 1, 10), user, 1, true);
            incomeService.AddIncome(7, 19.5m, new DateTime(2020, 5, 10), user, 1, true);
            incomeService.AddIncome(7, 6.5m, new DateTime(2020, 6, 10), user, 1, true);
            incomeService.AddIncome(7, 19.5m, new DateTime(2020, 9, 10), user, 1, true);
            incomeService.AddIncome(7, 6.5m, new DateTime(2020, 10, 10), user, 1, true);
            incomeService.AddIncome(7, 20, new DateTime(2021, 1, 13), user, 1, true);

            // за ремонт
            incomeService.AddIncome(7, 20, new DateTime(2020, 5, 10), user, 1, false);
            incomeService.AddIncome(7, 20, new DateTime(2020, 6, 10), user, 1, false);
            incomeService.AddIncome(7, 80, new DateTime(2020, 10, 10), user, 1, false);
            incomeService.AddIncome(7, 60, new DateTime(2021, 1, 13), user, 1, false);

            ////////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Албена Ангелова");
            // общи части
            for (int i = 1; i < 5; i++)
            {
                incomeService.AddIncome(8, 19.5m, new DateTime(2020, i, 10), user, 1, true);
            }
            for (int i = 5; i < 10; i++)
            {
                incomeService.AddIncome(8, 26, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(8, 20, new DateTime(2020, 10, 10), user, 1, true);
            incomeService.AddIncome(8, 38, new DateTime(2020, 11, 10), user, 1, true);
            incomeService.AddIncome(8, 26, new DateTime(2021, 1, 13), user, 1, true);
            incomeService.AddIncome(8, 27, new DateTime(2021, 2, 21), user, 1, true);
            incomeService.AddIncome(8, 27.5m, new DateTime(2021, 3, 14), user, 1, true);
            incomeService.AddIncome(8, 27, new DateTime(2021, 4, 28), user, 1, true);

            // за ремонт
            for (int i = 5; i < 10; i++)
            {
                incomeService.AddIncome(8, 20, new DateTime(2020, i, 10), user, 1, false);
            }
            incomeService.AddIncome(8, 300, new DateTime(2020, 10, 10), user, 1, false);

            /////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Калин Бошев");
            // общи части
            for (int i = 1; i < 9; i++)
            {
                incomeService.AddIncome(9, 13, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(9, 20, new DateTime(2020, 9, 10), user, 1, true);
            incomeService.AddIncome(9, 10, new DateTime(2020, 10, 10), user, 1, true);
            incomeService.AddIncome(9, 22, new DateTime(2020, 11, 10), user, 1, true);
            incomeService.AddIncome(9, 13, new DateTime(2021, 1, 12), user, 1, true);
            incomeService.AddIncome(9, 18, new DateTime(2021, 2, 21), user, 1, true);
            incomeService.AddIncome(9, 18, new DateTime(2021, 3, 14), user, 1, true);
            incomeService.AddIncome(9, 18, new DateTime(2021, 4, 28), user, 1, true);

            // за ремонт
            for (int i = 5; i < 10; i++)
            {
                incomeService.AddIncome(9, 20, new DateTime(2020, i, 10), user, 1, false);
            }
            incomeService.AddIncome(9, 60, new DateTime(2020, 10, 10), user, 1, false);
            incomeService.AddIncome(9, 40, new DateTime(2020, 11, 10), user, 1, false);
            incomeService.AddIncome(9, 20, new DateTime(2021, 2, 21), user, 1, false);
            incomeService.AddIncome(9, 20, new DateTime(2020, 4, 28), user, 1, false);

            ///////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "РДВР");
            // за ремонт
            incomeService.AddIncome(11, 150, new DateTime(2020, 10, 10), user, 1, false);

            /////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "---- Овчарова");
            // общи части
            for (int i = 1; i < 7; i++)
            {
                incomeService.AddIncome(12, 19.5m, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(12, 39, new DateTime(2020, 8, 10), user, 1, true);
            
            for (int i = 9; i < 13; i++)
            {
                incomeService.AddIncome(12, 6.5m, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(12, 6.5m, new DateTime(2021, 1, 29), user, 1, true);
            incomeService.AddIncome(12, 9, new DateTime(2021, 2, 26), user, 1, true);
            incomeService.AddIncome(12, 9, new DateTime(2021, 3, 26), user, 1, true);
            incomeService.AddIncome(12, 9, new DateTime(2021, 4, 27), user, 1, true);

            // за ремонт
            incomeService.AddIncome(12, 20, new DateTime(2020, 5, 10), user, 1, false);
            incomeService.AddIncome(12, 20, new DateTime(2020, 6, 10), user, 1, false);
            incomeService.AddIncome(12, 40, new DateTime(2020, 8, 10), user, 1, false);
            incomeService.AddIncome(12, 20, new DateTime(2020, 9, 10), user, 1, false);
            incomeService.AddIncome(12, 20, new DateTime(2020, 10, 10), user, 1, false);
            incomeService.AddIncome(12, 40, new DateTime(2020, 11, 10), user, 1, false);
            incomeService.AddIncome(12, 20, new DateTime(2021, 1, 29), user, 1, false);
            incomeService.AddIncome(12, 20, new DateTime(2021, 2, 26), user, 1, false);
            incomeService.AddIncome(12, 20, new DateTime(2021, 3, 26), user, 1, false);
            incomeService.AddIncome(12, 20, new DateTime(2021, 4, 27), user, 1, false);

            /////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Димо Лапчев");
            // общи части
            for (int i = 1; i < 10; i++)
            {
                incomeService.AddIncome(13, 13, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(13, 39, new DateTime(2020, 11, 10), user, 1, true);
            incomeService.AddIncome(13, 13, new DateTime(2021, 1, 10), user, 1, true);
            incomeService.AddIncome(13, 18, new DateTime(2021, 2, 21), user, 1, true);
            incomeService.AddIncome(13, 18, new DateTime(2021, 3, 14), user, 1, true);
            incomeService.AddIncome(13, 18, new DateTime(2021, 4, 28), user, 1, true);

            // за ремонт
            for (int i = 5; i < 10; i++)
            {
                incomeService.AddIncome(13, 20, new DateTime(2020, i, 10), user, 1, false);
            }
            
            incomeService.AddIncome(13, 300, new DateTime(2020, 10, 10), user, 1, false);
       
            ////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Ирина Панайотова");
            // общи части
            for (int i = 1; i < 13; i++)
            {
                incomeService.AddIncome(14, 13, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(14, 13, new DateTime(2021, 2, 3), user, 1, true);
            incomeService.AddIncome(14, 18, new DateTime(2021, 2, 21), user, 1, true);
            incomeService.AddIncome(14, 18, new DateTime(2021, 3, 31), user, 1, true);
            incomeService.AddIncome(14, 18, new DateTime(2021, 4, 28), user, 1, true);

            // за ремонт
            for (int i = 5; i < 13; i++)
            {
                incomeService.AddIncome(14, 20, new DateTime(2020, i, 10), user, 1, false);
            }
            incomeService.AddIncome(14, 20, new DateTime(2021, 2, 3), user, 1, false);
            incomeService.AddIncome(14, 20, new DateTime(2021, 2, 21), user, 1, false);
            incomeService.AddIncome(14, 20, new DateTime(2021, 3, 31), user, 1, false);
            incomeService.AddIncome(14, 20, new DateTime(2021, 4, 28), user, 1, false);

            //////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Атанас Бошев");
            // общи части
            for (int i = 1; i < 7; i++)
            {
                incomeService.AddIncome(15, 13, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(15, 26, new DateTime(2020, 8, 10), user, 1, true);
            incomeService.AddIncome(15, 52, new DateTime(2020, 11, 10), user, 1, true);
            incomeService.AddIncome(15, 20, new DateTime(2021, 1, 10), user, 1, true);
            incomeService.AddIncome(15, 27, new DateTime(2021, 2, 21), user, 1, true);
            incomeService.AddIncome(15, 26.5m, new DateTime(2021, 3, 14), user, 1, true);
            incomeService.AddIncome(15, 27, new DateTime(2021, 4, 28), user, 1, true);
            incomeService.AddIncome(15, 45, new DateTime(2021, 4, 29), user, 1, true);


            // за ремонт
            incomeService.AddIncome(15, 20, new DateTime(2020, 5, 10), user, 1, false);
            incomeService.AddIncome(15, 20, new DateTime(2020, 5, 10), user, 1, false);
            incomeService.AddIncome(15, 40, new DateTime(2020, 8, 10), user, 1, false);
            incomeService.AddIncome(15, 300, new DateTime(2020, 10, 10), user, 1, false);
            incomeService.AddIncome(15, 20, new DateTime(2021, 1, 10), user, 1, false);

            /////////////////////////////////////////////
            user = db.Users.FirstOrDefault(x => x.FullName == "Нана Милтиядова");
            // общи части
            for (int i = 1; i < 13; i++)
            {
                incomeService.AddIncome(16, 13, new DateTime(2020, i, 10), user, 1, true);
            }
            incomeService.AddIncome(16, 13, new DateTime(2021, 1, 18), user, 1, true);
            incomeService.AddIncome(16, 16, new DateTime(2021, 2, 12), user, 1, true);
            incomeService.AddIncome(16, 20, new DateTime(2021, 3, 24), user, 1, true);
            incomeService.AddIncome(16, 18, new DateTime(2021, 4, 20), user, 1, true);

            // за ремонт
            for (int i = 5; i < 13; i++)
            {
                incomeService.AddIncome(16, 20, new DateTime(2020, i, 10), user, 1, false);
            }
            incomeService.AddIncome(16, 20, new DateTime(2021, 1, 18), user, 1, false);
            incomeService.AddIncome(16, 20, new DateTime(2021, 2, 12), user, 1, false);
            incomeService.AddIncome(16, 20, new DateTime(2021, 3, 24), user, 1, false);
            incomeService.AddIncome(16, 20, new DateTime(2021, 4, 20), user, 1, false);
        }
    }
}
