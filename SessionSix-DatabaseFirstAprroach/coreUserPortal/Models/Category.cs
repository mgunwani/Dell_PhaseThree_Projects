using System;
using System.Collections.Generic;

#nullable disable

namespace coreUserPortal.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public DateTime? CategoryAddedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
