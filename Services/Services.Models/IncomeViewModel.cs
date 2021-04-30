﻿namespace Services.Models
{
    using System;
    using Data.Models;

    public class IncomeViewModel
    {
        public int Id { get; set; }

        public int PropertyId { get; set; }

        public Property Property { get; set; }

        public decimal Price { get; set; }

        public DateTime Date { get; set; }

        public string ResidentId { get; set; }

        public ApplicationUser Resident { get; set; }
    }
}
