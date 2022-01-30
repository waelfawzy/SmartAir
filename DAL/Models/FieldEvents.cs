using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class FieldEvents
    {
        public int Id { set; get; }
        [ForeignKey("Field")]
        public int FieldId { set; get; }
        [ForeignKey("Events")]
        public int EventId { set; get; }
        public Events Events { set; get; }
        public Field Field { set; get; }
    }
}
