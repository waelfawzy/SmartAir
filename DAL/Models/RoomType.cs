using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class RoomType
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public DateTime InsertionDate   { set; get; }= DateTime.Now;
        public bool Active { set; get; } = true;
        public ICollection<Room> rooms { set; get; }
    }
}
