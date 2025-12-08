using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabase.Model
{
    public class product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }

        public ICollection<sale> Sales { get; set; } = new HashSet<sale>();
        public string Description { get; set; }

    }
}
