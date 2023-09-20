﻿using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.WebApi.Models
{
    public class CustomerModel
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
    }
}
