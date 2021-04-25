namespace Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Expens
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(10)]
        public decimal Price { get; set; }

        public DateTime DateOfPayment { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }
    }
}