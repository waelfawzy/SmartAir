using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TripTransportation
    {
        public int Id { set; get; }
        [ForeignKey("Transportation")]
        public int TransportationId { set; get; }
        [ForeignKey("Trip")]
        public int TripId { set; get; }
        public string Status { set; get; }
        public Transportation Transportation { set; get; }
        public Trip Trip { set; get; }
    }
}
