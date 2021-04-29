namespace Services.Contracts
{
    using System.Collections.Generic;
    using Data.Models;

    public interface IFeeService
    {
        void AddFeeToAddress(int addressId, string feeName, decimal cost, bool isPersonel, bool isRegular);

        void AddFeeToProperty(ICollection<int> propertiesId, string feeName);

        ICollection<MonthFee> GetAllFees(int addressId);
    }
}
