using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TransportationDetails
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string DetailValue { set; get; }

        [ForeignKey("Transportation")]
        public int TransportationId { set; get; }
        public Transportation Transportation { set; get; }

    }
}
