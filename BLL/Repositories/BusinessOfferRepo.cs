using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BusinessOfferRepo : BaseRepo<BusinessOffer>, IBusinessOfferRepo
    {
        private readonly SmartContext _context;
        public BusinessOfferRepo(SmartContext context) : base(context)
        {
            this._Context = context;
        }
    }
}
