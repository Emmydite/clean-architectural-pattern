﻿using CleanArchitecturalPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Application.Interfaces.Repositories
{
    public interface ICustomerRepository : ISharedRepository<Customer>
    {

    }
}
