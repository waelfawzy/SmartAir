using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Terminal
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Latitude { set; get; }
        public decimal Longitude { set; get; }
        public ICollection<Flight> flights { set; get; } 
    }
}
