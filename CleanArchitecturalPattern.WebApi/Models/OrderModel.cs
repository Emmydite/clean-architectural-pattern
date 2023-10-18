namespace CleanArchitecturalPattern.WebApi.Models
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }
    }
}
