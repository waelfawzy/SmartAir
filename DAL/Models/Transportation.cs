using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Transportation
    {
        public int Id { set; get; }
        public string Model { set; get; }
        public string Color { set; get; }
        public int PlateNumber { set; get; }
        public int NumberOfSeats { set; get; }
        public int RemainingSeats { set; get; }
        public string Status { set; get; }
        [ForeignKey("TransportationType")]
        public int TransportationTypeId { set; get; }
        public TransportationType TransportationType { set; get; }
        public ICollection<TransportationDetails> TransportationDetails { set; get; }
        public ICollection<TripTransportation> tripTransportations { set; get; }

    }
}
