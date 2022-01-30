using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Country
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public DateTime InsertionDate { set; get; }= DateTime.Now;
        public ICollection<User> users { set; get; }
        public ICollection<AirPort> airPorts { set; get; }  

    }
}
