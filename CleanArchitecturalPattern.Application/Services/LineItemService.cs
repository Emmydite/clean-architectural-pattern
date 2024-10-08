﻿using CleanArchitecturalPattern.Application.Interfaces.Services;
using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using CleanArchitecturalPattern.Domain.Entities;

namespace CleanArchitecturalPattern.Application.Services
{
    public class LineItemService : ILineItemService
    {
        private readonly ILineItemRepository _lineItemRepository;
        public LineItemService(ILineItemRepository lineItemRepository)
        {
            _lineItemRepository = lineItemRepository;
        }

        public async Task<int> AddLineItem(LineItem lineItem)
        {
            try
            {
                await _lineItemRepository.AddAsync(lineItem);
                var result = await _lineItemRepository.SaveChanges();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteLineItem(Guid id)
        {
            try
            {
                var lineItem = _lineItemRepository.GetByIdAsync(id)
                                                  .GetAwaiter()
                                                  .GetResult();

                if (lineItem != null)
                {
                    _lineItemRepository.Delete(lineItem);
                    _lineItemRepository.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public async Task<bool> UpdateLineItem(LineItem lineItem)
        {
            try
            {
                _lineItemRepository.Update(lineItem);
                var result = await _lineItemRepository.SaveChanges();

                return result == 1;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<LineItem> GetLineItem(Guid id)
        {
            try
            {
                var lineItem = await _lineItemRepository.GetByIdAsync(id);

                return lineItem;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
