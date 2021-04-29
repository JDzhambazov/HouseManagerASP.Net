namespace Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Services.Contracts;

    public class FeeService : IFeeService
    {
        private readonly HouseManagerDbContext db;

        public FeeService(HouseManagerDbContext db)
        {
            this.db = db;
        }

        public void AddFeeToAddress(int addressId, string feeName, decimal cost, bool isPersonel, bool isRegular)
        {
            var currentFee = this.db.FeeTypes.FirstOrDefault(x => x.Name.ToUpper() == feeName.ToUpper())
                ?? new FeeType { Name = feeName };
            var address = this.db.Addresses.FirstOrDefault(x => x.Id == addressId);

            this.db.MonthlyFees.Add(new MonthFee
            {
                Address = address,
                FeeType = currentFee,
                Cost = cost,
                IsPersonal = isPersonel,
                IsRegular = isRegular,
            });
            this.db.SaveChanges();
        }

        public void AddFeeToProperty(ICollection<int> propertiesId, string feeName)
        {
            var properties = this.db.Properties.Where(x => propertiesId.Contains(x.Id)).ToList();
            var currentFee = this.db.MonthlyFees.FirstOrDefault(x => x.FeeType.Name == feeName);
            foreach (var property in properties)
            {
                property.MonthFees.Add(currentFee);
            }

            this.db.SaveChanges();
        }

        public ICollection<MonthFee> GetAllFees(int id)
        {
            var fees = this.db.MonthlyFees
                .Include(x => x.Address)
                .Include(f => f.FeeType)
                .Where(x => x.AddressId == id)
                .ToList();
            return fees;
        }
    }
}
