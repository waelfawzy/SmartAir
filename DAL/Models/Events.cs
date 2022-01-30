using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Events
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public ICollection<FieldEvents> fieldEvents { set; get; }
    }
}
