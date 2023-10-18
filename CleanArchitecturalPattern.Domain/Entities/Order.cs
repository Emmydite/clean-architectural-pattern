using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Domain.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? OrderShippedDate { get; set; }
        public int Status { get; set; }
        public List<LineItem> Items { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {
            Items = new List<LineItem>();
            OrderDate = DateTime.Now;
        }
    }
}
