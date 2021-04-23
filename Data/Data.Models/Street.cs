namespace Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Street
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}