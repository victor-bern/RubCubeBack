using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RubCubeBack.Domain.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>>? predicate = null, int page = 1, int pageSize= 10, CancellationToken cancellationToken = default);
        Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
    }
}
