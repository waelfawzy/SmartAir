using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Unit
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public ICollection <ProductUnits> productUnits { set; get; }
    }
}
