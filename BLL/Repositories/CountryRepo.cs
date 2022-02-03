using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class CountryRepo : BaseRepo<Country>, ICountryRepo
    {
        private readonly SmartContext _context;
        public CountryRepo(SmartContext context) : base(context)
        {
            this._Context = context;
        }
    }
}
