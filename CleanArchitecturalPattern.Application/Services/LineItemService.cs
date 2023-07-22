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

        public async Task<LineItem> AddLineItem(LineItem lineItem)
        {
            try
            {
               await _lineItemRepository.AddAsync(lineItem);
                await _lineItemRepository.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
