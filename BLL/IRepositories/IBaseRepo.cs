using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepositories
{
    public interface IBaseRepo<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetByID(int ID);
        Task<List<T>> GetByCondition(Expression<Func<T, bool>> condition);
        Task<IEnumerable<T>> GetIncluded(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> order = null, string includeproperties = "");
        void  Create(T Entity);
        void  Update(T Entity);
        void  Delete(T Entity);
    }
}
