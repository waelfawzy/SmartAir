﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DisabilityType
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public DateTime InsertionDate { set; get; } = DateTime.Now;

        public ICollection<UserDisability> userDisabilities { set; get; }
    }
}
