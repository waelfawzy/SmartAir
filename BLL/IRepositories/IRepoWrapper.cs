using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepositories
{
    public  interface IRepoWrapper
    {
        public   Task<List<T>> GetOracle<T>(string squery, Dictionary<string, object> para = null, int type = 0);
        public   Task<List<T>> GetSql<T>(string squery, Dictionary<string, object> para = null, int type = 0);
        void Save();
    }
}
