using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Field
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }
        public bool Draw { set; get; } = true;
        public string Description { set; get; }
        public DateTime InsertionDate { set; get; }=DateTime.Now;
        public bool Active { set; get; } = true;    
        public ICollection<ReservationForm> ReservationForms { set; get; }
        public ICollection<FieldValidations> validations { set; get; }
        public ICollection<FieldEvents> Events { set; get; }
    }
}
