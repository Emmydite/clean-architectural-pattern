using CleanArchitecturalPattern.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecturalPattern.Infrastructure.Data.Repositories
{
    public class SharedRepository<TEntity> : ISharedRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _appDbContext;
        private DbSet<TEntity> _entities;
        public SharedRepository(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
            _entities = appDbContext.Set<TEntity>();
        }

        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
