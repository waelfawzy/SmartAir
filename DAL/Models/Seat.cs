using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Seat
    {
        public int Id { set; get; }
        public string Code { set; get; }
        public bool Status { set; get; } = false;
        public decimal? Cost { set; get; }
        [ForeignKey("Plane")]
        public int PlaneId { set; get; }
        public Plane Plane { set; get; }
    }
}
