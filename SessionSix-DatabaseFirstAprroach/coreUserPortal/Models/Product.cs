using System;
using System.Collections.Generic;

#nullable disable

namespace coreUserPortal.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public string ProductDesc { get; set; }
        public DateTime? ProductAddedDate { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public int? ProductAvailability { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}
