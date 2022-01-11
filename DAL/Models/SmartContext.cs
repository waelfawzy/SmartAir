using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SmartContext:DbContext
    {
        public SmartContext()
        {

        }
        public SmartContext(DbContextOptions<SmartContext> options) : base(options) { }
    }
}
