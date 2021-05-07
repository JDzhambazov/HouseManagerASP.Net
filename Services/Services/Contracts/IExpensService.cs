namespace Services.Contracts
{
    using System;
    using Data.Models;

    public interface IExpensService
    {
        void AddExpens(string expensType, decimal price, DateTime date, bool isRegular, int addressId);
    }
}
