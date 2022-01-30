using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    //Lab
    //Hotel
    //TransportationCompany
    //TourstCmapny
    //Hotel
    //Air Company
    public class OrganizationType
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Description { set; get; }
        public ICollection<Organization> Organizations { set; get; }
    }
}
