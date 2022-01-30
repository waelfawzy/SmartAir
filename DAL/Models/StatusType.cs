using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class StatusType
    {
        public  int Id { set; get; }
        public string Name { set; get; }
        public bool Active { set; get; }
        public string Desciption { set; get; }
        public DateTime InsertionDate { set; get; }
        public ICollection<Reservation> reservations { set; get; }
    }
}
