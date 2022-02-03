using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class PaymentTypeRepo : BaseRepo<PaymentType>, IPaymentTypeRepo
    {
        private readonly SmartContext _context;
        public PaymentTypeRepo(SmartContext context) : base(context)
        {
            this._Context = context;
        }
    }
}
