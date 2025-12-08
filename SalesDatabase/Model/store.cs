using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabase.Model
{
    public class store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }

        public ICollection<sale> Sales { get; set; } = new HashSet<sale>();
    }
}
