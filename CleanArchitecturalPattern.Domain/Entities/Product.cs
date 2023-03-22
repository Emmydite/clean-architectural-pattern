using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductSKU { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

    }
}
