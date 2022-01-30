using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BusinessOffer
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public string Status { set; get; }
        public ICollection<UserBusnessOffers> UserBusnessOffers { set; get; }

    }
}
