using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class PlaneRepo : BaseRepo<DAL.Models.Plane>,IPlaneRepo
    {
        private readonly SmartContext _context;
        public PlaneRepo(SmartContext context) : base(context)
        {
            this._Context = context;
        }
    }
}
