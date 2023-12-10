//using Core.Repository;
//using Microsoft.EntityFrameworkCore;
//using Services;
//using System.Linq.Expressions;

//namespace Repository
//{
//    public class Repository<T> : IRepository<T> where T : class
//    {
//        private readonly ApplicationDbContext _context;

//        public Repository(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public Task<bool> Add(T entity)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<int> Count()
//        {
//            return await  _context.Set<T>().Distinct().CountAsync();
//        }

//        public async Task<int> Count(Expression<Func<T, bool>> criteria)
//        {
//            return await _context.Set<T>().Distinct().CountAsync(criteria);
//        }

//        //public Task<bool> Delete(int id)
//        //{

//        //}

//        public async Task<IEnumerable<T>> GetAll()
//        {
//            return await _context.Set<T>().ToListAsync();
//        }

//        public async Task<T> GetById(int id)
//        {
//            return await _context.Set<T>().FindAsync(id);
//        }

//        //public Task<bool> Update(T entity)
//        //{
//        //    throw new NotImplementedException();
//        //}

//        //Task<int> IRepository<T>.Count()
//        //{
//        //    throw new NotImplementedException();
//        //}



//        //public async Task<IEnumerable<T>> Top()
//        //{
//        //    throw new NotImplementedException();
//        //}
//    }
//}