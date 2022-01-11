using BLL.IRepositories;
using BLL.Repo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class RepoWrapper : IRepoWrapper
    {
        SmartContext _Context;
        public RepoWrapper(SmartContext context)
        {
            _Context = context;
        }


        public async Task<List<T>> GetOracle<T>(string squery, Dictionary<string, object> para = null, int type = 0)
        {
            return await TestQuery.GetOracle<T>(squery, para, type);
        }

        public async  Task<List<T>> GetSql<T>(string squery, Dictionary<string, object> para = null, int type = 0)
        {
            return await TestQuery.GetSql<T>(squery, para, type);
        }

        public void Save()
        {
            try 
            {
                _Context.SaveChangesAsync();
            }
            catch(Exception ex) 
            {
                _Context.SaveChanges();
            }
        }
    }
}
