namespace Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Property
    {
        public Property()
        {
            this.Residents = new HashSet<ApplicationUser>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int PropertyTypeId { get; set; }

        public PropertyType PropertyType { get; set; }

        [Required]
        public bool Lift { get; set; }

        [MaxLength(2)]
        public int ResidentsCount { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }

        public virtual ICollection<ApplicationUser> Residents { get; set; }
    }
}