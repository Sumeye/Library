﻿using System.Linq.Expressions;

namespace Library.Core.Service
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
