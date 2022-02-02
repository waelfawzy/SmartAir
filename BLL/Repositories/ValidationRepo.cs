using BLL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace BLL.Repositories
{
    public class ValidationRepo :  BaseRepo<Validation>,IValidationRepo
    {
        private readonly SmartContext _context;


        public ValidationRepo(SmartContext context) : base(context)
        {
            this._context = context;
        }
        }
    }
