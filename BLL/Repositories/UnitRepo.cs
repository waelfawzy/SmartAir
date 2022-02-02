using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UnitRepo : BaseRepo<Unit>, IUnitRepo
    {
        private readonly SmartContext _context;
        public UnitRepo(SmartContext context) : base(context)
        {
           this. _context = context;
        }
    }
}
