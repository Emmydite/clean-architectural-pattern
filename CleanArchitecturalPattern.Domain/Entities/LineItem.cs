using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Domain.Entities
{
    public class LineItem
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public Product product { get; set; }
        public virtual Order Order { get; set; }
        public decimal TotalPrice()
        {
            return product.Price * Quantity;
        }
    }
}
