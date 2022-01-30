using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Flight
    {
        public int Id { set; get; }
        public string FlightType { set; get; } //Direct  || transet
        public string From { set; get; }
        public string To { set; get; }
        public string Status { set; get; }
        public DateTime date { set; get; }

    }
}
