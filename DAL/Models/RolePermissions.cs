using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class RolePermissions
    {
        public int Id { set; get; }

        [ForeignKey("Role")]
        public int RoleId { set; get; }
        [ForeignKey("Permission")]
        public int PermissionId { set; get; }
        public DateTime InsertionDate { set; get; } = DateTime.Now;

        public Permission Permission { set; get; }
        public  Role Role { set; get; }
    }
}
