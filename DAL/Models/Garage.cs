using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Garage
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Latitude { set; get; }
        public decimal Longitude { set; get; }
        public int NumberOfLevels { set; get; }
        public int NumberOfRemainingBarking { set; get; }
        public decimal HourPrice { set; get; }
        public string Status { set; get; }
        public string Description { set; get; }
    }
}
