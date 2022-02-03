using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class ReservationTypeRepo : BaseRepo<ReservationType>, IReservationTypeRepo
    {
        private readonly SmartContext _context;
        public ReservationTypeRepo(SmartContext context) : base(context)
        {
            this._Context = context;
        }
    }
}
