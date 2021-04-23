namespace Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class District
    {
        public District()
        {
            this.Address = new HashSet<Address>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Address> Address { get; set; }
    }
}