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
        private ExpensService expensService;

        public Seeder(HouseManagerDbContext dbContext)
        {
            this.db = dbContext;
            this.propertyService = new PropertyService(db);
            this.addressService = new AddressService(db);
            this.feeService = new FeeService(db);
            this.userService = new UserService(db);
            this.amountService = new DueAmountService(db);
            this.incomeService = new IncomeService(db);
            this.expensService = new ExpensService(db);
            
        }

        public void Seed()
        {
            // SeedUsers();
            // SeedAddress();
            // SeedProperties();
            // SeedFees();
            // SeedDueAmounts();
            // SeedIncome();
            // SeedExpenses();
        }

    }
}
