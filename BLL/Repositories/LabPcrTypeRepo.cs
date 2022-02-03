using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class LabPcrTypeRepo : BaseRepo<LabPcrType>, ILabPcrTypeRepo
    {
        private readonly SmartContext _context;
        public LabPcrTypeRepo(SmartContext context) : base(context)
        {
            this._Context = context;
        }
    }
}
