﻿namespace Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RegularDueAmount
    {
        public int Id { get; set; }

        [MaxLength(2)]
        public int Month { get; set; }

        [MaxLength(4)]
        public int Year { get; set; }

        [MaxLength(6)]
        [Range(0, double.MaxValue)]
        public decimal Cost { get; set; }

        public int PropertyId { get; set; }

        public Property Property { get; set; }
    }
}
