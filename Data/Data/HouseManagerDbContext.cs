namespace Data
{
    using Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class HouseManagerDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public HouseManagerDbContext()
        {
        }

        public HouseManagerDbContext(DbContextOptions<HouseManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Street> Streets { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyType> PropertiesTypes { get; set; }

        public DbSet<Expens> Expens { get; set; }

        public DbSet<MonthFee> MonthlyFees { get; set; }

        public DbSet<RegularIncome> RegularIncomes { get; set; }

        public DbSet<NotRegularIncome> NotRegularIncomes { get; set; }

        public DbSet<RegularDueAmount> RegularDueAmounts { get; set; }

        public DbSet<NotRegularDueAmount> NotRegularDueAmounts { get; set; }

        public DbSet<FeeType> FeeTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=HouseManager;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MonthFee>()
                .HasOne(x => x.Address)
                .WithMany(x => x.MonthlyFees)
                .HasForeignKey(x => x.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RegularIncome>()
                .HasOne(x => x.Address)
                .WithMany(x => x.RegularIncomes)
                .HasForeignKey(x => x.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<NotRegularIncome>()
                .HasOne(x => x.Address)
                .WithMany(x => x.NotRegularIncomes)
                .HasForeignKey(x => x.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(builder);
        }
    }
}
