using BLL.IRepositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public abstract class BaseRepo<T>:IBaseRepo<T> where T :  class 
    {
        protected SmartContext _Context { set; get; }
        private DbSet<T> table ;
        protected DbSet<T> DbSet 
        {
            get => table ?? (table = _Context.Set<T>());
        }
        public BaseRepo(SmartContext context)
        {
            _Context = context;
            table = context.Set<T>();
        }

        public async  Task<List<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async  Task<T> GetByID(int ID)
        {
            return await table.FindAsync(ID);
        }

        public async  Task<List<T>> GetByCondition(Expression<Func<T, bool>> condition)
        {
            return await table.Where(condition).ToListAsync();
        }

        public async  Task<IEnumerable<T>> GetIncluded(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> order = null, string includeproperties = "")
        {
            IQueryable<T> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeproperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (order != null)
            {
                return await  order(query).ToListAsync();
            }
            else
            {
                return await  query.ToListAsync();
            }
        }

        public void  Create(T Entity)
        {
            table.AddAsync(Entity);
        }

        public void  Update(T Entity)
        {
            table.Update(Entity);
        }

        public void  Delete(T Entity)
        {
            table.Remove(Entity);
        }
    }
}
