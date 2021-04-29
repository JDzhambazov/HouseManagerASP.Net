namespace Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using Services.Contracts;

    public class DueAmountService : IDueAmountService
    {
        private readonly HouseManagerDbContext db;

        public DueAmountService(HouseManagerDbContext db)
        {
            this.db = db;
        }

        public void AddMounthDueAmountInProperies(int propertyId, int month, int year)
        {
            var property = this.db.Properties.FirstOrDefault(x => x.Id == propertyId);
            this.AddDueAmount(month, year, property);
        }

        public void AddMounthDueAmountInAllProperies(int addressId)
        {
            var propertyService = new PropertyService(this.db);
            var properties = this.db.Properties.Where(x => x.AddressId == addressId).ToList();
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;

            foreach (var property in properties)
            {
                this.AddDueAmount(month, year, property);

                // var dueAmount = propertyService.CalculateDueAmount(property.Id);
                // this.db.RegularDueAmounts.Add(new RegularDueAmount
                // {
                //     Year = year,
                //     Month = month,
                //     Cost = dueAmount.RegularDueAmount,
                //     PropertyId = property.Id,
                // });
                // this.db.NotRegularDueAmounts.Add(new NotRegularDueAmount
                // {
                //     Year = year,
                //     Month = month,
                //     Cost = dueAmount.NotRegularDueAmount,
                //     PropertyId = property.Id,
                // });
                // this.db.SaveChanges();
            }
        }

        public void EditMountDueAmount(int month, int year, int propertyId, decimal cost, bool isRegular)
        {
            if (isRegular)
            {
                var currentAmount = this.db.RegularDueAmounts
                    .Where(x => x.Month == month && x.Year == year && x.PropertyId == propertyId)
                    .FirstOrDefault();
                currentAmount.Cost = cost;
            }
            else
            {
                var currentAmount = this.db.NotRegularDueAmounts
                    .Where(x => x.Month == month && x.Year == year && x.PropertyId == propertyId)
                    .FirstOrDefault();
                currentAmount.Cost = cost;
            }

            this.db.SaveChanges();
        }

        public (decimal RegularDueAmount, decimal NotRegularDueAmount) GetPropertyMountDueAmount(int propertyId)
        {
            var regularDueAmount = this.db.RegularDueAmounts
                .Where(x => x.PropertyId == propertyId)
                .Sum(x => x.Cost) - this.db.RegularIncomes
                .Where(x => x.PropertyId == propertyId)
                .Sum(x => x.Price);

            var notRegularDueAmount = this.db.NotRegularDueAmounts
                .Where(x => x.PropertyId == propertyId)
                .Sum(x => x.Cost) - this.db.NotRegularIncomes
                .Where(x => x.PropertyId == propertyId)
                .Sum(x => x.Price);

            return (regularDueAmount > 0 ? regularDueAmount : 0, notRegularDueAmount > 0 ? notRegularDueAmount : 0);
        }

        private void AddDueAmount(int month, int year, Property property)
        {
            var propertyService = new PropertyService(this.db);
            var dueAmount = propertyService.CalculateDueAmount(property.Id);
            this.db.RegularDueAmounts.Add(new RegularDueAmount
            {
                Year = year,
                Month = month,
                Cost = dueAmount.RegularDueAmount,
                PropertyId = property.Id,
            });

            this.db.NotRegularDueAmounts.Add(new NotRegularDueAmount
            {
                Year = year,
                Month = month,
                Cost = dueAmount.NotRegularDueAmount,
                PropertyId = property.Id,
            });

            this.db.SaveChanges();
        }
    }
}
