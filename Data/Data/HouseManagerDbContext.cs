﻿namespace Data
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using Data.Common.Models;
    using Data.Models;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class HouseManagerDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
                typeof(HouseManagerDbContext).GetMethod(
                    nameof(SetIsDeletedQueryFilter),
                    BindingFlags.NonPublic | BindingFlags.Static);

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

        public DbSet<ExpensType> ExpensesTypes { get; set; }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
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

            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            this.ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        // Applies configurations
        private void ConfigureUserIdentityRelations(ModelBuilder builder)
             => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
