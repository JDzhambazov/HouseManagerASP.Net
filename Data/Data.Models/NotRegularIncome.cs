namespace Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class NotRegularIncome
    {
        public int Id { get; set; }

        public int PropertyId { get; set; }

        public Property Property { get; set; }

        [MaxLength(6)]
        public decimal Price { get; set; }

        public DateTime Date { get; set; }

        public string ResidentId { get; set; }

        public ApplicationUser Resident { get; set; }
    }
}
