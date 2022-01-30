using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    //Ride
    //Trip
    //Flight
    //Hotel
    //Shopping Order
    public class ReservationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InsertionDate { set; get; } = DateTime.Now;
        public bool Active { set; get; } = true;
        public ICollection<Reservation> reservations { set; get; }

    }
}
