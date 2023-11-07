namespace CleanArchitecturalPattern.WebApi.Models
{
    public class PaymentModel
    {
        public Guid CustomerId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
    }
}
