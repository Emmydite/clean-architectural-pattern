﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Application.DTOs
{
    public class CustomerPaymentsDto
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
    }
}
