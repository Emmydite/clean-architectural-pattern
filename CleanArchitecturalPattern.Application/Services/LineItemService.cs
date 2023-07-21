using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Application.Services
{
    public class LineItemService : ILineItemService
    {
        private readonly ILineItemRepository _lineItemRepository;
        public LineItemService(ILineItemRepository lineItemRepository)
        {
            _lineItemRepository = lineItemRepository;
        }

        public Task<LineItem> AddLineItem(LineItem lineItem)
        {
            try
            {

            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
