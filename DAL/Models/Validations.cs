using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Validations
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public DateTime InsertionDate { set; get; }= DateTime.Now;
        public bool Active { set; get; } = true;
        public bool? HasValue { get; set; }
        public string ControllerNames { get; set; }
        [ForeignKey("ValidationType")]
        public int ValidationTypeId { set; get; }
        public ValidationTypes ValidationType { set; get; }
        public ICollection<FieldValidations> validations { set; get; }

    }
}
