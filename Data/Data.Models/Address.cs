namespace Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Address
    {
        public Address()
        {
            this.Properties = new HashSet<Property>();
            this.Expenses = new HashSet<Expens>();
            this.Incomes = new HashSet<Income>();
        }

        public int Id { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public int? DistrictId { get; set; }

        public District District { get; set; }

        public int? StreetId { get; set; }

        public Street Street { get; set; }

        [Required]
        public string Number { get; set; }

        public string Entrance { get; set; }

        public int NumberOfProperties { get; set; }

        public string ManagerId { get; set; }

        [InverseProperty(nameof(ApplicationUser.Managers))]
        public ApplicationUser Manager { get; set; }

        public string PaymasterId { get; set; }

        [InverseProperty(nameof(ApplicationUser.Paymasters))]
        public ApplicationUser Paymaster { get; set; }

        public virtual ICollection<Property> Properties { get; set; }

        public virtual ICollection<Income> Incomes { get; set; }

        public virtual ICollection<Expens> Expenses { get; set; }

        public ICollection<МonthlyТaxe> МonthlyТaxes { get; set; }
    }
}
