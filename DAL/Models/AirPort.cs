using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AirPort
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Latitude { set; get; }
        public decimal Longitude { set; get; }
        public ICollection<Terminal> terminals { set; get; }
       [ForeignKey("Country")]
        public int CountryId { set; get; }  
        public Country Country { set; get; }
        public ICollection<AirportActivity> airportActivities { set; get; }

    }
}
