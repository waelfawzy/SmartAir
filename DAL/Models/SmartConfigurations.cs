using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SmartConfigurations
    {
        public int  Id { set; get; }
        public string Key { set; get; }
        public string Value { set; get; }
        [DefaultValue("true")]
        public bool Active { set; get; }
        [DefaultValue("getutcdate()")]
        public DateTime InsertionDate { set; get; }
        public string? Description { set; get; }
    }
}
