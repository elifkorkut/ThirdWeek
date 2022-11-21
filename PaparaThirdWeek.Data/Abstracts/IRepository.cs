using System;
using System.Linq;
using System.Linq.Expressions;

namespace PaparaThirdWeek.Data.Abstracts
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Get();
        IQueryable<T> GetAll(Expression<Func<T,bool>> expression=null);
        void GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void HardRemove(T entity);
        
    }
}
