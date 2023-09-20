using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.WebApi.Models
{
    public class CustomerModel
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string Postcode { get; set; }
        public string? City { get; set; }
    }
}
