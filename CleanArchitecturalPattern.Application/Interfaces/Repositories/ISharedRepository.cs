using System;

namespace CleanArchitecturalPattern.Application.Interfaces.Repositories
{
    public interface ISharedRepository<T> where T : class
    {
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<int> SaveChanges();
    }
}
