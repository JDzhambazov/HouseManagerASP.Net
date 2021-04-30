﻿namespace Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using Services.Contracts;
    using Services.Models;

    public class IncomeService : IIncomeService
    {
        private readonly HouseManagerDbContext db;

        public IncomeService(HouseManagerDbContext db)
        {
            this.db = db;
        }

        public void AddIncome(int? properyId, decimal price, DateTime date, ApplicationUser resident, int addressId, bool isRegular)
        {
            if (isRegular)
            {
                this.db.RegularIncomes.Add(new RegularIncome
                {
                    PropertyId = properyId,
                    Date = date,
                    Price = price,
                    Resident = resident,
                    AddressId = addressId,
                });
            }
            else
            {
                this.db.NotRegularIncomes.Add(new NotRegularIncome
                {
                    PropertyId = properyId,
                    Date = date,
                    Price = price,
                    Resident = resident,
                    AddressId = addressId,
                });
            }

            this.db.SaveChanges();
        }

        public void EditMounthProperyIncome(int propertyId, int month, int year, decimal newPrice, bool isRegular)
        {
            if (isRegular)
            {
                var currentIncome = this.db.RegularIncomes
                    .FirstOrDefault(x => x.PropertyId == propertyId && x.Date.Month == month && x.Date.Year == year);
                currentIncome.Price = newPrice;
                this.db.SaveChanges();
            }
            else
            {
                var currentIncome = this.db.NotRegularIncomes
                    .FirstOrDefault(x => x.PropertyId == propertyId && x.Date.Month == month && x.Date.Year == year);
                currentIncome.Price = newPrice;
                this.db.SaveChanges();
            }
        }

        public ICollection<IncomeViewModel> GetAllIncomeForPropery(int propertyId, bool isRegular)
        {
            if (isRegular)
            {
                return this.db.RegularIncomes
                    .Where(x => x.Id == propertyId)
                    .Select(x => new IncomeViewModel
                    {
                        PropertyId = x.PropertyId,
                        Property = x.Property,
                        Date = x.Date,
                        Price = x.Price,
                        Resident = x.Resident,
                        ResidentId = x.ResidentId,
                    })
                    .ToList();
            }
            else
            {
                return this.db.NotRegularIncomes
                    .Where(x => x.Id == propertyId)
                    .Select(x => new IncomeViewModel
                    {
                        PropertyId = x.PropertyId,
                        Property = x.Property,
                        Date = x.Date,
                        Price = x.Price,
                        Resident = x.Resident,
                        ResidentId = x.ResidentId,
                    })
                    .ToList();
            }
        }
    }
}
