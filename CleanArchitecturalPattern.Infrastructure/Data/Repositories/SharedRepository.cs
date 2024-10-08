﻿using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Infrastructure.Data.Repositories
{
    public class SharedRepository<TEntity> : ISharedRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _appDbContext;
        private DbSet<TEntity> _entities;
        public SharedRepository(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
            _entities = appDbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public async Task<int> SaveChanges()
        {
           return await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _entities.FindAsync(id);
        }
    }
}
