using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PcrType
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Description { set; get; }
        public ICollection<LabPcrType> labPCRTypes { set; get; }
    }
}
