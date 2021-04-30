namespace Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using Data.Models;
    using Services.Models;

    public interface IIncomeService
    {
        void AddIncome(int properyId, decimal price, DateTime date, ApplicationUser resident, int addressId, bool isRegular);

        ICollection<IncomeViewModel> GetAllIncomeForPropery(int properyId, bool isRegular);

        void EditMounthProperyIncome(int propertyID, int month, int year, decimal newPrice, bool isRegular);
    }
}
