using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IRepository<T> where T : class
    { 
        Task<T> GetById(int id);
        Task<T> GetById(String id);
        Task<T> Find (Expression<Func<T,bool>> match);
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> criteria);
        Task<IEnumerable<T>> GetAllinclude(Expression<Func<T, object>> criteria);
        Task<IQueryable<T>> GetWhere(Expression<Func<T, bool>> criteria);

        Task<IEnumerable<T>> GetAll(String[]? includes = null , Expression<Func<T, object>>? orderBy = null, int? take = null, int? skip= null);

        
        Task<int> Count();
        Task<int> Count(Expression<Func<T, bool>> criteria);
        //Task<IQueryable<T>> Count(Expression<Func<T, bool>> criteria, Expression<Func<T, bool>> groupBy = null);
        // Task<IEnumerable<T>> Top();
        Task<T> Add(T entity);
        Task<object> Update(T entity);
        Task<T> Delete(T entity);
        

    }
}
