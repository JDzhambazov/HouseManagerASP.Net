namespace Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MounthAmountViewModel
    {
        public string PropertyName { get; set; }

        public string ResidentName { get; set; }

        public int ResidentsCount { get; set; }

        public decimal RegularDueAmount { get; set; }

        public decimal NotRegularDueAmount { get; set; }
    }
}
