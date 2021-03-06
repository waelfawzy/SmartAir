using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserBusnessOffersRepo:BaseRepo<UserBusnessOffers>, IUserBusnessOffersRepo
    {
        private readonly SmartContext _context;

        public UserBusnessOffersRepo(SmartContext context) : base(context)
        {
            this._context = context;
        }
    }
}
