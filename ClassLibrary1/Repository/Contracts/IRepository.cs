using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository.Contracts
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T FirstBy(Expression<Func<T, bool>> predicate);
        void Add(T obj);
        void Delete(T obj);
        void SaveOrUpdate(T obj);
    }
}
