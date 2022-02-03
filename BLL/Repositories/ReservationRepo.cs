using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class ReservationRepo : BaseRepo<Reservation>, IReservationRepo
    {
        private readonly SmartContext _context;
        public ReservationRepo(SmartContext context) : base(context)
        {
            this._Context = context;
        }
    }
}
