﻿namespace Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MonthFee
    {
        public int Id { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }

        public int NameId { get; set; }

        public FeeType Name { get; set; }

        [MaxLength(6)]
        public decimal Cost { get; set; }

        public bool IsPersonal { get; set; }

        public bool IsRegular { get; set; }
    }
}
