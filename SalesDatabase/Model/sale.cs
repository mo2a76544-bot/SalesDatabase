using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabase.Model
{
    public class sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }

        public int ProductId { get; set; }
        public product Product { get; set; }

        public int CustomerId { get; set; }
        public customer Customer { get; set; }

        public int StoreId { get; set; }
        public store Store { get; set; }
    }
}
