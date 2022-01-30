using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Plane
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Model { set; get; }
        [ForeignKey("Organization")]
        public int OrganizationId { set; get; }
        public Organization Organization { set; get; }
        public ICollection<Flight> flights { set; get; }
        public ICollection<Seat> seats { set; get; }
    }
}
