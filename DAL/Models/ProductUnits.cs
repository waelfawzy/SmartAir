using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductUnits
    {
        public int Id { set; get; }
        [ForeignKey("Unit")]
        public int UnitId { set; get; }
        [ForeignKey("Product")]
        public int ProductId { set; get; }
        public decimal UnitPrice { set; get; }
        public Unit Unit { set; get; }
        public Product Product { set; get; }
    }
}
