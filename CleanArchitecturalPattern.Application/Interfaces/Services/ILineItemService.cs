﻿using CleanArchitecturalPattern.Domain.Entities;
using System;

namespace CleanArchitecturalPattern.Application.Interfaces.Services
{
    public interface ILineItemService
    {
        LineItem AddLineItem(LineItem lineItem);
    }
}
