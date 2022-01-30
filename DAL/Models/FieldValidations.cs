using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class FieldValidations
    {
        public int Id { set; get; }
        [ForeignKey("Field")]
        public int FieldId { set; get; }

        [ForeignKey("Validations")]
        public int ValidationId { set; get; }
        public DateTime InsertionDate { set; get; } = DateTime.Now;
        public bool Active { set; get; } = true;    
        public Field Field { set; get; }
        public Validations Validations { set; get; }

    }
}
