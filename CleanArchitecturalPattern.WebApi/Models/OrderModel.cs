namespace CleanArchitecturalPattern.WebApi.Models
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? OrderShippedDate { get; set; }
        public int Status { get; set; }
    }
}
