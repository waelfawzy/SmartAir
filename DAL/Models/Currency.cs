using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Currency
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal AppValue { set; get; }
        public DateTime InsertionDate { set; get; } = DateTime.Now;
        public bool Active { set; get; }



    }
}
