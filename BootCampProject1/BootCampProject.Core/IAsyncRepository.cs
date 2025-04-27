using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BootCampProject.Core
{
    public interface IAsyncRepository<T> where T : IEntity
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IList<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
