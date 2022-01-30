using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AirportActivity
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Status { set; get; }
        public decimal Latitude { set; get; }
        public decimal Langitude { set; get; } 

        [ForeignKey("AirPort")]
        public int AirportId { set; get; }
        public AirPort AirPort { set; get; }

    }
}
