namespace Services.Contracts
{
    using System;

    public interface IUserService
    {
        void AddNewUser(string userName, string firstName, string lastName, string email, string password);
    }
}
