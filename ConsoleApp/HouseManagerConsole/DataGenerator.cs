namespace HouseManagerConsole
{
    using System;
    using Data;
    using Data.Models;

    public class DataGenerator
    {
        private HouseManagerDbContext db;

        public DataGenerator(HouseManagerDbContext db)
        {
            this.db = db;
        }

        public void AddAddress()
        {
            this.db.Addresses.Add(new Address
            {
                City = new City { Name = "Бургас" },
                District = new District { Name = "Лазур" },
                Number = "88",
                Entrance = "Б",
                NumberOfProperties = 16,
            });
            this.db.SaveChanges();
        }

        public void AddProperties(Address address, PropertyType propertyType)
        {
            for (int i = 0; i < address.NumberOfProperties; i++)
            {
                this.db.Properties.Add(new Property
                {
                    Name = (17 + i).ToString(),
                    Address = address,
                    PropertyType = propertyType,
                });
                this.db.SaveChanges();
            }
        }
    }
}
