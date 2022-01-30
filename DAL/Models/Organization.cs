using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Organization
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public decimal Latitude { set; get; }
        public decimal Longitude { set; get; }
        public string WebsiteURL { set; get; }
        public bool HaveDelivery { set; get; } = false;
        public bool Active { set; get; } //Status Of Organization Online /Offline 
        
        [ForeignKey("OrganizationType")]
        public int OrganizationTypeId { set; get; }
        public OrganizationType OrganizationType { set; get; }
        public ICollection<LabPcrType> labPcrTypes { set; get; }
        public ICollection<TransportationType> transportationTypes { set; get; }
        public ICollection<Trip> trips { set; get; }
        public ICollection<OrganizationPackag> organizationPackags { set; get; }
        public ICollection<Plane> planes { set; get; }

    }
}
