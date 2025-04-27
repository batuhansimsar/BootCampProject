using BootCampProject.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BootCampProject.Repositories
{
    public class EfRepositoryBase<T> : IRepository<T>, IAsyncRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _context;

        public EfRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public IList<T> GetList(Expression<Func<T, bool>>? predicate = null)
        {
            return predicate == null
                ? _context.Set<T>().ToList()
                : _context.Set<T>().Where(predicate).ToList();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<IList<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null)
        {
            return predicate == null
                ? await _context.Set<T>().ToListAsync()
                : await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
