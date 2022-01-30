using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Room
    {
        public int Id { set; get; }
        public int NumberOfBaths { set; get; }  
        public int NumberOfBeds { set; get; }
        public decimal NightPrice { set; get; }
        public string status { set; get; }
        [ForeignKey("RoomType")]
        public int  RoomTypeId { set; get; }
        public RoomType RoomType { set; get; }
        [ForeignKey("Organization")]
        public int OranganizationId { set; get; }
        public Organization Hotel { set; get; }
    }
}
