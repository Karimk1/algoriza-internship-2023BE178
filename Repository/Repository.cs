using Core.Models;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using Services;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbset;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public  async Task<T> Add(T entity)
        {
            await _dbset.AddAsync(entity);
            return entity;
        } 
        public async Task<int> Count()
        {
            return await  _dbset.CountAsync();
        }
        public async Task<int> Count(Expression<Func<T, bool>> criteria)
        {
            return await  _dbset.CountAsync(criteria);
        }

        public async Task<T> Find(Expression<Func<T, bool>> match)
        {
            return await _dbset.SingleOrDefaultAsync(match);
        }


        public async Task<IEnumerable<T>> GetAll(String[] i , Expression<Func<T, bool>> criteria = null)
        {
            IQueryable<T> q =  _dbset;

            if (i != null) 
                foreach (var item in i) 
                    q = q.Include(item);
            return  q;
        }

         public async Task<IEnumerable<T>> GetAllinclude(Expression<Func<T, object>> criteria)
        {
             
            return _dbset.Include(criteria) ;
        }
        public async Task<IEnumerable<T>> GetAll(String[]? includes = null,
            Expression<Func<T, object>>? orderBy = null,
            int? take = null,
            int? skip = null)
        {
            IQueryable<T> q = _dbset;
            
            if (take.HasValue)
            {
                q = q.Take(take.Value);
            }
            if (skip.HasValue)
            {
                q = q.Skip(skip.Value);
            }
            if (orderBy != null)
            {
                q = q.OrderByDescending(orderBy);
            }

            return await q.ToListAsync();
            
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> criteria)
        {
            IQueryable<T> q = _dbset;
            if(criteria != null)
            {
                q = q.Where(criteria);
            }
            return await q.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task<T> GetById(string id)
        {
            var a = await _dbset.FindAsync(id);
            if (a != null)
            {
                return a;
            }
            return null;
        }

        

        public async Task<object> Update(T entity)
        {
            var q =  _dbset.Entry(entity).State =  EntityState.Modified;

            return  q;
        }
        
        public async Task<T> Delete(T entity)
        {
            var d = await _dbset.FirstOrDefaultAsync();
            _dbset.Remove(entity);
            return entity;
        }

        public async Task<IQueryable<T>> GetWhere(Expression<Func<T, bool>> criteria)
        {
            var q =  _dbset.Where(criteria);
            return q;
        }
    }
}