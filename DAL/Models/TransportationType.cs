using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TransportationType
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public ICollection<Transportation> transportations { set; get; }

    }
}
