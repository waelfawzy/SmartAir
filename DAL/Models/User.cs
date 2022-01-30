using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        public int Id { set; get; }
        
        public string Name { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string Phone { set; get; }
        public string? Address { set; get; }
        public string? City { set; get; } 
        public string? Government { set; get; } 
        public decimal? Latitud { set; get; } 
        public decimal? Longitud { set; get; } 
        public string? Passport { set; get; } = null;
        public string? PassportImg { set; get; } = null;
        public string? NationalId { set; get; } = null;
        [DefaultValue("true")]
        public bool Active { set; get; } = true;
        [DefaultValue("getutcdate()")]
        public DateTime InsertionDate { set; get; } = DateTime.Now;

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        [ForeignKey("Country")]
        public int? CountryId { set; get; }

        [ForeignKey("Role")]
        public int? RoleId { set; get; }
        public Role? Role { set; get; }
        public Country? Country { set; get; }

        public ICollection<UserDisability> userDisabilities { set; get; } 
        public ICollection<Reservation> reservations { set; get; }
        public ICollection<BusinessOffer> businessOffers { set; get; }
        
    }
}
