namespace Services
{
    using System;
    using System.Linq;
    using Data;
    using Data.Models;
    using Services.Contracts;

    public class ExpensService : IExpensService
    {
        private readonly HouseManagerDbContext db;

        public ExpensService(HouseManagerDbContext db)
        {
            this.db = db;
        }

        public void AddExpens(string expensType, decimal price, DateTime date, bool isRegular, int addressId)
        {
            this.db.Expens.Add(new Expens
            {
                ExpenseType = db.ExpensesTypes.FirstOrDefault(x => x.Name == expensType)
                ?? new ExpensType { Name = expensType },
                Price = price,
                DateOfPayment = date,
                AddressId = addressId,
                IsRegular = isRegular,
            });
            this.db.SaveChanges();
        }
    }
}
