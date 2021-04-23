namespace Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Address
    {
        public Address()
        {
            this.Properties = new HashSet<Property>();
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

        public int ManagerId { get; set; }

        public ApplicationUser Manager { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}
