using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabase.Model
{
    public class customer
    {
        public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; } // not unicode
    public string CreditCardNumber { get; set; }

    public ICollection<sale> Sales { get; set; } = new HashSet<sale>();
    }
}
