using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SuperMarketProducts
    {
        public int Id { set; get; }
        [ForeignKey("Product")]
        public int ProductId { set; get; }
        [ForeignKey("Organization")]
        public int OrganizationId { set; get; }
        public decimal Qty { set; get; }
        public Organization Organization { set; get; }
        public Product Product { set; get; }

    }
}
