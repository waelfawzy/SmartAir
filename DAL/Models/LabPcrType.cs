using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LabPcrType
    {
        public int Id { set; get; }
        [ForeignKey("Organization")]
        public int OrganizationId { set; get; }
        [ForeignKey("PcrType")]
        public int PcrTypeId { set; get; }

        public decimal Price { set; get; }
        public string Description { set; get; }
        public Organization Lab { set; get; }
        public PcrType PcrType { set; get; }
    }
}
