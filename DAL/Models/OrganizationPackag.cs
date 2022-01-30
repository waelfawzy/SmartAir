using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OrganizationPackag
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public DateTime InsertionDate { set; get; } = DateTime.Now;
        public bool Active { set; get; } = true;
        public decimal price { set; get; }
        [ForeignKey("Organization")]
        public int OrganizationId { set; get;}
        public Organization Organization { set; get; }


    }
}
