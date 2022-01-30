using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Trip
    {
        public int Id { set; get; }
        public int NumberOfDays { set; get; }
        public DateTime date { set; get; }
        public string status { set; get; }
        public string Place { set; get; }
        public string Description { set; get; }
        [ForeignKey("Organization")]
        public int OrganizationId { set; get; }
        public Organization TourstCompany { set; get; }
        public ICollection<TripTransportation> tripTransportations { set; get; }

    }
}
