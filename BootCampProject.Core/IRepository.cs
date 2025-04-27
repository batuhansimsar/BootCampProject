using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BootCampProject.Core
{
    public interface IRepository<T> where T : IEntity
    {
        T Get(Expression<Func<T, bool>> predicate);
        IList<T> GetList(Expression<Func<T, bool>> predicate = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
