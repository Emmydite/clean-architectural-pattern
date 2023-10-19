using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.WebApi.Models
{
    public class LineItemModel
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
