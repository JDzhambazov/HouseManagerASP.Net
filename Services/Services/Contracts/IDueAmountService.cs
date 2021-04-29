namespace Services.Contracts
{
    public interface IDueAmountService
    {
        void AddMounthDueAmountInProperies(int propertyId, int month, int year);

        void AddMounthDueAmountInAllProperies(int addressId);

        void EditMountDueAmount(int month, int year, int propertyId, decimal cost, bool isRegular);

        (decimal RegularDueAmount, decimal NotRegularDueAmount) GetPropertyMountDueAmount(int propertyId);
    }
}
