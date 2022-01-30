using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserDisability
    {
        public int Id { set;get; }
        [ForeignKey("User")]
        public int UserId { set; get; }
        [ForeignKey("DisabilityType")]
        public int DisabilityTypeId { set; get; }
        public User User { set; get; }
        public DisabilityType DisabilityType { set; get; }

        
    }
}
